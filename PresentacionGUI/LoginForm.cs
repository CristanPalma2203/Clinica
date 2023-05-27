using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Cache;
using Dominio;




namespace PresentacionGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "Programa Creado el 27 de Mayo de 2023,\nPara El Registro Clinico, Desarrollado Por un \nEquipo de 5 Programadores de La Universidad\nTecnologica de El Salvador,Con el Proposito de\nActualizar los Metodos Poco Comunes Utilizados \nEn La Buena Vida Ubicada En Soyapango.";
        }
        
        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text == "Usuario")
            {
                Usuario.Text = "";
                Usuario.ForeColor = Color.FromArgb(255, 44, 86);
                panelUsuario.BackColor = Color.FromArgb(255, 44, 86);
                iconUser.IconColor = Color.FromArgb(255, 44, 86);

            }
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.Text = "Usuario";
                Usuario.ForeColor = Color.FromArgb(120, 116, 127);
                panelUsuario.BackColor = Color.FromArgb(120, 116, 127);
                iconUser.IconColor = Color.FromArgb(120, 116, 127);


            }
        }

        private void Contraseña_Enter(object sender, EventArgs e)
        {
            if (Contraseña.Text == "Contraseña")
            {
                Contraseña.Text = "";
                Contraseña.ForeColor = Color.FromArgb(255, 44, 86);
                panelContraseña.BackColor = Color.FromArgb(255, 44, 86);
                iconPass.IconColor = Color.FromArgb(255, 44, 86);
                Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void Contraseña_Leave(object sender, EventArgs e)
        {
            if (Contraseña.Text == "")
            {
                Contraseña.Text = "Contraseña";
                Contraseña.ForeColor = Color.FromArgb(120, 116, 127);
                panelContraseña.BackColor = Color.FromArgb(120, 116, 127);
                iconPass.IconColor = Color.FromArgb(120, 116, 127);
                Contraseña.UseSystemPasswordChar = false;
            }
        }


        private void Minimizar_Click(object sender, EventArgs e)
        {
           
        }
        //metodo para mover ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void msjError(string msj)
        {
            Error.Text =  msj;
            Error.Visible = true;
            ErrorIcon.Visible = true;
        }

        private void cerrarSesion(object sender ,FormClosedEventArgs e ) {
           
            Contraseña.Text = "Contraseña";
            Contraseña.ForeColor = Color.FromArgb(120, 116, 127);
            Contraseña.UseSystemPasswordChar = false;
            Usuario.Text = "Usuario";
            Usuario.ForeColor = Color.FromArgb(120, 116, 127);
            panelContraseña.BackColor = Color.FromArgb(120, 116, 127);
            panelUsuario.BackColor = Color.FromArgb(120, 116, 127);
            iconPass.IconColor = Color.FromArgb(120, 116, 127);
            iconUser.IconColor = Color.FromArgb(120, 116, 127);
            Error.Visible = false;
            ErrorIcon.Visible = false;
            this.Show();
        }


        private void Acceder_Click_1(object sender, EventArgs e)
        {
            if (Usuario.Text != "Usuario")
            {
                if (Contraseña.Text != "Contraseña")
                {
                    ModeloUsuario usuario = new ModeloUsuario();
                    var LoginValido = usuario.AccesoUsuario(Usuario.Text, Contraseña.Text);
                    if (LoginValido == true)
                    {
                        this.Hide();
                        LoadingForm b1 = new LoadingForm();
                        b1.ShowDialog();
                        FormPrincipal menu = new FormPrincipal();
                        menu.Show();
                        menu.FormClosed += cerrarSesion;



                    }
                    else
                    {

                        msjError("Usuario o Contraseña Incorrecta \nPorfavor Intente de Nuevo.");
                        Contraseña.Text = "Contraseña";
                        Contraseña.ForeColor = Color.FromArgb(120, 116, 127);
                        panelContraseña.BackColor = Color.FromArgb(120, 116, 127);
                        iconPass.IconColor = Color.FromArgb(120, 116, 127);
                        Contraseña.UseSystemPasswordChar = false;
                        Usuario.Focus();
                    }
                }
                else
                {
                    msjError("Ingrese Su Contraseña De Usuario.");
                }
            }
            else
            {
                msjError("Ingrese Su Usuario De Usuario.");
            }
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        

        private void iniciar_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Width = 800;
            panelregistro.BringToFront();
            info.Visible =true;
            label5.Text = "¡Hola, Bienvenido!";
            pictureBox1.Visible = false;
            label6.Visible = false;
            iniciar.Visible = false;
            userLogin.Visible = false;
            logopic.Visible = true;

        }

        private void info_Click(object sender, EventArgs e)
        {
            if (bunifuGradientPanel2.Width == 800)
            {
                while (bunifuGradientPanel2.Width != 400)
                {
                    bunifuGradientPanel2.Width -= 10;

                }

            }
            logopic.Visible = false;
            panelregistro.SendToBack();
            info.Visible = false;
            label5.Text = "Acerca De";
            pictureBox1.Visible = true;
            label6.Visible = true;
            iniciar.Visible = true;
            userLogin.Visible = true;
            
        }

       
        private void ActivarOjo()
        {
            if (iconEye.IconChar == FontAwesome.Sharp.IconChar.EyeSlash) {
                if (Contraseña.Text != "Contraseña" && Contraseña.Text != "")
                {
                    iconEye.IconColor = Color.FromArgb(255, 44, 86);
                    iconEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    Contraseña.UseSystemPasswordChar = false;

                }
            }
            else
            {
                if (Contraseña.Text != "Contraseña"&& Contraseña.Text != "")
                {
                    iconEye.IconColor =  Color.FromArgb(120, 116, 127);
                    iconEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                    Contraseña.UseSystemPasswordChar = true;

                }

            }
            

        }

        private void iconEye_Click(object sender, EventArgs e)
        {
            ActivarOjo();
        }

        private void panelregistro_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuGradientPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
