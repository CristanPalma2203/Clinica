using Dominio;
using System;


using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CapaComun.Cache;
using AccesoDatos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace GUI_Principal
{
    public partial class Reportes : Form
    {
  
        private readonly ReportesD reportesD = new ReportesD();

        public Reportes()
        {
            InitializeComponent();

            //string[] tablas = { "Usuario", "Paciente", "Expediente", "Diagnostico", "Citas", "Movimientos" };

            //for (int i = 0; i < tablas.Length; i++)
            //{
            //    cbxReportes.Items.Add(tablas[i]);
            //}

            List<string> tablas = reportesD.Tablas();

            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.AddRange(tablas.ToArray());
            
        }
      
        private void grafica()
        {
            ModeloUsuario mu = new ModeloUsuario();
            mu.Grafica();
            chart1.Series[0].Points.DataBindXY(cahcegrafica.fecha, cahcegrafica.monto);
            lblMonto.Text = "$" + Convert.ToString( mu.montoGrafica());
            lblTotalCitas.Text = Convert.ToString(mu.TotalCitas());
        }       

        private void Administrador_Load_1(object sender, EventArgs e)
        {
            grafica();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex != -1)
            {
                string opcion = guna2ComboBox1.SelectedItem.ToString();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "ReportTest.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = saveFileDialog.FileName;

                    reportesD.GenerarInformePDF(ruta, opcion);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción del ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxReportes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalCitas_Click(object sender, EventArgs e)
        {

        }
    }
}
