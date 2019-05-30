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

    public partial class Principal : Form
    {
        int logMove;
        int mvalx;
        int mvaly;
        public Principal()
        {
            InitializeComponent();
            timer1.Enabled = true;//Habilita el control timer
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string idioma = "esp_mx";

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            salir.BackColor = System.Drawing.Color.Transparent;
        }

        private void salir_MouseEnter(object sender, EventArgs e)
        {
            salir.BackColor = Color.Red;
        }

        private void maximizar_MouseEnter(object sender, EventArgs e)
        {
            maximizar.BackColor = Color.Red;
        }

        private void maximizar_MouseLeave(object sender, EventArgs e)
        {
            maximizar.BackColor = System.Drawing.Color.Transparent;
        }

        private void minimizar_MouseEnter(object sender, EventArgs e)
        {
            minimizar.BackColor = Color.Red;
        }

        private void minimizar_MouseLeave(object sender, EventArgs e)
        {
            minimizar.BackColor = System.Drawing.Color.Transparent;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
        }

        private void panel_salir_MouseEnter(object sender, EventArgs e)
        {
        }

        private void panel_salir_MouseLeave(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void Principal_Load(object sender, EventArgs e)
        {
            panel_tiempo.BackgroundImage = TitleBar.BackgroundImage;
            flowLayoutPanel1.Visible = true;
            richTextBox1.Text = "                                   Cubok Simulator\n\nIntegrantes:\n\nCamacho Valdez Hernan Mitchel\n\nLópez Mendoza Luis Fernando\n\nMagaña Olea Brenda Cecilia\n\nUreña Fletes Cristhian Eduardo";
            label11.Text = richTextBox1.Text;
        }
        int seg = 0, min = 0, hora = 0,miliseg=0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            
            if (idioma == "esp_mx") {
                hora_actual.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss tt");
                fecha_actual.Text = "Fecha: " + DateTime.Now.ToString("d");
                label12.Text = "Tiempo Transcurrido: " + hora.ToString() + ":" + min.ToString() + ":" + seg.ToString();
            }
            if (idioma == "en_usa") {
                hora_actual.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss tt");
                fecha_actual.Text = "Date: " + DateTime.Now.ToString("d");
                label12.Text = "Time Elapsed: " + hora.ToString() + ":" + min.ToString() + ":" + seg.ToString();
            }
            miliseg+=6;
            if (miliseg == 60) { seg++; miliseg = 0; }
            if (seg==60) { seg = 0;min++; }
            if (min == 60) { min = 0; hora++; }
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void TitleBar_MouseClick(object sender, MouseEventArgs e)
        {

        }

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

        private void panel_contacto_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox8_MouseEnter_1(object sender, EventArgs e)
        {
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
        }
        RichTextBox d_ayuda = new RichTextBox();
        private void b_ayuda_Click(object sender, EventArgs e)
        {
        }

        private void b_salir_MouseEnter(object sender, EventArgs e)
        {

        }

        private void b_mn_Click(object sender, EventArgs e)
        {

        }

        private void b_salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static int op = 0;
        private void b_ed_Click(object sender, EventArgs e)
        {
            op = 1;

        }

        private void b_eb_Click(object sender, EventArgs e)
        {
            op = 2;
            label6.Invalidate();


        }

        private void b_idioma_Click(object sender, EventArgs e)
        {
            op = 3;
        }

        private void b_simu_Click(object sender, EventArgs e)
        {
            op = 5;

        }

        private void b_mn_Click_1(object sender, EventArgs e)
        {
            op = 4;

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            op = 0;

        }

        private void b_ayuda_Click_1(object sender, EventArgs e)
        {
            op = 6;
        }

        private void b_contacto_Click(object sender, EventArgs e)
        {
            op = 7;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.Brown;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void label6_Paint(object sender, PaintEventArgs e)
        {

            Font o = label6.Font;
            //Español
            if (idioma == "esp_mx")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("Inicio", o, aBrush, ClientRectangle);
                }
            }
            //ingles
            if (idioma == "en_usa")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString(" Home", o, aBrush, ClientRectangle);
                }
            }
        }

        private void label10_Paint(object sender, PaintEventArgs e)
        {
            Font o = label10.Font;
            //Español
            if (idioma == "esp_mx")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString(" Idioma", o, aBrush, ClientRectangle);
                }
            }
            //Ingles
            if (idioma == "en_usa")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("Language", o, aBrush, ClientRectangle);
                }
            }
        }

        private void label7_Paint(object sender, PaintEventArgs e)
        {
            Font o = label7.Font;
            //español
            if (idioma == "esp_mx")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("     Ecuaciones\n    Diferenciales", o, aBrush, ClientRectangle);
                }
            }
            //ingles
            if (idioma == "en_usa")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("      Differential\n       Equations", o, aBrush, ClientRectangle);
                }
            }
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Font o = label7.Font;
            //español
            if (idioma == "esp_mx")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("     Electrónica\n        Básica", o, aBrush, ClientRectangle);
                }
            }
            //ingles
            if (idioma == "en_usa")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("         Basic\n      Electronic", o, aBrush, ClientRectangle);
                }
            }
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            Font o = label2.Font;
            if (idioma == "esp_mx")
            {

                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("   Simulación", o, aBrush, ClientRectangle);
                }
            }
            //ingless
            if (idioma == "en_usa")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("    Simulation", o, aBrush, ClientRectangle);
                }
            }
        }

        private void label4_Paint(object sender, PaintEventArgs e)
        {
            Font o = label4.Font;
            //español
            if (idioma == "esp_mx")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("     Metodos\n   Numéricos", o, aBrush, ClientRectangle);
                }
            }
            //ingless
            if (idioma == "en_usa")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("      Numeric\n      Methods", o, aBrush, ClientRectangle);
                }
            }
        }

        private void label3_Paint(object sender, PaintEventArgs e)
        {
            Font o = label3.Font;
            //español
            if (idioma == "esp_mx")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("         Salir", o, aBrush, ClientRectangle);
                }
            }
            //ingless
            if (idioma == "en_usa")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("        Exit", o, aBrush, ClientRectangle);
                }
            }
        }

        private void label9_Paint(object sender, PaintEventArgs e)
        {
            Font o = label9.Font;
            //espñol
            if (idioma == "esp_mx")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("         Ayuda", o, aBrush, ClientRectangle);
                }
            }
            //ingless
            if (idioma == "en_usa")
            {
                using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
                {
                    e.Graphics.DrawString("        Help", o, aBrush, ClientRectangle);
                }
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
        }

        private void panel7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = System.Drawing.Color.Brown;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = System.Drawing.Color.Brown;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = System.Drawing.Color.Brown;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = System.Drawing.Color.Brown;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = System.Drawing.Color.Brown;
        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = System.Drawing.Color.Brown;
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            panel8.BackColor = System.Drawing.Color.Brown;
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = System.Drawing.Color.DarkCyan;
        }


        private void label5_Paint_1(object sender, PaintEventArgs e)
        {
            Font o = label5.Font;
            using (Brush aBrush = new SolidBrush(SystemColors.ControlText))
            {
                e.Graphics.DrawString("Ver temas", o, aBrush, ClientRectangle);
            }
        }

        private void panel9_MouseEnter(object sender, EventArgs e)
        {
            panel9.BackColor = System.Drawing.Color.Brown;
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = System.Drawing.Color.LightBlue;
        }
        public static string materia;
        private void panel6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Metodos Numericos:\n\nEs la rama de las matemáticas encargada de diseñar \nalgoritmos para, a través de números y reglas \nmatemáticas simples, simular procesos matemáticos \nmás complejos aplicados a procesos del mundo real.";
            label11.Text = richTextBox1.Text;
            materia = "mn";
            flowLayoutPanel1.Visible = true;
            panel9.Visible = true;

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "                                   Cubok Simulator\n\nIntegrantes:\n\nCamacho Valdez Hernan Mitchel\n\nLópez Mendoza Luis Fernando\n\nMagaña Olea Brenda Cecilia\n\nUreña Fletes Cristhian Eduardo";
            label11.Text = richTextBox1.Text;
            materia = "ini";
            panel9.Visible = false;
            flowLayoutPanel1.Visible = true;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Idioma id = new Idioma();
            id.ShowDialog();
            flowLayoutPanel1.Visible = false;
            Principal.ActiveForm.Enabled = false;


        }

        private void Principal_EnabledChanged(object sender, EventArgs e)
        {
            Principal.ActiveForm.Enabled = true;
            

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            if (materia == "mn")
            {
                MenuMnum menu = new MenuMnum();
                menu.ShowDialog();
            }
            if (materia == "eb")
            {
                Menueb menu = new Menueb();
                menu.ShowDialog();
            }
            if (materia == "ed")
            {
                MenuEd menu = new MenuEd();
                menu.ShowDialog();
            }
            if (materia == "sim")
            {
                Generador menu = new Generador();
                menu.Show();
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Electronica Básica\n\nLa electronica en el campo de la ingenieria,se encarga\ndel desarrollo y el analisis de sistemas, por lo general \ncircuitos electronicos, cuyo funcionamiento depende \ndel flujo de electrones para la generacion, transmision,\nrecepcion y almacenamiento de informacion. \nEsta información puede consistir en voz o música\n(señales de voz) en un receptor de radio,en una imagen \nen una pantalla de televisión, o en números u otros datos \nen un ordenador o computadora.";
            label11.Text = richTextBox1.Text;
            materia = "eb";
            flowLayoutPanel1.Visible = true;
            panel9.Visible = true;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Ecuaciones Diferenciales:\n\nUna ecuación diferencial es una ecuación matemática \nque relaciona una función con sus derivadas matemáticas \naplicadas, las funciones usualmente representan \ncantidades físicas, las derivadas representan sus razones \nde cambio, y la ecuación define la relación entre ellas. \nComo estas relaciones son muy comunes, las ecuaciones \ndiferenciales juegan un rol primordial en muchas disciplinas, \nincluyendo la ingeniería, la física, la economía y la biología.";
            label11.Text = richTextBox1.Text;
            materia = "ed";
            flowLayoutPanel1.Visible = true;
            panel9.Visible = true;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Simulacion\n\nEs una técnica numérica para conducir experimentos en \nuna computadora digital. Estos experimentos comprenden \nciertos tipos de relaciones matemáticas y lógicas, las \ncuales son necesarias para describir el comportamiento y la \nestructura de sistemas complejos del mundo real a través \nde largos períodos";
            label11.Text = richTextBox1.Text;
            materia = "sim";
            flowLayoutPanel1.Visible = true;
            panel9.Visible = true;
        }
    }
}
