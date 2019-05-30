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
    public partial class paso_rc2 : Form
    {
        public paso_rc2()
        {
            InitializeComponent();
        }

        private void paso_rc2_Load(object sender, EventArgs e)
        {
            try
            {
                //Variables del circuito a reducir
                double corriente = rc2.corriente;
                double r1 = rc2.r1a;
                double r2 = rc2.r2a;
                double r3 = rc2.r3a;
                double c = rc2.ca;
                double r12 = 1 / ((1 / r1) + (1 / r2));
                double vs = corriente * r12;
                double r13 = r12 + r3;
                double vca = rc2.vc;

                //Imprimiendo
                label1.Text = label1.Text + " " + corriente.ToString("N2") + "A";
                label2.Text = label2.Text + " " + r1.ToString("N2") + "Ω";
                label3.Text = label3.Text + " " + r2.ToString("N2") + "Ω";
                label4.Text = label4.Text + " " + r3.ToString("N2") + "Ω";
                label5.Text = label5.Text + " " + corriente.ToString("N2") + "A";
                label6.Text = label6.Text + " " + r12.ToString("N2") + "Ω";
                label7.Text = label7.Text + " " + r3.ToString("N2") + "Ω";
                label8.Text = label8.Text + " " + c.ToString("N2") + "h";
                label9.Text = label9.Text + " " + c.ToString("N2") + "h";
                label10.Text = label10.Text + " " + vs.ToString("N2") + "v";
                label11.Text = label11.Text + " " + r12.ToString("N2") + "Ω";
                label12.Text = label12.Text + " " + r3.ToString("N2") + "Ω";
                label13.Text = label13.Text + " " + c.ToString("N2") + "h";
                label14.Text = label14.Text + " " + r13.ToString("N2") + "Ω";
                label15.Text = label15.Text + " " + vs.ToString("N2") + "v";
                label16.Text = label16.Text + " " + c.ToString("N2") + "h";
                label17.Text = label17.Text + " " + vca.ToString("N5") + "v";

            }
            catch { }




        }
    }
}
