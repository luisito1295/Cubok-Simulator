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
    public partial class preamplificador : Form
    {
        public preamplificador()
        {
            InitializeComponent();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            lb9.Text = tb1.Text;
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            lb24.Text = tb2.Text;
        }

        private void tb5_TextChanged(object sender, EventArgs e)
        {
            label1.Text = tb5.Text;
        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {
            lb20.Text = tb3.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            try
            {
                //11 16 22 28 35
                double v1, v2, r1, r3, vre, ie, vr, vc, vce;
                v1 = Convert.ToDouble(tb1.Text);
                v2 = Convert.ToDouble(tb2.Text);
                r1 = Convert.ToDouble(tb3.Text);
                r3 = Convert.ToDouble(tb5.Text);
                vre = -0.7 - v1;
                ie = vre / r3;
                vr = ie * r1;
                vc = v2 - vr;
                vce = vc + 0.7;
                lb11.Text = lb13.Text = ("" + vre).Substring(0, ("" + vre).Length > 4 ? 4 :("" + vre).Length);
                lb16.Text = lb19.Text = "" + ie;
                lb26.Text = lb22.Text = "" + vr; 
                lb28.Text = lb31.Text =  "" + vc;
                lb35.Text = "" + vce;
            }
            catch
            {
                MessageBox.Show("fff");
            }
        }

        private void lb28_Click(object sender, EventArgs e)
        {

        }

        private void preamplificador_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb5.Clear();
            lb9.Text = "";
            lb11.Text = "";
            lb13.Text = "";
            label1.Text = "";
            lb16.Text = "";
            lb19.Text = "";
            lb20.Text = "";
            lb22.Text = "";
            lb24.Text = "";
            lb26.Text = "";
            lb28.Text = "";
            lb31.Text = "";
            lb35.Text = "";
        }
    }
}
