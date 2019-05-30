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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        public static string id = "esp_mx";
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(140, 140, 140);
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.BackColor = System.Drawing.Color.FromArgb(140, 140, 140);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = System.Drawing.Color.FromArgb(140, 140, 140);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = System.Drawing.Color.FromArgb(140, 140, 140);
        }

       

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = System.Drawing.Color.Transparent;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = System.Drawing.Color.Transparent;
        }

      

        private void Principal_Load(object sender, EventArgs e)
        {
            if (id == "esp_mx")
            {
              
                label3.Text = "Simulación";
                label4.Text = " Ecuaciones \nDiferenciales";
                label1.Text = " Métodos \nNuméricos";
                label6.Text = "Electronica \n  Básica";
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Menu_Numericos m = new Menu_Numericos();
            m.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu__simu s = new Menu__simu();
            s.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu_Ecuaciones m = new Menu_Ecuaciones();
            m.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            EB.menu v = new EB.menu();
            v.ShowDialog();
        }
    }
}
