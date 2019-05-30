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
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
            timer1.Enabled = true;//Habilita el control timer
        }

        int progreso;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progreso;
            if (progressBar1.Value == 100) {timer1.Stop(); Principal P = new Principal(); P.Show(); this.Hide(); }
            progreso += 2;
            label2.Text = progressBar1.Value.ToString() + "%";
           
            if (progressBar1.Value == 2)
            {
                label3.Text = "Iniciando Cubok Simulator...";
            }
            if (progressBar1.Value == 10)
            {
                label3.Text = "Recopilando información...";      
            }
            if (progressBar1.Value == 20)
            {
                label3.Text = "Cargando Imágenes...";
            }
            if (progressBar1.Value == 30)
            {
                label3.Text = "Cargando Materias...";
            }
             if (progressBar1.Value == 40)
            {
                label3.Text = "Cargando Temas...";
            }
            if (progressBar1.Value == 50)
            {
                label3.Text = "Cargando Contenido...";
            }
            if (progressBar1.Value == 60)
            {
                label3.Text = "Cargando Programa...";
            }
            if (progressBar1.Value == 70)
            {
                label3.Text = "Ajustes Finales...";
            }
 
        }
    }

}
