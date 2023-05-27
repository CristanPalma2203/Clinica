namespace PresentacionGUI
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsuarioBienvenida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconoBienvenida = new FontAwesome.Sharp.IconPictureBox();
            this.CargoBienvenida = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoBienvenida)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Controls.Add(this.panel6);
            this.bunifuGradientPanel2.Controls.Add(this.panel5);
            this.bunifuGradientPanel2.Controls.Add(this.panel4);
            this.bunifuGradientPanel2.Controls.Add(this.panel3);
            this.bunifuGradientPanel2.Controls.Add(this.circularProgressBar1);
            this.bunifuGradientPanel2.Controls.Add(this.panel1);
            this.bunifuGradientPanel2.Controls.Add(this.UsuarioBienvenida);
            this.bunifuGradientPanel2.Controls.Add(this.label2);
            this.bunifuGradientPanel2.Controls.Add(this.iconoBienvenida);
            this.bunifuGradientPanel2.Controls.Add(this.CargoBienvenida);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-219, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(620, 589);
            this.bunifuGradientPanel2.TabIndex = 16;
            this.bunifuGradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(353, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "BUENA VIDA";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(315, 385);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(23, 183);
            this.panel6.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(491, 387);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(23, 183);
            this.panel5.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(337, 554);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 21);
            this.panel4.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(337, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 21);
            this.panel3.TabIndex = 26;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Gainsboro;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -2;
            this.circularProgressBar1.Location = new System.Drawing.Point(337, 401);
            this.circularProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.circularProgressBar1.OuterMargin = -60;
            this.circularProgressBar1.OuterWidth = 30;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.circularProgressBar1.ProgressWidth = 10;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.circularProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 2, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.Gainsboro;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "%";
            this.circularProgressBar1.TabIndex = 3;
            this.circularProgressBar1.Text = "0";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(1);
            this.circularProgressBar1.Value = 68;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 18);
            this.panel1.TabIndex = 24;
            // 
            // UsuarioBienvenida
            // 
            this.UsuarioBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.UsuarioBienvenida.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.UsuarioBienvenida.Location = new System.Drawing.Point(231, 191);
            this.UsuarioBienvenida.Name = "UsuarioBienvenida";
            this.UsuarioBienvenida.Size = new System.Drawing.Size(377, 40);
            this.UsuarioBienvenida.TabIndex = 21;
            this.UsuarioBienvenida.Text = "Usuario";
            this.UsuarioBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(299, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 44);
            this.label2.TabIndex = 20;
            this.label2.Text = "BIENVENIDO";
            // 
            // iconoBienvenida
            // 
            this.iconoBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.iconoBienvenida.ForeColor = System.Drawing.Color.MintCream;
            this.iconoBienvenida.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconoBienvenida.IconColor = System.Drawing.Color.MintCream;
            this.iconoBienvenida.IconSize = 122;
            this.iconoBienvenida.Location = new System.Drawing.Point(357, 250);
            this.iconoBienvenida.Name = "iconoBienvenida";
            this.iconoBienvenida.Size = new System.Drawing.Size(140, 122);
            this.iconoBienvenida.TabIndex = 22;
            this.iconoBienvenida.TabStop = false;
            // 
            // CargoBienvenida
            // 
            this.CargoBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.CargoBienvenida.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.CargoBienvenida.Location = new System.Drawing.Point(302, 151);
            this.CargoBienvenida.Name = "CargoBienvenida";
            this.CargoBienvenida.Size = new System.Drawing.Size(233, 40);
            this.CargoBienvenida.TabIndex = 23;
            this.CargoBienvenida.Text = "Cargo";
            this.CargoBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 40;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 589);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoBienvenida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UsuarioBienvenida;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconoBienvenida;
        private System.Windows.Forms.Label CargoBienvenida;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
    }
}