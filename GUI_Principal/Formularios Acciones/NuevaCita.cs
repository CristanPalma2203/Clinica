using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun;
using CapaComun.Cache;
using Dominio;

namespace GUI_Principal.Formularios_Acciones
{
    public partial class NuevaCita : Form
    {
        public NuevaCita()
        {
            InitializeComponent();
        }

        private void NuevaCita_Load(object sender, EventArgs e)
        {
            lblNombre.Text = CachePaciente.NombrePaciente;
            lblApellido.Text = CachePaciente.ApellidoPaciente;
            lblDui.Text = Convert.ToString( CachePaciente.Dui);
            lblUsuario.Text = CacheDeUsuario.NonbreUsuario;
            lblCargo.Text = CacheDeUsuario.CargoUsuario;

        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            int seg = 00;
            int minutes = 00;
           
            try {
                DateTime fecha = new DateTime(Convert.ToInt32(txtAño.Text), Convert.ToInt32(txtMes.Text), Convert.ToInt32(txtDia.Text), Convert.ToInt32(txtHora.Text), minutes, seg);
                ModeloCita crearCita = new ModeloCita(
                    motivo: rtbMotivo.Text,
                    fechaCita: fecha,
                    CreadoPor:CacheDeUsuario.NonbreUsuario,
                    Precio:Convert.ToDouble( txtPrecio.Text),
                    dui: CachePaciente.Dui
                    );
                var resultado = crearCita.Cita();
                MessageBox.Show(resultado);
                if (resultado == "Cita Creada") {
                    this.Close();
                }
                
            } catch (Exception) {

               MessageBox.Show("Rellene los campos");
            
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtAño.Clear();
            txtDia.Clear();
            txtHora.Clear();
            txtMes.Clear();
            txtPrecio.Clear();
            rtbMotivo.Clear();
        }
    }
}
