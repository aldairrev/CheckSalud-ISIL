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
    public partial class Medicoman01 : Form
    {     //Instancias
        ProxyMedico.ServicioMedicoClient objServicioMedico = new ProxyMedico.ServicioMedicoClient();

        public Medicoman01()
        {
            InitializeComponent();

        }
        private void Medicoman01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDatos.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarDatos()
        {
            dtgDatos.DataSource = objServicioMedico.ListarMedicos();
            lblRegistro.Text = dtgDatos.Rows.Count.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                MedicoMan02 medicoMan02 = new MedicoMan02();
                medicoMan02.ShowDialog();
                CargarDatos();
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
                MedicoMan03 medicoMan03 = new MedicoMan03();
                String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                medicoMan03.strCodigo = strCodigo;
                medicoMan03.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


       
    }

 

