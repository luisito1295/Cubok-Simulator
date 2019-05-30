using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;
using System.Windows.Forms;

namespace Cubok_Simulator_Pro
{
    public partial class Trapecio : Form
    {
        public Trapecio()
        {
            InitializeComponent();
        }
    
    public static double fxa;
    public static double fxb;
    public static double fx0;
    public static double[] fxi;
    public static double fxn;
    private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t_a.Text = "";
            t_b.Text = "";
            t_fx.Text = "";
            t_n.Text = "";
            label5.Text = "A = 0 u²";
            label6.Text = "A = 0 u²";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(t_n.Text)) { t_n.Text = "1"; }
            double xd; int xd2;
            if ((double.TryParse(t_a.Text, out xd) && double.TryParse(t_b.Text, out xd) && int.TryParse(t_n.Text, out xd2)) == true)
            {
                if (string.IsNullOrWhiteSpace(t_fx.Text) == false)
                {
                    //Trapecio Simple
                    double a = Convert.ToDouble(t_a.Text);
                    double b = Convert.ToDouble(t_b.Text);
                    int n = Convert.ToInt32(t_n.Text);
                    double h = (b - a);
                    richTextBox1.Text = richTextBox1.Text + "Metodo del Trapecio\n";
                    richTextBox1.Text = richTextBox1.Text + "===========================\n";
                    richTextBox1.Text = richTextBox1.Text + "h=" + h.ToString();
                    ExpressionParser parser = new ExpressionParser();
                    // Create value instances
                    DoubleValue xval = new DoubleValue();
                    // Add values for variables x and y
                    parser.Values.Add("x", xval);
                    parser.Values.Add("a", xval);
                    parser.Values.Add("b", xval);
                    parser.Values.Add("c", xval);
                    parser.Values.Add("d", xval);
                    parser.Values.Add("e", xval);
                    parser.Values.Add("f", xval);
                    parser.Values.Add("g", xval);
                    parser.Values.Add("h", xval);
                    parser.Values.Add("i", xval);
                    parser.Values.Add("j", xval);
                    parser.Values.Add("k", xval);
                    parser.Values.Add("l", xval);
                    parser.Values.Add("m", xval);
                    parser.Values.Add("n", xval);
                    parser.Values.Add("o", xval);
                    parser.Values.Add("p", xval);
                    parser.Values.Add("q", xval);
                    parser.Values.Add("r", xval);
                    parser.Values.Add("s", xval);
                    parser.Values.Add("t", xval);
                    parser.Values.Add("u", xval);
                    parser.Values.Add("v", xval);
                    parser.Values.Add("w", xval);
                    parser.Values.Add("y", xval);
                    parser.Values.Add("z", xval);
                    xval.Value = a; // Update value of "x"
                    try
                    {
                        fxa = parser.Parse(t_fx.Text);
                    }
                    catch { MessageBox.Show("Funcion fx invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    richTextBox1.Text = richTextBox1.Text + "\nf(a)=" + fxa.ToString();
                    parser.Values["x"].SetValue(b); // x previously added with Add
                    parser.Values["a"].SetValue(b);
                    parser.Values["b"].SetValue(b);
                    parser.Values["c"].SetValue(b);
                    parser.Values["d"].SetValue(b);
                    parser.Values["e"].SetValue(b);
                    parser.Values["f"].SetValue(b);
                    parser.Values["g"].SetValue(b);
                    parser.Values["h"].SetValue(b);
                    parser.Values["i"].SetValue(b);
                    parser.Values["j"].SetValue(b);
                    parser.Values["k"].SetValue(b);
                    parser.Values["l"].SetValue(b);
                    parser.Values["m"].SetValue(b);
                    parser.Values["n"].SetValue(b);
                    parser.Values["o"].SetValue(b);
                    parser.Values["p"].SetValue(b);
                    parser.Values["q"].SetValue(b);
                    parser.Values["r"].SetValue(b);
                    parser.Values["s"].SetValue(b);
                    parser.Values["t"].SetValue(b);
                    parser.Values["w"].SetValue(b);
                    parser.Values["y"].SetValue(b);
                    parser.Values["z"].SetValue(b);
                    try
                    {
                        fxb = parser.Parse(t_fx.Text);
                    }
                    catch { }
                    richTextBox1.Text = richTextBox1.Text + "\nf(b)=" + fxb.ToString();
                    double r = (h / 2) * (fxa + fxb);
                    richTextBox1.Text = richTextBox1.Text + "\nA=" + r.ToString() + " u²";
                    label5.Text = "A = " + r.ToString() + " u²";
                    //Trapecio por segmentos
                    h = (b - a) / n;
                    richTextBox1.Text = richTextBox1.Text + "\n\nMetodo del Trapecio por segmentos multiples";
                    richTextBox1.Text = richTextBox1.Text + "\n===========================\n";
                    richTextBox1.Text = richTextBox1.Text + "h=" + h.ToString();
                    richTextBox1.Text = richTextBox1.Text + "\nn=" + n.ToString();
                    parser.Values["x"].SetValue(a); // x previously added with Add
                    parser.Values["a"].SetValue(a);
                    parser.Values["b"].SetValue(a);
                    parser.Values["c"].SetValue(a);
                    parser.Values["d"].SetValue(a);
                    parser.Values["e"].SetValue(a);
                    parser.Values["f"].SetValue(a);
                    parser.Values["g"].SetValue(a);
                    parser.Values["h"].SetValue(a);
                    parser.Values["i"].SetValue(a);
                    parser.Values["j"].SetValue(a);
                    parser.Values["k"].SetValue(a);
                    parser.Values["l"].SetValue(a);
                    parser.Values["m"].SetValue(a);
                    parser.Values["n"].SetValue(a);
                    parser.Values["o"].SetValue(a);
                    parser.Values["p"].SetValue(a);
                    parser.Values["q"].SetValue(a);
                    parser.Values["r"].SetValue(a);
                    parser.Values["s"].SetValue(a);
                    parser.Values["t"].SetValue(a);
                    parser.Values["u"].SetValue(a);
                    parser.Values["v"].SetValue(a);
                    parser.Values["w"].SetValue(a);
                    parser.Values["y"].SetValue(a);
                    parser.Values["z"].SetValue(a);
                    try
                    {
                        fx0 = parser.Parse(t_fx.Text);
                    }
                    catch { }
                    richTextBox1.Text = richTextBox1.Text + "\nf(a)=" + fx0.ToString();
                    double temp = a + h;
                    fxi = new double[n + 1];
                    double area_s = 0;
                    for (int i = 1; i <= n - 1; i++)
                    {

                        parser.Values["x"].SetValue(temp); // x previously added with Add
                        parser.Values["a"].SetValue(temp);
                        parser.Values["b"].SetValue(temp);
                        parser.Values["c"].SetValue(temp);
                        parser.Values["d"].SetValue(temp);
                        parser.Values["e"].SetValue(temp);
                        parser.Values["f"].SetValue(temp);
                        parser.Values["g"].SetValue(temp);
                        parser.Values["h"].SetValue(temp);
                        parser.Values["i"].SetValue(temp);
                        parser.Values["j"].SetValue(temp);
                        parser.Values["k"].SetValue(temp);
                        parser.Values["l"].SetValue(temp);
                        parser.Values["m"].SetValue(temp);
                        parser.Values["n"].SetValue(temp);
                        parser.Values["o"].SetValue(temp);
                        parser.Values["p"].SetValue(temp);
                        parser.Values["q"].SetValue(temp);
                        parser.Values["r"].SetValue(temp);
                        parser.Values["s"].SetValue(temp);
                        parser.Values["t"].SetValue(temp);
                        parser.Values["u"].SetValue(temp);
                        parser.Values["v"].SetValue(temp);
                        parser.Values["w"].SetValue(temp);
                        parser.Values["y"].SetValue(temp);
                        parser.Values["z"].SetValue(temp);
                        try
                        {
                            fxi[i] = parser.Parse(t_fx.Text);
                        }
                        catch { }

                        richTextBox1.Text = richTextBox1.Text + "\nf(x" + i.ToString() + ")=" + fxi[i].ToString() + "";
                        temp = temp + h;
                        area_s = area_s + fxi[i];
                    }

                    parser.Values["x"].SetValue(b); // x previously added with Add
                    parser.Values["a"].SetValue(b);
                    parser.Values["b"].SetValue(b);
                    parser.Values["c"].SetValue(b);
                    parser.Values["d"].SetValue(b);
                    parser.Values["e"].SetValue(b);
                    parser.Values["f"].SetValue(b);
                    parser.Values["g"].SetValue(b);
                    parser.Values["h"].SetValue(b);
                    parser.Values["i"].SetValue(b);
                    parser.Values["j"].SetValue(b);
                    parser.Values["k"].SetValue(b);
                    parser.Values["l"].SetValue(b);
                    parser.Values["m"].SetValue(b);
                    parser.Values["n"].SetValue(b);
                    parser.Values["o"].SetValue(b);
                    parser.Values["p"].SetValue(b);
                    parser.Values["q"].SetValue(b);
                    parser.Values["r"].SetValue(b);
                    parser.Values["s"].SetValue(b);
                    parser.Values["t"].SetValue(b);
                    parser.Values["w"].SetValue(b);
                    parser.Values["y"].SetValue(b);
                    parser.Values["z"].SetValue(b);
                    parser.Values["x"].SetValue(b);
                    parser.Values["x"].SetValue(b);
                    try
                    {
                        fxn = parser.Parse(t_fx.Text);
                        richTextBox1.Text = richTextBox1.Text + "\nf(b)=" + fxn.ToString();
                        r = (h / 2) * (fx0 + (2 * (area_s)) + fxn);
                        richTextBox1.Text = richTextBox1.Text + "\nA=" + r.ToString() + " u²";
                        label6.Text = "A = " + r.ToString() + " u²";
                    }
                    catch { }
                }
                else { MessageBox.Show("Espacio en blanco o caracter invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Espacio en blanco o caracter invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
