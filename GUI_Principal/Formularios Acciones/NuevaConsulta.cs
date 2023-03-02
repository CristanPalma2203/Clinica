using CapaComun.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio;

namespace GUI_Principal
{
    public partial class FrmExpediente : Form
    {
        public FrmExpediente()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if(Cache != true) {
                TxtEstatura.Clear();
                TxtPeso.Clear();
                TxtPresion.Clear();
                TxtTemperatura.Clear();
                txtEnfermedad.Clear();
                txtEstado.Clear();
                rtbRecomendaciones.Clear();
                RtbDetalles.Clear();
            }
            else
            {

                resestCache();
            }
            

            

        }
        public string fechaGet()
        {
            DateTime fec = DateTime.Today;
            return fec.ToString("d");
        }
        bool Cache = false;
        private void FrmExpediente_Load(object sender, EventArgs e)
        {
            Cache = false;
            Nombre_newcita.Text = CachePaciente.NombrePaciente;
            numExpe_newcita.Text = Convert.ToString( CacheExpediente.NumExpediente);
            lblFecha.Text =  fechaGet();
            cargarDiagnostico();
            if (CacheDeUsuario.CargoUsuario == Cargos.Admistrador)
            {
                BtnGuardar.Enabled = false;
                
            }
            if (CacheDeUsuario.CargoUsuario == Cargos.Enfermera)
            {

                BtnGuardar.Enabled = false;
            }
            

        }
        
        private void cargarDiagnostico()
        {
            if (CacheDiagnostico.id != 0) {

                TxtTemperatura.Text = Convert.ToString(CacheDiagnostico.temperatura);
                TxtPeso.Text = Convert.ToString(CacheDiagnostico.peso);
                txtEnfermedad.Text = CacheDiagnostico.enfermead;
                lblFecha.Text = Convert.ToString( CacheDiagnostico.fechaCreacion);
                TxtPresion.Text = Convert.ToString(CacheDiagnostico.presion);
                TxtEstatura.Text = Convert.ToString(CacheDiagnostico.estatura);
                rtbRecomendaciones.Text = CacheDiagnostico.recomendaciones;
                txtEstado.Text = CacheDiagnostico.estado;
                RtbDetalles.Text = CacheDiagnostico.detalles;
                BtnGuardar.Visible = false;
                button1.Text = "Volver";
                Cache = true;

            }
        }
        private void resestCache()
        {


                TxtTemperatura.Text = Convert.ToString(CacheDiagnostico.temperatura);
                TxtPeso.Text = Convert.ToString(CacheDiagnostico.peso);
                txtEnfermedad.Text = CacheDiagnostico.enfermead;
                lblFecha.Text = Convert.ToString(CacheDiagnostico.fechaCreacion);
                TxtPresion.Text = Convert.ToString(CacheDiagnostico.presion);
                TxtEstatura.Text = Convert.ToString(CacheDiagnostico.estatura);
                rtbRecomendaciones.Text = CacheDiagnostico.recomendaciones;
                txtEstado.Text = CacheDiagnostico.estado;
                RtbDetalles.Text = CacheDiagnostico.detalles;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();  
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloDianostPacie CrearDianostico = new ModeloDianostPacie(EnfermedadP: txtEnfermedad.Text,
              EstadoP: txtEstado.Text,
              pesoP: Convert.ToSingle(TxtPeso.Text),
              estaturaP: Convert.ToSingle(TxtEstatura.Text),
              presionP: Convert.ToSingle(TxtPresion.Text),
              temperaturaP: Convert.ToSingle(TxtTemperatura.Text),
              detallesP: RtbDetalles.Text,
              recomendacionesP: rtbRecomendaciones.Text,
              NumExped: CacheExpediente.NumExpediente
              );
                var resultado = CrearDianostico.Dianostico();
                MessageBox.Show(resultado);
                this.Hide();
            }
            catch (Exception) {
                MessageBox.Show("Datos Incorrectos");
            }
               
        }
    }
}
