namespace GUI_Principal
{
    partial class Paciente
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
            this.numExpedientePaciente = new System.Windows.Forms.Label();
            this.lblFechaExpedientePaciente = new System.Windows.Forms.Label();
            this.lblFechaNacPaciente = new System.Windows.Forms.Label();
            this.lblApellidoPaciente = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblDuiPaciente = new System.Windows.Forms.Label();
            this.DeleteExpediente = new FontAwesome.Sharp.IconButton();
            this.Actualizar = new FontAwesome.Sharp.IconButton();
            this.NewConsulta = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Dui = new System.Windows.Forms.Label();
            this.btnPrueba = new FontAwesome.Sharp.IconButton();
            this.SerachExpediente = new FontAwesome.Sharp.IconButton();
            this.addPaciente = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelvisual1 = new System.Windows.Forms.Panel();
            this.panelvisual2 = new System.Windows.Forms.Panel();
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
            this.PanelPaciente.Location = new System.Drawing.Point(12, 34);
            this.PanelPaciente.Name = "PanelPaciente";
            this.PanelPaciente.Size = new System.Drawing.Size(905, 426);
            this.PanelPaciente.TabIndex = 0;
            this.PanelPaciente.MouseEnter += new System.EventHandler(this.PanelPaciente_MouseEnter);
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
            this.icondatabse.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.icondatabse.IconSize = 40;
            this.icondatabse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icondatabse.Location = new System.Drawing.Point(732, 26);
            this.icondatabse.Name = "icondatabse";
            this.icondatabse.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icondatabse.Rotation = 0D;
            this.icondatabse.Size = new System.Drawing.Size(154, 42);
            this.icondatabse.TabIndex = 24;
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
            this.ErrorBusquedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.ErrorBusquedad.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.ErrorBusquedad.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
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
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
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
            this.SearchExp.Enter += new System.EventHandler(this.textBox1_Enter);
            this.SearchExp.Leave += new System.EventHandler(this.SearchExp_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.numExpedientePaciente);
            this.panel2.Controls.Add(this.lblFechaExpedientePaciente);
            this.panel2.Controls.Add(this.lblFechaNacPaciente);
            this.panel2.Controls.Add(this.lblApellidoPaciente);
            this.panel2.Controls.Add(this.lblNombrePaciente);
            this.panel2.Controls.Add(this.lblDuiPaciente);
            this.panel2.Controls.Add(this.DeleteExpediente);
            this.panel2.Controls.Add(this.Actualizar);
            this.panel2.Controls.Add(this.NewConsulta);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Nombre);
            this.panel2.Controls.Add(this.Dui);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.panel2.Location = new System.Drawing.Point(23, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 332);
            this.panel2.TabIndex = 12;
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            // 
            // numExpedientePaciente
            // 
            this.numExpedientePaciente.AutoSize = true;
            this.numExpedientePaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numExpedientePaciente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numExpedientePaciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.numExpedientePaciente.Location = new System.Drawing.Point(762, 14);
            this.numExpedientePaciente.Name = "numExpedientePaciente";
            this.numExpedientePaciente.Size = new System.Drawing.Size(0, 22);
            this.numExpedientePaciente.TabIndex = 15;
            // 
            // lblFechaExpedientePaciente
            // 
            this.lblFechaExpedientePaciente.AutoSize = true;
            this.lblFechaExpedientePaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFechaExpedientePaciente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaExpedientePaciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFechaExpedientePaciente.Location = new System.Drawing.Point(251, 184);
            this.lblFechaExpedientePaciente.Name = "lblFechaExpedientePaciente";
            this.lblFechaExpedientePaciente.Size = new System.Drawing.Size(0, 22);
            this.lblFechaExpedientePaciente.TabIndex = 14;
            // 
            // lblFechaNacPaciente
            // 
            this.lblFechaNacPaciente.AutoSize = true;
            this.lblFechaNacPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFechaNacPaciente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacPaciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFechaNacPaciente.Location = new System.Drawing.Point(254, 141);
            this.lblFechaNacPaciente.Name = "lblFechaNacPaciente";
            this.lblFechaNacPaciente.Size = new System.Drawing.Size(0, 22);
            this.lblFechaNacPaciente.TabIndex = 13;
            // 
            // lblApellidoPaciente
            // 
            this.lblApellidoPaciente.AutoSize = true;
            this.lblApellidoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellidoPaciente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblApellidoPaciente.Location = new System.Drawing.Point(133, 101);
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
            this.lblNombrePaciente.Location = new System.Drawing.Point(129, 56);
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
            this.lblDuiPaciente.Location = new System.Drawing.Point(83, 14);
            this.lblDuiPaciente.Name = "lblDuiPaciente";
            this.lblDuiPaciente.Size = new System.Drawing.Size(0, 22);
            this.lblDuiPaciente.TabIndex = 10;
            // 
            // DeleteExpediente
            // 
            this.DeleteExpediente.BackColor = System.Drawing.Color.Transparent;
            this.DeleteExpediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteExpediente.FlatAppearance.BorderSize = 0;
            this.DeleteExpediente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.DeleteExpediente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.DeleteExpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.DeleteExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteExpediente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DeleteExpediente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteExpediente.ForeColor = System.Drawing.Color.Gainsboro;
            this.DeleteExpediente.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.DeleteExpediente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.DeleteExpediente.IconSize = 70;
            this.DeleteExpediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteExpediente.Location = new System.Drawing.Point(651, 247);
            this.DeleteExpediente.Name = "DeleteExpediente";
            this.DeleteExpediente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.DeleteExpediente.Rotation = 0D;
            this.DeleteExpediente.Size = new System.Drawing.Size(212, 74);
            this.DeleteExpediente.TabIndex = 9;
            this.DeleteExpediente.Text = "Eliminar Expediente";
            this.DeleteExpediente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteExpediente.UseVisualStyleBackColor = false;
            this.DeleteExpediente.Click += new System.EventHandler(this.DeleteExpediente_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.BackColor = System.Drawing.Color.Transparent;
            this.Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Actualizar.FlatAppearance.BorderSize = 0;
            this.Actualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Actualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Actualizar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.Actualizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.Actualizar.IconSize = 70;
            this.Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Actualizar.Location = new System.Drawing.Point(318, 247);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Actualizar.Rotation = 0D;
            this.Actualizar.Size = new System.Drawing.Size(205, 74);
            this.Actualizar.TabIndex = 8;
            this.Actualizar.Text = "Editar Expediente";
            this.Actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Actualizar.UseVisualStyleBackColor = false;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // NewConsulta
            // 
            this.NewConsulta.BackColor = System.Drawing.Color.Transparent;
            this.NewConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewConsulta.FlatAppearance.BorderSize = 0;
            this.NewConsulta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.NewConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.NewConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.NewConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewConsulta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NewConsulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewConsulta.ForeColor = System.Drawing.Color.Gainsboro;
            this.NewConsulta.IconChar = FontAwesome.Sharp.IconChar.FileMedicalAlt;
            this.NewConsulta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.NewConsulta.IconSize = 70;
            this.NewConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewConsulta.Location = new System.Drawing.Point(13, 247);
            this.NewConsulta.Name = "NewConsulta";
            this.NewConsulta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.NewConsulta.Rotation = 0D;
            this.NewConsulta.Size = new System.Drawing.Size(211, 74);
            this.NewConsulta.TabIndex = 7;
            this.NewConsulta.Text = "Nueva Consulta";
            this.NewConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewConsulta.UseVisualStyleBackColor = false;
            this.NewConsulta.Click += new System.EventHandler(this.NewConsulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(38, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(686, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nº Exp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(38, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Expediente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(38, 101);
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
            this.Nombre.Location = new System.Drawing.Point(38, 56);
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
            this.Dui.Location = new System.Drawing.Point(38, 14);
            this.Dui.Name = "Dui";
            this.Dui.Size = new System.Drawing.Size(44, 23);
            this.Dui.TabIndex = 0;
            this.Dui.Text = "Dui:";
            // 
            // btnPrueba
            // 
            this.btnPrueba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnPrueba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrueba.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPrueba.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnPrueba.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnPrueba.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnPrueba.IconSize = 25;
            this.btnPrueba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrueba.Location = new System.Drawing.Point(34, 5);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Rotation = 0D;
            this.btnPrueba.Size = new System.Drawing.Size(251, 35);
            this.btnPrueba.TabIndex = 10;
            this.btnPrueba.Text = "Busquedad De Paciente";
            this.btnPrueba.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrueba.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrueba.UseVisualStyleBackColor = false;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // SerachExpediente
            // 
            this.SerachExpediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.SerachExpediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SerachExpediente.FlatAppearance.BorderSize = 0;
            this.SerachExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerachExpediente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SerachExpediente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerachExpediente.ForeColor = System.Drawing.Color.Gainsboro;
            this.SerachExpediente.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.SerachExpediente.IconColor = System.Drawing.Color.Gainsboro;
            this.SerachExpediente.IconSize = 25;
            this.SerachExpediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SerachExpediente.Location = new System.Drawing.Point(35, 5);
            this.SerachExpediente.Name = "SerachExpediente";
            this.SerachExpediente.Rotation = 0D;
            this.SerachExpediente.Size = new System.Drawing.Size(251, 35);
            this.SerachExpediente.TabIndex = 8;
            this.SerachExpediente.Text = "Busquedad De Paciente";
            this.SerachExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SerachExpediente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SerachExpediente.UseVisualStyleBackColor = false;
            this.SerachExpediente.Click += new System.EventHandler(this.SerachExpediente_Click);
            // 
            // addPaciente
            // 
            this.addPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.addPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPaciente.FlatAppearance.BorderSize = 0;
            this.addPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPaciente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addPaciente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPaciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.addPaciente.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addPaciente.IconColor = System.Drawing.Color.Gainsboro;
            this.addPaciente.IconSize = 25;
            this.addPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPaciente.Location = new System.Drawing.Point(320, 3);
            this.addPaciente.Name = "addPaciente";
            this.addPaciente.Rotation = 0D;
            this.addPaciente.Size = new System.Drawing.Size(251, 35);
            this.addPaciente.TabIndex = 9;
            this.addPaciente.Text = "Crear Nuevo Expediente";
            this.addPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addPaciente.UseVisualStyleBackColor = false;
            this.addPaciente.Click += new System.EventHandler(this.addPaciente_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.panel3.Location = new System.Drawing.Point(11, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(907, 428);
            this.panel3.TabIndex = 11;
            // 
            // panelvisual1
            // 
            this.panelvisual1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.panelvisual1.Location = new System.Drawing.Point(38, 30);
            this.panelvisual1.Name = "panelvisual1";
            this.panelvisual1.Size = new System.Drawing.Size(245, 10);
            this.panelvisual1.TabIndex = 17;
            // 
            // panelvisual2
            // 
            this.panelvisual2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.panelvisual2.Location = new System.Drawing.Point(323, 30);
            this.panelvisual2.Name = "panelvisual2";
            this.panelvisual2.Size = new System.Drawing.Size(245, 10);
            this.panelvisual2.TabIndex = 18;
            this.panelvisual2.Visible = false;
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(929, 472);
            this.Controls.Add(this.panelvisual2);
            this.Controls.Add(this.panelvisual1);
            this.Controls.Add(this.PanelPaciente);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.SerachExpediente);
            this.Controls.Add(this.addPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Paciente";
            this.Tag = "Paciente";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.Paciente_Load);
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
        private FontAwesome.Sharp.IconButton SerachExpediente;
        private FontAwesome.Sharp.IconButton addPaciente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label numExpedientePaciente;
        private System.Windows.Forms.Label lblFechaExpedientePaciente;
        private System.Windows.Forms.Label lblFechaNacPaciente;
        private System.Windows.Forms.Label lblApellidoPaciente;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblDuiPaciente;
        private FontAwesome.Sharp.IconButton DeleteExpediente;
        private FontAwesome.Sharp.IconButton Actualizar;
        private FontAwesome.Sharp.IconButton NewConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Dui;
        private System.Windows.Forms.TextBox SearchExp;
        private FontAwesome.Sharp.IconPictureBox Search;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnPrueba;
        private FontAwesome.Sharp.IconPictureBox ErrorBusquedad;
        private System.Windows.Forms.Label Errorlbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelvisual1;
        private System.Windows.Forms.Panel panelvisual2;
        private FontAwesome.Sharp.IconButton icondatabse;
    }
}