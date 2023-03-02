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

using System.Runtime.InteropServices;
using GUI_Principal.Formularios_Acciones;

namespace GUI_Principal
{
    public partial class Paciente : Form
    {
        private Form currentChildForm;
        public Paciente()
        {
            InitializeComponent();

        }
        private IconButton currentBtn;
   
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.FlatAppearance.BorderSize = 1;
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.FlatAppearance.BorderSize = 0;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;

            }
        }



        private void AbrirFormularioHijoPaciente(Form FormularioHijo)
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
            PanelPaciente.Controls.Add(FormularioHijo);
            PanelPaciente.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
            

        }
        public string diaGet()
        {
            return Convert.ToString(DateTime.Now.Day);
        }
        public string MesGet()
        {
            return Convert.ToString(DateTime.Now.Month);
        }
        public string AñoGet()
        {
            return Convert.ToString(DateTime.Now.Year);
        }
        public string HorasGet()
        {
            return Convert.ToString(DateTime.Now.Hour);
        }
        public string MinutesGet()
        {
            return Convert.ToString(DateTime.Now.Minute);
        }
        public DateTime FechaCitaBusquedad()
        {
            int seg = 00;
            int minutes = 00;
            DateTime fecha = new DateTime(Convert.ToInt32(AñoGet()), Convert.ToInt32(MesGet()), Convert.ToInt32(diaGet()), Convert.ToInt32(HorasGet()), minutes, seg);
            return fecha;

        }
        public DateTime FechaCitaInsertar()
        {
            int seg = 00;
            int minutes = Convert.ToInt32(MinutesGet());
            DateTime fecha = new DateTime(Convert.ToInt32(AñoGet()), Convert.ToInt32(MesGet()), Convert.ToInt32(diaGet()), Convert.ToInt32(HorasGet()), minutes, seg);
            return fecha;

        }

        private void NewConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCita usuario = new ModeloCita();
                var resultado = usuario.BusquedadCitasEnPacientes(Convert.ToInt32(SearchExp.Text), FechaCitaBusquedad());
                if (resultado == false)
                {
                    ModeloCita d1 = new ModeloCita("Cita Comun", FechaCitaInsertar(), CacheDeUsuario.NonbreUsuario, 5, Convert.ToInt32(SearchExp.Text));
                    d1.Cita();
                }

            }
            catch (Exception) {
                msjError("Ingrese un Dui Correctamente");
            }
            
            
            if (SearchExp.Text == "Buscar" || acceso ==  false) 
            {

                msjError("Ingrese un Dui");
                SearchExp.Focus();



            }
            else {
                if (registros == true) {
                    CacheDiagnostico.id = 0;
                }
                AbrirFormularioHijoPaciente(new FrmExpediente()); 
            
            
            }
            
        }


        private void textBox1_Enter(object sender, EventArgs e)
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

        private void NewSearch_Click(object sender, EventArgs e)
        {
            SearchExp.Focus();
            SearchExp.Clear();
            reset();
        }

        private void SerachExpediente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(253, 138, 114));
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            this.BringToFront();
            panelvisual1.Visible = true;
            panelvisual2.Visible = false;
        }

        private void addPaciente_Click(object sender, EventArgs e)
        {
            btnPrueba.Visible = false;
            AbrirFormularioHijoPaciente(new FrmCrearExpediente());
            ActivateButton(sender, Color.FromArgb(253, 138, 114));
            panelvisual2.Visible = true;
            panelvisual1.Visible = false;
            
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            registros = false;

            //Permisos
            if (CacheDeUsuario.CargoUsuario == Cargos.Admistrador)
            {

                NewConsulta.Enabled = false;
            }
            if (CacheDeUsuario.CargoUsuario == Cargos.Enfermera)
            {
                NewConsulta.Enabled = false;
                DeleteExpediente.Enabled = false;

            }
            if (CacheDeUsuario.CargoUsuario == Cargos.Doctor)
            {

            }


        }
       

        bool act=false;
        private void Actualizar_Click(object sender, EventArgs e)
        {
            
            
            if (SearchExp.Text == "Buscar" || acceso == false)
            {
                msjError("Ingrese un Dui");
                SearchExp.Focus();

            }
            else {
                AbrirFormularioHijoPaciente(new ActualizarExp());
                act = true;
            }

        }
        private void PanelPaciente_MouseEnter(object sender, EventArgs e)
        {

            if (act == true) { BuscarExpe(); act = false; }

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            this.BringToFront();
            panelvisual1.Visible = true;
            panelvisual2.Visible = false;

        }


        private void msjError(string msj)
        {
            Errorlbl.Text = msj;
            Errorlbl.Visible = true;
            ErrorBusquedad.Visible = true;
        }
        public void Search_Click(object sender, EventArgs e)
        {
            BuscarExpe();
        }
        bool acceso = false;
        public void BuscarExpe() {
            
            if (SearchExp.Text != "Buscar")
            {
                
                try
                {
                    ModeloPaciente usuario = new ModeloPaciente();
                    var BusquedadValida = usuario.BusquedadPaciente(Convert.ToInt32( SearchExp.Text));
                    if (BusquedadValida == true)
                    {
                        
                        lblDuiPaciente.Text = Convert.ToString(CachePaciente.Dui);
                        lblNombrePaciente.Text = CachePaciente.NombrePaciente;
                        lblApellidoPaciente.Text = CachePaciente.ApellidoPaciente;
                        lblFechaNacPaciente.Text = Convert.ToString(CachePaciente.FechaNacimientoPaciente);
                        lblFechaExpedientePaciente.Text = Convert.ToString(CacheExpediente.FechaCreacionExpediente);
                        numExpedientePaciente.Text = Convert.ToString(CacheExpediente.NumExpediente);
                        Errorlbl.Visible = false;
                        ErrorBusquedad.Visible = false;
                        acceso = true;

                    }
                    else
                    {
                        acceso = false;
                        msjError("Usuario No Encontrado");
                    }
                }
                catch (Exception)
                {
                    acceso = false;
                    msjError("Dui Invalido");
                }

            }
            else
            {
                acceso = false;
                msjError("Ingrese Un Usuario");
            }



        }

        private void DeleteExpediente_Click(object sender, EventArgs e)
        {

            if (SearchExp.Text == "Buscar" || acceso == false || SearchExp.Text == "" )
            {
                msjError("Ingrese un Dui");
                SearchExp.Focus();
                

            }
            else
            {
                try
                {
                    ModeloPaciente eliminar = new ModeloPaciente();
                    eliminar.EliminarExp();
                    MessageBox.Show("Expediente Eliminado");
                    reset();


                }
                catch (Exception)
                {
                    MessageBox.Show("Error Al Eliminar Expediente");
                }
            }


        }

        public void reset() {

            lblDuiPaciente.Text = "";
            lblNombrePaciente.Text = "";
            lblApellidoPaciente.Text = "";
            lblFechaNacPaciente.Text = "";
            lblFechaExpedientePaciente.Text = "";
            numExpedientePaciente.Text = "";
            
        }

        private void SearchExp_TextChanged(object sender, EventArgs e)
        {
            if(SearchExp.Text.Length == 9)
            {
                BuscarExpe();
            }
            if (SearchExp.Text.Length >=1 && SearchExp.Text.Length < 9 ) {
            Errorlbl.Visible = false;
            ErrorBusquedad.Visible = false;
                reset();

            }

        }
        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            if (act == true) { BuscarExpe(); act = false; }
        }


        bool registros = false;
        private void icondatabse_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijoPaciente(new DatosPaciente());
            registros = true;
        }
    }
}
