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
                
                //CBOENFERMEDAD
                cboEnfermedad.DataSource = objServicioResultado.ListarCboEnfermedad();
                cboEnfermedad.ValueMember = "codEnfermedad";
                cboEnfermedad.DisplayMember = "descEnfermedad";                

                //CBOPACIENTE
                cboPaciente.DataSource = objServicioResultado.ListarCboPaciente();
                cboPaciente.ValueMember = "codPaciente";
                cboPaciente.DisplayMember = "ApeNomPaciente";

                //llenamos el Formulario:
                objResultadoDC = objServicioResultado.ConsultarResultado(strCodigo);
                mskcodResultado.Text = objResultadoDC.codResultado;
                cboPaciente.SelectedValue = objResultadoDC.codPaciente;
                cboEnfermedad.SelectedValue = objResultadoDC.codEnfermedad;

                cboOrina.Text = objResultadoDC.orina.ToString();
                cboEspirometria.Text = objResultadoDC.spirometria.ToString();
                cboPsicologia.Text = objResultadoDC.psicologia.ToString();
                cboSangre.Text = objResultadoDC.sangre.ToString();
                cboRayosx.Text = objResultadoDC.rayosX.ToString();
                cboAudicion.Text = objResultadoDC.audicion.ToString();
                cboVista.Text = objResultadoDC.vista.ToString();
                cboEkg.Text = objResultadoDC.ekg.ToString();

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
