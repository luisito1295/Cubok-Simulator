namespace InterfazG
{
    partial class Menueb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menueb));
            this.temarioMet = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Button();
            this.temarioMet.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // temarioMet
            // 
            this.temarioMet.BackColor = System.Drawing.Color.Transparent;
            this.temarioMet.Controls.Add(this.button6);
            this.temarioMet.Controls.Add(this.button3);
            this.temarioMet.Controls.Add(this.button2);
            this.temarioMet.Controls.Add(this.button1);
            this.temarioMet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temarioMet.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temarioMet.Location = new System.Drawing.Point(0, 36);
            this.temarioMet.Name = "temarioMet";
            this.temarioMet.Size = new System.Drawing.Size(505, 451);
            this.temarioMet.TabIndex = 6;
            this.temarioMet.TabStop = false;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Location = new System.Drawing.Point(125, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(224, 58);
            this.button6.TabIndex = 10;
            this.button6.Text = "Cerrar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(125, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 58);
            this.button3.TabIndex = 7;
            this.button3.Text = "Puente Rectificador";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(125, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ley de Ohm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(125, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Resistencias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.TitleBar.Size = new System.Drawing.Size(505, 36);
            this.TitleBar.TabIndex = 5;
            // 
            // salir
            // 
            this.salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salir.BackgroundImage")));
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(454, 0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(51, 36);
            this.salir.TabIndex = 5;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            this.salir.MouseEnter += new System.EventHandler(this.salir_MouseEnter);
            this.salir.MouseLeave += new System.EventHandler(this.salir_MouseLeave);
            // 
            // Menueb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 487);
            this.Controls.Add(this.temarioMet);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menueb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menueb";
            this.Load += new System.EventHandler(this.Menueb_Load);
            this.temarioMet.ResumeLayout(false);
            this.TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox temarioMet;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button salir;
    }
}