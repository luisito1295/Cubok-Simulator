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
    public partial class gen_cong : Form
    {
        public gen_cong()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lineal_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void multiplicador_CheckedChanged(object sender, EventArgs e)
        {
            
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

        private void salir_MouseEnter(object sender, EventArgs e)
        {
            salir.BackColor = Color.Red;
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            salir.BackColor = System.Drawing.Color.Transparent;
        }

        private void lineal_Click(object sender, EventArgs e)
        {
            int xd;
            if ((int.TryParse(Multi.Text, out xd) && int.TryParse(Cons.Text, out xd) && int.TryParse(Semilla.Text, out xd) && int.TryParse(modulo.Text, out xd) && int.TryParse(Cantidad.Text, out xd)) == true)
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
                    x = (a * x + c) % mod;
                    numeros.Text = numeros.Text + x + "- ";
                    periodo = periodo + 1;
                }
            }
            else { MessageBox.Show("Dato no numerico o vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void multiplicador_Click(object sender, EventArgs e)
        {
            int xd;
            if ((int.TryParse(Multi.Text, out xd) && int.TryParse(Cons.Text, out xd) && int.TryParse(Semilla.Text, out xd) && int.TryParse(modulo.Text, out xd) && int.TryParse(Cantidad.Text, out xd)) == true)
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
            else { MessageBox.Show("Dato no numerico o vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        int logMove;
        int mvalx;
        int mvaly;
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            logMove = 1;
            mvalx = e.X;
            mvaly = e.Y;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (logMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mvalx, MousePosition.Y - mvaly);
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            logMove = 0;
        }
    }
}
