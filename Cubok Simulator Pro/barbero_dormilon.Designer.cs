namespace Cubok_Simulator_Pro
{
    partial class barbero_dormilon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barbero_dormilon));
            this.dormilon = new System.Windows.Forms.PictureBox();
            this.iniciar = new System.Windows.Forms.Button();
            this.cliente = new System.Windows.Forms.PictureBox();
            this.barbero = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            this.procesos = new System.Windows.Forms.Timer(this.components);
            this.proseso2 = new System.Windows.Forms.Timer(this.components);
            this.proseso3 = new System.Windows.Forms.Timer(this.components);
            this.proseso4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dormilon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            this.SuspendLayout();
            // 
            // dormilon
            // 
            this.dormilon.Image = ((System.Drawing.Image)(resources.GetObject("dormilon.Image")));
            this.dormilon.Location = new System.Drawing.Point(225, 13);
            this.dormilon.Margin = new System.Windows.Forms.Padding(4);
            this.dormilon.Name = "dormilon";
            this.dormilon.Size = new System.Drawing.Size(251, 116);
            this.dormilon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dormilon.TabIndex = 9;
            this.dormilon.TabStop = false;
            // 
            // iniciar
            // 
            this.iniciar.BackColor = System.Drawing.Color.Green;
            this.iniciar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.ForeColor = System.Drawing.Color.White;
            this.iniciar.Location = new System.Drawing.Point(445, 224);
            this.iniciar.Margin = new System.Windows.Forms.Padding(4);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(97, 34);
            this.iniciar.TabIndex = 8;
            this.iniciar.Text = "Iniciar";
            this.iniciar.UseVisualStyleBackColor = false;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // cliente
            // 
            this.cliente.Image = ((System.Drawing.Image)(resources.GetObject("cliente.Image")));
            this.cliente.Location = new System.Drawing.Point(100, 5);
            this.cliente.Margin = new System.Windows.Forms.Padding(4);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(43, 57);
            this.cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cliente.TabIndex = 6;
            this.cliente.TabStop = false;
            // 
            // barbero
            // 
            this.barbero.Image = ((System.Drawing.Image)(resources.GetObject("barbero.Image")));
            this.barbero.Location = new System.Drawing.Point(225, 13);
            this.barbero.Margin = new System.Windows.Forms.Padding(4);
            this.barbero.Name = "barbero";
            this.barbero.Size = new System.Drawing.Size(251, 116);
            this.barbero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barbero.TabIndex = 5;
            this.barbero.TabStop = false;
            // 
            // line
            // 
            this.line.Image = ((System.Drawing.Image)(resources.GetObject("line.Image")));
            this.line.Location = new System.Drawing.Point(160, -11);
            this.line.Margin = new System.Windows.Forms.Padding(4);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(33, 326);
            this.line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.line.TabIndex = 7;
            this.line.TabStop = false;
            // 
            // procesos
            // 
            this.procesos.Tick += new System.EventHandler(this.procesos_Tick);
            // 
            // proseso2
            // 
            this.proseso2.Tick += new System.EventHandler(this.proseso2_Tick);
            // 
            // proseso3
            // 
            this.proseso3.Tick += new System.EventHandler(this.proseso3_Tick);
            // 
            // proseso4
            // 
            this.proseso4.Interval = 700;
            this.proseso4.Tick += new System.EventHandler(this.proseso4_Tick);
            // 
            // barbero_dormilon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 298);
            this.Controls.Add(this.dormilon);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.barbero);
            this.Controls.Add(this.line);
            this.Name = "barbero_dormilon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación de Procesos";
            this.Load += new System.EventHandler(this.barbero_dormilon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dormilon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dormilon;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.PictureBox cliente;
        private System.Windows.Forms.PictureBox barbero;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.Timer procesos;
        private System.Windows.Forms.Timer proseso2;
        private System.Windows.Forms.Timer proseso3;
        private System.Windows.Forms.Timer proseso4;
    }
}