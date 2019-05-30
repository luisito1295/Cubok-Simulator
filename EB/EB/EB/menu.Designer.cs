namespace EB
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Arial", 11F);
            this.bt1.Location = new System.Drawing.Point(33, 43);
            this.bt1.Margin = new System.Windows.Forms.Padding(4);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(138, 68);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "Resistencias";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Arial", 11F);
            this.bt2.Location = new System.Drawing.Point(198, 43);
            this.bt2.Margin = new System.Windows.Forms.Padding(4);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(140, 68);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "Ley de Ohm";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Arial", 11F);
            this.bt3.Location = new System.Drawing.Point(33, 118);
            this.bt3.Margin = new System.Windows.Forms.Padding(4);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(138, 68);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "Puente Rectificador";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Arial", 11F);
            this.bt4.Location = new System.Drawing.Point(198, 118);
            this.bt4.Margin = new System.Windows.Forms.Padding(4);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(140, 68);
            this.bt4.TabIndex = 3;
            this.bt4.Text = "Media Onda (capacitores)";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11F);
            this.button1.Location = new System.Drawing.Point(358, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Arial", 11F);
            this.bt6.Location = new System.Drawing.Point(198, 200);
            this.bt6.Margin = new System.Windows.Forms.Padding(4);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(140, 68);
            this.bt6.TabIndex = 6;
            this.bt6.Text = "Ganancia de un Transistor";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 11F);
            this.button2.Location = new System.Drawing.Point(358, 200);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 68);
            this.button2.TabIndex = 7;
            this.button2.Text = "Preamplificador";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Arial", 11F);
            this.bt5.Location = new System.Drawing.Point(33, 200);
            this.bt5.Margin = new System.Windows.Forms.Padding(4);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(138, 68);
            this.bt5.TabIndex = 8;
            this.bt5.Text = "Onda Completa";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bt3);
            this.groupBox1.Controls.Add(this.bt5);
            this.groupBox1.Controls.Add(this.bt1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.bt2);
            this.groupBox1.Controls.Add(this.bt6);
            this.groupBox1.Controls.Add(this.bt4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(527, 353);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(561, 384);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

