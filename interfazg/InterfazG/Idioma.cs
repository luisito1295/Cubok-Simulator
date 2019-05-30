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
    public partial class Idioma : Form
    {
        public Idioma()
        {
            InitializeComponent();
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

        private void Idioma_Load(object sender, EventArgs e)
        {
            this.Left = this.Left + 130;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Principal.idioma = "esp_mx";
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal.idioma = "en_usa";
            this.Close();

        }
    }
}