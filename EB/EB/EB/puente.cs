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
    public partial class puente : Form
    {
        public puente()
        {
            InitializeComponent();
        }

        double a, d,c,b,e, rvp, vsal,vprom1,vprom2,iprom,ri;
       
        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            try
            {
                // esto calcula el voltaje pico
                if (tb1.Text == "")
                {
                    MessageBox.Show("Agregue valor al voltaje Rms");
                    return;
                }
                else
                {
                    a = double.Parse(tb1.Text);
                    rvp = a * 1.414213562;
                    lbl3.Text = rvp.ToString();
                    lbl3.Text = rvp.ToString("0.00");
                }

                // esto calcula el vprom1
                {
                    d = double.Parse(lbl3.Text);
                    vprom1 = d * 0.636;
                    lbl10.Text = vprom1.ToString();
                    lbl10.Text = vprom1.ToString("0.00");
                }

                // esto calcula el voltaje de salida
                {
                    c = double.Parse(lbl3.Text);
                    vsal = rvp - 1.4;
                    label2.Text = vsal.ToString();
                    label2.Text = vsal.ToString("0.00");
                }

                // esto calcula el vprom2
                {
                    b = double.Parse(label2.Text);
                    vprom2 = vsal * 0.636;
                    label6.Text = vprom2.ToString();
                    label6.Text = vprom2.ToString("0.00");
                }


                //esto pone el valor del voltaje pico en la corriente
                a = double.Parse(label6.Text);
                rvp = a * 1.414213562;
                label14.Text = rvp.ToString();
                label14.Text = rvp.ToString("0.00");
                label14.Text = a.ToString();

                //esto calcula la corriente
                if (txtb1.Text == "")
                {
                    MessageBox.Show("Agregue valor a la resistencia (R)");
                    return;
                }
                else
                {
                    b = double.Parse(txtb1.Text);
                    ri = vprom2 / b;
                    label10.Text = ri.ToString();
                    label10.Text = ri.ToString("0.00");
                }



            }catch { }

            }

        private void bt3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
           
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            lbl3.Text = "";
            lbl10.Text = "";
            label2.Text = "";
            label6.Text = "";
            label14.Text = "";
            txtb1.Clear();
            label10.Text = "";
        }

        private void puente_Load(object sender, EventArgs e)
        {

        }
    }
}
