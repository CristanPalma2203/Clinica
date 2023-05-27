using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;
namespace GUI_Principal
{
    public partial class FrmCrearExpediente : Form
    {
        public FrmCrearExpediente()
        {
            InitializeComponent();
        }


        private void BtnCrear_Click(object sender, EventArgs e)
        {
            
            try {
                DateTime fecha = new DateTime(Convert.ToInt32(txtAño.Text), Convert.ToInt32(txtMes.Text), Convert.ToInt32(txtDia.Text));
                ModeloPaciente createPaciente = new ModeloPaciente(dui: Convert.ToInt32(TxtDui.Text),
              nombreP: TxtNombre.Text,
              apellidosP: TxtApellido.Text,
              sexoP: Convert.ToString(guna2ComboBox1.SelectedItem),
              numeroTeleP: Convert.ToInt32(TxtNumero.Text),
              direccionP: RtbDireccion.Text,
              estadoCivilP: Convert.ToString(gunaEstadoC.SelectedItem),
              fechaNaciemientoP: fecha,
              antecedentes: rtbAntecedentes.Text,
              medicamentos: rtbMedicamentos.Text,
              tipoSangre: Convert.ToString(GunaTypeSan.SelectedItem)


              );
                var resultado = createPaciente.CrearExpediente();
                MessageBox.Show(resultado);
                
                if (resultado != "El numero de Dui ya esta registrado") { Reset(); }
            }
            catch (FormatException) {
                MessageBox.Show("Rellene Los Campos");
            }
            

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

            Reset();

        }

        private void FrmCrearExpediente_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GunaTypeSan.Items.Add("O -");
            GunaTypeSan.Items.Add("O +");
            GunaTypeSan.Items.Add("A -");
            GunaTypeSan.Items.Add("A +");
            GunaTypeSan.Items.Add("B -");
            GunaTypeSan.Items.Add("B +");
            GunaTypeSan.Items.Add("AB -");
            GunaTypeSan.Items.Add("AB +");
        }

        private void CboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboEstadoCivil_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }
        private void Reset()
        {
            rtbMedicamentos.Clear();
            rtbAntecedentes.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtDui.Clear();
            RtbDireccion.Clear();
            TxtNumero.Clear();
            txtDia.Clear();
            txtMes.Clear();
            txtAño.Clear();
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.Add("F");
            guna2ComboBox1.Items.Add("M");
    

            gunaEstadoC.Items.Clear();
            gunaEstadoC.Items.Add("Soltero");
            gunaEstadoC.Items.Add("Casado");
            gunaEstadoC.Items.Add("Divorsiado");
            gunaEstadoC.Items.Add("Viudo");

            GunaTypeSan.Items.Clear();
            GunaTypeSan.Items.Add("O -");
            GunaTypeSan.Items.Add("O +");
            GunaTypeSan.Items.Add("A -");
            GunaTypeSan.Items.Add("A +");
            GunaTypeSan.Items.Add("B -");
            GunaTypeSan.Items.Add("B +");
            GunaTypeSan.Items.Add("AB -");
            GunaTypeSan.Items.Add("AB +");
        }

    }
}
