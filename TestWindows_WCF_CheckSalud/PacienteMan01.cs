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
    public partial class PacienteMan01 : Form
    {
        ProxyPaciente.ServicioPacienteClient
            objServicioResultado = new ProxyPaciente.ServicioPacienteClient();

        public PacienteMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgResultados.DataSource = objServicioResultado.Listar();
            lblRegistros.Text = dtgResultados.Rows.Count.ToString();
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                //PacienteMan02 obj02 = new PacienteMan02();
                //obj02.ShowDialog();
                //refrescamos 
                CargarDatos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void ResultadoMan01_Load(object sender, EventArgs e)
        {

            try
            {
                dtgResultados.AutoGenerateColumns = false;
                CargarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ResultadoMan03 objResultadoMan03 = new ResultadoMan03();
                //Obtenemos el codigo de resultado seleccionado:
                String strCodigo = dtgResultados.CurrentRow.Cells[0].Value.ToString();
                objResultadoMan03.strCodigo = strCodigo;
                objResultadoMan03.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
