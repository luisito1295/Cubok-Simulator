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
    public partial class prueba : Form
    {
        public prueba()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            salir.BackColor = System.Drawing.Color.Transparent;
        }

        private void salir_MouseEnter(object sender, EventArgs e)
        {
            salir.BackColor = Color.Red;
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
    }
}
