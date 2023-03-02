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


namespace GUI_Principal
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
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
    }
}
