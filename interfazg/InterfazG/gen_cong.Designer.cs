namespace InterfazG
{
    partial class gen_cong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gen_cong));
            this.numeros = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.msg2 = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.Label();
            this.lineal = new System.Windows.Forms.RadioButton();
            this.multiplicador = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Semilla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Multi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cons = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeros
            // 
            this.numeros.Location = new System.Drawing.Point(22, 250);
            this.numeros.Multiline = true;
            this.numeros.Name = "numeros";
            this.numeros.ReadOnly = true;
            this.numeros.Size = new System.Drawing.Size(402, 166);
            this.numeros.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.msg2);
            this.groupBox1.Controls.Add(this.msg);
            this.groupBox1.Controls.Add(this.lineal);
            this.groupBox1.Controls.Add(this.multiplicador);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Cantidad);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.modulo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Semilla);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Multi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cons);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 204);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa todos los datos y elije una de las opciones";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(238, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Xn+1 = (aXn)  mod m";
            // 
            // msg2
            // 
            this.msg2.AutoSize = true;
            this.msg2.BackColor = System.Drawing.Color.Yellow;
            this.msg2.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.msg2.Location = new System.Drawing.Point(147, 115);
            this.msg2.Name = "msg2";
            this.msg2.Size = new System.Drawing.Size(196, 17);
            this.msg2.TabIndex = 18;
            this.msg2.Text = "mayor a los demás valores";
            this.msg2.Visible = false;
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.BackColor = System.Drawing.Color.Yellow;
            this.msg.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.msg.Location = new System.Drawing.Point(130, 20);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(161, 17);
            this.msg.TabIndex = 17;
            this.msg.Text = "ingrese cuatro digitos";
            this.msg.Visible = false;
            // 
            // lineal
            // 
            this.lineal.AutoSize = true;
            this.lineal.Location = new System.Drawing.Point(242, 40);
            this.lineal.Name = "lineal";
            this.lineal.Size = new System.Drawing.Size(150, 22);
            this.lineal.TabIndex = 9;
            this.lineal.TabStop = true;
            this.lineal.Text = "Congruencial lineal";
            this.lineal.UseVisualStyleBackColor = true;
            this.lineal.CheckedChanged += new System.EventHandler(this.lineal_CheckedChanged);
            this.lineal.Click += new System.EventHandler(this.lineal_Click);
            // 
            // multiplicador
            // 
            this.multiplicador.AutoSize = true;
            this.multiplicador.Location = new System.Drawing.Point(242, 100);
            this.multiplicador.Name = "multiplicador";
            this.multiplicador.Size = new System.Drawing.Size(109, 22);
            this.multiplicador.TabIndex = 10;
            this.multiplicador.TabStop = true;
            this.multiplicador.Text = "Multiplicador";
            this.multiplicador.UseVisualStyleBackColor = true;
            this.multiplicador.CheckedChanged += new System.EventHandler(this.multiplicador_CheckedChanged);
            this.multiplicador.Click += new System.EventHandler(this.multiplicador_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(238, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Xn+1 = (aXn + c)  mod m";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(151, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Numeros de valores a generar";
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(91, 156);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(57, 24);
            this.Cantidad.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(154, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "a";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(154, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "c";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Xo";
            // 
            // modulo
            // 
            this.modulo.Location = new System.Drawing.Point(91, 124);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(57, 24);
            this.modulo.TabIndex = 9;
            this.modulo.Enter += new System.EventHandler(this.modulo_Enter);
            this.modulo.Leave += new System.EventHandler(this.modulo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Semilla";
            // 
            // Semilla
            // 
            this.Semilla.Location = new System.Drawing.Point(91, 38);
            this.Semilla.MaxLength = 4;
            this.Semilla.Name = "Semilla";
            this.Semilla.Size = new System.Drawing.Size(57, 24);
            this.Semilla.TabIndex = 0;
            this.Semilla.Enter += new System.EventHandler(this.Semilla_Enter);
            this.Semilla.Leave += new System.EventHandler(this.Semilla_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Multiplicador";
            // 
            // Multi
            // 
            this.Multi.Location = new System.Drawing.Point(91, 67);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(57, 24);
            this.Multi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Constante";
            // 
            // Cons
            // 
            this.Cons.Location = new System.Drawing.Point(91, 98);
            this.Cons.Name = "Cons";
            this.Cons.Size = new System.Drawing.Size(57, 24);
            this.Cons.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 10;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(258, 155);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 11;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
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
            this.TitleBar.Size = new System.Drawing.Size(451, 36);
            this.TitleBar.TabIndex = 14;
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
            this.salir.Location = new System.Drawing.Point(400, 0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(51, 36);
            this.salir.TabIndex = 5;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            this.salir.MouseEnter += new System.EventHandler(this.salir_MouseEnter);
            this.salir.MouseLeave += new System.EventHandler(this.salir_MouseLeave);
            // 
            // gen_cong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 426);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.numeros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.limpiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gen_cong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gen_cong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label msg2;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.RadioButton lineal;
        private System.Windows.Forms.RadioButton multiplicador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Semilla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Multi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button salir;
    }
}