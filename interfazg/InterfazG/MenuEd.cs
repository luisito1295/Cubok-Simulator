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
    public partial class MenuEd : Form
    {
        public MenuEd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CRL rl = new CRL();
            rl.Show();
        }

        private void MenuEd_Load(object sender, EventArgs e)
        {
            if (Principal.idioma == "en_usa")
            {
                button1.Text = "RC Circuit";
                button2.Text = "Rl Circuit";
                button3.Text = "Integration Factor";
                button6.Text = "Close";
                this.Left = this.Left + 130;
            }
            if (Principal.idioma == "esp_mx")
            {
                button1.Text = "Circuito Rc";
                button2.Text = "Circuito RL";
                button3.Text = "Factor de integración";
                button6.Text = "Cerrar";
                this.Left = this.Left + 130;
            }
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
    }
}
