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
    public partial class gen_con : Form
    {
        public gen_con()
        {
            InitializeComponent();
        }

        private void Semilla_Enter(object sender, EventArgs e)
        {
            msg.Visible = true;
        }

        private void Semilla_Leave(object sender, EventArgs e)
        {
            msg.Visible = false;
        }

        private void modulo_Enter(object sender, EventArgs e)
        {
            msg2.Visible = true;
        }

        private void modulo_Leave(object sender, EventArgs e)
        {
            msg2.Visible = false;
        }

        private void lineal_Click(object sender, EventArgs e)
        {
            int xd;
         try { 
                numeros.Text = null;
                int periodo = 0;
                int x, a, c, mod, num;
                a = int.Parse(Multi.Text);
                c = int.Parse(Cons.Text);
                x = int.Parse(Semilla.Text);
                mod = int.Parse(modulo.Text);
                num = int.Parse(Cantidad.Text);
                while (periodo != num)
                {
                    x = (a * x + c) % mod;
                    numeros.Text = numeros.Text + x + "- ";
                    periodo = periodo + 1;
                }
            }
            catch { MessageBox.Show("Dato no numerico o vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void multiplicador_Click(object sender, EventArgs e)
        {
            int xd;
           try
            {
                numeros.Text = null;
                int periodo = 0;
                int x, a, c, mod, num;
                a = int.Parse(Multi.Text);
                c = int.Parse(Cons.Text);
                x = int.Parse(Semilla.Text);
                mod = int.Parse(modulo.Text);
                num = int.Parse(Cantidad.Text);
                while (periodo != num)
                {
                    x = (a * x) % mod;
                    numeros.Text = numeros.Text + x + "- ";
                    periodo = periodo + 1;

                }
            }
            catch { MessageBox.Show("Dato no numerico o vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
