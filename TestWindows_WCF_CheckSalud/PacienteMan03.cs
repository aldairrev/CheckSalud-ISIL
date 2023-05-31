using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWindows_WCF_CheckSalud.ProxyPaciente;

namespace TestWindows_WCF_CheckSalud
{
    public partial class PacienteMan03 : Form
    {
        ProxyPaciente.PacienteDC objPacienteDC = new ProxyPaciente.PacienteDC();
        //Combox
        ProxyUbicacion.ServicioUbicacionClient objServicioUbicacion = new ProxyUbicacion.ServicioUbicacionClient();
        ProxyEmpresa.ServicioEmpresaClient objServicioEmpresa = new ProxyEmpresa.ServicioEmpresaClient();
        ProxyPaciente.ServicioPacienteClient objServicioPaciente = new ProxyPaciente.ServicioPacienteClient();

        public String strCodigo { get; set; }
        public PacienteMan03()
        {
            InitializeComponent();
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MedicoMan02_Load(object sender, EventArgs e)
        {
            try
            {                   
                cboDistrito.DataSource = objServicioUbicacion.ListarUbicacion();
                cboDistrito.DisplayMember = "Distrito";
                cboDistrito.ValueMember = "Id_Ubigeo";

                cbxEmpresa.DataSource = objServicioEmpresa.Listar();
                cbxEmpresa.DisplayMember = "descEmpresa";
                cbxEmpresa.ValueMember = "codEmpresa";

                objPacienteDC = objServicioPaciente.Consultar(strCodigo);

                txtCodigo.Text = objPacienteDC.codPaciente;
                txtNombre.Text = objPacienteDC.nomPaciente;
                txtApellido.Text = objPacienteDC.apePaciente;
                dtpNacimiento.Value = objPacienteDC.fechaNacimiento;
                txtDni.Text = objPacienteDC.dniPaciente;
                cbxSexo.SelectedIndex = objPacienteDC.sexo;
                cbxTipoCliente.SelectedIndex = objPacienteDC.tipoCliente;
                cbxTipoSangre.SelectedIndex = objPacienteDC.tipoSangre + 1;
                txtDireccion.Text = objPacienteDC.direcPaciente;
                txtEmail.Text = objPacienteDC.emailPaciente;
                dtpIngreso.Value = objPacienteDC.fechaIngreso;
                txtNumTelefono.Text = objPacienteDC.numTelefono;
                cboDistrito.SelectedValue = objPacienteDC.Id_Ubigeo;
                cbxEmpresa.SelectedValue = objPacienteDC.codEmpresa;
                chkestado.Checked = objPacienteDC.estado > 0;

                dtpIngreso.MinDate = new DateTime(2005, 6, 20);
                dtpNacimiento.MinDate = new DateTime(1905, 1, 01);
                dtpIngreso.MaxDate = DateTime.Today;
                dtpNacimiento.MaxDate = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApellido.Text.Trim() == "" || txtNombre.Text.Trim() == ""
                    || txtDni.Text.Trim() == "" || txtEmail.Text.Trim() == ""
                    || txtDireccion.Text.Trim() == ""
                    )
                {
                    throw new Exception("Todos los datos son obligatorios");
                }

                objPacienteDC.nomPaciente = txtNombre.Text.Trim();
                objPacienteDC.apePaciente = txtApellido.Text.Trim();
                objPacienteDC.fechaNacimiento = dtpNacimiento.Value;
                objPacienteDC.dniPaciente = txtDni.Text.Trim();
                //objPacienteDC.sexo = (Int16) cbxSexo.SelectedValue;
                objPacienteDC.sexo = Convert.ToInt16(cbxSexo.SelectedIndex);
                objPacienteDC.tipoCliente = Convert.ToInt16(cbxTipoCliente.SelectedIndex);
                objPacienteDC.tipoSangre = Convert.ToInt16(cbxTipoSangre.SelectedIndex - 1);
                objPacienteDC.direcPaciente = txtDireccion.Text.Trim();
                objPacienteDC.emailPaciente = txtEmail.Text.Trim();
                objPacienteDC.fechaIngreso = dtpIngreso.Value;
                objPacienteDC.numTelefono = txtNumTelefono.Text.Trim();
                objPacienteDC.Id_Ubigeo = cboDistrito.SelectedValue.ToString();
                objPacienteDC.codEmpresa = cbxEmpresa.SelectedValue.ToString();
                objPacienteDC.estado = Convert.ToInt16(chkestado.Checked);
                objPacienteDC.Usu_Registro = "maria20";

                if (objServicioPaciente.Actualizar(objPacienteDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro, contacte con IT");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <=64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >=123  && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }

}
