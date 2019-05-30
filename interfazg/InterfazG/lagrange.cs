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
    public partial class lagrange : Form
    {
        public lagrange()
        {
            InitializeComponent();
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
            panel1.Visible = true;
            cuadro = new TextBox[1000];
            cuadro2 = new TextBox[1000];
            l = new Label[1000];
            l2 = new Label[1000];
            int v;
            if (int.TryParse(textBox1.Text, out v) == false)
            {
                MessageBox.Show("Grado del polinomio incorrecto, Ingresa solo numeros!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (int.TryParse(textBox1.Text, out v) != false)
            {
                Siguiente.Enabled = false;
                calcular.Visible = true;
                button2.Visible = true;
                panel1.Controls.Clear();
                grado = Convert.ToInt32(textBox1.Text);

                int cont = 0;
                for (int i = 0; i <= grado; i++)
                {
                    //xi textboxs
                    xd = new TextBox();
                    xd.Height = 50;
                    xd.Width = 70;
                    xd.Font = new Font("Modern No. 20", 14);
                    xd.Top = 1 + (i * 35);
                    xd.Left = 95;
                    cuadro[i] = xd;
                    panel1.Controls.Add(cuadro[i]);

                    //xi textboxs
                    xd2 = new TextBox();
                    xd2.Height = 50;
                    xd2.Width = 70;
                    xd2.Font = new Font("Modern No. 20", 14);
                    xd2.Top = 1 + (i * 35);
                    xd2.Left = xd.Left + 150;
                    cuadro2[i] = xd2;
                    panel1.Controls.Add(cuadro2[i]);

                    //labels
                    labelfxi = new Label();
                    labelfxi.Width = 100;
                    labelfxi.Top = 1 + (i * 35);
                    labelfxi.Left = 30;
                    labelfxi.Font = new Font("Modern No. 20", 14);
                    Convert.ToString(cont);
                    labelfxi.Text = "x" + cont + ":";
                    l[i] = labelfxi;
                    panel1.Controls.Add(l[i]);
                    Convert.ToInt32(cont);

                    //labels 
                    labelxi = new Label();
                    labelxi.Width = 100;
                    labelxi.Top = 1 + (i * 35);
                    labelxi.Left = xd.Left + 85;
                    labelxi.Font = new Font("Modern No. 20", 14);
                    Convert.ToString(cont);
                    labelxi.Text = "f(" + cont + "):";
                    l2[i] = labelxi;
                    panel1.Controls.Add(l2[i]);
                    Convert.ToInt32(cont);
                    cont = cont + 1;
                }

                m = 0;
            }
        }
        int i, j;
        public static double factor;
        public static double fx;
        double x;
        public static double[] fxi;
        public static double[] xi;
        public static double[] fxx;

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            textBox1.Text = "";
            textBox3.Text = "";
            calcular.Left = calcular.Left - 120;
            button2.Left = button2.Left - 120;
            Siguiente.Enabled = true;
            calcular.Visible = false;
            button2.Visible = false;

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lagrange_Load(object sender, EventArgs e)
        {
            if (Principal.idioma == "en_usa")
            {
                label1.Text = "Grade";
                Siguiente.Text = "Next";
                titulo.Text = "Lagrange Interpolation Method";
                calcular.Text = "Calculate";
                button1.Text ="Close";
                    button2.Text ="Restart";
            }
            if (Principal.idioma == "esp_mx")
            {

            }
        }
        int logMove;
        int mvalx;
        int mvaly;
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

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            logMove = 1;
            mvalx = e.X;
            mvaly = e.Y;
        }

        private void salir_MouseEnter(object sender, EventArgs e)
        {
            salir.BackColor = Color.Red;
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            salir.BackColor = System.Drawing.Color.Transparent;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            bool xd;
            int v;
            double v2;
            fxi = new double[1000];
            xi = new double[1000];
            xd = true;
            for (i = 0; i < grado + 1; i++)
            {
                if (double.TryParse(cuadro[i].Text, out v2) != false && double.TryParse(cuadro2[i].Text, out v2) != false)
                {
                    xi[i] = Convert.ToDouble(cuadro[i].Text);
                    fxi[i] = Convert.ToDouble(cuadro2[i].Text);
                }
                else { xd = false; }
            }
            if (xd == false)
            {
                MessageBox.Show("Valor no numerico, verifique los datos..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (xd == true)
            {
               


                if (string.IsNullOrWhiteSpace(textBox1.Text)) { textBox3.Text = "1"; }

                grado = Convert.ToInt32(textBox1.Text);

                if (string.IsNullOrWhiteSpace(textBox3.Text)) { textBox3.Text = "1"; }

                x = Convert.ToDouble(textBox3.Text);
                //Operaciones
                fxx = new double[1000];
                int g = 0;
                for (int k = 0; k < grado + 1; k++)
                {
                    fx = 0;
                    for (i = 0; i < g + 1; i++)
                    {
                        factor = fxi[i];

                        for (j = 0; j < g + 1; j++)
                        {
                            if (i != j)
                            {
                                factor = factor * (x - xi[j]) / (xi[i] - xi[j]);

                            }

                        }
                        fx = factor + fx;

                    }
                    g++;
                    fxx[k] = fx;
                }


                //x numero a interpolar
                //xi variable
                //fxi variable


                //tabla llenar datos
                dataGridView1.Visible = true;
                dataGridView1.RowCount = grado;
                dataGridView1.ColumnCount = 2;
                int contador = 1;
                for (j = 1; j <= dataGridView1.RowCount; j++)
                {
                    dataGridView1[1, j - 1].Value = Math.Round(fxx[j], 7);
                    dataGridView1[0, j - 1].Value = contador;
                    
                    contador++;
                }



            }
        }
    }
}
