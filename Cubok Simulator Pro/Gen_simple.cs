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
    public partial class Gen_simple : Form
    {
        public Gen_simple()
        {
            InitializeComponent();
        }
        int i, linf, lsup, cn;

        private void limpiar_Click(object sender, EventArgs e)
        {
            linferior.Text = null;
            lsuperior.Text = null;
            cantidad.Text = null;
            numeros.Text = null;
        }

        private void Others_Click(object sender, EventArgs e)
        {
            gen_con con = new gen_con();
            con.ShowDialog();
        }

        private void generar_Click(object sender, EventArgs e)
        {
            int xd;
            try
            {
                numeros.Text = "";
                linf = int.Parse(linferior.Text);
                lsup = int.Parse(lsuperior.Text);
                cn = int.Parse(cantidad.Text);
                Random rdn = new Random();
                for (i = 1; i <= int.Parse(cantidad.Text); i++)
                {
                    int numaleatorio = rdn.Next(linf, lsup);
                    numeros.Text = numeros.Text + i + ": " + numaleatorio.ToString() + ", ";

                }
            }
            catch { MessageBox.Show("Ingresa solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
