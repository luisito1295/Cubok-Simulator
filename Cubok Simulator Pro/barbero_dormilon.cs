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
    public partial class barbero_dormilon : Form
    {
        public barbero_dormilon()
        {
            InitializeComponent();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            if (iniciar.Text == "Iniciar")
            {
                iniciar.BackColor = Color.Red;
                iniciar.Text = "Detener";
                procesos.Enabled = true;
                cliente.Top = 8;
                cliente.Left = 83;
            }
            else
            {
                iniciar.BackColor = Color.Green;
                iniciar.Text = "Iniciar";
                procesos.Enabled = false;
                proseso2.Enabled = false;
                proseso3.Enabled = false;
                proseso3.Enabled = false;
                cliente.Left = 83;
                cliente.Top = 8;

            }


            //Random rnd = new Random();
            /*

            cliente.Location = new Point();
            this.cliente.Location = new System.Drawing.Point(83, 100);
            // tomar la decisión...
            Random rnd = new Random();
            int es = rnd.Next(0, 1);

            //result.Text = es;
            if (es == 0)
            {
                // decide sientra o se va.....
                // decide irse
                cliente.Location = new Point();
                this.cliente.Location = new System.Drawing.Point(153, 100);

            }
            else
            {
                cliente.Location = new Point();
                this.cliente.Location = new System.Drawing.Point(83, 120);

            }*/
        }

        private void procesos_Tick(object sender, EventArgs e)
        {
            if (cliente.Top != 100)
            {
                cliente.Top = cliente.Top + 1;//Mover vertical

            }
            else
            {
                // cliente entra???
                Random rnd = new Random();
                int es = rnd.Next(0, 2);

                if (es == 1)
                {
                    proseso2.Enabled = true;

                }
                else
                {
                    proseso3.Enabled = true;
                }

                procesos.Enabled = false;

            }
        }

        private void proseso2_Tick(object sender, EventArgs e)
        {
            if (cliente.Left != 200)
            {
                cliente.Left = cliente.Left + 1;//Mover a la derecha
                dormilon.Visible = false;

            }
            else
            {
                dormilon.Visible = true;
                proseso2.Enabled = false;
                proseso4.Enabled = true;
                procesos.Enabled = true;
            }
        }

        private void proseso3_Tick(object sender, EventArgs e)
        {
            if (cliente.Top != 190)
            {
                cliente.Top = cliente.Top + 1;//Mover vertical

            }
            else
            {
                proseso4.Enabled = true;
                proseso3.Enabled = false;

            }
        }

        private void proseso4_Tick(object sender, EventArgs e)
        {
            cliente.Top = 8;
            cliente.Left = 83;
            procesos.Enabled = true;
            proseso4.Enabled = false;
        }

        private void barbero_dormilon_Load(object sender, EventArgs e)
        {

        }
    }
}
