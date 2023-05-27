namespace PresentacionGUI
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.Menu = new System.Windows.Forms.Panel();
            this.Salir = new FontAwesome.Sharp.IconButton();
            this.Reportes = new FontAwesome.Sharp.IconButton();
            this.Registros = new FontAwesome.Sharp.IconButton();
            this.Paciente = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linklblEditar = new System.Windows.Forms.LinkLabel();
            this.Cargo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.iconUsers = new FontAwesome.Sharp.IconPictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TituloFormularioHijo = new System.Windows.Forms.Label();
            this.iconFormularioActual = new FontAwesome.Sharp.IconPictureBox();
            this.Minimizar = new FontAwesome.Sharp.IconPictureBox();
            this.Close = new FontAwesome.Sharp.IconPictureBox();
            this.Formularios = new System.Windows.Forms.Panel();
            this.Guia = new FontAwesome.Sharp.IconPictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Menu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsers)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormularioActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.Formularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(16)))), ((int)(((byte)(31)))));
            this.Menu.Controls.Add(this.Salir);
            this.Menu.Controls.Add(this.Reportes);
            this.Menu.Controls.Add(this.Registros);
            this.Menu.Controls.Add(this.Paciente);
            this.Menu.Controls.Add(this.panel3);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(200, 529);
            this.Menu.TabIndex = 0;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Salir.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.Color.Gainsboro;
            this.Salir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Salir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Salir.IconSize = 50;
            this.Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Salir.Location = new System.Drawing.Point(0, 469);
            this.Salir.Name = "Salir";
            this.Salir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Salir.Rotation = 180D;
            this.Salir.Size = new System.Drawing.Size(200, 60);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Reportes
            // 
            this.Reportes.BackColor = System.Drawing.Color.Transparent;
            this.Reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reportes.FlatAppearance.BorderSize = 0;
            this.Reportes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Reportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Reportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.Reportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.Reportes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Reportes.IconSize = 50;
            this.Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportes.Location = new System.Drawing.Point(0, 282);
            this.Reportes.Name = "Reportes";
            this.Reportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Reportes.Rotation = 0D;
            this.Reportes.Size = new System.Drawing.Size(200, 60);
            this.Reportes.TabIndex = 3;
            this.Reportes.Text = "Reportes";
            this.Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reportes.UseVisualStyleBackColor = false;
            this.Reportes.Click += new System.EventHandler(this.Administrador_Click);
            // 
            // Registros
            // 
            this.Registros.BackColor = System.Drawing.Color.Transparent;
            this.Registros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registros.Dock = System.Windows.Forms.DockStyle.Top;
            this.Registros.FlatAppearance.BorderSize = 0;
            this.Registros.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Registros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Registros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registros.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Registros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registros.ForeColor = System.Drawing.Color.Gainsboro;
            this.Registros.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.Registros.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Registros.IconSize = 50;
            this.Registros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registros.Location = new System.Drawing.Point(0, 222);
            this.Registros.Name = "Registros";
            this.Registros.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Registros.Rotation = 0D;
            this.Registros.Size = new System.Drawing.Size(200, 60);
            this.Registros.TabIndex = 2;
            this.Registros.Text = "Citas";
            this.Registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Registros.UseVisualStyleBackColor = false;
            this.Registros.Click += new System.EventHandler(this.Registros_Click);
            // 
            // Paciente
            // 
            this.Paciente.BackColor = System.Drawing.Color.Transparent;
            this.Paciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.Paciente.FlatAppearance.BorderSize = 0;
            this.Paciente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Paciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Paciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paciente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Paciente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.Paciente.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.Paciente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Paciente.IconSize = 50;
            this.Paciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Paciente.Location = new System.Drawing.Point(0, 162);
            this.Paciente.Name = "Paciente";
            this.Paciente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Paciente.Rotation = 0D;
            this.Paciente.Size = new System.Drawing.Size(200, 60);
            this.Paciente.TabIndex = 1;
            this.Paciente.Text = "Paciente";
            this.Paciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Paciente.UseVisualStyleBackColor = false;
            this.Paciente.Click += new System.EventHandler(this.Paciente_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.linklblEditar);
            this.panel3.Controls.Add(this.Cargo);
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.iconUsers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panel3.Size = new System.Drawing.Size(200, 162);
            this.panel3.TabIndex = 0;
            this.panel3.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            // 
            // linklblEditar
            // 
            this.linklblEditar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.linklblEditar.AutoSize = true;
            this.linklblEditar.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.linklblEditar.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold);
            this.linklblEditar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.linklblEditar.Location = new System.Drawing.Point(137, 13);
            this.linklblEditar.Name = "linklblEditar";
            this.linklblEditar.Size = new System.Drawing.Size(59, 14);
            this.linklblEditar.TabIndex = 19;
            this.linklblEditar.TabStop = true;
            this.linklblEditar.Text = "Editar Perfil";
            this.linklblEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblEditar_LinkClicked);
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.BackColor = System.Drawing.Color.Transparent;
            this.Cargo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargo.ForeColor = System.Drawing.Color.Gainsboro;
            this.Cargo.Location = new System.Drawing.Point(26, 111);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(77, 21);
            this.Cargo.TabIndex = 6;
            this.Cargo.Text = "lblCargo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(26, 135);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "lblNombre";
            // 
            // iconUsers
            // 
            this.iconUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(16)))), ((int)(((byte)(31)))));
            this.iconUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.iconUsers.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconUsers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.iconUsers.IconSize = 120;
            this.iconUsers.Location = new System.Drawing.Point(33, 11);
            this.iconUsers.Name = "iconUsers";
            this.iconUsers.Size = new System.Drawing.Size(120, 121);
            this.iconUsers.TabIndex = 5;
            this.iconUsers.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.BarraTitulo.Controls.Add(this.iconPictureBox1);
            this.BarraTitulo.Controls.Add(this.TituloFormularioHijo);
            this.BarraTitulo.Controls.Add(this.iconFormularioActual);
            this.BarraTitulo.Controls.Add(this.Minimizar);
            this.BarraTitulo.Controls.Add(this.Close);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(200, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(929, 48);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.iconPictureBox1.IconSize = 33;
            this.iconPictureBox1.Location = new System.Drawing.Point(809, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(36, 33);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // TituloFormularioHijo
            // 
            this.TituloFormularioHijo.AutoSize = true;
            this.TituloFormularioHijo.BackColor = System.Drawing.Color.Transparent;
            this.TituloFormularioHijo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFormularioHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.TituloFormularioHijo.Location = new System.Drawing.Point(63, 18);
            this.TituloFormularioHijo.Name = "TituloFormularioHijo";
            this.TituloFormularioHijo.Size = new System.Drawing.Size(60, 23);
            this.TituloFormularioHijo.TabIndex = 4;
            this.TituloFormularioHijo.Text = "Inicio";
            // 
            // iconFormularioActual
            // 
            this.iconFormularioActual.BackColor = System.Drawing.Color.Transparent;
            this.iconFormularioActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.iconFormularioActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconFormularioActual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.iconFormularioActual.IconSize = 50;
            this.iconFormularioActual.Location = new System.Drawing.Point(7, 4);
            this.iconFormularioActual.Name = "iconFormularioActual";
            this.iconFormularioActual.Size = new System.Drawing.Size(50, 50);
            this.iconFormularioActual.TabIndex = 3;
            this.iconFormularioActual.TabStop = false;
            this.iconFormularioActual.Click += new System.EventHandler(this.iconFormularioActual_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.GripLines;
            this.Minimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Minimizar.Location = new System.Drawing.Point(851, 13);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(32, 32);
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.Close.Location = new System.Drawing.Point(889, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.TabIndex = 1;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Formularios
            // 
            this.Formularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.Formularios.Controls.Add(this.Guia);
            this.Formularios.Controls.Add(this.lblFecha);
            this.Formularios.Controls.Add(this.lblHora);
            this.Formularios.Controls.Add(this.pictureBox1);
            this.Formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Formularios.Location = new System.Drawing.Point(200, 48);
            this.Formularios.Name = "Formularios";
            this.Formularios.Size = new System.Drawing.Size(929, 481);
            this.Formularios.TabIndex = 2;
            // 
            // Guia
            // 
            this.Guia.BackColor = System.Drawing.Color.Transparent;
            this.Guia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guia.ForeColor = System.Drawing.Color.DimGray;
            this.Guia.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.Guia.IconColor = System.Drawing.Color.DimGray;
            this.Guia.IconSize = 30;
            this.Guia.Location = new System.Drawing.Point(894, 448);
            this.Guia.Name = "Guia";
            this.Guia.Size = new System.Drawing.Size(35, 30);
            this.Guia.TabIndex = 6;
            this.Guia.TabStop = false;
            this.Guia.Click += new System.EventHandler(this.Guia_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Silver;
            this.lblFecha.Location = new System.Drawing.Point(204, 405);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(517, 44);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "jueves, 14 de mayo de 2020";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.lblHora.Location = new System.Drawing.Point(313, 327);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(279, 78);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "00:00:00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 529);
            this.Controls.Add(this.Formularios);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.Menu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsers)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormularioActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.Formularios.ResumeLayout(false);
            this.Formularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private new System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panel3;
        private new FontAwesome.Sharp.IconPictureBox Close;
        private FontAwesome.Sharp.IconPictureBox Minimizar;
        private FontAwesome.Sharp.IconButton Paciente;
        private FontAwesome.Sharp.IconButton Reportes;
        private FontAwesome.Sharp.IconButton Registros;
        private FontAwesome.Sharp.IconPictureBox iconFormularioActual;
        private System.Windows.Forms.Label TituloFormularioHijo;
        private System.Windows.Forms.Panel Formularios;
        private FontAwesome.Sharp.IconButton Salir;
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconPictureBox iconUsers;
        private System.Windows.Forms.Label Cargo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.LinkLabel linklblEditar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private FontAwesome.Sharp.IconPictureBox Guia;
    }
}

