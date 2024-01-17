using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uriasz_funkcje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                this.textBox3.Enabled = false;
                this.textBox4.Enabled = false;
                this.label3.Enabled = false;
                this.label4.Enabled = false;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                this.textBox4.Enabled = false;
                this.textBox3.Enabled = true;
                this.label3.Enabled=true;
                this.label4.Enabled = false;

               
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked == true)
            {
                this.textBox1.Enabled = true;
                this.textBox2.Enabled = true;
                this.textBox3.Enabled = true;
                this.textBox4.Enabled = true;
                this.label1.Enabled = true;
                this.label2.Enabled = true;
                this.label3.Enabled = true;
                this.label4.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr H = this.pictureBox1.Handle;
            Graphics obr =  Graphics.FromHwnd(H);

            obr.Clear(Color.White);
            

            int hW = this.pictureBox1.Width / 2;
            int hH = this.pictureBox1.Height / 2;

            int k = 80;

            obr.DrawLine(new Pen(Color.Gray, 1), 0, hH, 2 * hW, hH );

            obr.DrawLine(new Pen(Color.Gray, 1), hW, 0, hW,2 * hH);

            for(int x = -5; x <= 5; x++)
            {
                int xp = hW + k * x;

                obr.DrawLine(new Pen(Color.Gray, 1), xp, hH - 5, xp, hH + 5);
                obr.DrawString(x.ToString(), new Font("Verdana", 12), new SolidBrush(Color.Gray), xp, hH);
            }
            for(int y = -5; y <= 5; y++)
            {
                int yp = hH - k * y;

                obr.DrawLine(new Pen(Color.Gray, 1), hW - 5, yp, hW + 5, yp);
                obr.DrawString(y.ToString(), new Font("Verdana", 12), new SolidBrush(Color.Gray), hW, yp);
            }
            
            
            
          
            if (radioButton1.Checked == true)
            {
                for (double xx = -5.2; xx <= 5.2; xx += 0.01)
                {
                    double a = double.Parse(this.textBox1.Text);
                    double b = double.Parse(this.textBox2.Text);
                    
                    double yy = (a * xx) + b;

                    int xss = hW + (int)(k * xx);
                    int yss = hH - (int)(k * yy);
                    obr.FillRectangle(new SolidBrush(Color.Gray), xss - 1, yss - 1, 2, 2);
                }
            }
            if(radioButton2.Checked == true)
            {
                for (double xx = -5.2; xx <= 5.2; xx += 0.01)
                {
                    double a = double.Parse(this.textBox1.Text);
                    double b = double.Parse(this.textBox2.Text);
                    double c = double.Parse(this.textBox3.Text);
                    
                    double yy = (a * xx * xx) + (b * xx) + c;

                    int xss = hW + (int)(k * xx);
                    int yss = hH - (int)(k * yy);
                    obr.FillRectangle(new SolidBrush(Color.Gray), xss - 1, yss - 1, 2, 2);
                }
            }
            if(radioButton3.Checked == true)
            {
                for (double xx = -5.2; xx <= 5.2; xx += 0.01)
                {
                    double a = double.Parse(this.textBox1.Text);
                    double b = double.Parse(this.textBox2.Text);
                    double c = double.Parse(this.textBox3.Text);
                    double d = double.Parse(this.textBox4.Text);
                    double yy = (a * xx * xx * xx) + (b * xx * xx) + (c * xx) + d;

                    int xss = hW + (int)(k * xx);
                    int yss = hH - (int)(k * yy);
                    obr.FillRectangle(new SolidBrush(Color.Gray), xss - 1, yss - 1, 2, 2);
                }
            }
            obr.Dispose();
        }
    }
}
