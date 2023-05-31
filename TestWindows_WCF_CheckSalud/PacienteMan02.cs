using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWindows_WCF_CheckSalud.ProxyResultado;
using System.Collections.Generic;

namespace TestWindows_WCF_CheckSalud
{
    public partial class PacienteMan02 : Form
    {
        ProxyResultado.ServicioResultadoClient objServicioResultado = new ProxyResultado.ServicioResultadoClient();
        ProxyResultado.ResultadoDC objResultadoDC = new ProxyResultado.ResultadoDC();

        ProxyAnalisis.ServicioAnalisisClient objServicioAnalisis = new ProxyAnalisis.ServicioAnalisisClient();
        ProxyAnalisis.AnalisisDC objAnalisisDC = new ProxyAnalisis.AnalisisDC();

        ProxyEvaluacion.ServicioEvaluacionClient objServicioEvaluacion = new ProxyEvaluacion.ServicioEvaluacionClient();
        ProxyEvaluacion.EvaluacionDC objEvaluacionDC = new ProxyEvaluacion.EvaluacionDC();
        public PacienteMan02()
        {
            InitializeComponent();
        }

        private void ResultadoMan02_Load(object sender, EventArgs e)
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

                //CBOAUDITOR
                cboAuditor.DataSource = objServicioResultado.listarCboAuditores();
                cboAuditor.ValueMember = "codAuditor";
                cboAuditor.DisplayMember = "ApeNomAuditor";
                cboAuditor.Text = "Seleccione";

                //CBOMEDICO
                cboMedico.DataSource = objServicioResultado.listarCboMedicoDC();
                cboMedico.ValueMember = "codMedico";
                cboMedico.DisplayMember = "ApeNomMedico";
                cboMedico.SelectedIndex = 0;
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
                    || txtRecomendacion.Text.Trim() == ""
                    || mskCosto.Text.Trim() == "")

                {
                    throw new Exception("Todos los datos son obligatorios");
                }

                //si pasa todo, procedemos:
                objResultadoDC.codPaciente = cboPaciente.SelectedValue.ToString();
                objResultadoDC.codEnfermedad = cboEnfermedad.SelectedValue.ToString();
                objResultadoDC.Usu_Registro = "pepe20";
                objResultadoDC.recomendaciones = txtRecomendacion.Text.Trim();
                objResultadoDC.altura = Convert.ToSingle(mskAltura.Text.Trim());
                objResultadoDC.peso = Convert.ToSingle(mskPeso.Text.Trim());

                objResultadoDC.orina = cboOrina.SelectedItem.ToString();
                objResultadoDC.spirometria = cboEspirometria.SelectedItem.ToString();
                objResultadoDC.psicologia = cboPsicologia.SelectedItem.ToString();
                objResultadoDC.sangre = cboSangre.SelectedItem.ToString();
                objResultadoDC.audicion = cboAudicion.SelectedItem.ToString();
                objResultadoDC.vista = cboVista.SelectedItem.ToString();
                objResultadoDC.rayosX = cboRayosx.SelectedItem.ToString();
                objResultadoDC.ekg = cboEkg.SelectedItem.ToString();


                //Datos para ingresar Analisis:
                objAnalisisDC.descAnalisis = "EXAMEN PREOCUPACIONAL";
                objAnalisisDC.costo = Convert.ToDouble(mskCosto.Text.Trim());
                objAnalisisDC.Estado = 1;
                objAnalisisDC.Usu_Registro = "pepe20";

                //Datos para ingresar Evaluacion:
                objEvaluacionDC.Fec_Eva = dtFEvaluacion.Value.ToShortDateString();
                objEvaluacionDC.codMedico = cboMedico.SelectedValue.ToString();
                objEvaluacionDC.codAuditor = cboAuditor.SelectedValue.ToString();
                objEvaluacionDC.Estado = 1;
                objEvaluacionDC.Usu_Registro = "pepe20";

                if (objServicioAnalisis.InsertarAnalisis(objAnalisisDC) == true)
                {
                    //Ingresamos Analisis si todo sale bien
                }
                else throw new Exception("No se inserto el registro, contacte con IT");

                if (objServicioEvaluacion.InsertarEvaluacion(objEvaluacionDC) == true)
                {
                    //Ingresamos Evaluacion si todo sale bien
                }
                else throw new Exception("No se inserto el registro, contacte con IT");

                objAnalisisDC = objServicioAnalisis.ConsultarUltAnalisis();
                objEvaluacionDC = objServicioEvaluacion.ConsultarUltEvaluacion();

                //Agregamos los codigos de analisis y evaluacion a Resultado :
                objResultadoDC.codAnalisis = objAnalisisDC.codAnalisis;
                objResultadoDC.codEvaluacion = objEvaluacionDC.codEvaluacion;

                if (objServicioResultado.InsertarResultado(objResultadoDC) == true)
                {
                    //Ingresamos resultado si todo esta bien
                    this.Close();
                }
                else throw new Exception("No se inserto el registro, contacte con IT");
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
