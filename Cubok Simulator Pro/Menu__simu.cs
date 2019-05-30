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
    public partial class Menu__simu : Form
    {
        public Menu__simu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gen_con ge = new gen_con();
            ge.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gen_simple s = new Gen_simple();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            barbero_dormilon b = new barbero_dormilon();
            b.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
