using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;

namespace Cubok_Simulator_Pro
{
    public partial class Simpson : Form
    {
        public Simpson()
        {
            InitializeComponent();
        }
        public static double fxa;
        public static double fxb;
        public static double fx0, fx1;
        public static double[] fxi;
        public static double fxn;
        private void button1_Click(object sender, EventArgs e)
        {
            double xd; int xd2;
            if ((double.TryParse(t_a.Text, out xd) && double.TryParse(t_b.Text, out xd) && int.TryParse(t_n.Text, out xd2)) == true)
            {
                if (string.IsNullOrWhiteSpace(t_fx.Text) == false)
                {
                    //Metodo Simpson 1/3
                    double a = Convert.ToDouble(t_a.Text);
                    double b = Convert.ToDouble(t_b.Text);
                    int n = Convert.ToInt32(t_n.Text);
                    double h = (b - a) / 2;
                    ExpressionParser parser = new ExpressionParser();
                    // Create value instances
                    DoubleValue xval = new DoubleValue();
                    try
                    {
                        parser.Values.Add("x", a);
                        fxa = parser.Parse(t_fx.Text);
                        parser.Values["x"].SetValue(a + h);
                        fx0 = parser.Parse(t_fx.Text);
                        parser.Values["x"].SetValue(b);
                        fxb = parser.Parse(t_fx.Text);
                        double r = (h / 3) * (fxa + (4 * fx0) + fxb);
                        label5.Text = "A = " + r.ToString() + " u²";
                    }
                    catch { MessageBox.Show("Funcion fx invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    h = (b - a) / 3;
                    try
                    {
                        parser.Values["x"].SetValue(a);
                        fxa = parser.Parse(t_fx.Text);
                        parser.Values["x"].SetValue(a + h);
                        fx0 = parser.Parse(t_fx.Text);
                        parser.Values["x"].SetValue(b);
                        fxb = parser.Parse(t_fx.Text);
                        parser.Values["x"].SetValue(a + h + h);
                        fx1 = parser.Parse(t_fx.Text);
                        double r = ((h * 3) / 8) * (fxa + (3 * fx0) + (3 * fx1) + fxb);
                        label6.Text = "A = " + r.ToString() + " u²";
                    }
                    catch { }
                }
                else { MessageBox.Show("Espacio en blanco o caracter invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Espacio en blanco o caracter invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t_a.Text = "";
            t_b.Text = "";
            t_fx.Text = "";
            t_n.Text = "1";
            label5.Text = "A = 0 u²";
            label6.Text = "A = 0 u²";
        }
    }
}
