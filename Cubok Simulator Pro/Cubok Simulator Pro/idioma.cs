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
    public partial class idioma : Form
    {
        public idioma()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Principal.id = "esp_mx";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal.id = "en_usa";
        }
    }
}
