namespace GUI_Principal
{
    partial class Citas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelPaciente = new System.Windows.Forms.Panel();
            this.icondatabse = new FontAwesome.Sharp.IconButton();
            this.Errorlbl = new System.Windows.Forms.Label();
            this.ErrorBusquedad = new FontAwesome.Sharp.IconPictureBox();
            this.Search = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchExp = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EleminarCita = new FontAwesome.Sharp.IconButton();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCreador = new System.Windows.Forms.Label();
            this.lblCreadoPor = new System.Windows.Forms.Label();
            this.lblProx = new System.Windows.Forms.Label();
            this.lblProxcita = new System.Windows.Forms.Label();
            this.lblApellidoPaciente = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblDuiPaciente = new System.Windows.Forms.Label();
            this.ActualizarCita = new FontAwesome.Sharp.IconButton();
            this.NewCita = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Dui = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorBusquedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPaciente
            // 
            this.PanelPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.PanelPaciente.Controls.Add(this.icondatabse);
            this.PanelPaciente.Controls.Add(this.Errorlbl);
            this.PanelPaciente.Controls.Add(this.ErrorBusquedad);
            this.PanelPaciente.Controls.Add(this.Search);
            this.PanelPaciente.Controls.Add(this.panel1);
            this.PanelPaciente.Controls.Add(this.SearchExp);
            this.PanelPaciente.Controls.Add(this.panel2);
            this.PanelPaciente.Location = new System.Drawing.Point(12, 12);
            this.PanelPaciente.Name = "PanelPaciente";
            this.PanelPaciente.Size = new System.Drawing.Size(905, 448);
            this.PanelPaciente.TabIndex = 19;
            // 
            // icondatabse
            // 
            this.icondatabse.BackColor = System.Drawing.Color.Transparent;
            this.icondatabse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icondatabse.FlatAppearance.BorderSize = 0;
            this.icondatabse.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.icondatabse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.icondatabse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.icondatabse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icondatabse.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icondatabse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icondatabse.ForeColor = System.Drawing.Color.Gainsboro;
            this.icondatabse.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.icondatabse.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.icondatabse.IconSize = 40;
            this.icondatabse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icondatabse.Location = new System.Drawing.Point(735, 26);
            this.icondatabse.Name = "icondatabse";
            this.icondatabse.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icondatabse.Rotation = 0D;
            this.icondatabse.Size = new System.Drawing.Size(154, 42);
            this.icondatabse.TabIndex = 23;
            this.icondatabse.Text = "Registros";
            this.icondatabse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.icondatabse.UseVisualStyleBackColor = false;
            this.icondatabse.Click += new System.EventHandler(this.icondatabse_Click);
            // 
            // Errorlbl
            // 
            this.Errorlbl.AutoSize = true;
            this.Errorlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Errorlbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.Errorlbl.Location = new System.Drawing.Point(428, 35);
            this.Errorlbl.Name = "Errorlbl";
            this.Errorlbl.Size = new System.Drawing.Size(50, 16);
            this.Errorlbl.TabIndex = 17;
            this.Errorlbl.Text = "ERROR";
            this.Errorlbl.Visible = false;
            // 
            // ErrorBusquedad
            // 
            this.ErrorBusquedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.ErrorBusquedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.ErrorBusquedad.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.ErrorBusquedad.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.ErrorBusquedad.Location = new System.Drawing.Point(390, 28);
            this.ErrorBusquedad.Name = "ErrorBusquedad";
            this.ErrorBusquedad.Size = new System.Drawing.Size(32, 32);
            this.ErrorBusquedad.TabIndex = 16;
            this.ErrorBusquedad.TabStop = false;
            this.ErrorBusquedad.Visible = false;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.Search.IconSize = 27;
            this.Search.Location = new System.Drawing.Point(341, 32);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(32, 27);
            this.Search.TabIndex = 15;
            this.Search.TabStop = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.panel1.Location = new System.Drawing.Point(25, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 1);
            this.panel1.TabIndex = 14;
            // 
            // SearchExp
            // 
            this.SearchExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.SearchExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchExp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.SearchExp.Location = new System.Drawing.Point(25, 28);
            this.SearchExp.MaxLength = 9;
            this.SearchExp.Name = "SearchExp";
            this.SearchExp.Size = new System.Drawing.Size(310, 20);
            this.SearchExp.TabIndex = 13;
            this.SearchExp.Text = "Buscar";
            this.SearchExp.TextChanged += new System.EventHandler(this.SearchExp_TextChanged);
            this.SearchExp.Enter += new System.EventHandler(this.SearchExp_Enter);
            this.SearchExp.Leave += new System.EventHandler(this.SearchExp_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.EleminarCita);
            this.panel2.Controls.Add(this.lblMotivo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblCreador);
            this.panel2.Controls.Add(this.lblCreadoPor);
            this.panel2.Controls.Add(this.lblProx);
            this.panel2.Controls.Add(this.lblProxcita);
            this.panel2.Controls.Add(this.lblApellidoPaciente);
            this.panel2.Controls.Add(this.lblNombrePaciente);
            this.panel2.Controls.Add(this.lblDuiPaciente);
            this.panel2.Controls.Add(this.ActualizarCita);
            this.panel2.Controls.Add(this.NewCita);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Nombre);
            this.panel2.Controls.Add(this.Dui);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.panel2.Location = new System.Drawing.Point(23, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 357);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            // 
            // EleminarCita
            // 
            this.EleminarCita.BackColor = System.Drawing.Color.Transparent;
            this.EleminarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EleminarCita.FlatAppearance.BorderSize = 0;
            this.EleminarCita.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.EleminarCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.EleminarCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.EleminarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EleminarCita.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EleminarCita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EleminarCita.ForeColor = System.Drawing.Color.Gainsboro;
            this.EleminarCita.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.EleminarCita.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.EleminarCita.IconSize = 70;
            this.EleminarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EleminarCita.Location = new System.Drawing.Point(609, 269);
            this.EleminarCita.Name = "EleminarCita";
            this.EleminarCita.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EleminarCita.Rotation = 0D;
            this.EleminarCita.Size = new System.Drawing.Size(229, 74);
            this.EleminarCita.TabIndex = 22;
            this.EleminarCita.Text = "Eliminar Cita";
            this.EleminarCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EleminarCita.UseVisualStyleBackColor = false;
            this.EleminarCita.Click += new System.EventHandler(this.DeleteExpediente_Click);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMotivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMotivo.Location = new System.Drawing.Point(116, 217);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(0, 22);
            this.lblMotivo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(38, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Motivo:";
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCreador.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreador.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCreador.Location = new System.Drawing.Point(581, 156);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(0, 22);
            this.lblCreador.TabIndex = 19;
            // 
            // lblCreadoPor
            // 
            this.lblCreadoPor.AutoSize = true;
            this.lblCreadoPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCreadoPor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreadoPor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCreadoPor.Location = new System.Drawing.Point(454, 155);
            this.lblCreadoPor.Name = "lblCreadoPor";
            this.lblCreadoPor.Size = new System.Drawing.Size(121, 23);
            this.lblCreadoPor.TabIndex = 18;
            this.lblCreadoPor.Text = "Creada Por:";
            // 
            // lblProx
            // 
            this.lblProx.AutoSize = true;
            this.lblProx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProx.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProx.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblProx.Location = new System.Drawing.Point(179, 156);
            this.lblProx.Name = "lblProx";
            this.lblProx.Size = new System.Drawing.Size(0, 22);
            this.lblProx.TabIndex = 17;
            // 
            // lblProxcita
            // 
            this.lblProxcita.AutoSize = true;
            this.lblProxcita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProxcita.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProxcita.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblProxcita.Location = new System.Drawing.Point(38, 155);
            this.lblProxcita.Name = "lblProxcita";
            this.lblProxcita.Size = new System.Drawing.Size(135, 23);
            this.lblProxcita.TabIndex = 16;
            this.lblProxcita.Text = "Proxima Cita:";
            // 
            // lblApellidoPaciente
            // 
            this.lblApellidoPaciente.AutoSize = true;
            this.lblApellidoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellidoPaciente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblApellidoPaciente.Location = new System.Drawing.Point(132, 107);
            this.lblApellidoPaciente.Name = "lblApellidoPaciente";
            this.lblApellidoPaciente.Size = new System.Drawing.Size(0, 22);
            this.lblApellidoPaciente.TabIndex = 12;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePaciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombrePaciente.Location = new System.Drawing.Point(128, 63);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(0, 22);
            this.lblNombrePaciente.TabIndex = 11;
            // 
            // lblDuiPaciente
            // 
            this.lblDuiPaciente.AutoSize = true;
            this.lblDuiPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDuiPaciente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuiPaciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDuiPaciente.Location = new System.Drawing.Point(82, 14);
            this.lblDuiPaciente.Name = "lblDuiPaciente";
            this.lblDuiPaciente.Size = new System.Drawing.Size(0, 22);
            this.lblDuiPaciente.TabIndex = 10;
            // 
            // ActualizarCita
            // 
            this.ActualizarCita.BackColor = System.Drawing.Color.Transparent;
            this.ActualizarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarCita.FlatAppearance.BorderSize = 0;
            this.ActualizarCita.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ActualizarCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.ActualizarCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.ActualizarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarCita.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ActualizarCita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarCita.ForeColor = System.Drawing.Color.Gainsboro;
            this.ActualizarCita.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.ActualizarCita.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.ActualizarCita.IconSize = 70;
            this.ActualizarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualizarCita.Location = new System.Drawing.Point(318, 269);
            this.ActualizarCita.Name = "ActualizarCita";
            this.ActualizarCita.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ActualizarCita.Rotation = 0D;
            this.ActualizarCita.Size = new System.Drawing.Size(244, 74);
            this.ActualizarCita.TabIndex = 8;
            this.ActualizarCita.Text = "Actualizar Proxima Cita";
            this.ActualizarCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ActualizarCita.UseVisualStyleBackColor = false;
            this.ActualizarCita.Click += new System.EventHandler(this.ActualizarCita_Click);
            // 
            // NewCita
            // 
            this.NewCita.BackColor = System.Drawing.Color.Transparent;
            this.NewCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewCita.FlatAppearance.BorderSize = 0;
            this.NewCita.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.NewCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.NewCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.NewCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewCita.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NewCita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCita.ForeColor = System.Drawing.Color.Gainsboro;
            this.NewCita.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.NewCita.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.NewCita.IconSize = 70;
            this.NewCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewCita.Location = new System.Drawing.Point(60, 269);
            this.NewCita.Name = "NewCita";
            this.NewCita.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.NewCita.Rotation = 0D;
            this.NewCita.Size = new System.Drawing.Size(211, 74);
            this.NewCita.TabIndex = 7;
            this.NewCita.Text = "Nueva Cita";
            this.NewCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewCita.UseVisualStyleBackColor = false;
            this.NewCita.Click += new System.EventHandler(this.NewCita_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(38, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.Nombre.Location = new System.Drawing.Point(38, 62);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(90, 23);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre:";
            // 
            // Dui
            // 
            this.Dui.AutoSize = true;
            this.Dui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dui.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dui.ForeColor = System.Drawing.Color.Gainsboro;
            this.Dui.Location = new System.Drawing.Point(38, 13);
            this.Dui.Name = "Dui";
            this.Dui.Size = new System.Drawing.Size(44, 23);
            this.Dui.TabIndex = 0;
            this.Dui.Text = "Dui:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.panel3.Location = new System.Drawing.Point(11, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(907, 450);
            this.panel3.TabIndex = 23;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(929, 472);
            this.Controls.Add(this.PanelPaciente);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Citas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Enfermera_Load);
            this.PanelPaciente.ResumeLayout(false);
            this.PanelPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorBusquedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelPaciente;
        private System.Windows.Forms.Label Errorlbl;
        private FontAwesome.Sharp.IconPictureBox ErrorBusquedad;
        private FontAwesome.Sharp.IconPictureBox Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchExp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblApellidoPaciente;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblDuiPaciente;
        private FontAwesome.Sharp.IconButton ActualizarCita;
        private FontAwesome.Sharp.IconButton NewCita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Dui;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblProx;
        private System.Windows.Forms.Label lblProxcita;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.Label lblCreadoPor;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton EleminarCita;
        private FontAwesome.Sharp.IconButton icondatabse;
    }
}