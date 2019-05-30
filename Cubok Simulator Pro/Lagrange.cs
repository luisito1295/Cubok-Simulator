using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;
using System.Windows.Forms;

namespace Cubok_Simulator_Pro
{
    public partial class Lagrange : Form
    {
        public Lagrange()
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
            if (int.TryParse(textBox1.Text, out v) == false )
            {
                MessageBox.Show("Grado del polinomio incorrecto, Ingresa solo numeros!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text) == true) {
                MessageBox.Show("Ingrese una Funcion Valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (int.TryParse(textBox1.Text, out v) != false && string.IsNullOrWhiteSpace(textBox2.Text)==false)
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
               // this.Height = 289 + 350;
            }
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
            chart1.Visible = true;
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

                chart1.Series["Series1"].Points.Clear();
                ExpressionParser p = new ExpressionParser();
                p.Values.Add("x",0);
                string func = textBox2.Text;
                chart1.Series["Series1"].Points.AddXY(0,0);
                for (double i = 1; i <= 10; i+=1)
                {

              //      if (i == 1) { chart1.Series["Series1"].Points.AddXY(0,0); }
                    p.Values["x"].SetValue(i);
                    double lol = p.Parse(func);
                    chart1.Series["Series1"].Points.AddY(lol);
                    
                }


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
                //this.Width = 500+550;

            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lagrange_Load(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            panel1.Controls.Clear();
            textBox1.Text = "";
            textBox3.Text = "";
            Siguiente.Enabled = true;
            calcular.Visible = false;
            button2.Visible = false;
            chart1.Series["Series1"].Points.Clear();
          //  this.Height = 289;
            //this.Width = 600;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            panel1.Visible = false;
        }
    }
}
