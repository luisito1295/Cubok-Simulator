using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazG
{
    public partial class CRL : Form
    {
        public CRL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vs = double.Parse(textBox1.Text);
            double R = double.Parse(textBox2.Text);
            double L = double.Parse(textBox4.Text);
            double t = double.Parse(textBox6.Text);

            double vl = vs * (1 - Math.Exp(-t/(R*L)));
            label1.Text = "VL=" + vs.ToString() + "* (1 - e^(-" + t.ToString() + "/(" + R.ToString() + " * " + L.ToString() + "))";
            textBox5.Text = textBox5.Text + vl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double vs = double.Parse(textBox1.Text);
            double R = double.Parse(textBox2.Text);
            double L = double.Parse(textBox4.Text);
            double t = double.Parse(textBox6.Text);

            double il = (vs / R) * (1 - Math.Exp((-R * t) / L));
            label7.Text ="IL="+ vs.ToString() + "/" + R.ToString() + "* (1 - e^(-" + R.ToString()+" * " + t.ToString()+")" + "/("+ L.ToString() + "))";
            textBox3.Text = textBox3.Text + il;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            logMove = 0;
        }
        int logMove;
        int mvalx;
        int mvaly;
        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (logMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mvalx, MousePosition.Y - mvaly);
            }
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            logMove = 1;
            mvalx = e.X;
            mvaly = e.Y;
        }
    }
}
