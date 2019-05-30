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
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Métodos Numéricos")
            {
                comboBox2.Enabled = true;
                comboBox2.Text = "Elíja un Tema...";
                comboBox2.Items.Add("Regla del Trapecio");
                comboBox2.Items.Add("Método de Simpsom 1/3 y 3/8");
                comboBox2.Items.Add("Método de Gauss Jordan");
                comboBox2.Items.Add("Método de Lagrange");
                comboBox2.Items.Add("Método de Newton Rhapson");
            }

        }
    }
}
