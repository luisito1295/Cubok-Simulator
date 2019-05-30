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
    public partial class res : Form
    {
        public res()
        {
            InitializeComponent();
        }

        int banda1,banda2,banda3;

        private void rojo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button5.BackColor = Color.Red;
            button5.Enabled = false;
            banda1 = 2;
        }

        private void naranja3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button5.BackColor = Color.Orange;
            button5.Enabled = false;
            banda1 = 3;
        }

        private void amarillo4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button5.BackColor = Color.Yellow;
            button5.Enabled = false;
            banda1 = 4;
        }

        private void verde5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button5.BackColor = Color.Green;
            button5.Enabled = false;
            banda1 = 5;
        }

        private void azul6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button5.BackColor = Color.Blue;
            button5.Enabled = false;
            banda1 = 6;
        }

        private void violeta7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button5.BackColor = Color.Violet;
            button5.Enabled = false;
            banda1 = 7;
        }

        private void gris8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button5.BackColor = Color.Gray;
            button5.Enabled = false;
            banda1 = 8;
        }

        private void blanco9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button5.BackColor = Color.White;
            button5.Enabled = false;
            banda1 = 9;
        }

        private void negro0ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Black;
            button1.Enabled = false;
            banda2 = 0;
        }

        private void café1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Brown;
            button1.Enabled = false;
            banda2 = 1;
        }

        private void rojo2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            banda2 = 2;
        }

        private void naranja3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Orange;
            button1.Enabled = false;
            banda2 = 3;
        }

        private void amarillo4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Yellow;
            button1.Enabled = false;
            banda2 = 4;
        }

        private void verde4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Green;
            button1.Enabled = false;
            banda2 = 5;
        }

        private void azul5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Blue;
            button1.Enabled = false;
            banda2 = 6;
        }

        private void violeta7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Violet;
            button1.Enabled = false;
            banda2 = 7;
        }

        private void gris8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Gray;
            button1.Enabled = false;
            banda2 = 8;
        }

        private void blanco9ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.White;
            button1.Enabled = false;
            banda2 = 9;
        }

        private void negro0ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.BackColor = Color.Black;
            button2.Enabled = false;
            banda3 = 1;
        }

        private void café1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.BackColor = Color.Brown;
            button2.Enabled = false;
            banda3 = 10;
        }

        private void rojo2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.BackColor = Color.Red;
            button2.Enabled = false;
            banda3 = 100;
        }

        private void naranja3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.BackColor = Color.Orange;
            button2.Enabled = false;
            banda3 = 1000;
        }

        private void amarillo4ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.BackColor = Color.Yellow;
            button2.Enabled = false;
            banda3 = 10000;
        }

        private void verde5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.BackColor = Color.Green;
            button2.Enabled = false;
            banda3 = 100000;
        }

        private void azul6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.BackColor = Color.Blue;
            button2.Enabled = false;
            banda3 = 1000000;
        }

        private void violeta7ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.BackColor = Color.Violet;
            button2.Enabled = false;
            banda3 = 10000000;
        }

        private void gris8ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.BackColor = Color.Gray;
            button2.Enabled = false;
            banda3 = 100000000;
        }

        private void blanco9ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.BackColor = Color.White;
            button2.Enabled = false;
            banda3 = 1000000000;
        }
        string banda4;
        private void dorado5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button3.BackColor = Color.Gold;
            button3.Enabled = false;
            banda4 = "dorado";
        }

        private void plata10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button3.BackColor = Color.Silver;
            button3.Enabled = false;
            banda4 = "plata";
        }
        string c;
        double y;
        private void button4_Click(object sender, EventArgs e)
        {
            c = banda1.ToString() + banda2.ToString();
            y = double.Parse(c) * banda3;
            if (banda3 == 10 || banda3 == 100)

            {
            label2.Text = "Ohm's";
            }



            if (banda4 == "dorado")
            {
                lab2.Text = "5% de tolerancia";
            }
            if(banda4=="plata"){ lab2.Text = "10% de tolerancia"; }

            lab1.Text = y.ToString()+" "+ " Ohm";
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void negro0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button5.BackColor = Color.Black;
            button5.Enabled = false;
            banda1 = 0;
        }

        private void café1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button5.BackColor = Color.Brown;
            button5.Enabled = false;
            banda1 = 1;
        }
    }
}
