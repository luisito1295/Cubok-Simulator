namespace InterfazG
{
    partial class MenuMnum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMnum));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.temarioMet = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            this.temarioMet.SuspendLayout();
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
            this.TitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(673, 44);
            this.TitleBar.TabIndex = 2;
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
            this.salir.Location = new System.Drawing.Point(605, 0);
            this.salir.Margin = new System.Windows.Forms.Padding(4);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(68, 44);
            this.salir.TabIndex = 5;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click_1);
            this.salir.MouseEnter += new System.EventHandler(this.salir_MouseEnter_1);
            this.salir.MouseLeave += new System.EventHandler(this.salir_MouseLeave_1);
            // 
            // temarioMet
            // 
            this.temarioMet.BackColor = System.Drawing.Color.Transparent;
            this.temarioMet.Controls.Add(this.button6);
            this.temarioMet.Controls.Add(this.button5);
            this.temarioMet.Controls.Add(this.button4);
            this.temarioMet.Controls.Add(this.button3);
            this.temarioMet.Controls.Add(this.button2);
            this.temarioMet.Controls.Add(this.button1);
            this.temarioMet.Dock = System.Windows.Forms.DockStyle.Left;
            this.temarioMet.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temarioMet.Location = new System.Drawing.Point(0, 44);
            this.temarioMet.Margin = new System.Windows.Forms.Padding(4);
            this.temarioMet.Name = "temarioMet";
            this.temarioMet.Padding = new System.Windows.Forms.Padding(4);
            this.temarioMet.Size = new System.Drawing.Size(669, 555);
            this.temarioMet.TabIndex = 4;
            this.temarioMet.TabStop = false;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Location = new System.Drawing.Point(168, 448);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(299, 71);
            this.button6.TabIndex = 10;
            this.button6.Text = "Cerrar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(167, 351);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(299, 71);
            this.button5.TabIndex = 9;
            this.button5.Text = "Método de Newton-Rhapson";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(167, 272);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(299, 71);
            this.button4.TabIndex = 8;
            this.button4.Text = "Método de Gauss-Seidel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(167, 193);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(299, 71);
            this.button3.TabIndex = 7;
            this.button3.Text = "Método de Gauss-Jordan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(167, 114);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 71);
            this.button2.TabIndex = 6;
            this.button2.Text = "Método de Falsa Posición";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(167, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "Interpolacion de Lagrange";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuMnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(673, 599);
            this.Controls.Add(this.temarioMet);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuMnum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodos Numericos";
            this.Load += new System.EventHandler(this.MenuMnum_Load);
            this.TitleBar.ResumeLayout(false);
            this.temarioMet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox temarioMet;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button salir;
    }
}