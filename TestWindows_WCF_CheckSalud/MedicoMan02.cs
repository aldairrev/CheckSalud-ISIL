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
    public partial class MedicoMan02 : Form
    {
        ProxyMedico.ServicioMedicoClient objServicioMedico = new ProxyMedico.ServicioMedicoClient();
        ProxyMedico.MedicoDC objMedicoDC = new ProxyMedico.MedicoDC();
        ProxyUsuario.ServicioUsuarioClient objServicioUsuario = new ProxyUsuario.ServicioUsuarioClient();
        ProxyUsuario.UsuarioDC objUsuarioDC = new ProxyUsuario.UsuarioDC();
        //Combox
        ProxyEspecialidad.ServicioEspecialidadClient objServicioEspecialidad = new ProxyEspecialidad.ServicioEspecialidadClient();
        ProxyUbicacion.ServicioUbicacionClient objServicioUbicacion = new ProxyUbicacion.ServicioUbicacionClient();
               
                
        public MedicoMan02()
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
                    || txtNumColegiatura.Text.Trim() == "" || txtDireccion.Text.Trim() == ""
                    || cboEspecialidad.SelectedIndex == 0 || cboDistrito.SelectedIndex == 0
                    )
                {
                    throw new Exception("Todos los datos son obligatorios");
                }
                if (txtLogin.Text.Trim() == "" || txtLogin.Text.Trim().Length >= 11)
                {
                    throw new Exception("El login es obligatoria o el login es muy largo");
                }

                objMedicoDC.nomMedico = txtNombre.Text.Trim();
                objMedicoDC.apeMedico = txtApellido.Text.Trim();
                objMedicoDC.fechaNacimiento = dtpNacimiento.Value;
                objMedicoDC.dniMedic = txtDni.Text.Trim();
                objMedicoDC.numColegiatura = txtNumColegiatura.Text.Trim(); 
                objMedicoDC.direcMedico = txtDireccion.Text.Trim();
                objMedicoDC.emailMedico = txtEmail.Text.Trim();
                objMedicoDC.fec_ingreso = dtpIngreso.Value;
                objMedicoDC.codEspecialidad= cboEspecialidad.SelectedValue.ToString();
                objMedicoDC.Id_Ubigeo = cboDistrito.SelectedValue.ToString();
                objMedicoDC.Usu_Registro = "maria20";
                objMedicoDC.estado = Convert.ToInt16(chkestado.Checked);
                objMedicoDC.Login_Usuario = txtLogin.Text.Trim();

                objUsuarioDC.Login_Usuario = txtLogin.Text.Trim();
                objUsuarioDC.Pass_Usuario = "pepito123";
                objUsuarioDC.Usu_Registro = "maria20";

                if (objServicioUsuario.InsertarUsuario(objUsuarioDC) == true)
                {
                   
                }
                if (objServicioMedico.InsertarMedico(objMedicoDC) == true)
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
