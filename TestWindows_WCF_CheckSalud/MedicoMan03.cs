using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindows_WCF_CheckSalud
{
    public partial class MedicoMan03 : Form
    {
        ProxyMedico.ServicioMedicoClient objServicioMedico = new ProxyMedico.ServicioMedicoClient();
        ProxyMedico.MedicoDC objMedicoDC = new ProxyMedico.MedicoDC();
        ProxyUsuario.ServicioUsuarioClient objServicioUsuario = new ProxyUsuario.ServicioUsuarioClient();
        ProxyUsuario.UsuarioDC objUsuarioDC = new ProxyUsuario.UsuarioDC();
        //Combox
        ProxyEspecialidad.ServicioEspecialidadClient objServicioEspecialidad = new ProxyEspecialidad.ServicioEspecialidadClient();
        ProxyUbicacion.ServicioUbicacionClient objServicioUbicacion = new ProxyUbicacion.ServicioUbicacionClient();

        public MedicoMan03()
        {
            InitializeComponent();
        }
        public String strCodigo { get; set; }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MedicoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                cboEspecialidad.DataSource = objServicioEspecialidad.ListarEspecialidad();
                cboEspecialidad.DisplayMember = "descEspecialidad";
                cboEspecialidad.ValueMember = "codEspecialidad";

                cboDistrito.DataSource = objServicioUbicacion.ListarUbicacion();
                cboDistrito.DisplayMember = "Distrito";
                cboDistrito.ValueMember = "Id_Ubigeo";


                dtpIngreso.MinDate = new DateTime(2005, 6, 20);
                dtpNacimiento.MinDate = new DateTime(1905, 1, 01);
                dtpIngreso.MaxDate = DateTime.Today;
                dtpNacimiento.MaxDate = DateTime.Today;

                objMedicoDC = objServicioMedico.ConsultarMedico(this.strCodigo);

                lblCodigo.Text = this.strCodigo;
                txtNombre.Text = objMedicoDC.nomMedico;
                txtApellido.Text = objMedicoDC.apeMedico;
                txtDni.Text = objMedicoDC.dniMedic;
                txtDireccion.Text = objMedicoDC.direcMedico;
                txtEmail.Text = objMedicoDC.emailMedico;
                txtNumColegiatura.Text = objMedicoDC.numColegiatura;
                dtpNacimiento.Value = Convert.ToDateTime(objMedicoDC.fechaNacimiento);
                dtpIngreso.Value = objMedicoDC.fec_ingreso;
                cboEspecialidad.SelectedValue = objMedicoDC.codEspecialidad;
                cboDistrito.SelectedValue = objMedicoDC.Id_Ubigeo;
                chkestado.Checked = Convert.ToBoolean(objMedicoDC.estado);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApellido.Text.Trim() == "" || txtNombre.Text.Trim() == ""
                    || txtDni.Text.Trim() == "" || txtEmail.Text.Trim() == ""
                    || txtNumColegiatura.Text.Trim() == "" || txtDireccion.Text.Trim() == ""
                    || cboEspecialidad.SelectedIndex == 0 || cboDistrito.SelectedIndex == 0
                    )
                {
                    throw new Exception("Todos los datos son obligatorios");
                }

                objMedicoDC.codMedico = lblCodigo.Text;
                objMedicoDC.nomMedico = txtNombre.Text.Trim();
                objMedicoDC.apeMedico = txtApellido.Text.Trim();
                objMedicoDC.fechaNacimiento = dtpNacimiento.Value;
                objMedicoDC.dniMedic = txtDni.Text.Trim();
                objMedicoDC.numColegiatura = txtNumColegiatura.Text.Trim();
                objMedicoDC.direcMedico = txtDireccion.Text.Trim();
                objMedicoDC.emailMedico = txtEmail.Text.Trim();
                objMedicoDC.fec_ingreso = dtpIngreso.Value;
                objMedicoDC.codEspecialidad = cboEspecialidad.SelectedValue.ToString();
                objMedicoDC.Id_Ubigeo = cboDistrito.SelectedValue.ToString();
                objMedicoDC.estado = Convert.ToInt16(chkestado.Checked);
                objMedicoDC.Usu_Ult_Mod = "maria20";
                if (objServicioMedico.ActualizarMedico(objMedicoDC) == true)
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
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
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

