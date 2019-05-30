namespace InterfazG
{
    partial class Gauss_jordan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gauss_jordan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.b_pasos = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Crear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.b_pasos);
            this.groupBox1.Controls.Add(this.titulo);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Crear);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(364, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 48);
            this.button3.TabIndex = 36;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // b_pasos
            // 
            this.b_pasos.BackColor = System.Drawing.Color.DarkOrange;
            this.b_pasos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_pasos.Enabled = false;
            this.b_pasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pasos.Location = new System.Drawing.Point(364, 232);
            this.b_pasos.Name = "b_pasos";
            this.b_pasos.Size = new System.Drawing.Size(127, 48);
            this.b_pasos.TabIndex = 35;
            this.b_pasos.Text = "Ver Pasos";
            this.b_pasos.UseVisualStyleBackColor = false;
            this.b_pasos.Visible = false;
            this.b_pasos.Click += new System.EventHandler(this.b_pasos_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titulo.Location = new System.Drawing.Point(255, 39);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(310, 31);
            this.titulo.TabIndex = 34;
            this.titulo.Text = "Metodo De Gauss Jordan";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(14, 410);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(124, 31);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(364, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 48);
            this.button2.TabIndex = 32;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(364, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 48);
            this.button1.TabIndex = 31;
            this.button1.Text = "Resolver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(527, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 232);
            this.panel2.TabIndex = 30;
            this.panel2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(37, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 29);
            this.textBox1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(100, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tamaño";
            // 
            // Crear
            // 
            this.Crear.BackColor = System.Drawing.Color.DarkOrange;
            this.Crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crear.Location = new System.Drawing.Point(231, 112);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(127, 48);
            this.Crear.TabIndex = 27;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = false;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 232);
            this.panel1.TabIndex = 26;
            this.panel1.Visible = false;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TitleBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitleBar.BackgroundImage")));
            this.TitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitleBar.Controls.Add(this.salir);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(877, 36);
            this.TitleBar.TabIndex = 3;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // salir
            // 
            this.salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salir.BackgroundImage")));
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(826, 0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(51, 36);
            this.salir.TabIndex = 5;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            this.salir.MouseEnter += new System.EventHandler(this.salir_MouseEnter);
            this.salir.MouseLeave += new System.EventHandler(this.salir_MouseLeave);
            // 
            // Gauss_jordan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 447);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gauss_jordan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gauss_jordan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_pasos;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
    }
}