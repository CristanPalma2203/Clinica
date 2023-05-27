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

namespace PresentacionGUI
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {

                timer2.Stop();
                this.Close();
            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            if (CacheDeUsuario.CargoUsuario == Cargos.Doctor) { iconoBienvenida.IconChar = FontAwesome.Sharp.IconChar.UserMd; }
            if (CacheDeUsuario.CargoUsuario == Cargos.Enfermera) { iconoBienvenida.IconChar = FontAwesome.Sharp.IconChar.UserNurse; label2.Text = "BIENVENIDA"; }
            if (CacheDeUsuario.CargoUsuario == Cargos.Admistrador) { iconoBienvenida.IconChar = FontAwesome.Sharp.IconChar.UserShield; }
            if (CacheDeUsuario.CargoUsuario == Cargos.Ingeniera) { iconoBienvenida.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher; label2.Text = "BIENVENIDA"; }
            UsuarioBienvenida.Text = CacheDeUsuario.NonbreUsuario + " " + CacheDeUsuario.ApellidoUsuario;
            CargoBienvenida.Text = CacheDeUsuario.CargoUsuario;
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
