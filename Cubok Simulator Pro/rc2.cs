using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cubok_Simulator_Pro
{
    public partial class rc2 : Form
    {
        public rc2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paso_rc2 p2 = new paso_rc2();
            p2.ShowDialog();

        }
        public static double corriente;
        public static double r12;
        public static double vs1;
        public static double r13;
        public static double r1a;
        public static double r2a;
        public static double r3a;
        public static double ca;
        public static double vc;



      private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;

                //Haciendo publicas las variables del circuito a reducir
                r1a = Convert.ToDouble(r1.Text);
                r2a = Convert.ToDouble(r2.Text);
                r3a = Convert.ToDouble(r3.Text);
                ca = Convert.ToDouble(c.Text);
                //Se calcula la corriente por ley de ohm i=v/r
                corriente = Convert.ToDouble(vs.Text) / Convert.ToDouble(r1.Text);
                //Se calcula la resistencia resultante de la suma en paralelo r12 = 1/((1/r1)+(1/r2))
                r12 = 1 / ((1 / Convert.ToDouble(r1.Text)) + (1 / Convert.ToDouble(r2.Text)));

                //Se multiplica la corriente por la resistencia para calcular el voltaje de la reduccion
                vs1 = corriente * r12;

                //Sumamos las resistencias en serie
                r13 = r12 + Convert.ToDouble(r3.Text);


                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;

                //Imprimiendo
                label6.Text =  " " + vs1.ToString("N2") + "v";
                label7.Text =  " " + r13.ToString("N2") + "Ω";
                label8.Text =  " " + c.Text;

                //Calcular Vc
                double t = Convert.ToDouble(tiempo.Text);
                double cc = double.Parse(c.Text);
                vc = vs1 * (1 - Math.Exp(-t / r13 * cc));


                //Imprimir Vc

                label10.Text = " " + vc.ToString("N5") + "v";
                button2.Enabled = true;
          
            }
            catch
            {
                MessageBox.Show("Dato incorrecto, llenar todos los campos correctamente.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            r2.Clear();
            r1.Clear();
            r3.Clear();
            vs.Clear();
            button2.Enabled = false;
            c.Clear();
            tiempo.Clear();
            label6.Text = "VS =";
            label7.Text = "R =";
            label8.Text = "C =";
            label10.Text = "VC =";
 
        }
    }
}
