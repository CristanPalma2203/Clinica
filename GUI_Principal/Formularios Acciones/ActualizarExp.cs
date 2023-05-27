using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Dominio;
using CapaComun.Cache;

namespace GUI_Principal
{
    
    public partial class ActualizarExp : Form
    {
        
        public ActualizarExp()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ActualizarExp_Load(object sender, EventArgs e)
        {
            
            cargar_Datos();
            

        }
        private void cargar_Datos() {
            DateTime fecha = CachePaciente.FechaNacimientoPaciente;
            int dia =fecha.Day;
            int mes = fecha.Month;
            int año = fecha.Year;
            TxtNombre.Text = CachePaciente.NombrePaciente;
            TxtApellido.Text = CachePaciente.ApellidoPaciente;
            txtDui.Text = Convert.ToString(CachePaciente.Dui);
            txtDia.Text = Convert.ToString(dia);
            txtMes.Text = Convert.ToString(mes);
            txtAño.Text = Convert.ToString(año);
            TxtNumero.Text = Convert.ToString(CachePaciente.TelefonoPaciente);
            gunaCmbSexo.SelectedItem = CachePaciente.SexoPaciente;
            gunaEstadoCivil.SelectedItem = CachePaciente.EstadoCivilPaciente;
            GunaTypeSan.SelectedItem = CacheExpediente.TipoSangre;
            RtbDireccion.Text = CachePaciente.DirrecionPaciente;
            rtbAntecedentes.Text = CacheExpediente.AntecedentesClinicos;
            rtbMedicamentos.Text = CacheExpediente.MedicamentosPreEscritos;
            FechaExp.Value = CacheExpediente.FechaCreacionExpediente;
        }
        private void Reiniciar()
        {
            cargar_Datos();

        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            DateTime fecha = new DateTime(Convert.ToInt32(txtAño.Text), Convert.ToInt32(txtMes.Text), Convert.ToInt32(txtDia.Text));
            try
            {
                ModeloPaciente actPaciente = new ModeloPaciente(dui: CachePaciente.Dui,
               antecedentes: rtbAntecedentes.Text,
               medicamentos: rtbMedicamentos.Text,
               tipoSangre: Convert.ToString(GunaTypeSan.SelectedItem),
               nombreP: TxtNombre.Text,
               apellidosP: TxtApellido.Text,
               sexoP: Convert.ToString(gunaCmbSexo.SelectedItem),
               numeroTeleP: Convert.ToInt32(TxtNumero.Text),
               direccionP: RtbDireccion.Text,
               estadoCivilP: Convert.ToString(gunaEstadoCivil.SelectedItem),
               fechaNaciemientoP: fecha);
                var resultado = actPaciente.ActualizarExpediente();
                MessageBox.Show(resultado);
                Reiniciar();
                this.Hide();
                

            }
            catch (Exception)
            {

                MessageBox.Show("Error al actulizar datos");
                
            }


        }

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

    
    }
}
