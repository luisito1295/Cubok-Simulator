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
    public partial class MenuMnum : Form
    {
        public MenuMnum()
        {
            InitializeComponent();
        }
        int logMove;
        int mvalx;
        int mvaly;
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
          /*  logMove = 1;
            mvalx = e.X;
            mvaly = e.Y;*/
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
         //   logMove = 0;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
          /*  if (logMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mvalx, MousePosition.Y - mvaly);
            }*/
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void salir_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void minimizar_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void minimizar_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lagrange lag = new lagrange();
            lag.Show();

        }
        public static TextBox xd;
        public static TextBox xd2;
        public static TextBox[] cuadro;
        public static TextBox[] cuadro2;
        public static Label labelfxi;
        public static Label labelxi;
        public static Label[] l;
        public static Label[] l2;
        int grado;
        public static int m;
        private void Siguiente_Click(object sender, EventArgs e)
        {

        }
        int i, j;
        public static double factor;
        public static double fx;
        double x;
        public static double[] fxi;
        public static double[] xi;
        public static double[] fxx;

        private void calcular_Click(object sender, EventArgs e)
        {

        }

        private void salir_MouseEnter_1(object sender, EventArgs e)
        {
            salir.BackColor = Color.Red;
        }

        private void salir_MouseLeave_1(object sender, EventArgs e)
        {
            salir.BackColor = System.Drawing.Color.Transparent;
        }

        private void salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuMnum_Load(object sender, EventArgs e)
        {
            if (Principal.idioma=="en_usa")
            {
                button1.Text = "Lagrange Interpolation";
                button2.Text = "False Position";
                button6.Text = "Close";
                this.Left = this.Left + 130;
            }
            if (Principal.idioma == "esp_mx")
            {
                button1.Text = "Interpolacion de Lagrange";
                button2.Text = "Falsa Posicion";
                button6.Text = "Cerrar";
                this.Left = this.Left + 130;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gauss_jordan gaus_j = new Gauss_jordan();
            gaus_j.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
