namespace InterfazG
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Icono = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.hora_actual = new System.Windows.Forms.Label();
            this.fecha_actual = new System.Windows.Forms.Label();
            this.panel_tiempo = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel_tiempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TitleBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitleBar.BackgroundImage")));
            this.TitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitleBar.Controls.Add(this.minimizar);
            this.TitleBar.Controls.Add(this.maximizar);
            this.TitleBar.Controls.Add(this.label8);
            this.TitleBar.Controls.Add(this.Icono);
            this.TitleBar.Controls.Add(this.salir);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(791, 36);
            this.TitleBar.TabIndex = 1;
            this.TitleBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseClick);
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // minimizar
            // 
            this.minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizar.BackgroundImage")));
            this.minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizar.Location = new System.Drawing.Point(642, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(48, 36);
            this.minimizar.TabIndex = 8;
            this.minimizar.UseVisualStyleBackColor = true;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            this.minimizar.MouseEnter += new System.EventHandler(this.minimizar_MouseEnter);
            this.minimizar.MouseLeave += new System.EventHandler(this.minimizar_MouseLeave);
            // 
            // maximizar
            // 
            this.maximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizar.BackgroundImage")));
            this.maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizar.Enabled = false;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizar.Location = new System.Drawing.Point(690, 0);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(50, 36);
            this.maximizar.TabIndex = 7;
            this.maximizar.UseVisualStyleBackColor = true;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            this.maximizar.MouseEnter += new System.EventHandler(this.maximizar_MouseEnter);
            this.maximizar.MouseLeave += new System.EventHandler(this.maximizar_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cubok Simulator";
            // 
            // Icono
            // 
            this.Icono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Icono.BackgroundImage")));
            this.Icono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icono.Dock = System.Windows.Forms.DockStyle.Left;
            this.Icono.Location = new System.Drawing.Point(0, 0);
            this.Icono.Name = "Icono";
            this.Icono.Size = new System.Drawing.Size(57, 36);
            this.Icono.TabIndex = 5;
            this.Icono.TabStop = false;
            // 
            // salir
            // 
            this.salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salir.BackgroundImage")));
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(740, 0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(51, 36);
            this.salir.TabIndex = 4;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.button1_Click_1);
            this.salir.MouseEnter += new System.EventHandler(this.salir_MouseEnter);
            this.salir.MouseLeave += new System.EventHandler(this.salir_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "                                    ";
            this.label3.Paint += new System.Windows.Forms.PaintEventHandler(this.label3_Paint);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Location = new System.Drawing.Point(12, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(106, 96);
            this.pictureBox7.TabIndex = 71;
            this.pictureBox7.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkCyan;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(130, 399);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(129, 134);
            this.panel7.TabIndex = 95;
            this.panel7.Click += new System.EventHandler(this.panel7_Click_1);
            this.panel7.MouseEnter += new System.EventHandler(this.panel7_MouseEnter);
            this.panel7.MouseLeave += new System.EventHandler(this.panel7_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "                                    ";
            this.label9.Paint += new System.Windows.Forms.PaintEventHandler(this.label9_Paint);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Enabled = false;
            this.pictureBox8.Location = new System.Drawing.Point(12, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(106, 96);
            this.pictureBox8.TabIndex = 71;
            this.pictureBox8.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkCyan;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.pictureBox8);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(0, 399);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(129, 134);
            this.panel8.TabIndex = 96;
            this.panel8.MouseEnter += new System.EventHandler(this.panel8_MouseEnter);
            this.panel8.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "                                    ";
            this.label2.Paint += new System.Windows.Forms.PaintEventHandler(this.label2_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Location = new System.Drawing.Point(12, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(106, 96);
            this.pictureBox5.TabIndex = 71;
            this.pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkCyan;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(130, 249);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(129, 148);
            this.panel5.TabIndex = 93;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            this.panel5.MouseEnter += new System.EventHandler(this.panel5_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 40);
            this.label4.TabIndex = 70;
            this.label4.Text = "                                    \r\n                            \r\n";
            this.label4.Paint += new System.Windows.Forms.PaintEventHandler(this.label4_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Location = new System.Drawing.Point(12, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(106, 96);
            this.pictureBox6.TabIndex = 71;
            this.pictureBox6.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkCyan;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(0, 249);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(129, 148);
            this.panel6.TabIndex = 94;
            this.panel6.Click += new System.EventHandler(this.panel6_Click);
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            this.panel6.MouseEnter += new System.EventHandler(this.panel6_MouseEnter);
            this.panel6.MouseLeave += new System.EventHandler(this.panel6_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 40);
            this.label7.TabIndex = 70;
            this.label7.Text = "                                    \r\n                                    ";
            this.label7.Paint += new System.Windows.Forms.PaintEventHandler(this.label7_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(12, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 96);
            this.pictureBox3.TabIndex = 71;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 150);
            this.panel3.TabIndex = 91;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            this.panel3.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 40);
            this.label1.TabIndex = 70;
            this.label1.Text = "                                    \r\n                                    ";
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(12, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 96);
            this.pictureBox4.TabIndex = 71;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(130, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(129, 150);
            this.panel4.TabIndex = 92;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            this.panel4.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "        ";
            this.label6.Paint += new System.Windows.Forms.PaintEventHandler(this.label6_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(4, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 44);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 60);
            this.panel1.TabIndex = 89;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "                ";
            this.label10.Paint += new System.Windows.Forms.PaintEventHandler(this.label10_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(4, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 44);
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(130, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 60);
            this.panel2.TabIndex = 90;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.panel12);
            this.flowLayoutPanel1.Controls.Add(this.panel10);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel11);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(269, 37);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(516, 496);
            this.flowLayoutPanel1.TabIndex = 97;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.richTextBox1);
            this.panel12.Controls.Add(this.label11);
            this.panel12.ForeColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(2, 2);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(514, 337);
            this.panel12.TabIndex = 103;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 18F);
            this.richTextBox1.Location = new System.Drawing.Point(3, 210);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(460, 55);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 21);
            this.label11.TabIndex = 104;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel10.ForeColor = System.Drawing.Color.Transparent;
            this.panel10.Location = new System.Drawing.Point(3, 344);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(146, 60);
            this.panel10.TabIndex = 100;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightBlue;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.pictureBox9);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel9.Location = new System.Drawing.Point(155, 344);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(165, 60);
            this.panel9.TabIndex = 101;
            this.panel9.Visible = false;
            this.panel9.Click += new System.EventHandler(this.panel9_Click);
            this.panel9.MouseEnter += new System.EventHandler(this.panel9_MouseEnter);
            this.panel9.MouseLeave += new System.EventHandler(this.panel9_MouseLeave);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Enabled = false;
            this.pictureBox9.Location = new System.Drawing.Point(4, 7);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 44);
            this.pictureBox9.TabIndex = 71;
            this.pictureBox9.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 70;
            this.label5.Text = "                  ";
            this.label5.Paint += new System.Windows.Forms.PaintEventHandler(this.label5_Paint_1);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel11.Location = new System.Drawing.Point(326, 344);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(139, 60);
            this.panel11.TabIndex = 102;
            // 
            // hora_actual
            // 
            this.hora_actual.AutoSize = true;
            this.hora_actual.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_actual.Location = new System.Drawing.Point(9, 8);
            this.hora_actual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hora_actual.Name = "hora_actual";
            this.hora_actual.Size = new System.Drawing.Size(73, 21);
            this.hora_actual.TabIndex = 0;
            this.hora_actual.Text = "label11";
            // 
            // fecha_actual
            // 
            this.fecha_actual.AutoSize = true;
            this.fecha_actual.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_actual.Location = new System.Drawing.Point(208, 8);
            this.fecha_actual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fecha_actual.Name = "fecha_actual";
            this.fecha_actual.Size = new System.Drawing.Size(73, 21);
            this.fecha_actual.TabIndex = 1;
            this.fecha_actual.Text = "label12";
            // 
            // panel_tiempo
            // 
            this.panel_tiempo.BackColor = System.Drawing.Color.Transparent;
            this.panel_tiempo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_tiempo.Controls.Add(this.label12);
            this.panel_tiempo.Controls.Add(this.fecha_actual);
            this.panel_tiempo.Controls.Add(this.hora_actual);
            this.panel_tiempo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_tiempo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_tiempo.Location = new System.Drawing.Point(0, 539);
            this.panel_tiempo.Name = "panel_tiempo";
            this.panel_tiempo.Size = new System.Drawing.Size(791, 37);
            this.panel_tiempo.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(456, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "label12";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 576);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_tiempo);
            this.Controls.Add(this.TitleBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "es_mx";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.EnabledChanged += new System.EventHandler(this.Principal_EnabledChanged);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel_tiempo.ResumeLayout(false);
            this.panel_tiempo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox Icono;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label hora_actual;
        private System.Windows.Forms.Label fecha_actual;
        private System.Windows.Forms.Panel panel_tiempo;
        private System.Windows.Forms.Label label12;
    }
}

