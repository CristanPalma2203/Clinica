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
            PanelVentas.Visible = false;
            ProVisible();
            ProVisible2();
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
                            reportesD.GenerarInformePDF(ruta, opcion, desdec, hastac,2,2,0,0,0);
                        }
                    }
                    else
                    {
                        // Mostrar un mensaje de error indicando que las fechas no son válidas
                        MessageBox.Show("Las fechas ingresadas no son válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (opcion.Equals("Ventas"))
                {
                    int month = 0;
                    int month2 = 0;
                    int year = 0;
                    int year2 = 0;
                    if (hastaMex.SelectedIndex != -1 && desdeMex.SelectedIndex != -1)
                    {
                        string mesSeleccionado = hastaMex.SelectedItem.ToString();
                        switch (mesSeleccionado)
                        {

                            case "Enero":
                                month = 1;
                                break;
                            case "Febrero":
                                month = 2;
                                break;
                            case "Marzo":
                                month = 3;
                                break;
                            case "Abril":
                                month = 4;
                                break;
                            case "Mayo":
                                month = 5;
                                break;
                            case "Junio":
                                month = 6;
                                break;
                            case "Julio":
                                month = 7;
                                break;
                            case "Agosto":
                                month = 8;
                                break;
                            case "Septiembre":
                                month = 9;
                                break;
                            case "Octubre":
                                month = 10;
                                break;
                            case "Noviembre":
                                month = 11;
                                break;
                            case "Diciembre":
                                month = 12;
                                break;
                            default:
                                Console.WriteLine("Mes no reconocido");
                                break;
                        }
                        string mesSeleccionado2 = desdeMex.SelectedItem.ToString();
                        switch (mesSeleccionado2)
                        {
                            case "Enero":
                                month2 = 1;
                                break;
                            case "Febrero":
                                month2 = 2;
                                break;
                            case "Marzo":
                                month2 = 3;
                                break;
                            case "Abril":
                                month2 = 4;
                                break;
                            case "Mayo":
                                month2 = 5;
                                break;
                            case "Junio":
                                month2 = 6;
                                break;
                            case "Julio":
                                month2 = 7;
                                break;
                            case "Agosto":
                                month2 = 8;
                                break;
                            case "Septiembre":
                                month2 = 9;
                                break;
                            case "Octubre":
                                month2 = 10;
                                break;
                            case "Noviembre":
                                month2 = 11;
                                break;
                            case "Diciembre":
                                month2 = 12;
                                break;
                            default:
                                Console.WriteLine("Mes no reconocido");
                                break;
                        }

                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        desdec = DateTime.Now; hastac = DateTime.Now;
                        saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                        saveFileDialog.FileName = "Report " + opcion + ".pdf";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string ruta = saveFileDialog.FileName;
                            reportesD.GenerarInformePDF(ruta, opcion, desdec, hastac, month2, month, year, year2, 1);
                        }
                    } else if (txtyearHast.Text != "" && txtyearDes.Text != "")
                    {
                        year = Convert.ToInt32(txtyearDes.Text);
                        year2 = Convert.ToInt32(txtyearHast.Text);

                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        desdec = DateTime.Now; hastac = DateTime.Now;
                        saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                        saveFileDialog.FileName = "Report " + opcion + ".pdf";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string ruta = saveFileDialog.FileName;
                            reportesD.GenerarInformePDF(ruta, opcion, desdec, hastac, month2, month, year, year2, 2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, completa los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            reportesD.GenerarInformePDF(ruta, opcion, desdec, hastac, 2,2, 0, 0, 2);
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

                if (opcion.Equals("Ventas"))
                {
                    PanelVentas.Visible = true;
                    iconMonto.Visible = false;
                    bunePanelfechas.Visible = true;
                    prueba2.Visible = false;
                    lblMonto.Visible = false;
                    Prueba1.Visible = false;
                    lblTotalCitas.Visible = false;
                    iconCitas.Visible = false;
                }
                else if (opcion.Equals("Citas"))
                {
                    bunePanelfechas.Visible = true;
                    PanelVentas.Visible = false;
                    iconMonto.Visible = false;
                    prueba2.Visible = false;
                    lblMonto.Visible = false;
                    Prueba1.Visible = false;
                    lblTotalCitas.Visible = false;
                    iconCitas.Visible = false;
                }
                else
                {
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

        private void btnPresenteYear_Click(object sender, EventArgs e)
        {
            ProVisible2();
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            desdeMex.Visible = true;
            hastaMex.Visible = true;
        }


        public void ProVisible() {
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            desdeMex.Visible = false;
            hastaMex.Visible = false;
        }

        public void ProVisible2()
        {
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            txtyearDes.Visible = false;
            txtyearHast.Visible = false;
        }


        private void btnyearAndMonjt_Click(object sender, EventArgs e)
        {
            ProVisible();
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            txtyearDes.Visible = true;
            txtyearHast.Visible = true;
        }
    }
}
