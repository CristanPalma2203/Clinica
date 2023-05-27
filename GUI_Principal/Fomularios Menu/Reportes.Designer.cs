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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.iconMonto = new FontAwesome.Sharp.IconPictureBox();
            this.iconCitas = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBar)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
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
            this.lblTotalCitas.Click += new System.EventHandler(this.lblTotalCitas_Click);
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
            this.chart1.Size = new System.Drawing.Size(747, 285);
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
    }
}