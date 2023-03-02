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
using GUI_Principal.Formularios_Acciones;

namespace GUI_Principal
{
    public partial class Citas : Form
    {
        private Form FormularioActual;
        public Citas()
        {
            InitializeComponent();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        
        bool acceso = false;
        private void msjError(string msj)
        {
            Errorlbl.Text = msj;
            Errorlbl.Visible = true;
            ErrorBusquedad.Visible = true;
        }
        public void BuscarExpe()
        {
            acceso = false;

            if (SearchExp.Text != "Buscar")
            {
                ModeloPaciente usuario = new ModeloPaciente();
                try
                {
                    var BusquedadValida = usuario.BusquedadPacienteCita(Convert.ToInt32(SearchExp.Text));
                    if (BusquedadValida == true)
                    {

                        lblDuiPaciente.Text = Convert.ToString(CachePaciente.Dui);
                        lblNombrePaciente.Text = CachePaciente.NombrePaciente;
                        lblApellidoPaciente.Text = CachePaciente.ApellidoPaciente;
                        lblProx.Text = Convert.ToString( CacheCita.fechaCita);
                        lblCreador.Text = CacheCita.CreadoPor;
                        lblMotivo.Text = CacheCita.motivo;

                        Errorlbl.Visible = false;
                        ErrorBusquedad.Visible = false;
                        acceso = true;

                    }
                    
                }
                catch (Exception)
                {
                    acceso = false;
                    msjError("Dui Invalido");
                }

                if(acceso== false)
                {
                    try {

                        var BusquedadValida = usuario.BusquedadPaciente(Convert.ToInt32(SearchExp.Text));
                        if (BusquedadValida == true)
                        {

                            lblDuiPaciente.Text = Convert.ToString(CachePaciente.Dui);
                            lblNombrePaciente.Text = CachePaciente.NombrePaciente;
                            lblApellidoPaciente.Text = CachePaciente.ApellidoPaciente;
                            
                            lblProx.Text = "";
                            lblCreador.Text = "";
                            lblMotivo.Text = "";
                            Errorlbl.Visible = false;
                            ErrorBusquedad.Visible = false;
                            acceso = true;

                        }
                        else
                        {

                            acceso = false;
                            msjError("Usuario No Encontrado");
                        }


                    } catch (Exception) {
                        acceso = false;
                        msjError("Dui Invalido");
                    }


                }
                

            }
            



        }
        private void Enfermera_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchExp_TextChanged(object sender, EventArgs e)
        {
            if (SearchExp.Text.Length == 9)
            {
                BuscarExpe();
            }
            if (SearchExp.Text.Length > 1 && SearchExp.Text.Length < 9)
            {
                Errorlbl.Visible = false;
                ErrorBusquedad.Visible = false;
                reset();
            }
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
            BuscarExpe();
        }
     
        public void reset()
        {

            lblDuiPaciente.Text = "";
            lblNombrePaciente.Text = "";
            lblApellidoPaciente.Text = "";
            lblProx.Text = "";
            lblMotivo.Text = "";
            lblCreador.Text = "";
            acceso = false;



        }
        private void AbrirFormularioHijoCita(Form FormularioHijo)
        {
            
            if (FormularioActual != null)
            {
                FormularioActual.Close();
            }
            FormularioActual = FormularioHijo;
            
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            PanelPaciente.Controls.Add(FormularioHijo);
            PanelPaciente.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();


        }
        bool act=false;
        private void NewCita_Click(object sender, EventArgs e)
        {
            if (SearchExp.Text == "Buscar" || acceso == false)
            {
                msjError("Ingrese un Dui");
                SearchExp.Focus();

            }
            else
            {
                AbrirFormularioHijoCita(new NuevaCita());
                act = true;
            }
        }

        private void ActualizarCita_Click(object sender, EventArgs e)
        {
            if (SearchExp.Text == "Buscar" || acceso == false)
            {
                msjError("Ingrese un Dui");
                SearchExp.Focus();

            }
            else
            {
                
                AbrirFormularioHijoCita(new ActualizarCita());
                act = true;
            }

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            if (act == true) { BuscarExpe(); act = false; }
        }

        private void DeleteExpediente_Click(object sender, EventArgs e)
        {
            try {

                if (SearchExp.Text == "Buscar" || acceso == false)
            {
                msjError("Ingrese un Dui");
                SearchExp.Focus();

            }
            else
            {

                    ModeloCita c1 = new ModeloCita(CachePaciente.Dui, CacheCita.fechaCita);
                    var resultado = c1.eliminarCita();

                    if (resultado >= 1)
                    {
                        BuscarExpe();
                        MessageBox.Show("Cita Eliminada");

                    }
                    else { MessageBox.Show("Cita No Encontrada"); }
                    
                }



                

            } catch (Exception) {

                MessageBox.Show("Error Al Eliminar Cita");
            }
           


        }

        private void icondatabse_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijoCita(new DatosCitas());
        }
    }
}
