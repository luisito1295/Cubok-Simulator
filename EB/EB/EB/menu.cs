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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            InterfazG.res A = new InterfazG.res();
            A.Show();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            ohm B = new ohm();
            B.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            puente C = new puente();
            C.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mediaonda D = new mediaonda();
            D.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
         
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            ganancia E = new ganancia();
            E.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            preamplificador F = new preamplificador();
            F.Show();
        }

        private void bt5_Click_1(object sender, EventArgs e)
        {
            ondacompleta G = new ondacompleta();
            G.Show();
        }
    }
}
