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
    public partial class Menu_Numericos : Form
    {
        public Menu_Numericos()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trapecio t = new Trapecio();
            t.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Simpson s = new Simpson();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gauss_Jordan g = new Gauss_Jordan();
            g.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lagrange l = new Lagrange();
            l.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Newton_Rhapson n = new Newton_Rhapson();
            n.ShowDialog();
        }
    }
}
