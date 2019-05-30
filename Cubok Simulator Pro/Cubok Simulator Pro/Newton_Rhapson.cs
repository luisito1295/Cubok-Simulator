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
    public partial class Newton_Rhapson : Form
    {
        public Newton_Rhapson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = "Metodo de Newton Rhapson: \n";
                double[] xi = new double[1000];
                double x0 = 1;//valor  inicial de xi
                string fx = t_fx.Text;//Funcion alamacenada de fx
                string fpx = t_fpx.Text;//Derivada de la funcion fx
                double ea = double.Parse(t_ea.Text);
                double EA = 100;

                ExpressionParser parser = new ExpressionParser();
                // Create value instances
                DoubleValue xval = new DoubleValue();
                // Add values for variables x and y
                parser.Values.Add("x", xval);
                xval.Value = x0; // Update value of "x"
                xi[0] = x0;
                int contador = 1; ;
                while (EA > ea)
                {
                    double efx = parser.Parse(t_fx.Text);//evalua fx
                    double efpx = parser.Parse(t_fpx.Text);//evalua fpx
                    xi[contador] = xi[contador - 1] - (efx / efpx);//iteraciones
                    parser.Values["x"].SetValue(xi[contador]); // x previously added with Add
                    EA = Math.Abs(((xi[contador] - xi[contador - 1]) / xi[contador])) * 100;


                    richTextBox1.Text = richTextBox1.Text + "\n--============--\n";
                    richTextBox1.Text = richTextBox1.Text + "Iteracion " + contador.ToString() + ":";
                    richTextBox1.Text = richTextBox1.Text + "\nX" + contador.ToString() + " = " + xi[contador].ToString("N6");
                    richTextBox1.Text = richTextBox1.Text + "\nεa= " + EA.ToString("N3") + "%";
                    contador++;
                }
            }
            catch {
                MessageBox.Show("Verificar datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (b == 1) { t_fx.Text = t_fx.Text + button2.Text; }
            if (b == 2) { t_fpx.Text = t_fpx.Text + button2.Text; }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (b == 1) { t_fx.Text = t_fx.Text + button5.Text; }
            if (b == 2) { t_fpx.Text = t_fpx.Text + button5.Text; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (b == 1) { t_fx.Text = t_fx.Text + button3.Text; }
            if (b == 2) { t_fpx.Text = t_fpx.Text + button3.Text; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (b == 1) { t_fx.Text = t_fx.Text + button6.Text; }
            if (b == 2) { t_fpx.Text = t_fpx.Text + button6.Text; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (b == 1) { t_fx.Text = t_fx.Text + button4.Text; }
            if (b == 2) { t_fpx.Text = t_fpx.Text + button4.Text; }
        }
        public static int b = 0;
        private void Newton_Rhapson_Load(object sender, EventArgs e)
        {

        }

        private void t_fx_Enter(object sender, EventArgs e)
        {
            b = 1;
            operadores.Visible = true;
        }

        private void t_fpx_Enter(object sender, EventArgs e)
        {
            b = 2;
            operadores.Visible = true;
        }

        private void t_ea_Enter(object sender, EventArgs e)
        {
            operadores.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            t_ea.Clear();
            t_fpx.Clear();
            t_fx.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
