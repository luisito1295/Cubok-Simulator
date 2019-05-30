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
    public partial class Menu_Ecuaciones : Form
    {
        public Menu_Ecuaciones()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rc2 r = new rc2();
            r.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InterfazG.CRL c = new InterfazG.CRL();
            c.Show();
        }
    }
}
