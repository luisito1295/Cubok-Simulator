﻿using System;
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
    public partial class ohm : Form
    {
        public ohm()
        {
            InitializeComponent();
        }


        double r1, r2, r3, voltaje, Rt, i, calcular, l1, l2, l3;
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                r1 = double.Parse(tb1.Text);
                r2 = double.Parse(tb2.Text);
                r3 = double.Parse(tb3.Text);

                lab1.Text = r1.ToString();
                lab2.Text = r2.ToString();
                lab3.Text = r3.ToString();

                lab11.Text = r1.ToString();
                lab22.Text = r2.ToString();
                lab33.Text = r3.ToString();

                lab11.Text = l1.ToString();
                lab22.Text = l2.ToString();
                lab33.Text = l3.ToString();



                voltaje = double.Parse(tb5.Text);

                Rt = r1 + r2 + r3;


                lb15.Text = Rt.ToString();
                lab44.Text = Rt.ToString();
                lab11.Text = r1.ToString();
                lab22.Text = r2.ToString();
                lab33.Text = r3.ToString();
                lab55.Text = voltaje.ToString();
                labrt.Text = Rt.ToString();
                labresultado.Text = calcular.ToString();

                calcular = voltaje / Rt;
                lb16.Text = calcular.ToString("0.00");
                label5.Text = voltaje.ToString();

            }
            catch { MessageBox.Show("Datos incorrectos, Verificar","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void b4_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            lb15.Text = "";
            tb5.Clear();
            lb16.Text = "";
            lab1.Text="";
            lab2.Text = ""; 
            lab3.Text = "";
            label5.Text = "";

        }

        private void b5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lab3_Click(object sender, EventArgs e)
        {

        }

        public static int b = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (b == 0)
            {
                groupBox1.Visible = true;
                b = 1;
            }
            else 
            {
                groupBox1.Visible = false;
                b=0;
            }

        }

        private void tb6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
