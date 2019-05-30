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
    public partial class Gauss_Jordan : Form
    {
        public Gauss_Jordan()
        {
            InitializeComponent();
        }


        public static TextBox m;
        public static TextBox mb;
        public static Label la;
        public static Label[,] texto_pasos;
        public static TextBox[,] matriz;
        public static TextBox[,] matrizb;
        int inc = new int();
        public static int filas, columnas;
        public static int fil, col;
        public static double[,] laura = new double[1000, 1000];
        bool t;
        public int a2 = 0;
        public static int w = 2;
        public static double[] r_pasos = new double[100000];
        public static TextBox pasos_textbox;
        public static TextBox[,] tbox_pasos;
        public static Panel panel_pasos = new Panel();
        protected static double temp;
        public static int top_temp;
        public static int label_temp, label_temp2;
        public static int mtemp;
        public static int l = 0, l2 = 0;
        public static double[] l3 = new double[1000];

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static double[,] ll3 = new double[1000, 1000];
        private void Crear_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            panel1.Controls.Clear();

            t = Convert.ToBoolean(string.IsNullOrWhiteSpace(textBox1.Text));
            if (t == true) { button1.Enabled = false; }
            if (string.IsNullOrWhiteSpace(textBox1.Text)) { MessageBox.Show("Ingrese tamaño", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            matriz = new TextBox[1000, 1000];
            if (t == false)
            {
                filas = Int32.Parse(textBox1.Text);
                columnas = Int32.Parse(textBox1.Text) + 1;
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        m = new TextBox();
                        matriz[i, j] = m;//igualo el textbox array al textbox como referencia
                        panel1.Controls.Add(matriz[i, j]);
                        matriz[i, j].Top = 1 + (i * 25);//coordenadas
                        matriz[i, j].Left = 1 + (j * 40);
                        matriz[i, j].Width = 40;//tamaño
                        matriz[i, j].Height = 40;
                    }
                }
            }
            panel1.BackColor = System.Drawing.Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            textBox1.Clear();
            b_pasos.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            matrizb = new TextBox[1000, 1000];

            fil = Int32.Parse(textBox1.Text);
            col = Int32.Parse(textBox1.Text) + 1;
            tbox_pasos = new TextBox[1000, 1000];
            mtemp = 0;

            for (int i = 0; i < fil; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    mb = new TextBox();
                    matrizb[i, j] = mb;//igualo el textbox array al textbox como referencia
                    panel2.Controls.Add(matrizb[i, j]);
                    matrizb[i, j].Top = 1 + (i * 25);//coordenadas
                    matrizb[i, j].Left = 1 + (j * 40);
                    matrizb[i, j].Width = 40;//tamaño
                    matrizb[i, j].Height = 40;
                    matrizb[i, j].ReadOnly = true;


                }

            }
            panel_pasos.AutoScroll = true;
            //Lectura de datos ingresados
            // richTextBox1.Visible = true;

            richTextBox1.Text = "Matriz Inicial: \n";
            int contp = 1;
            int a = 1;
            texto_pasos = new Label[1000, 1000];
            panel_pasos.Controls.Clear();

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    //Inicializo texbox y lo igualo al array de textbox

                    if (string.IsNullOrWhiteSpace(matriz[i, j].Text))//pone 0 si se deja espacio en blanco
                    {
                        matriz[i, j].Text = "0";
                    }
                    laura[i, j] = Convert.ToDouble(matriz[i, j].Text);//Se almacenan los datos ingresados en un array double
                    richTextBox1.Text = richTextBox1.Text + "   |   " + laura[i, j];
                    pasos_textbox = new TextBox();
                    tbox_pasos[i, j] = pasos_textbox;
                    panel_pasos.Controls.Add(tbox_pasos[i, j]);
                    tbox_pasos[i, j].Top = 40 + (i * 20);
                    tbox_pasos[i, j].Left = 10 + (j * 30);
                    top_temp = tbox_pasos[i, j].Top;
                    label_temp = top_temp;
                    tbox_pasos[i, j].Width = 30;
                    tbox_pasos[i, j].Height = 40;
                    tbox_pasos[i, j].ReadOnly = true;
                    tbox_pasos[i, j].Text = laura[i, j].ToString();
                }

            }

            la = new Label();
            panel_pasos.Controls.Add(la);
            la.Text = "Matriz Inicial..";
            la.Width = 500;
            la.BackColor = Color.Black;
            la.ForeColor = Color.White;
            la.Font = new Font("Arial", 14.0f);
            la.Top = 10;
            la.Left = 10;

            label_temp = label_temp + 30;

            label_temp2 = label_temp;
            //Operaciones

            //Diagonal de 1
            for (int fi = 0; fi < filas; fi++)
            {
                double frac = laura[fi, fi];

                for (int i = 0; i < columnas; i++) // se convierte en 1 la diagonal
                {
                    if (i == a2)
                    {
                        temp = laura[fi, i];
                    }
                    laura[fi, i] = laura[fi, i] / frac;
                    Math.Round(laura[fi, i], 3);
                }
                a2++;
                for (int i = 0; i < fil; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        r_pasos[mtemp] = laura[i, j];
                        mtemp++;
                    }
                }

                int f = fi + 1;

                if (f == filas) { f = 0; }


                for (int m = 0; m < 1; m++)
                {

                    la = new Label();


                    panel_pasos.Controls.Add(la);
                    la.Text = "Paso " + contp.ToString() + ": R" + a.ToString() + "= 1 / " + temp.ToString();
                    la.Width = 500;
                    la.BackColor = Color.Black;
                    la.ForeColor = Color.White;
                    la.Font = new Font("Arial", 14.0f);
                    la.Top = label_temp2;
                    la.Left = 10;
                    label_temp2 = label_temp2 + label_temp;
                    contp++;
                    a++;
                }
                l = 0; int p = 0; int p2 = 0;
                for (int k = 0; k < (col * fil); k++)
                {
                    if (p == fil - 1) { p = 0; p2++; }
                    if (p != p2)
                    {
                        l3[l] = laura[p, p2];
                        l++;
                    }
                    p++;
                }
                //0 abajos del 1
                for (int fila = 0; fila < filas - 1; fila++)
                {
                    double k = laura[f, fi];

                    for (int c = fi; c < columnas; c++)
                    {
                        Math.Round(laura[f, c], 3);
                        laura[f, c] = laura[f, c] - (k * laura[fi, c]);
                    }

                    if (f == filas - 1) { f = 0; }
                    else f++;
                }

                for (int i = 0; i < fil; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        r_pasos[mtemp] = laura[i, j];
                        mtemp++;
                    }
                }

                l = 0;
                for (int m = 0; m < 1; m++)
                {
                    la = new Label();

                    panel_pasos.Controls.Add(la);
                    la.Text = "Paso " + contp.ToString() + ": Se multiplico el R" + " por el R" + "" + " y se le resto al R";
                    la.Width = 500;
                    la.BackColor = Color.Black;
                    la.ForeColor = Color.White;
                    la.Font = new Font("Arial", 14.0f);
                    la.Top = label_temp2;
                    la.Left = 10;
                    label_temp2 = label_temp2 + label_temp;
                    contp++;
                    l++;


                }
                if (a == fil) { a = 1; }

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        matrizb[i, j].Text = Convert.ToString(laura[i, j]);
                        if (matrizb[i, j].Text == "NaN" || matrizb[i, j].Text == "-∞" || matrizb[i, j].Text == "∞" || matrizb[i, j].Text == "Null")
                        {
                            matrizb[i, j].Text = "0";
                        }

                    }
                }

            }
            int lu = 0;
            top_temp = top_temp + 70;
            for (int n = 0; n < (fil * 2); n++)
            {

                for (int i = 0; i < fil; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        pasos_textbox = new TextBox();
                        tbox_pasos[i, j] = pasos_textbox;
                        panel_pasos.Controls.Add(tbox_pasos[i, j]);
                        tbox_pasos[i, j].Top = top_temp;
                        tbox_pasos[i, j].Left = 10 + (j * 30);
                        top_temp = tbox_pasos[i, j].Top;
                        tbox_pasos[i, j].Width = 30;
                        tbox_pasos[i, j].Height = 40;
                        tbox_pasos[i, j].ReadOnly = true;
                        tbox_pasos[i, j].Text = r_pasos[lu].ToString();
                        if (tbox_pasos[i, j].Text == "NaN" || tbox_pasos[i, j].Text == "-∞" || tbox_pasos[i, j].Text == "∞" || tbox_pasos[i, j].Text == "Null")
                        {
                            tbox_pasos[i, j].Text = "0";
                        }
                        lu++;

                    }
                    top_temp = top_temp + 20;
                }
                top_temp = top_temp + 50;
  
                panel_pasos.Dock = DockStyle.Fill;
                panel_pasos.BackColor = System.Drawing.Color.Transparent;
            }
        }
    }
}
