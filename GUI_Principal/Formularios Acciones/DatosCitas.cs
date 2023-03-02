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
using CapaComun.Cache;

namespace GUI_Principal.Formularios_Acciones
{
    public partial class DatosCitas : Form
    {
        DateTime fec = DateTime.Today;
        public DatosCitas()
        {
            InitializeComponent();
        }

        private void DatosCitas_Load(object sender, EventArgs e)
        {
            MostrarCitas();

        }
        public int fechaDia()
        {
            return fec.Day; 
        }
        public int fechaMes()
        {
            return fec.Month; 
        }
        public int fechaAño()
        {
            return fec.Year;
        }

        private void MostrarCitas(){
            ModeloCita mc =new  ModeloCita();
            dataGridView1.DataSource = mc.mostrar();
        }
        private void MostrarCitasFechas() {
            ModeloCita c1 = new ModeloCita();
            dataGridView1.DataSource = c1.MostrarFechaCita(Fecha(Convert.ToInt32(txtDia.Text), Convert.ToInt32(txtMes.Text), Convert.ToInt32(txtAño.Text)));
        }
        private void MostrarCitasFechasPersona()
        {
            ModeloCita c1 = new ModeloCita();
            dataGridView1.DataSource = c1.MostrarFechaCitaPersona(Fecha(Convert.ToInt32(txtDia.Text), Convert.ToInt32(txtMes.Text), Convert.ToInt32(txtAño.Text)), Convert.ToInt32(SearchExp.Text));
        }
        private void msjError(string msj)
        {
            Errorlbl.Text = msj;
            Errorlbl.Visible = true;
            ErrorBusquedad.Visible = true;
        }
        private void MostrarCitasPersona()
        {
            
                ModeloCita c1 = new ModeloCita();
                dataGridView1.DataSource = c1.MostrarCitasPersona(Convert.ToInt32( SearchExp.Text));
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
        private void Busquedad()
        {
            try {

                if (SearchExp.TextLength == 0 || SearchExp.TextLength == 9 || SearchExp.TextLength == 6) {

                    if (txtDia.Text != "")
                    {
                        if (txtMes.Text != "")
                        {
                            if (txtAño.Text != "")
                            {
                                if (SearchExp.Text != "Buscar" && SearchExp.Text != "")
                                {
                                    MostrarCitasFechasPersona();
                                   
                                   
                                }
                                else if (SearchExp.Text == "Buscar" || SearchExp.Text == "")
                                {
                                    MostrarCitasFechas();
                                 
                                }
                            }
                        }
                    }
                    else
                    {
                        MostrarCitasPersona();
                    }


                }
                else { msjError("Complete Los 9 Digitos del Dui"); }
               
                }catch (FormatException)
                {
                msjError("Ingrese Un Dui Valido");
                }



        }
        private void Search_Click(object sender, EventArgs e)
        {
            try { Busquedad(); }
            catch (FormatException)
            {
                msjError("Ingrese Un Dui Valido");
            }


        }

        private void calendario_Click(object sender, EventArgs e)
        {

            int dia = fechaDia();
            int mes = fechaMes();
            int año = fechaAño();


            if (txtDia.Text == "")
            {
                txtDia.Text = Convert.ToString(dia);
            }
            if (txtMes.Text == "")
            {
                txtMes.Text = Convert.ToString(mes);
            }
            if (txtAño.Text == "")
            {
                txtAño.Text = Convert.ToString(año);
            }
        }

        private DateTime Fecha(int dia,int mes,int año)
        {
            DateTime fecha = new DateTime(Convert.ToInt32(txtAño.Text), Convert.ToInt32(txtMes.Text), Convert.ToInt32(txtDia.Text));
            return fecha;
        }

        private void ActualizarCita_Click(object sender, EventArgs e)
        {
            try {
                
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Dui"].Value.ToString());
                ModeloPaciente p1 = new ModeloPaciente();
                p1.BusquedadPacienteCita(id);
                AbrirFormularioHijoCita(new ActualizarCita());
            }
            catch (Exception) { MessageBox.Show("Selecione Fila"); }
            
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

        private void EleminarCita_Click(object sender, EventArgs e)
        {
            
                
                ModeloCita md = new ModeloCita();
                int dui = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Dui"].Value.ToString());
                DateTime fecha = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Fecha"].Value.ToString());
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    

                    ModeloCita c1 = new ModeloCita();
                    c1.busquedad(dui);
                    var resultado = c1.eliminarCitasinfecha(dui, fecha);
                    

                if (resultado >= 1)
                    {

                        MessageBox.Show("Cita Eliminada");
                         MostrarCitas();


                    }
                    else { MessageBox.Show("Cita No Encontrada"); }


                }
                else
                {
                    MessageBox.Show("Selecione Una Fila");

                }
            
            
            
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SearchExp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SearchExp.Text.Length == 9)
                {
                    Busquedad();
                }
                if (SearchExp.Text.Length <9 )
                {
                    Errorlbl.Visible = false;
                    ErrorBusquedad.Visible = false;
                    MostrarCitas();
                }
            }
            catch (Exception)
            {
                msjError("Ingrese Un Dui Valido");

            }
        }
    }
}
