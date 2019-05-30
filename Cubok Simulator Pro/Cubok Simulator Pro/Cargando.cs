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
    public partial class Cargando : Form
    {
        public Cargando()
        {
            InitializeComponent();
            timer1.Enabled = true;//Habilita el control timer
        }
       
        

        private void Cargando_Load(object sender, EventArgs e)
        {

        }
        int progreso;
        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value = progreso;
            progreso += 2;
            label2.Text = progressBar1.Value.ToString()+"%" ;
            if (progressBar1.Value == 100) { timer1.Enabled = false; }
            if (progressBar1.Value == 2)
            {
                label3.Text = "Iniciando Cubok Simulator...";
            }
            if (progressBar1.Value == 10)
            {
                label3.Text = "Cargando Imagenes...";
            }
            if (progressBar1.Value == 30)
            {
                label3.Text = "Cargando Materias...";
            }
            if (progressBar1.Value == 50)
            {
                label3.Text = "Cargando Contenido...";
            }
            if (progressBar1.Value == 70)
            {
                label3.Text = "Ajustes Finales...";
            }
        }
    }
}
