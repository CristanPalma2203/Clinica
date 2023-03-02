namespace GUI_Principal.Formularios_Acciones
{
    partial class DatosPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcentral = new System.Windows.Forms.Panel();
            this.lblVolver = new System.Windows.Forms.Label();
            this.Regresar = new FontAwesome.Sharp.IconPictureBox();
            this.AbrirExpediente = new FontAwesome.Sharp.IconButton();
            this.Errorlbl = new System.Windows.Forms.Label();
            this.ErrorBusquedad = new FontAwesome.Sharp.IconPictureBox();
            this.Search = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchExp = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paneltrasero = new System.Windows.Forms.Panel();
            this.panelcentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorBusquedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcentral
            // 
            this.panelcentral.Controls.Add(this.lblVolver);
            this.panelcentral.Controls.Add(this.Regresar);
            this.panelcentral.Controls.Add(this.AbrirExpediente);
            this.panelcentral.Controls.Add(this.Errorlbl);
            this.panelcentral.Controls.Add(this.ErrorBusquedad);
            this.panelcentral.Controls.Add(this.Search);
            this.panelcentral.Controls.Add(this.panel2);
            this.panelcentral.Controls.Add(this.SearchExp);
            this.panelcentral.Controls.Add(this.dataGridView1);
            this.panelcentral.Controls.Add(this.paneltrasero);
            this.panelcentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentral.Location = new System.Drawing.Point(0, 0);
            this.panelcentral.Name = "panelcentral";
            this.panelcentral.Size = new System.Drawing.Size(905, 448);
            this.panelcentral.TabIndex = 0;
            this.panelcentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcentral_Paint);
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVolver.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblVolver.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblVolver.Location = new System.Drawing.Point(44, 24);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(66, 16);
            this.lblVolver.TabIndex = 175;
            this.lblVolver.Text = "Regresar";
            this.lblVolver.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.Regresar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.Regresar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.Regresar.Location = new System.Drawing.Point(10, 15);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(32, 32);
            this.Regresar.TabIndex = 174;
            this.Regresar.TabStop = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // AbrirExpediente
            // 
            this.AbrirExpediente.BackColor = System.Drawing.Color.Transparent;
            this.AbrirExpediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbrirExpediente.FlatAppearance.BorderSize = 0;
            this.AbrirExpediente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AbrirExpediente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.AbrirExpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.AbrirExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbrirExpediente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AbrirExpediente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbrirExpediente.ForeColor = System.Drawing.Color.Gainsboro;
            this.AbrirExpediente.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.AbrirExpediente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.AbrirExpediente.IconSize = 40;
            this.AbrirExpediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AbrirExpediente.Location = new System.Drawing.Point(690, 359);
            this.AbrirExpediente.Name = "AbrirExpediente";
            this.AbrirExpediente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AbrirExpediente.Rotation = 0D;
            this.AbrirExpediente.Size = new System.Drawing.Size(198, 51);
            this.AbrirExpediente.TabIndex = 173;
            this.AbrirExpediente.Text = "Abrir Consulta";
            this.AbrirExpediente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AbrirExpediente.UseVisualStyleBackColor = false;
            this.AbrirExpediente.Click += new System.EventHandler(this.AbrirExpediente_Click);
            // 
            // Errorlbl
            // 
            this.Errorlbl.AutoSize = true;
            this.Errorlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Errorlbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.Errorlbl.Location = new System.Drawing.Point(454, 70);
            this.Errorlbl.Name = "Errorlbl";
            this.Errorlbl.Size = new System.Drawing.Size(50, 16);
            this.Errorlbl.TabIndex = 172;
            this.Errorlbl.Text = "ERROR";
            this.Errorlbl.Visible = false;
            // 
            // ErrorBusquedad
            // 
            this.ErrorBusquedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.ErrorBusquedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.ErrorBusquedad.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.ErrorBusquedad.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.ErrorBusquedad.Location = new System.Drawing.Point(416, 63);
            this.ErrorBusquedad.Name = "ErrorBusquedad";
            this.ErrorBusquedad.Size = new System.Drawing.Size(32, 32);
            this.ErrorBusquedad.TabIndex = 171;
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
            this.Search.Location = new System.Drawing.Point(363, 67);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(32, 27);
            this.Search.TabIndex = 170;
            this.Search.TabStop = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.panel2.Location = new System.Drawing.Point(47, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 1);
            this.panel2.TabIndex = 169;
            // 
            // SearchExp
            // 
            this.SearchExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.SearchExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchExp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.SearchExp.Location = new System.Drawing.Point(47, 68);
            this.SearchExp.MaxLength = 9;
            this.SearchExp.Name = "SearchExp";
            this.SearchExp.Size = new System.Drawing.Size(310, 20);
            this.SearchExp.TabIndex = 168;
            this.SearchExp.Text = "Buscar";
            this.SearchExp.TextChanged += new System.EventHandler(this.SearchExp_TextChanged);
            this.SearchExp.Enter += new System.EventHandler(this.SearchExp_Enter);
            this.SearchExp.Leave += new System.EventHandler(this.SearchExp_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.dataGridView1.Location = new System.Drawing.Point(19, 101);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(868, 252);
            this.dataGridView1.TabIndex = 166;
            // 
            // paneltrasero
            // 
            this.paneltrasero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.paneltrasero.Location = new System.Drawing.Point(18, 100);
            this.paneltrasero.Name = "paneltrasero";
            this.paneltrasero.Size = new System.Drawing.Size(870, 255);
            this.paneltrasero.TabIndex = 167;
            // 
            // DatosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(905, 448);
            this.Controls.Add(this.panelcentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosPaciente";
            this.Text = "DatosPaciente";
            this.Load += new System.EventHandler(this.DatosPaciente_Load);
            this.panelcentral.ResumeLayout(false);
            this.panelcentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorBusquedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcentral;
        private System.Windows.Forms.Label lblVolver;
        private FontAwesome.Sharp.IconPictureBox Regresar;
        private FontAwesome.Sharp.IconButton AbrirExpediente;
        private System.Windows.Forms.Label Errorlbl;
        private FontAwesome.Sharp.IconPictureBox ErrorBusquedad;
        private FontAwesome.Sharp.IconPictureBox Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchExp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel paneltrasero;
    }
}