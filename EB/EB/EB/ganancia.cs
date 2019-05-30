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
    public partial class ganancia : Form
    {
        funciones funciones = new funciones();
        Control[] controlesIniciales;
        string[,] defText;
        public ganancia()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            controlesIniciales = funciones.getVisibleControls(this);
            defText = funciones.getControlsNameAndText(groupBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //4/5
            try{
                double vcc, vce, lc, b, vbe, vbb, lb;
                vbe = 0.7;
                vbb = Convert.ToDouble(txb2.Text);
                vcc = Convert.ToDouble(txb3.Text);
                vce = Convert.ToDouble(txb1.Text);
                lc = Convert.ToDouble(txb4.Text);
                b = Convert.ToDouble(txb5.Text);
                lb = lc/b;
                lb25.Text = "0.7";
                lb27.Text = lb + "mA";
                lb12.Text = "" + (vcc-vce)/lc;
                lb20.Text = "" + lb;
                lb30.Text = "" + (vbb - vbe) / lb;

            }
            catch
            {
                MessageBox.Show("-");
            }
        }

        private void txb1_TextChanged(object sender, EventArgs e)
        {
            lb8.Text = txb1.Text;
        }

        private void txb3_TextChanged(object sender, EventArgs e)
        {
            lb6.Text = txb3.Text;
        }

        private void txb4_TextChanged(object sender, EventArgs e)
        {
            lb10.Text = txb4.Text;
            lb16.Text = txb4.Text;
        }

        private void txb5_TextChanged(object sender, EventArgs e)
        {
            lb18.Text = txb5.Text;
        }

        private void txb2_TextChanged(object sender, EventArgs e)
        {
            lb23.Text = txb2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funciones.setControlsTextToDefault(groupBox1, defText);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
