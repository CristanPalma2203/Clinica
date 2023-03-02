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
    public partial class DatosPaciente : Form
    {
        public DatosPaciente()
        {
            InitializeComponent();
        }

        private void DatosPaciente_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            ModeloPaciente p1 = new ModeloPaciente();
            dataGridView1.DataSource = p1.mostrarExpedientes();

        }
        private void MostrarDatosDui(int dui)
        {
            ModeloPaciente p1 = new ModeloPaciente();
            dataGridView1.DataSource = p1.mostrarExpedientes(dui);

        }


        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void SearchExp_Enter(object sender, EventArgs e)
        {
            if (SearchExp.Text == "Buscar")
            {
                SearchExp.Text = "";

                SearchExp.ForeColor = Color.Gainsboro;
            }
        }

        private void SearchExp_Leave(object sender, EventArgs e)
        {
            if (SearchExp.Text == "")
            {
                SearchExp.Text = "Buscar";
                SearchExp.ForeColor = Color.FromArgb(120, 116, 127);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try {
                if (SearchExp.Text != "Buscar" && SearchExp.Text != "")
                {

                    MostrarDatosDui(Convert.ToInt32(SearchExp.Text));

                }
                else
                {

                    MostrarDatos();
                }
            }
            catch (Exception)
            {
                msjError("Ingrese Un Dui Valido");

            }
            

        }
        private Form currentChildForm;
        private void AbrirFormularioHijoCita(Form FormularioHijo)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = FormularioHijo;
            //End
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            panelcentral.Controls.Add(FormularioHijo);
            panelcentral.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }
        private void AbrirExpediente_Click(object sender, EventArgs e)
        {
            
                int dui;
                int id;
                dui = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Dui"].Value.ToString());
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Consulta"].Value.ToString());
                ModeloPaciente mp = new ModeloPaciente();
                mp.BusquedadExpediente(dui, id);
                AbrirFormularioHijoCita(new FrmExpediente());
            
        
        }

        private void SearchExp_TextChanged(object sender, EventArgs e)
        {
            try {
                if (SearchExp.Text.Length == 9)
                {
                    MostrarDatosDui(Convert.ToInt32(SearchExp.Text));
                }
                if (SearchExp.Text.Length >= 1 && SearchExp.Text.Length < 9)
                {
                    Errorlbl.Visible = false;
                    ErrorBusquedad.Visible = false;
                    MostrarDatos();

                }
            }
            catch (Exception) {
                msjError("Ingrese Un Dui Valido");
                
            }
            
        }
        private void msjError(string msj)
        {
            Errorlbl.Text = msj;
            Errorlbl.Visible = true;
            ErrorBusquedad.Visible = true;
        }

        private void panelcentral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
