using System.Drawing;

namespace GUI_Principal
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PanelPaciente = new System.Windows.Forms.Panel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.ChartBar = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTotalCitas = new System.Windows.Forms.Label();
            this.prueba2 = new System.Windows.Forms.Label();
            this.Prueba1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunePanelfechas = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.CalenderSince = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalenderUntil = new System.Windows.Forms.MonthCalendar();
            this.textBoxFechaSeleccionadaHasta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxFechaSeleccionadaDesde = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.iconMonto = new FontAwesome.Sharp.IconPictureBox();
            this.iconCitas = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBar)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunePanelfechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPaciente
            // 
            this.PanelPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.PanelPaciente.Controls.Add(this.guna2ComboBox1);
            this.PanelPaciente.Controls.Add(this.btnGenerar);
            this.PanelPaciente.Controls.Add(this.ChartBar);
            this.PanelPaciente.Controls.Add(this.label1);
            this.PanelPaciente.Controls.Add(this.lblMonto);
            this.PanelPaciente.Controls.Add(this.lblTotalCitas);
            this.PanelPaciente.Controls.Add(this.prueba2);
            this.PanelPaciente.Controls.Add(this.Prueba1);
            this.PanelPaciente.Controls.Add(this.bunifuGradientPanel1);
            this.PanelPaciente.Controls.Add(this.iconMonto);
            this.PanelPaciente.Controls.Add(this.iconCitas);
            this.PanelPaciente.Location = new System.Drawing.Point(12, 12);
            this.PanelPaciente.Name = "PanelPaciente";
            this.PanelPaciente.Size = new System.Drawing.Size(905, 448);
            this.PanelPaciente.TabIndex = 24;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(121)))), ((int)(((byte)(230)))));
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Usuario",
            "Paciente",
            "Expendiente",
            "Diagnostico",
            "Citas",
            "Movimientos"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(647, 29);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(135, 36);
            this.guna2ComboBox1.TabIndex = 32;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(121)))), ((int)(((byte)(230)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(121)))), ((int)(((byte)(230)))));
            this.btnGenerar.Location = new System.Drawing.Point(788, 31);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(85, 34);
            this.btnGenerar.TabIndex = 13;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // ChartBar
            // 
            this.ChartBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.ChartBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(121)))), ((int)(((byte)(230)))));
            this.ChartBar.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.ChartBar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(121)))), ((int)(((byte)(230)))));
            this.ChartBar.IconSize = 40;
            this.ChartBar.Location = new System.Drawing.Point(544, 23);
            this.ChartBar.Name = "ChartBar";
            this.ChartBar.Size = new System.Drawing.Size(32, 32);
            this.ChartBar.TabIndex = 27;
            this.ChartBar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(243, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Reporte de Ganancias Por Mes";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMonto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMonto.Location = new System.Drawing.Point(749, 85);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(70, 23);
            this.lblMonto.TabIndex = 25;
            this.lblMonto.Text = "000,00";
            // 
            // lblTotalCitas
            // 
            this.lblTotalCitas.AutoSize = true;
            this.lblTotalCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalCitas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCitas.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalCitas.Location = new System.Drawing.Point(231, 85);
            this.lblTotalCitas.Name = "lblTotalCitas";
            this.lblTotalCitas.Size = new System.Drawing.Size(65, 23);
            this.lblTotalCitas.TabIndex = 24;
            this.lblTotalCitas.Text = "00000";
            // 
            // prueba2
            // 
            this.prueba2.AutoSize = true;
            this.prueba2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prueba2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prueba2.ForeColor = System.Drawing.Color.Gainsboro;
            this.prueba2.Location = new System.Drawing.Point(626, 85);
            this.prueba2.Name = "prueba2";
            this.prueba2.Size = new System.Drawing.Size(117, 23);
            this.prueba2.TabIndex = 23;
            this.prueba2.Text = "Monto Total";
            // 
            // Prueba1
            // 
            this.Prueba1.AutoSize = true;
            this.Prueba1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prueba1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prueba1.ForeColor = System.Drawing.Color.Gainsboro;
            this.Prueba1.Location = new System.Drawing.Point(112, 85);
            this.Prueba1.Name = "Prueba1";
            this.Prueba1.Size = new System.Drawing.Size(113, 23);
            this.Prueba1.TabIndex = 22;
            this.Prueba1.Text = "Nº de Citas";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunePanelfechas);
            this.bunifuGradientPanel1.Controls.Add(this.chart1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(74, 127);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(747, 287);
            this.bunifuGradientPanel1.TabIndex = 21;
            // 
            // bunePanelfechas
            // 
            this.bunePanelfechas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunePanelfechas.BackgroundImage")));
            this.bunePanelfechas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunePanelfechas.Controls.Add(this.label4);
            this.bunePanelfechas.Controls.Add(this.CalenderSince);
            this.bunePanelfechas.Controls.Add(this.label3);
            this.bunePanelfechas.Controls.Add(this.label2);
            this.bunePanelfechas.Controls.Add(this.CalenderUntil);
            this.bunePanelfechas.Controls.Add(this.textBoxFechaSeleccionadaHasta);
            this.bunePanelfechas.Controls.Add(this.textBoxFechaSeleccionadaDesde);
            this.bunePanelfechas.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.bunePanelfechas.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.bunePanelfechas.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.bunePanelfechas.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.bunePanelfechas.Location = new System.Drawing.Point(3, 0);
            this.bunePanelfechas.Name = "bunePanelfechas";
            this.bunePanelfechas.Quality = 10;
            this.bunePanelfechas.Size = new System.Drawing.Size(747, 287);
            this.bunePanelfechas.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(204, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Reporte de Ganancias Por Mes";
            // 
            // CalenderSince
            // 
            this.CalenderSince.Location = new System.Drawing.Point(428, 99);
            this.CalenderSince.Name = "CalenderSince";
            this.CalenderSince.TabIndex = 9;
            this.CalenderSince.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalenderSince_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(416, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 7;
            this.label3.Tag = "Hasta";
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 6;
            this.label2.Tag = "Hasta";
            this.label2.Text = "Desde:";
            // 
            // CalenderUntil
            // 
            this.CalenderUntil.Location = new System.Drawing.Point(53, 99);
            this.CalenderUntil.Name = "CalenderUntil";
            this.CalenderUntil.TabIndex = 8;
            this.CalenderUntil.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalenderUntil_DateChanged);
            // 
            // textBoxFechaSeleccionadaHasta
            // 
            this.textBoxFechaSeleccionadaHasta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxFechaSeleccionadaHasta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxFechaSeleccionadaHasta.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxFechaSeleccionadaHasta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFechaSeleccionadaHasta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxFechaSeleccionadaHasta.ForeColor = System.Drawing.Color.White;
            this.textBoxFechaSeleccionadaHasta.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxFechaSeleccionadaHasta.HintText = "";
            this.textBoxFechaSeleccionadaHasta.isPassword = false;
            this.textBoxFechaSeleccionadaHasta.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxFechaSeleccionadaHasta.LineIdleColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxFechaSeleccionadaHasta.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxFechaSeleccionadaHasta.LineThickness = 3;
            this.textBoxFechaSeleccionadaHasta.Location = new System.Drawing.Point(122, 53);
            this.textBoxFechaSeleccionadaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFechaSeleccionadaHasta.MaxLength = 32767;
            this.textBoxFechaSeleccionadaHasta.Name = "textBoxFechaSeleccionadaHasta";
            this.textBoxFechaSeleccionadaHasta.Size = new System.Drawing.Size(179, 33);
            this.textBoxFechaSeleccionadaHasta.TabIndex = 5;
            this.textBoxFechaSeleccionadaHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxFechaSeleccionadaDesde
            // 
            this.textBoxFechaSeleccionadaDesde.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxFechaSeleccionadaDesde.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxFechaSeleccionadaDesde.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxFechaSeleccionadaDesde.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFechaSeleccionadaDesde.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxFechaSeleccionadaDesde.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxFechaSeleccionadaDesde.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxFechaSeleccionadaDesde.HintText = "";
            this.textBoxFechaSeleccionadaDesde.isPassword = false;
            this.textBoxFechaSeleccionadaDesde.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxFechaSeleccionadaDesde.LineIdleColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxFechaSeleccionadaDesde.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxFechaSeleccionadaDesde.LineThickness = 3;
            this.textBoxFechaSeleccionadaDesde.Location = new System.Drawing.Point(485, 53);
            this.textBoxFechaSeleccionadaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFechaSeleccionadaDesde.MaxLength = 32767;
            this.textBoxFechaSeleccionadaDesde.Name = "textBoxFechaSeleccionadaDesde";
            this.textBoxFechaSeleccionadaDesde.Size = new System.Drawing.Size(191, 33);
            this.textBoxFechaSeleccionadaDesde.TabIndex = 4;
            this.textBoxFechaSeleccionadaDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-1, -1);
            this.chart1.Name = "chart1";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(121)))), ((int)(((byte)(230)))));
            series1.LabelBorderWidth = 5;
            series1.Legend = "Legend1";
            series1.MarkerSize = 6;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(745, 288);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // iconMonto
            // 
            this.iconMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.iconMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(121)))), ((int)(((byte)(230)))));
            this.iconMonto.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.iconMonto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(121)))), ((int)(((byte)(230)))));
            this.iconMonto.IconSize = 47;
            this.iconMonto.Location = new System.Drawing.Point(579, 77);
            this.iconMonto.Name = "iconMonto";
            this.iconMonto.Size = new System.Drawing.Size(63, 47);
            this.iconMonto.TabIndex = 29;
            this.iconMonto.TabStop = false;
            // 
            // iconCitas
            // 
            this.iconCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.iconCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(121)))), ((int)(((byte)(230)))));
            this.iconCitas.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.iconCitas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(121)))), ((int)(((byte)(230)))));
            this.iconCitas.IconSize = 44;
            this.iconCitas.Location = new System.Drawing.Point(70, 76);
            this.iconCitas.Name = "iconCitas";
            this.iconCitas.Size = new System.Drawing.Size(48, 44);
            this.iconCitas.TabIndex = 28;
            this.iconCitas.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(121)))), ((int)(((byte)(230)))));
            this.panel3.Location = new System.Drawing.Point(11, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(907, 450);
            this.panel3.TabIndex = 25;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(929, 472);
            this.Controls.Add(this.PanelPaciente);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Administrador_Load_1);
            this.PanelPaciente.ResumeLayout(false);
            this.PanelPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBar)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunePanelfechas.ResumeLayout(false);
            this.bunePanelfechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPaciente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTotalCitas;
        private System.Windows.Forms.Label prueba2;
        private System.Windows.Forms.Label Prueba1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private FontAwesome.Sharp.IconPictureBox ChartBar;
        private FontAwesome.Sharp.IconPictureBox iconMonto;
        private FontAwesome.Sharp.IconPictureBox iconCitas;
        private System.Windows.Forms.Button btnGenerar;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxFechaSeleccionadaDesde;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxFechaSeleccionadaHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar CalenderSince;
        private System.Windows.Forms.MonthCalendar CalenderUntil;
        private Bunifu.Framework.UI.BunifuGradientPanel bunePanelfechas;
        private System.Windows.Forms.Label label4;
    }
}