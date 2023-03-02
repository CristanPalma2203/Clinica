using CapaComun.Cache;
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

namespace GUI_Principal.Formularios_Acciones
{
    public partial class ActualizarCita : Form
    {
        public ActualizarCita()
        {
            InitializeComponent();
        }

        private void ActualizarCita_Load(object sender, EventArgs e)
        {

            reset();
        }
        private void reset()
        {
            lblNombre.Text = CachePaciente.NombrePaciente;
            lblApellido.Text = CachePaciente.ApellidoPaciente;
            lblDui.Text = Convert.ToString(CachePaciente.Dui);
            lblFecha.Text = Convert.ToString(CacheCita.fechaCita);
            lblNumCita.Text = Convert.ToString(CacheCita.numCita);
            lblCargo.Text = CacheDeUsuario.CargoUsuario;
            lblUsuario.Text = CacheDeUsuario.NonbreUsuario;
            txtPrecio.Text = Convert.ToString(CacheCita.Precio);
            rtbMotivo.Text = CacheCita.motivo;
            txtAño.Clear();
            txtDia.Clear();
            txtMes.Clear();
            txtHora.Clear();

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            try {
                int seg = 00;
                int minutes = 00;
                DateTime fecha = new DateTime(Convert.ToInt32(txtAño.Text), Convert.ToInt32(txtMes.Text), Convert.ToInt32(txtDia.Text), Convert.ToInt32(txtHora.Text), minutes, seg);
                ModeloCita c1 = new ModeloCita(rtbMotivo.Text, fecha, lblUsuario.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(lblDui.Text));
                var resultado = c1.ActCita();
                MessageBox.Show(resultado);
                if (resultado == "Cita Actualizada")
                {
                    this.Close();
                }
            }
            catch (Exception) {
                MessageBox.Show("Error");
            }
            
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
