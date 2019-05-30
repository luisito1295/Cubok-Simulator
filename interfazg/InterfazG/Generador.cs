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
    public partial class Generador : Form
    {
        public Generador()
        {
            InitializeComponent();
        }

        private void Generador_Load(object sender, EventArgs e)
        {
            this.Left = this.Left + 130;
        }
        int i, linf, lsup, cn;

        private void salir_MouseEnter(object sender, EventArgs e)
        {
            salir.BackColor = Color.Red;
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            salir.BackColor = System.Drawing.Color.Transparent;
        }

        private void Others_Click(object sender, EventArgs e)
        {
            gen_cong con = new gen_cong();
            con.ShowDialog();
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

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            logMove = 0;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (logMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mvalx, MousePosition.Y - mvaly);
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            linferior.Text = null;
            lsuperior.Text = null;
            cantidad.Text = null;
            numeros.Text = null;
        }

        private void generar_Click(object sender, EventArgs e)
        {
            int xd;
            if ((int.TryParse(linferior.Text, out xd) && int.TryParse(lsuperior.Text, out xd) && int.TryParse(cantidad.Text, out xd)) == true)
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
            else { MessageBox.Show("Ingresa solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
