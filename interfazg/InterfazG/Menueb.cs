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
    public partial class Menueb : Form
    {
        public Menueb()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salir_MouseEnter(object sender, EventArgs e)
        {
            salir.BackColor = Color.Red;
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            salir.BackColor = System.Drawing.Color.Transparent;
        }

        private void Menueb_Load(object sender, EventArgs e)
        {
            if (Principal.idioma == "en_usa")
            {
                button1.Text = "Resistance";
                button2.Text = "Ohm's law";
                button3.Text = "Bridge rectifier";
                button6.Text = "Close";
                this.Left = this.Left + 130;
            }
            if (Principal.idioma == "esp_mx")
            {
                button1.Text = "Resistencias";
                button2.Text = "Ley de Ohm";
                button3.Text = "Puente Rectificador";
                button6.Text = "Cerrar";
                this.Left = this.Left + 130;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res frm = new res();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ley_ohm lo = new ley_ohm();
            lo.Show();
        }
    }
}
