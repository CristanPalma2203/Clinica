namespace GUI_Principal
{
    partial class FrmExpediente
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.rtbRecomendaciones = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.RtbDetalles = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.TxtPresion = new System.Windows.Forms.TextBox();
            this.TxtTemperatura = new System.Windows.Forms.TextBox();
            this.TxtEstatura = new System.Windows.Forms.TextBox();
            this.Nombre_newcita = new System.Windows.Forms.Label();
            this.numExpe_newcita = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.BtnLimpiar.Location = new System.Drawing.Point(800, 295);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.BtnGuardar.Location = new System.Drawing.Point(678, 391);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(101, 30);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(704, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nº Exp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre Paciente:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.groupBox2.Controls.Add(this.lblFecha);
            this.groupBox2.Controls.Add(this.rtbRecomendaciones);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.RtbDetalles);
            this.groupBox2.Controls.Add(this.BtnLimpiar);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtEnfermedad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtPeso);
            this.groupBox2.Controls.Add(this.TxtPresion);
            this.groupBox2.Controls.Add(this.TxtTemperatura);
            this.groupBox2.Controls.Add(this.TxtEstatura);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 331);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dianostigo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha.Location = new System.Drawing.Point(692, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 16);
            this.lblFecha.TabIndex = 29;
            this.lblFecha.Text = "Fecha";
            // 
            // rtbRecomendaciones
            // 
            this.rtbRecomendaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.rtbRecomendaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRecomendaciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.rtbRecomendaciones.Location = new System.Drawing.Point(189, 250);
            this.rtbRecomendaciones.Name = "rtbRecomendaciones";
            this.rtbRecomendaciones.Size = new System.Drawing.Size(585, 57);
            this.rtbRecomendaciones.TabIndex = 8;
            this.rtbRecomendaciones.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "Recomendaciones:";
            // 
            // RtbDetalles
            // 
            this.RtbDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.RtbDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbDetalles.ForeColor = System.Drawing.Color.Gainsboro;
            this.RtbDetalles.Location = new System.Drawing.Point(189, 172);
            this.RtbDetalles.Name = "RtbDetalles";
            this.RtbDetalles.Size = new System.Drawing.Size(585, 57);
            this.RtbDetalles.TabIndex = 7;
            this.RtbDetalles.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(96, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Detalles:";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEstado.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtEstado.Location = new System.Drawing.Point(189, 126);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 16);
            this.txtEstado.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(102, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Estado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(560, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Enfermedad:";
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.txtEnfermedad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnfermedad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEnfermedad.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtEnfermedad.Location = new System.Drawing.Point(657, 49);
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(127, 16);
            this.txtEnfermedad.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Presión:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Temperatura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estatura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Peso:";
            // 
            // TxtPeso
            // 
            this.TxtPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.TxtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPeso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtPeso.ForeColor = System.Drawing.Color.Gainsboro;
            this.TxtPeso.Location = new System.Drawing.Point(419, 49);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(100, 16);
            this.TxtPeso.TabIndex = 1;
            // 
            // TxtPresion
            // 
            this.TxtPresion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.TxtPresion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPresion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtPresion.ForeColor = System.Drawing.Color.Gainsboro;
            this.TxtPresion.Location = new System.Drawing.Point(189, 89);
            this.TxtPresion.Name = "TxtPresion";
            this.TxtPresion.Size = new System.Drawing.Size(100, 16);
            this.TxtPresion.TabIndex = 3;
            // 
            // TxtTemperatura
            // 
            this.TxtTemperatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.TxtTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTemperatura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtTemperatura.ForeColor = System.Drawing.Color.Gainsboro;
            this.TxtTemperatura.Location = new System.Drawing.Point(191, 49);
            this.TxtTemperatura.Name = "TxtTemperatura";
            this.TxtTemperatura.Size = new System.Drawing.Size(100, 16);
            this.TxtTemperatura.TabIndex = 0;
            // 
            // TxtEstatura
            // 
            this.TxtEstatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.TxtEstatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEstatura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtEstatura.ForeColor = System.Drawing.Color.Gainsboro;
            this.TxtEstatura.Location = new System.Drawing.Point(419, 89);
            this.TxtEstatura.Name = "TxtEstatura";
            this.TxtEstatura.Size = new System.Drawing.Size(100, 16);
            this.TxtEstatura.TabIndex = 4;
            // 
            // Nombre_newcita
            // 
            this.Nombre_newcita.AutoSize = true;
            this.Nombre_newcita.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Nombre_newcita.ForeColor = System.Drawing.Color.Gainsboro;
            this.Nombre_newcita.Location = new System.Drawing.Point(134, 18);
            this.Nombre_newcita.Name = "Nombre_newcita";
            this.Nombre_newcita.Size = new System.Drawing.Size(60, 16);
            this.Nombre_newcita.TabIndex = 18;
            this.Nombre_newcita.Text = "Nombre";
            // 
            // numExpe_newcita
            // 
            this.numExpe_newcita.AutoSize = true;
            this.numExpe_newcita.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.numExpe_newcita.ForeColor = System.Drawing.Color.Gainsboro;
            this.numExpe_newcita.Location = new System.Drawing.Point(764, 21);
            this.numExpe_newcita.Name = "numExpe_newcita";
            this.numExpe_newcita.Size = new System.Drawing.Size(23, 16);
            this.numExpe_newcita.TabIndex = 19;
            this.numExpe_newcita.Text = "Nº";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.button1.Location = new System.Drawing.Point(798, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmExpediente
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(905, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numExpe_newcita);
            this.Controls.Add(this.Nombre_newcita);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExpediente";
            this.Text = "Expediente";
            this.Load += new System.EventHandler(this.FrmExpediente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.TextBox TxtPresion;
        private System.Windows.Forms.TextBox TxtTemperatura;
        private System.Windows.Forms.TextBox TxtEstatura;
        private System.Windows.Forms.Label Nombre_newcita;
        private System.Windows.Forms.Label numExpe_newcita;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEnfermedad;
        private System.Windows.Forms.RichTextBox rtbRecomendaciones;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox RtbDetalles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFecha;
    }
}
