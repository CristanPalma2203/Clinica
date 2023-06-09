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
            CalenderUntil.DateChanged += CalenderUntil_DateChanged;
            CalenderSince.DateChanged += CalenderSince_DateChanged;
            bunePanelfechas.Visible = false;
            List<string> tablas = reportesD.Tablas();

            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.AddRange(tablas.ToArray());
            textBoxFechaSeleccionadaDesde.Enabled = false;
            textBoxFechaSeleccionadaHasta.Enabled = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Actualizar el texto del cuadro de texto con la fecha seleccionada
            textBoxFechaSeleccionadaHasta.Text = e.Start.ToShortDateString();
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
                DateTime desdec, hastac;

                if (opcion == "Citas")
                {
                    if (DateTime.TryParse(textBoxFechaSeleccionadaDesde.Text, out desdec) && DateTime.TryParse(textBoxFechaSeleccionadaHasta.Text, out hastac))
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                        saveFileDialog.FileName = "Report " + opcion + ".pdf";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string ruta = saveFileDialog.FileName;
                            reportesD.GenerarInformePDF(ruta, opcion, desdec, hastac);
                        }
                    }
                    else
                    {
                        // Mostrar un mensaje de error indicando que las fechas no son válidas
                        MessageBox.Show("Las fechas ingresadas no son válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else {
                    desdec = DateTime.Now; hastac = DateTime.Now;
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                    saveFileDialog.FileName = "Report " + opcion + ".pdf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string ruta = saveFileDialog.FileName;
                        reportesD.GenerarInformePDF(ruta, opcion, desdec, hastac);
                    }
                }
              
            }
            else
            {
                // Mostrar un mensaje de error indicando que los campos están vacíos
                MessageBox.Show("Por favor, completa los campos de fecha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
        private void CalenderUntil_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxFechaSeleccionadaHasta.Text = e.Start.ToShortDateString();
           
        }

        private void CalenderSince_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxFechaSeleccionadaDesde.Text = e.Start.ToShortDateString();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex != -1)
            {
                string opcion = guna2ComboBox1.SelectedItem.ToString();
                DateTime desdec, hastac;

                if (opcion == "Citas")
                {
                    bunePanelfechas.Visible = true;
                    iconMonto.Visible = false;
                    prueba2.Visible = false;
                    lblMonto.Visible=false;
                    Prueba1.Visible = false;
                    lblTotalCitas.Visible = false;
                    iconCitas.Visible   =false;
                }
                else {
                    iconMonto.Visible = true;
                    prueba2.Visible = true;
                    lblMonto.Visible = true;
                    Prueba1.Visible = true;
                    lblTotalCitas.Visible = true;
                    iconCitas.Visible = true;
                    bunePanelfechas.Visible = false;
                    }
             }
        }
    }
}
