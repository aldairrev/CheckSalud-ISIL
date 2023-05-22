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
    public partial class ResultadoMan01 : Form
    {
        ProxyResultado.ServicioResultadoClient objServicioResultado = new ProxyResultado.ServicioResultadoClient();

        public ResultadoMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgResultados.DataSource = objServicioResultado.ListarResultados();
            lblRegistros.Text = dtgResultados.Rows.Count.ToString();
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }catch(Exception ex)
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
