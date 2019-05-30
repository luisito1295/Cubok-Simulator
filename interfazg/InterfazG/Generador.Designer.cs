namespace InterfazG
{
    partial class Generador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generador));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Button();
            this.temarioMet = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Others = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linferior = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lsuperior = new System.Windows.Forms.TextBox();
            this.generar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeros = new System.Windows.Forms.TextBox();
            this.TitleBar.SuspendLayout();
            this.temarioMet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TitleBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitleBar.BackgroundImage")));
            this.TitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitleBar.Controls.Add(this.salir);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(463, 44);
            this.TitleBar.TabIndex = 8;
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
            this.salir.Location = new System.Drawing.Point(395, 0);
            this.salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(68, 44);
            this.salir.TabIndex = 5;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            this.salir.MouseEnter += new System.EventHandler(this.salir_MouseEnter);
            this.salir.MouseLeave += new System.EventHandler(this.salir_MouseLeave);
            // 
            // temarioMet
            // 
            this.temarioMet.BackColor = System.Drawing.Color.Transparent;
            this.temarioMet.Controls.Add(this.groupBox1);
            this.temarioMet.Controls.Add(this.label3);
            this.temarioMet.Controls.Add(this.label2);
            this.temarioMet.Controls.Add(this.numeros);
            this.temarioMet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temarioMet.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temarioMet.Location = new System.Drawing.Point(0, 44);
            this.temarioMet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temarioMet.Name = "temarioMet";
            this.temarioMet.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temarioMet.Size = new System.Drawing.Size(463, 587);
            this.temarioMet.TabIndex = 9;
            this.temarioMet.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Others);
            this.groupBox1.Controls.Add(this.limpiar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.linferior);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lsuperior);
            this.groupBox1.Controls.Add(this.generar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cantidad);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(44, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(357, 236);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo basico";
            // 
            // Others
            // 
            this.Others.Font = new System.Drawing.Font("Arial", 10F);
            this.Others.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Others.Location = new System.Drawing.Point(13, 193);
            this.Others.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Others.Name = "Others";
            this.Others.Size = new System.Drawing.Size(100, 28);
            this.Others.TabIndex = 8;
            this.Others.Text = "Otros,,,,";
            this.Others.UseVisualStyleBackColor = true;
            this.Others.Click += new System.EventHandler(this.Others_Click);
            // 
            // limpiar
            // 
            this.limpiar.Font = new System.Drawing.Font("Arial", 10F);
            this.limpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.limpiar.Location = new System.Drawing.Point(240, 193);
            this.limpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(100, 28);
            this.limpiar.TabIndex = 7;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Intervalo Inferior";
            // 
            // linferior
            // 
            this.linferior.Location = new System.Drawing.Point(165, 39);
            this.linferior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linferior.Name = "linferior";
            this.linferior.Size = new System.Drawing.Size(75, 38);
            this.linferior.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Intervalo superior";
            // 
            // lsuperior
            // 
            this.lsuperior.Location = new System.Drawing.Point(165, 90);
            this.lsuperior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsuperior.Name = "lsuperior";
            this.lsuperior.Size = new System.Drawing.Size(75, 38);
            this.lsuperior.TabIndex = 1;
            // 
            // generar
            // 
            this.generar.Font = new System.Drawing.Font("Arial", 10F);
            this.generar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generar.Location = new System.Drawing.Point(132, 193);
            this.generar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(100, 28);
            this.generar.TabIndex = 3;
            this.generar.Text = "Generar";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(97, 143);
            this.cantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(75, 38);
            this.cantidad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numeros aleatorios generados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 7;
            // 
            // numeros
            // 
            this.numeros.Font = new System.Drawing.Font("Arial", 10F);
            this.numeros.Location = new System.Drawing.Point(44, 316);
            this.numeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeros.Multiline = true;
            this.numeros.Name = "numeros";
            this.numeros.ReadOnly = true;
            this.numeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.numeros.Size = new System.Drawing.Size(356, 255);
            this.numeros.TabIndex = 8;
            // 
            // Generador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 631);
            this.Controls.Add(this.temarioMet);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Generador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador";
            this.Load += new System.EventHandler(this.Generador_Load);
            this.TitleBar.ResumeLayout(false);
            this.temarioMet.ResumeLayout(false);
            this.temarioMet.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.GroupBox temarioMet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Others;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox linferior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lsuperior;
        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeros;
    }
}