namespace PresentacionGUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.info = new FontAwesome.Sharp.IconPictureBox();
            this.userLogin = new FontAwesome.Sharp.IconPictureBox();
            this.iniciar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelregistro = new System.Windows.Forms.Panel();
            this.iconEye = new FontAwesome.Sharp.IconPictureBox();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.iconPass = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Minimizar = new FontAwesome.Sharp.IconPictureBox();
            this.ErrorIcon = new FontAwesome.Sharp.IconPictureBox();
            this.Close = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Acceder = new System.Windows.Forms.Button();
            this.panelContraseña = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelregistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.bunifuGradientPanel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 464);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.info);
            this.bunifuGradientPanel2.Controls.Add(this.userLogin);
            this.bunifuGradientPanel2.Controls.Add(this.iniciar);
            this.bunifuGradientPanel2.Controls.Add(this.label5);
            this.bunifuGradientPanel2.Controls.Add(this.logopic);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(50)))), ((int)(((byte)(87)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(50)))), ((int)(((byte)(87)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-7, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(800, 464);
            this.bunifuGradientPanel2.TabIndex = 15;
            this.bunifuGradientPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel2_MouseMove);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.ForeColor = System.Drawing.Color.Silver;
            this.info.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.info.IconColor = System.Drawing.Color.Silver;
            this.info.IconSize = 50;
            this.info.Location = new System.Drawing.Point(352, 367);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(52, 50);
            this.info.TabIndex = 17;
            this.info.TabStop = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // userLogin
            // 
            this.userLogin.BackColor = System.Drawing.Color.Transparent;
            this.userLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.userLogin.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.userLogin.IconColor = System.Drawing.Color.Gainsboro;
            this.userLogin.IconSize = 155;
            this.userLogin.Location = new System.Drawing.Point(123, 115);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(155, 155);
            this.userLogin.TabIndex = 16;
            this.userLogin.TabStop = false;
            this.userLogin.Visible = false;
            // 
            // iniciar
            // 
            this.iniciar.BackColor = System.Drawing.Color.Transparent;
            this.iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.iniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.ForeColor = System.Drawing.Color.Gainsboro;
            this.iniciar.Location = new System.Drawing.Point(151, 302);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(110, 40);
            this.iniciar.TabIndex = 15;
            this.iniciar.Text = "Iniciar Sesion";
            this.iniciar.UseVisualStyleBackColor = false;
            this.iniciar.Visible = false;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(56, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "¡Hola, Bienvenido!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logopic
            // 
            this.logopic.BackColor = System.Drawing.Color.Transparent;
            this.logopic.Image = ((System.Drawing.Image)(resources.GetObject("logopic.Image")));
            this.logopic.Location = new System.Drawing.Point(44, 85);
            this.logopic.Name = "logopic";
            this.logopic.Size = new System.Drawing.Size(338, 296);
            this.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logopic.TabIndex = 18;
            this.logopic.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(7, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = ".";
            this.label6.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelregistro
            // 
            this.panelregistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.panelregistro.Controls.Add(this.iconEye);
            this.panelregistro.Controls.Add(this.iconUser);
            this.panelregistro.Controls.Add(this.iconPass);
            this.panelregistro.Controls.Add(this.panel4);
            this.panelregistro.Controls.Add(this.Minimizar);
            this.panelregistro.Controls.Add(this.ErrorIcon);
            this.panelregistro.Controls.Add(this.Close);
            this.panelregistro.Controls.Add(this.label1);
            this.panelregistro.Controls.Add(this.Error);
            this.panelregistro.Controls.Add(this.Usuario);
            this.panelregistro.Controls.Add(this.panelUsuario);
            this.panelregistro.Controls.Add(this.Contraseña);
            this.panelregistro.Controls.Add(this.Acceder);
            this.panelregistro.Controls.Add(this.panelContraseña);
            this.panelregistro.Location = new System.Drawing.Point(395, -2);
            this.panelregistro.Name = "panelregistro";
            this.panelregistro.Size = new System.Drawing.Size(400, 464);
            this.panelregistro.TabIndex = 13;
            this.panelregistro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelregistro_MouseMove);
            // 
            // iconEye
            // 
            this.iconEye.BackColor = System.Drawing.Color.Transparent;
            this.iconEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconEye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.iconEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconEye.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.iconEye.IconSize = 30;
            this.iconEye.Location = new System.Drawing.Point(337, 236);
            this.iconEye.Name = "iconEye";
            this.iconEye.Size = new System.Drawing.Size(30, 31);
            this.iconEye.TabIndex = 27;
            this.iconEye.TabStop = false;
            this.iconEye.Click += new System.EventHandler(this.iconEye_Click);
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.Transparent;
            this.iconUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.iconUser.IconSize = 21;
            this.iconUser.Location = new System.Drawing.Point(61, 147);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(21, 22);
            this.iconUser.TabIndex = 26;
            this.iconUser.TabStop = false;
            // 
            // iconPass
            // 
            this.iconPass.BackColor = System.Drawing.Color.Transparent;
            this.iconPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.iconPass.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.iconPass.IconSize = 21;
            this.iconPass.Location = new System.Drawing.Point(64, 238);
            this.iconPass.Name = "iconPass";
            this.iconPass.Size = new System.Drawing.Size(21, 22);
            this.iconPass.TabIndex = 25;
            this.iconPass.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(31, 387);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 1);
            this.panel4.TabIndex = 19;
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.GripLines;
            this.Minimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Minimizar.Location = new System.Drawing.Point(306, 11);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(32, 32);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Minimizar.TabIndex = 21;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click_1);
            // 
            // ErrorIcon
            // 
            this.ErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.ErrorIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.ErrorIcon.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.ErrorIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.ErrorIcon.IconSize = 23;
            this.ErrorIcon.Location = new System.Drawing.Point(67, 280);
            this.ErrorIcon.Name = "ErrorIcon";
            this.ErrorIcon.Size = new System.Drawing.Size(27, 23);
            this.ErrorIcon.TabIndex = 23;
            this.ErrorIcon.TabStop = false;
            this.ErrorIcon.Visible = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Close.Location = new System.Drawing.Point(344, 11);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Close.TabIndex = 20;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(101, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Iniciar Sesion";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.Color.Transparent;
            this.Error.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Error.Location = new System.Drawing.Point(100, 284);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(41, 18);
            this.Error.TabIndex = 22;
            this.Error.Text = "Error";
            this.Error.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.Usuario.Location = new System.Drawing.Point(91, 149);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(240, 20);
            this.Usuario.TabIndex = 15;
            this.Usuario.Text = "Usuario";
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            this.Usuario.Enter += new System.EventHandler(this.Usuario_Enter);
            this.Usuario.Leave += new System.EventHandler(this.Usuario_Leave);
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.panelUsuario.Enabled = false;
            this.panelUsuario.Location = new System.Drawing.Point(61, 175);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(267, 2);
            this.panelUsuario.TabIndex = 17;
            // 
            // Contraseña
            // 
            this.Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.Contraseña.Location = new System.Drawing.Point(91, 238);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(240, 20);
            this.Contraseña.TabIndex = 16;
            this.Contraseña.Text = "Contraseña";
            this.Contraseña.Enter += new System.EventHandler(this.Contraseña_Enter);
            this.Contraseña.Leave += new System.EventHandler(this.Contraseña_Leave);
            // 
            // Acceder
            // 
            this.Acceder.BackColor = System.Drawing.Color.Transparent;
            this.Acceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Acceder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Acceder.FlatAppearance.BorderSize = 0;
            this.Acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acceder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acceder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Acceder.Location = new System.Drawing.Point(156, 341);
            this.Acceder.Name = "Acceder";
            this.Acceder.Size = new System.Drawing.Size(90, 40);
            this.Acceder.TabIndex = 13;
            this.Acceder.Text = "ACCEDER";
            this.Acceder.UseVisualStyleBackColor = false;
            this.Acceder.Click += new System.EventHandler(this.Acceder_Click_1);
            // 
            // panelContraseña
            // 
            this.panelContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.panelContraseña.Enabled = false;
            this.panelContraseña.Location = new System.Drawing.Point(61, 265);
            this.panelContraseña.Name = "panelContraseña";
            this.panelContraseña.Size = new System.Drawing.Size(267, 2);
            this.panelContraseña.TabIndex = 18;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(790, 417);
            this.Controls.Add(this.panelregistro);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelregistro.ResumeLayout(false);
            this.panelregistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelregistro;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox Minimizar;
        private FontAwesome.Sharp.IconPictureBox ErrorIcon;
        private new FontAwesome.Sharp.IconPictureBox Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Panel panelContraseña;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button iniciar;
        private FontAwesome.Sharp.IconPictureBox userLogin;
        private FontAwesome.Sharp.IconPictureBox info;
        private System.Windows.Forms.PictureBox logopic;
        private System.Windows.Forms.Button Acceder;
        private FontAwesome.Sharp.IconPictureBox iconPass;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private FontAwesome.Sharp.IconPictureBox iconEye;
    }
}

