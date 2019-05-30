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
    public partial class mediaonda : Form
    {
        public mediaonda()
        {
            InitializeComponent();
        }
        double a, rvp, b, ri, f, c, rvr, s, vs, ce;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // esto calcula el voltaje pico
                if (txb1.Text == "")
                {
                    MessageBox.Show("Agregue valor al voltaje Rms");
                    return;
                }
                else
                {
                    a = double.Parse(txb1.Text);
                    rvp = a * 1.414213562;
                    label1.Text = rvp.ToString();
                    label1.Text = rvp.ToString("0.00");
                }

                //esto pone el valor del voltaje pico en la corriente
                a = double.Parse(txb1.Text);
                rvp = a * 1.414213562;
                label3.Text = rvp.ToString();
                label3.Text = rvp.ToString("0.00");

                //esto calcula la corriente
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Agregue valor a la resistencia (R)");
                    return;
                }
                else
                {
                    b = double.Parse(textBox1.Text);
                    ri = rvp / b;
                    label6.Text = ri.ToString();
                    label6.Text = ri.ToString("0.000");
                }

                // esto pone el valor de la corriente el en vrizo
                b = double.Parse(textBox1.Text);
                ri = rvp / b;
                label19.Text = ri.ToString();
                label19.Text = ri.ToString("0.000");


                //esto calcula el voltaje rizo 
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Agregue valor a la Frecuencia (Hz)");
                    return;
                }
                else
                {
                    if (textBox3.Text == "")
                    {
                        MessageBox.Show("Agregue valor al capacitor");
                        return;
                    }
                    else
                    {
                        f = double.Parse(textBox2.Text);
                        c = double.Parse(textBox3.Text);
                        ce = Math.Pow(c * 10, -6);
                        rvr = ri / (f * c);

                        label15.Text = rvr.ToString();

                    }
                }

                // esto calcula el voltaje de salida
                s = double.Parse(label3.Text);
                vs = rvp - 0.7 - rvr / 2;
                lab18.Text = vs.ToString();
                lab18.Text = vs.ToString("0.00");
            }catch{ }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txb1.Clear();
            label1.Text = "";
            label3.Text = "";
            textBox1.Clear();
            label6.Text = "";
            label15.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            label15.Text = "";
            lab18.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }
    }
}
