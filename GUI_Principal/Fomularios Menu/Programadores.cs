using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Principal
{
    public partial class Programadores : Form
    {
        int r = 244;
        int g = 65;
        int b = 65;
        int Resta = 9;

        public Programadores()
        {
            InitializeComponent();
        }
       

        private void timerR_Tick(object sender, EventArgs e)
        {
            if (b >= 244)
            {
                r -= Resta;
                
                panelfondo1.BackColor = Color.FromArgb(r, g, b);
                panelfondo2.BackColor = Color.FromArgb(r, g, b);
                panelfondo3.BackColor = Color.FromArgb(r, g, b);
                panelfondo4.BackColor = Color.FromArgb(r, g, b);
                panelfondo5.BackColor = Color.FromArgb(r, g, b);
                panelfondo6.BackColor = Color.FromArgb(r, g, b);
                panelfondo7.BackColor = Color.FromArgb(r, g, b);
                

                if (r <= 65)
                {
                    timerR.Stop();
                    timerG.Start();

                    
                }
            }

            if (b <= 65)
            {
                r += Resta;
                panelfondo1.BackColor = Color.FromArgb(r, g, b);
                panelfondo2.BackColor = Color.FromArgb(r, g, b);
                panelfondo3.BackColor = Color.FromArgb(r, g, b);
                panelfondo4.BackColor = Color.FromArgb(r, g, b);
                panelfondo5.BackColor = Color.FromArgb(r, g, b);
                panelfondo6.BackColor = Color.FromArgb(r, g, b);
                panelfondo7.BackColor = Color.FromArgb(r, g, b);
                


                if (r >= 244)
                {
                    timerR.Stop();
                    timerG.Start();

                    
                }
            }
        }

        private void timerG_Tick(object sender, EventArgs e)
        {
            if (r <= 65)
            {
                g += Resta;
                panelfondo1.BackColor = Color.FromArgb(r, g, b);
                panelfondo2.BackColor = Color.FromArgb(r, g, b);
                panelfondo3.BackColor = Color.FromArgb(r, g, b);
                panelfondo4.BackColor = Color.FromArgb(r, g, b);
                panelfondo5.BackColor = Color.FromArgb(r, g, b);
                panelfondo6.BackColor = Color.FromArgb(r, g, b);
                panelfondo7.BackColor = Color.FromArgb(r, g, b);
          


                if (g >= 244)
                {
                    timerG.Stop();
                    timerB.Start();

                    
                }
            }

            if (r >= 244)
            {
                g -= Resta;
                panelfondo1.BackColor = Color.FromArgb(r, g, b);
                panelfondo2.BackColor = Color.FromArgb(r, g, b);
                panelfondo3.BackColor = Color.FromArgb(r, g, b);
                panelfondo4.BackColor = Color.FromArgb(r, g, b);
                panelfondo5.BackColor = Color.FromArgb(r, g, b);
                panelfondo6.BackColor = Color.FromArgb(r, g, b);
                panelfondo7.BackColor = Color.FromArgb(r, g, b);
              


                if (g <= 65)
                {
                    timerG.Stop();
                    timerB.Start();

                  
                }
            }



        }

        private void timerB_Tick(object sender, EventArgs e)
        {
            if (g <= 65)
            {
                b += Resta;
                panelfondo1.BackColor = Color.FromArgb(r, g, b);
                panelfondo2.BackColor = Color.FromArgb(r, g, b);
                panelfondo3.BackColor = Color.FromArgb(r, g, b);
                panelfondo4.BackColor = Color.FromArgb(r, g, b);
                panelfondo5.BackColor = Color.FromArgb(r, g, b);
                panelfondo6.BackColor = Color.FromArgb(r, g, b);
                panelfondo7.BackColor = Color.FromArgb(r, g, b);
          

                if (b >= 244)
                {
                    timerB.Stop();
                    timerR.Start();

                   
                }
            }

            if (g >= 244)
            {
                b -= Resta;
                panelfondo1.BackColor = Color.FromArgb(r, g, b);
                panelfondo2.BackColor = Color.FromArgb(r, g, b);
                panelfondo3.BackColor = Color.FromArgb(r, g, b);
                panelfondo4.BackColor = Color.FromArgb(r, g, b);
                panelfondo5.BackColor = Color.FromArgb(r, g, b);
                panelfondo6.BackColor = Color.FromArgb(r, g, b);
                panelfondo7.BackColor = Color.FromArgb(r, g, b);
              

                if (b <= 65)
                {
                    timerB.Stop();
                    timerR.Start();

                   
                }
            }
        }

        private void Programadores_Load(object sender, EventArgs e)
        {
            timerG.Start();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
