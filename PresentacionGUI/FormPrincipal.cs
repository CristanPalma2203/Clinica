using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using GUI_Principal;
using CapaComun;
using CapaComun.Cache;
using GUI_Principal.Formularios_Acciones;
using FrmSlide;

namespace PresentacionGUI
{
    public partial class FormPrincipal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FormPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            Menu.Controls.Add(leftBorderBtn);
            //Formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
            CargaDatosUsuario();
            //Permisos
            if (CacheDeUsuario.CargoUsuario == Cargos.Admistrador)
            {
                iconUsers.IconChar = FontAwesome.Sharp.IconChar.UserShield;
                // admin
            }
            if (CacheDeUsuario.CargoUsuario == Cargos.Enfermera)
            {
                iconUsers.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
                Reportes.Enabled = false;
           
          

            }
            if (CacheDeUsuario.CargoUsuario == Cargos.Doctor)
            {
                iconUsers.IconChar = FontAwesome.Sharp.IconChar.UserMd;
           
            }
            if (CacheDeUsuario.CargoUsuario == Cargos.Ingeniera)
            {
                iconUsers.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            }


            }
        private void CargaDatosUsuario()
        {
            lblNombre.Text = CacheDeUsuario.NonbreUsuario +" "+CacheDeUsuario.ApellidoUsuario+".";
            Cargo.Text = CacheDeUsuario.CargoUsuario;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(2, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconFormularioActual.IconChar = currentBtn.IconChar;
                iconFormularioActual.IconColor = color;
                TituloFormularioHijo.ForeColor = color;
                //Botones
                Close.ForeColor = color;
                Minimizar.ForeColor = color;
                iconPictureBox1.ForeColor = color;
                iconUsers.ForeColor = color;
                linklblEditar.LinkColor = color;
                
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(245, 50, 87);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                
            }
        }
        private void AbrirFormularioHijo(Form FormularioHijo)
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
            Formularios.Controls.Add(FormularioHijo);
            Formularios.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
            TituloFormularioHijo.Text = FormularioHijo.Text;

        }
        

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Paciente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(253, 138, 114));
            AbrirFormularioHijo(new Paciente());
        }

        private void Registros_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(84, 177, 248));
            AbrirFormularioHijo(new Citas());            

        }

        private void Administrador_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
            AbrirFormularioHijo(new Reportes());
        }

   
        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(95, 77, 221));
            AbrirFormularioHijo(new Reportes());

            Reportes reportes = new Reportes();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconFormularioActual.IconChar = IconChar.Home;
            iconFormularioActual.IconColor = Color.FromArgb(245, 50, 87);
            TituloFormularioHijo.Text = "Inicio";
            TituloFormularioHijo.ForeColor = Color.Gainsboro;
            Close.ForeColor = Color.FromArgb(245, 50, 87);
            Minimizar.ForeColor = Color.FromArgb(245, 50, 87);
            iconUsers.IconColor = Color.FromArgb(245, 50, 87);
            iconPictureBox1.IconColor = Color.FromArgb(245, 50, 87);
            iconPictureBox1.ForeColor = Color.FromArgb(245, 50, 87);
            iconUsers.ForeColor = Color.FromArgb(245, 50, 87);
            linklblEditar.LinkColor = Color.FromArgb(245, 50, 87);
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void iconFormularioActual_Click(object sender, EventArgs e)
        {

        }
        
        private void Salir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que quieres cerrar sesion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
            }
            
        }
        private void cerrarGuia(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
            

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();

        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            CargaDatosUsuario();
        }

        private void linklblEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormularioHijo(new ActualizarUsuario());
            Reset();
        }

        private void Guia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
            menu.FormClosed += cerrarGuia;

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
