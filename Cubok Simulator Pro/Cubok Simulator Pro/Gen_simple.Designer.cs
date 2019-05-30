namespace Cubok_Simulator_Pro
{
    partial class Gen_simple
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(24, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(357, 236);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo basico";
            // 
            // Others
            // 
            this.Others.Font = new System.Drawing.Font("Arial", 10F);
            this.Others.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Others.Location = new System.Drawing.Point(231, 200);
            this.Others.Margin = new System.Windows.Forms.Padding(4);
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
            this.limpiar.Location = new System.Drawing.Point(123, 200);
            this.limpiar.Margin = new System.Windows.Forms.Padding(4);
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
            this.label5.ForeColor = System.Drawing.Color.Black;
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
            this.linferior.Margin = new System.Windows.Forms.Padding(4);
            this.linferior.Name = "linferior";
            this.linferior.Size = new System.Drawing.Size(75, 30);
            this.linferior.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
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
            this.lsuperior.Margin = new System.Windows.Forms.Padding(4);
            this.lsuperior.Name = "lsuperior";
            this.lsuperior.Size = new System.Drawing.Size(75, 30);
            this.lsuperior.TabIndex = 1;
            // 
            // generar
            // 
            this.generar.Font = new System.Drawing.Font("Arial", 10F);
            this.generar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generar.Location = new System.Drawing.Point(15, 200);
            this.generar.Margin = new System.Windows.Forms.Padding(4);
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
            this.label1.ForeColor = System.Drawing.Color.Black;
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
            this.cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(75, 30);
            this.cantidad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Numeros aleatorios generados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 11;
            // 
            // numeros
            // 
            this.numeros.BackColor = System.Drawing.Color.Snow;
            this.numeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeros.Location = new System.Drawing.Point(24, 302);
            this.numeros.Margin = new System.Windows.Forms.Padding(4);
            this.numeros.Multiline = true;
            this.numeros.Name = "numeros";
            this.numeros.ReadOnly = true;
            this.numeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.numeros.Size = new System.Drawing.Size(356, 255);
            this.numeros.TabIndex = 12;
            // 
            // Gen_simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(390, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeros);
            this.Name = "Gen_simple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Números Aleatorios Simple";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button Others;
    }
}