using CapaComun.Cache;
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
    public partial class ActualizarUsuario : Form
    {
        public ActualizarUsuario()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "ID Usuario")
            {
                txtUsuario.Text = "";

                txtUsuario.ForeColor = Color.Gainsboro;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
               txtUsuario.Text = "ID Usuario";
               txtUsuario.ForeColor = Color.FromArgb(120, 116, 127);
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";

                txtNombre.ForeColor = Color.Gainsboro;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.FromArgb(120, 116, 127);
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";

               txtApellido.ForeColor = Color.Gainsboro;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.FromArgb(120, 116, 127);
            }
        }

        private void txtContraseñaN_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaN.Text == "Contraseña Nueva")
            {
                txtContraseñaN.Text = "";
                txtContraseñaN.UseSystemPasswordChar = true;
                txtContraseñaN.ForeColor = Color.Gainsboro;
            }
        }

        private void txtContraseñaN_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaN.Text == "")
            {
                txtContraseñaN.UseSystemPasswordChar = false;
                txtContraseñaN.Text = "Contraseña Nueva";
                txtContraseñaN.ForeColor = Color.FromArgb(120, 116, 127);
            }
        }

        private void txtRContraseñaN_Enter(object sender, EventArgs e)
        {
            if (txtRContraseñaN.Text == "Confirmar Contraseña")
            {
                txtRContraseñaN.Text = "";
                txtRContraseñaN.UseSystemPasswordChar = true;
                txtRContraseñaN.ForeColor = Color.Gainsboro;
            }
        }

        private void txtRContraseñaN_Leave(object sender, EventArgs e)
        {
            if (txtRContraseñaN.Text == "")
            {
                txtRContraseñaN.UseSystemPasswordChar = false;
                txtRContraseñaN.Text = "Confirmar Contraseña";
                txtRContraseñaN.ForeColor = Color.FromArgb(120, 116, 127);
            }
        }

        private void ContraseñaAnterior_Enter(object sender, EventArgs e)
        {
            if (ContraseñaAnterior.Text == "Contraseña Actual")
            {
                ContraseñaAnterior.Text = "";
                ContraseñaAnterior.UseSystemPasswordChar = true;
                ContraseñaAnterior.ForeColor = Color.Gainsboro;
            }
        }

        private void ContraseñaAnterior_Leave(object sender, EventArgs e)
        {
            if (ContraseñaAnterior.Text == "")
            {
                ContraseñaAnterior.Text = "Contraseña Actual";
                ContraseñaAnterior.ForeColor = Color.FromArgb(120, 116, 127);
                ContraseñaAnterior.UseSystemPasswordChar = false;
            }
        }

        private void ActualizarUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos() {
            lblNombre.Text = CacheDeUsuario.NonbreUsuario;
            lblApellido.Text = CacheDeUsuario.ApellidoUsuario;
            lblCargo.Text = CacheDeUsuario.CargoUsuario;
            lblUsuario.Text = CacheDeUsuario.idUser;
            //panel
            txtUsuario.Text = CacheDeUsuario.idUser;
            txtNombre.Text = CacheDeUsuario.NonbreUsuario;
            txtApellido.Text = CacheDeUsuario.ApellidoUsuario;
            ContraseñaAnterior.Text = "Contraseña Actual";
            txtContraseñaN.Enabled = false;
            txtRContraseñaN.Enabled = false;
            ContraseñaAnterior.UseSystemPasswordChar = false;
            ContraseñaAnterior.ForeColor = Color.FromArgb(120, 116, 127);
        }
        private void inicializarContraseña()
        {
            linkEditarContraseña.Text = "Editar Contraseña";
            txtContraseñaN.Enabled = false;
            txtContraseñaN.UseSystemPasswordChar = false;
            txtRContraseñaN.Enabled = false;
            txtRContraseñaN.UseSystemPasswordChar = false;
            txtRContraseñaN.Text = "Confirmar Contraseña";
            txtContraseñaN.Text = "Contraseña Nueva";
        }

        private void reset() {

            CargarDatos();
            inicializarContraseña();
        
        }



        private void linkEditarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkEditarContraseña.Text == "Editar Contraseña") {
                linkEditarContraseña.Text = "Cancelar";
                txtContraseñaN.Enabled = true;
                txtContraseñaN.Text = "Contraseña Nueva";
                txtContraseñaN.ForeColor= Color.FromArgb(120, 116, 127);
                txtRContraseñaN.Enabled = true;
                txtRContraseñaN.ForeColor= Color.FromArgb(120, 116, 127);
                txtRContraseñaN.Text = "Confirmar Contraseña";
                txtContraseñaN.UseSystemPasswordChar = false;
                txtRContraseñaN.UseSystemPasswordChar = false;

            }
            else if (linkEditarContraseña.Text == "Cancelar") {
                inicializarContraseña();

            
            }
        }
        private void Actualizar()

        {/*string nombre, string usuario, string contraseña, string apellido*/
            
            


        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtRContraseñaN.Enabled == false)
            {
                if (ContraseñaAnterior.Text == CacheDeUsuario.Contraseña) {

                    var ModeloUsuario = new ModeloUsuario(txtNombre.Text, txtUsuario.Text, CacheDeUsuario.Contraseña, txtApellido.Text);
                    var resultado = ModeloUsuario.editarUsuario();
                    MessageBox.Show(resultado);
                    reset();
                    panelEdicion.Visible = false;
                    panelConexion.Visible = false;
                }
                else
                {
                    MessageBox.Show("Contraseña Actual Incorrecta");

                }

            }
            else {

                if (txtContraseñaN.Text == txtRContraseñaN.Text && CacheDeUsuario.Contraseña == ContraseñaAnterior.Text)
                {
                    var ModeloUsuario = new ModeloUsuario(txtNombre.Text, txtUsuario.Text, txtRContraseñaN.Text, txtApellido.Text);
                    var resultado = ModeloUsuario.editarUsuario();
                    MessageBox.Show(resultado);
                    reset();
                    panelEdicion.Visible = false;
                    panelConexion.Visible = false;
                }
                else {
                    MessageBox.Show("Contraseñas No Coinciden");
                
                }
            }
        }

        private void linklblEditar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelConexion.Visible = true;
            panelEdicion.Visible = true;
            CargarDatos();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelEdicion.Visible = false;
            panelConexion.Visible = false;
            reset();
        }
    }
}
