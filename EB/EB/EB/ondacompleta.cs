using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EB
{
    public partial class ondacompleta : Form
    {
        public ondacompleta()
        {
            InitializeComponent();
        }

        double a, rvp, b, ri, f, c, rvr, s, vs, ce;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // esto calcula el voltaje pico
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Agregue valor al voltaje Rms");
                    return;
                }
                else
                {
                    a = double.Parse(textBox1.Text);
                    rvp = a / 2 * (1.414213562);
                    label4.Text = rvp.ToString();
                    label4.Text = rvp.ToString("0.00");
                }

                //esto pone el valor del voltaje pico en la corriente
                a = double.Parse(textBox1.Text);
                rvp = a / 2 * (1.414213562);
                label5.Text = rvp.ToString();
                label5.Text = rvp.ToString("0.00");

                //esto calcula la corriente
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Agregue valor a la resistencia (R)");
                    return;
                }
                else
                {
                    b = double.Parse(textBox2.Text);
                    ri = rvp / b;
                    label8.Text = ri.ToString();
                    label8.Text = ri.ToString("0.000");
                }

                // esto pone el valor de la corriente el en vrizo
                b = double.Parse(textBox2.Text);
                ri = rvp / b;
                label11.Text = ri.ToString();
                label11.Text = ri.ToString("0.000");


                //esto calcula el voltaje rizo 
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Agregue valor a la Frecuencia (Hz)");
                    return;
                }
                else
                {
                    if (textBox4.Text == "")
                    {
                        MessageBox.Show("Agregue valor al capacitor");
                        return;
                    }
                    else
                    {
                        f = double.Parse(textBox3.Text);
                        c = double.Parse(textBox4.Text);
                        ce = Math.Pow(c * 10, -6);
                        rvr = ri / (f * c);

                        label16.Text = rvr.ToString();

                    }
                }

                // esto calcula el voltaje de salida
                s = double.Parse(label5.Text);
                vs = rvp - 0.7 - rvr / 2;
                label18.Text = vs.ToString();
                label18.Text = vs.ToString("0.00");
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = "";
            label5.Text = "";
            textBox2.Clear();
            label8.Text = "";
            label11.Text = "";
            textBox3.Clear();
            textBox4.Clear();
            label18.Text= "";
            label16.Text = "";
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
