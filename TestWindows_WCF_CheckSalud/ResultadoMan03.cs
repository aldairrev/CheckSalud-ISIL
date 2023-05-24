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
    public partial class ResultadoMan03 : Form
    {
        ProxyResultado.ServicioResultadoClient objServicioResultado = new ProxyResultado.ServicioResultadoClient();
        ProxyResultado.ResultadoDC objResultadoDC = new ProxyResultado.ResultadoDC();
        public ResultadoMan03()
        {
            InitializeComponent();
            
        }        

        public String strCodigo { get; set; }
        private void ResultadoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                //cargar combos....
                cboOrina.SelectedIndex = 0;
                cboEspirometria.SelectedIndex = 0;
                cboPsicologia.SelectedIndex = 0;
                cboSangre.SelectedIndex = 0;
                cboRayosx.SelectedIndex = 0;
                cboAudicion.SelectedIndex = 0;
                cboVista.SelectedIndex = 0;
                cboEkg.SelectedIndex = 0;

                //CBOENFERMEDAD
                cboEnfermedad.DataSource = objServicioResultado.ListarCboEnfermedad();
                cboEnfermedad.ValueMember = "codEnfermedad";
                cboEnfermedad.DisplayMember = "descEnfermedad";
                cboEnfermedad.SelectedIndex = 0;

                //CBOPACIENTE
                cboPaciente.DataSource = objServicioResultado.ListarCboPaciente();
                cboPaciente.ValueMember = "codPaciente";
                cboPaciente.DisplayMember = "ApeNomPaciente";
                cboPaciente.SelectedIndex = 0;

                //llenamos el Formulario:
                objResultadoDC = objServicioResultado.ConsultarResultado(this.strCodigo);
                mskcodResultado.Text = objResultadoDC.codResultado.ToString();
                cboPaciente.SelectedValue = objResultadoDC.codPaciente;
                cboOrina.SelectedValue = objResultadoDC.orina;
                cboEspirometria.SelectedValue = objResultadoDC.spirometria;
                cboPsicologia.SelectedValue = objResultadoDC.psicologia;
                cboSangre.SelectedValue = objResultadoDC.sangre;
                cboRayosx.SelectedValue = objResultadoDC.rayosX;
                cboAudicion.SelectedValue = objResultadoDC.audicion;
                cboVista.SelectedValue = objResultadoDC.vista;
                cboEkg.SelectedValue = objResultadoDC.ekg;
                cboEnfermedad.SelectedValue = objResultadoDC.codEnfermedad;
                txtRecomendacion.Text = objResultadoDC.recomendaciones;
                mskPeso.Text = objResultadoDC.peso.ToString();
                mskAltura.Text = objResultadoDC.altura.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //validamos

                if (mskPeso.Text.Trim() == "" || mskAltura.Text.Trim() == ""
                    || txtRecomendacion.Text.Trim() == "" )

                {
                    throw new Exception("Todos los datos son obligatorios");
                }

                //si pasa todo, procedemos:
                objResultadoDC.codResultado = mskcodResultado.Text;
                objResultadoDC.codPaciente = cboPaciente.SelectedValue.ToString();
                objResultadoDC.codEnfermedad = cboEnfermedad.SelectedValue.ToString();                
                objResultadoDC.recomendaciones = txtRecomendacion.Text.Trim();
                objResultadoDC.altura = Convert.ToSingle(mskAltura.Text.Trim());
                objResultadoDC.peso = Convert.ToSingle(mskPeso.Text.Trim());
                objResultadoDC.Usu_Registro = "pepe20";

                objResultadoDC.orina = cboOrina.SelectedItem.ToString();
                objResultadoDC.spirometria = cboEspirometria.SelectedItem.ToString();
                objResultadoDC.psicologia = cboPsicologia.SelectedItem.ToString();
                objResultadoDC.sangre = cboSangre.SelectedItem.ToString();
                objResultadoDC.audicion = cboAudicion.SelectedItem.ToString();
                objResultadoDC.vista = cboVista.SelectedItem.ToString();
                objResultadoDC.rayosX = cboRayosx.SelectedItem.ToString();
                objResultadoDC.ekg = cboEkg.SelectedItem.ToString();


                if (objServicioResultado.ActualizarResultado(objResultadoDC) == true)
                {
                    //Ingresamos resultado si todo esta bien
                    this.Close();
                }
                else throw new Exception("No se Actualizo el registro, contacte con IT");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
