namespace Isobot_terminal
{
    partial class Form1
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
            this.command_box = new System.Windows.Forms.ListBox();
            this.Isobot_com = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DDRB = new System.Windows.Forms.GroupBox();
            this.DDRB7 = new System.Windows.Forms.CheckBox();
            this.DDRB6 = new System.Windows.Forms.CheckBox();
            this.DDRB5 = new System.Windows.Forms.CheckBox();
            this.DDRB4 = new System.Windows.Forms.CheckBox();
            this.DDRB3 = new System.Windows.Forms.CheckBox();
            this.DDRB2 = new System.Windows.Forms.CheckBox();
            this.DDRB1 = new System.Windows.Forms.CheckBox();
            this.DDRB0 = new System.Windows.Forms.CheckBox();
            this.PORTC_PINC = new System.Windows.Forms.GroupBox();
            this.PINC7 = new System.Windows.Forms.RadioButton();
            this.PINC6 = new System.Windows.Forms.RadioButton();
            this.PINC5 = new System.Windows.Forms.RadioButton();
            this.PINC4 = new System.Windows.Forms.RadioButton();
            this.PINC3 = new System.Windows.Forms.RadioButton();
            this.PINC2 = new System.Windows.Forms.RadioButton();
            this.PINC1 = new System.Windows.Forms.RadioButton();
            this.PINC0 = new System.Windows.Forms.RadioButton();
            this.PORTC7 = new System.Windows.Forms.CheckBox();
            this.PORTC6 = new System.Windows.Forms.CheckBox();
            this.PORTC5 = new System.Windows.Forms.CheckBox();
            this.PORTC2 = new System.Windows.Forms.CheckBox();
            this.PORTC4 = new System.Windows.Forms.CheckBox();
            this.PORTC3 = new System.Windows.Forms.CheckBox();
            this.PORTC0 = new System.Windows.Forms.CheckBox();
            this.PORTC1 = new System.Windows.Forms.CheckBox();
            this.PORTB7 = new System.Windows.Forms.CheckBox();
            this.PORTB0 = new System.Windows.Forms.CheckBox();
            this.PORTB6 = new System.Windows.Forms.CheckBox();
            this.PORTB1 = new System.Windows.Forms.CheckBox();
            this.PORTB5 = new System.Windows.Forms.CheckBox();
            this.PORTB2 = new System.Windows.Forms.CheckBox();
            this.PORTB4 = new System.Windows.Forms.CheckBox();
            this.PORTB3 = new System.Windows.Forms.CheckBox();
            this.DDRC = new System.Windows.Forms.GroupBox();
            this.DDRC7 = new System.Windows.Forms.CheckBox();
            this.DDRC0 = new System.Windows.Forms.CheckBox();
            this.DDRC6 = new System.Windows.Forms.CheckBox();
            this.DDRC1 = new System.Windows.Forms.CheckBox();
            this.DDRC5 = new System.Windows.Forms.CheckBox();
            this.DDRC2 = new System.Windows.Forms.CheckBox();
            this.DDRC4 = new System.Windows.Forms.CheckBox();
            this.DDRC3 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PORTB_PINB = new System.Windows.Forms.GroupBox();
            this.PINB6 = new System.Windows.Forms.RadioButton();
            this.PINB5 = new System.Windows.Forms.RadioButton();
            this.PINB4 = new System.Windows.Forms.RadioButton();
            this.PINB3 = new System.Windows.Forms.RadioButton();
            this.PINB2 = new System.Windows.Forms.RadioButton();
            this.PINB1 = new System.Windows.Forms.RadioButton();
            this.PINB0 = new System.Windows.Forms.RadioButton();
            this.PINB7 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.UP_LEFT = new System.Windows.Forms.Button();
            this.DOWN_LEFT = new System.Windows.Forms.Button();
            this.DOWN_RIGHT = new System.Windows.Forms.Button();
            this.UP_RIGHT = new System.Windows.Forms.Button();
            this.RIGHT = new System.Windows.Forms.Button();
            this.ROTATE_RIGHT = new System.Windows.Forms.Button();
            this.ROTATE_LEFT = new System.Windows.Forms.Button();
            this.UP = new System.Windows.Forms.Button();
            this.LEFT = new System.Windows.Forms.Button();
            this.DOWN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DDRB.SuspendLayout();
            this.PORTC_PINC.SuspendLayout();
            this.DDRC.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.PORTB_PINB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // command_box
            // 
            this.command_box.FormattingEnabled = true;
            this.command_box.Location = new System.Drawing.Point(661, 16);
            this.command_box.Name = "command_box";
            this.command_box.Size = new System.Drawing.Size(120, 186);
            this.command_box.TabIndex = 0;
            this.command_box.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dvojklik_commands);
            // 
            // Isobot_com
            // 
            this.Isobot_com.BaudRate = 19200;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // DDRB
            // 
            this.DDRB.Controls.Add(this.DDRB7);
            this.DDRB.Controls.Add(this.DDRB6);
            this.DDRB.Controls.Add(this.DDRB5);
            this.DDRB.Controls.Add(this.DDRB4);
            this.DDRB.Controls.Add(this.DDRB3);
            this.DDRB.Controls.Add(this.DDRB2);
            this.DDRB.Controls.Add(this.DDRB1);
            this.DDRB.Controls.Add(this.DDRB0);
            this.DDRB.Location = new System.Drawing.Point(12, 244);
            this.DDRB.Name = "DDRB";
            this.DDRB.Size = new System.Drawing.Size(94, 120);
            this.DDRB.TabIndex = 2;
            this.DDRB.TabStop = false;
            this.DDRB.Text = "DDRB";
            // 
            // DDRB7
            // 
            this.DDRB7.AutoSize = true;
            this.DDRB7.Location = new System.Drawing.Point(55, 89);
            this.DDRB7.Name = "DDRB7";
            this.DDRB7.Size = new System.Drawing.Size(32, 17);
            this.DDRB7.TabIndex = 0;
            this.DDRB7.Text = "7";
            this.DDRB7.UseVisualStyleBackColor = true;
            this.DDRB7.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRB6
            // 
            this.DDRB6.AutoSize = true;
            this.DDRB6.Location = new System.Drawing.Point(55, 66);
            this.DDRB6.Name = "DDRB6";
            this.DDRB6.Size = new System.Drawing.Size(32, 17);
            this.DDRB6.TabIndex = 0;
            this.DDRB6.Text = "6";
            this.DDRB6.UseVisualStyleBackColor = true;
            this.DDRB6.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRB5
            // 
            this.DDRB5.AutoSize = true;
            this.DDRB5.Location = new System.Drawing.Point(55, 43);
            this.DDRB5.Name = "DDRB5";
            this.DDRB5.Size = new System.Drawing.Size(32, 17);
            this.DDRB5.TabIndex = 0;
            this.DDRB5.Text = "5";
            this.DDRB5.UseVisualStyleBackColor = true;
            this.DDRB5.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRB4
            // 
            this.DDRB4.AutoSize = true;
            this.DDRB4.Location = new System.Drawing.Point(55, 19);
            this.DDRB4.Name = "DDRB4";
            this.DDRB4.Size = new System.Drawing.Size(32, 17);
            this.DDRB4.TabIndex = 0;
            this.DDRB4.Text = "4";
            this.DDRB4.UseVisualStyleBackColor = true;
            this.DDRB4.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRB3
            // 
            this.DDRB3.AutoSize = true;
            this.DDRB3.Location = new System.Drawing.Point(6, 89);
            this.DDRB3.Name = "DDRB3";
            this.DDRB3.Size = new System.Drawing.Size(32, 17);
            this.DDRB3.TabIndex = 0;
            this.DDRB3.Text = "3";
            this.DDRB3.UseVisualStyleBackColor = true;
            this.DDRB3.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRB2
            // 
            this.DDRB2.AutoSize = true;
            this.DDRB2.Location = new System.Drawing.Point(7, 66);
            this.DDRB2.Name = "DDRB2";
            this.DDRB2.Size = new System.Drawing.Size(32, 17);
            this.DDRB2.TabIndex = 0;
            this.DDRB2.Text = "2";
            this.DDRB2.UseVisualStyleBackColor = true;
            this.DDRB2.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRB1
            // 
            this.DDRB1.AutoSize = true;
            this.DDRB1.Location = new System.Drawing.Point(7, 43);
            this.DDRB1.Name = "DDRB1";
            this.DDRB1.Size = new System.Drawing.Size(32, 17);
            this.DDRB1.TabIndex = 0;
            this.DDRB1.Text = "1";
            this.DDRB1.UseVisualStyleBackColor = true;
            this.DDRB1.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRB0
            // 
            this.DDRB0.AutoSize = true;
            this.DDRB0.Location = new System.Drawing.Point(7, 20);
            this.DDRB0.Name = "DDRB0";
            this.DDRB0.Size = new System.Drawing.Size(32, 17);
            this.DDRB0.TabIndex = 0;
            this.DDRB0.Text = "0";
            this.DDRB0.UseVisualStyleBackColor = true;
            this.DDRB0.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // PORTC_PINC
            // 
            this.PORTC_PINC.Controls.Add(this.PINC7);
            this.PORTC_PINC.Controls.Add(this.PINC6);
            this.PORTC_PINC.Controls.Add(this.PINC5);
            this.PORTC_PINC.Controls.Add(this.PINC4);
            this.PORTC_PINC.Controls.Add(this.PINC3);
            this.PORTC_PINC.Controls.Add(this.PINC2);
            this.PORTC_PINC.Controls.Add(this.PINC1);
            this.PORTC_PINC.Controls.Add(this.PINC0);
            this.PORTC_PINC.Controls.Add(this.PORTC7);
            this.PORTC_PINC.Controls.Add(this.PORTC6);
            this.PORTC_PINC.Controls.Add(this.PORTC5);
            this.PORTC_PINC.Controls.Add(this.PORTC2);
            this.PORTC_PINC.Controls.Add(this.PORTC4);
            this.PORTC_PINC.Controls.Add(this.PORTC3);
            this.PORTC_PINC.Controls.Add(this.PORTC0);
            this.PORTC_PINC.Controls.Add(this.PORTC1);
            this.PORTC_PINC.Location = new System.Drawing.Point(306, 244);
            this.PORTC_PINC.Name = "PORTC_PINC";
            this.PORTC_PINC.Size = new System.Drawing.Size(91, 120);
            this.PORTC_PINC.TabIndex = 2;
            this.PORTC_PINC.TabStop = false;
            this.PORTC_PINC.Text = "PORTC/PINC";
            // 
            // PINC7
            // 
            this.PINC7.AutoSize = true;
            this.PINC7.Enabled = false;
            this.PINC7.Location = new System.Drawing.Point(54, 85);
            this.PINC7.Name = "PINC7";
            this.PINC7.Size = new System.Drawing.Size(31, 17);
            this.PINC7.TabIndex = 0;
            this.PINC7.TabStop = true;
            this.PINC7.Text = "7";
            this.PINC7.UseVisualStyleBackColor = true;
            // 
            // PINC6
            // 
            this.PINC6.AutoSize = true;
            this.PINC6.Enabled = false;
            this.PINC6.Location = new System.Drawing.Point(54, 64);
            this.PINC6.Name = "PINC6";
            this.PINC6.Size = new System.Drawing.Size(31, 17);
            this.PINC6.TabIndex = 0;
            this.PINC6.TabStop = true;
            this.PINC6.Text = "6";
            this.PINC6.UseVisualStyleBackColor = true;
            // 
            // PINC5
            // 
            this.PINC5.AutoSize = true;
            this.PINC5.Enabled = false;
            this.PINC5.Location = new System.Drawing.Point(54, 41);
            this.PINC5.Name = "PINC5";
            this.PINC5.Size = new System.Drawing.Size(31, 17);
            this.PINC5.TabIndex = 0;
            this.PINC5.TabStop = true;
            this.PINC5.Text = "5";
            this.PINC5.UseVisualStyleBackColor = true;
            // 
            // PINC4
            // 
            this.PINC4.AutoSize = true;
            this.PINC4.Enabled = false;
            this.PINC4.Location = new System.Drawing.Point(54, 18);
            this.PINC4.Name = "PINC4";
            this.PINC4.Size = new System.Drawing.Size(31, 17);
            this.PINC4.TabIndex = 0;
            this.PINC4.TabStop = true;
            this.PINC4.Text = "4";
            this.PINC4.UseVisualStyleBackColor = true;
            // 
            // PINC3
            // 
            this.PINC3.AutoSize = true;
            this.PINC3.Enabled = false;
            this.PINC3.Location = new System.Drawing.Point(5, 86);
            this.PINC3.Name = "PINC3";
            this.PINC3.Size = new System.Drawing.Size(31, 17);
            this.PINC3.TabIndex = 0;
            this.PINC3.TabStop = true;
            this.PINC3.Text = "3";
            this.PINC3.UseVisualStyleBackColor = true;
            // 
            // PINC2
            // 
            this.PINC2.AutoSize = true;
            this.PINC2.Enabled = false;
            this.PINC2.Location = new System.Drawing.Point(5, 64);
            this.PINC2.Name = "PINC2";
            this.PINC2.Size = new System.Drawing.Size(31, 17);
            this.PINC2.TabIndex = 0;
            this.PINC2.TabStop = true;
            this.PINC2.Text = "2";
            this.PINC2.UseVisualStyleBackColor = true;
            // 
            // PINC1
            // 
            this.PINC1.AutoSize = true;
            this.PINC1.Enabled = false;
            this.PINC1.Location = new System.Drawing.Point(5, 42);
            this.PINC1.Name = "PINC1";
            this.PINC1.Size = new System.Drawing.Size(31, 17);
            this.PINC1.TabIndex = 0;
            this.PINC1.TabStop = true;
            this.PINC1.Text = "1";
            this.PINC1.UseVisualStyleBackColor = true;
            // 
            // PINC0
            // 
            this.PINC0.AutoSize = true;
            this.PINC0.Enabled = false;
            this.PINC0.Location = new System.Drawing.Point(5, 17);
            this.PINC0.Name = "PINC0";
            this.PINC0.Size = new System.Drawing.Size(31, 17);
            this.PINC0.TabIndex = 0;
            this.PINC0.TabStop = true;
            this.PINC0.Text = "0";
            this.PINC0.UseVisualStyleBackColor = true;
            // 
            // PORTC7
            // 
            this.PORTC7.AutoSize = true;
            this.PORTC7.Location = new System.Drawing.Point(54, 88);
            this.PORTC7.Name = "PORTC7";
            this.PORTC7.Size = new System.Drawing.Size(32, 17);
            this.PORTC7.TabIndex = 0;
            this.PORTC7.Text = "7";
            this.PORTC7.UseVisualStyleBackColor = true;
            this.PORTC7.Visible = false;
            // 
            // PORTC6
            // 
            this.PORTC6.AutoSize = true;
            this.PORTC6.Location = new System.Drawing.Point(54, 65);
            this.PORTC6.Name = "PORTC6";
            this.PORTC6.Size = new System.Drawing.Size(32, 17);
            this.PORTC6.TabIndex = 0;
            this.PORTC6.Text = "6";
            this.PORTC6.UseVisualStyleBackColor = true;
            this.PORTC6.Visible = false;
            // 
            // PORTC5
            // 
            this.PORTC5.AutoSize = true;
            this.PORTC5.Location = new System.Drawing.Point(54, 42);
            this.PORTC5.Name = "PORTC5";
            this.PORTC5.Size = new System.Drawing.Size(32, 17);
            this.PORTC5.TabIndex = 0;
            this.PORTC5.Text = "5";
            this.PORTC5.UseVisualStyleBackColor = true;
            this.PORTC5.Visible = false;
            // 
            // PORTC2
            // 
            this.PORTC2.AutoSize = true;
            this.PORTC2.Location = new System.Drawing.Point(6, 65);
            this.PORTC2.Name = "PORTC2";
            this.PORTC2.Size = new System.Drawing.Size(32, 17);
            this.PORTC2.TabIndex = 0;
            this.PORTC2.Text = "2";
            this.PORTC2.UseVisualStyleBackColor = true;
            this.PORTC2.Visible = false;
            // 
            // PORTC4
            // 
            this.PORTC4.AutoSize = true;
            this.PORTC4.Location = new System.Drawing.Point(54, 18);
            this.PORTC4.Name = "PORTC4";
            this.PORTC4.Size = new System.Drawing.Size(32, 17);
            this.PORTC4.TabIndex = 0;
            this.PORTC4.Text = "4";
            this.PORTC4.UseVisualStyleBackColor = true;
            this.PORTC4.Visible = false;
            // 
            // PORTC3
            // 
            this.PORTC3.AutoSize = true;
            this.PORTC3.Location = new System.Drawing.Point(5, 88);
            this.PORTC3.Name = "PORTC3";
            this.PORTC3.Size = new System.Drawing.Size(32, 17);
            this.PORTC3.TabIndex = 0;
            this.PORTC3.Text = "3";
            this.PORTC3.UseVisualStyleBackColor = true;
            this.PORTC3.Visible = false;
            // 
            // PORTC0
            // 
            this.PORTC0.AutoSize = true;
            this.PORTC0.Location = new System.Drawing.Point(6, 19);
            this.PORTC0.Name = "PORTC0";
            this.PORTC0.Size = new System.Drawing.Size(32, 17);
            this.PORTC0.TabIndex = 0;
            this.PORTC0.Text = "0";
            this.PORTC0.UseVisualStyleBackColor = true;
            this.PORTC0.Visible = false;
            // 
            // PORTC1
            // 
            this.PORTC1.AutoSize = true;
            this.PORTC1.Location = new System.Drawing.Point(6, 42);
            this.PORTC1.Name = "PORTC1";
            this.PORTC1.Size = new System.Drawing.Size(32, 17);
            this.PORTC1.TabIndex = 0;
            this.PORTC1.Text = "1";
            this.PORTC1.UseVisualStyleBackColor = true;
            this.PORTC1.Visible = false;
            // 
            // PORTB7
            // 
            this.PORTB7.AutoSize = true;
            this.PORTB7.Location = new System.Drawing.Point(53, 88);
            this.PORTB7.Name = "PORTB7";
            this.PORTB7.Size = new System.Drawing.Size(32, 17);
            this.PORTB7.TabIndex = 0;
            this.PORTB7.Text = "7";
            this.PORTB7.UseVisualStyleBackColor = true;
            this.PORTB7.Visible = false;
            // 
            // PORTB0
            // 
            this.PORTB0.AutoSize = true;
            this.PORTB0.Location = new System.Drawing.Point(6, 17);
            this.PORTB0.Name = "PORTB0";
            this.PORTB0.Size = new System.Drawing.Size(32, 17);
            this.PORTB0.TabIndex = 0;
            this.PORTB0.Text = "0";
            this.PORTB0.UseVisualStyleBackColor = true;
            this.PORTB0.Visible = false;
            // 
            // PORTB6
            // 
            this.PORTB6.AutoSize = true;
            this.PORTB6.Location = new System.Drawing.Point(53, 63);
            this.PORTB6.Name = "PORTB6";
            this.PORTB6.Size = new System.Drawing.Size(32, 17);
            this.PORTB6.TabIndex = 0;
            this.PORTB6.Text = "6";
            this.PORTB6.UseVisualStyleBackColor = true;
            this.PORTB6.Visible = false;
            // 
            // PORTB1
            // 
            this.PORTB1.AutoSize = true;
            this.PORTB1.Location = new System.Drawing.Point(6, 42);
            this.PORTB1.Name = "PORTB1";
            this.PORTB1.Size = new System.Drawing.Size(32, 17);
            this.PORTB1.TabIndex = 0;
            this.PORTB1.Text = "1";
            this.PORTB1.UseVisualStyleBackColor = true;
            this.PORTB1.Visible = false;
            // 
            // PORTB5
            // 
            this.PORTB5.AutoSize = true;
            this.PORTB5.Location = new System.Drawing.Point(54, 41);
            this.PORTB5.Name = "PORTB5";
            this.PORTB5.Size = new System.Drawing.Size(32, 17);
            this.PORTB5.TabIndex = 0;
            this.PORTB5.Text = "5";
            this.PORTB5.UseVisualStyleBackColor = true;
            this.PORTB5.Visible = false;
            // 
            // PORTB2
            // 
            this.PORTB2.AutoSize = true;
            this.PORTB2.Location = new System.Drawing.Point(6, 64);
            this.PORTB2.Name = "PORTB2";
            this.PORTB2.Size = new System.Drawing.Size(32, 17);
            this.PORTB2.TabIndex = 0;
            this.PORTB2.Text = "2";
            this.PORTB2.UseVisualStyleBackColor = true;
            this.PORTB2.Visible = false;
            // 
            // PORTB4
            // 
            this.PORTB4.AutoSize = true;
            this.PORTB4.Location = new System.Drawing.Point(53, 19);
            this.PORTB4.Name = "PORTB4";
            this.PORTB4.Size = new System.Drawing.Size(32, 17);
            this.PORTB4.TabIndex = 0;
            this.PORTB4.Text = "4";
            this.PORTB4.UseVisualStyleBackColor = true;
            this.PORTB4.Visible = false;
            // 
            // PORTB3
            // 
            this.PORTB3.AutoSize = true;
            this.PORTB3.Location = new System.Drawing.Point(6, 88);
            this.PORTB3.Name = "PORTB3";
            this.PORTB3.Size = new System.Drawing.Size(32, 17);
            this.PORTB3.TabIndex = 0;
            this.PORTB3.Text = "3";
            this.PORTB3.UseVisualStyleBackColor = true;
            this.PORTB3.Visible = false;
            // 
            // DDRC
            // 
            this.DDRC.Controls.Add(this.DDRC7);
            this.DDRC.Controls.Add(this.DDRC0);
            this.DDRC.Controls.Add(this.DDRC6);
            this.DDRC.Controls.Add(this.DDRC1);
            this.DDRC.Controls.Add(this.DDRC5);
            this.DDRC.Controls.Add(this.DDRC2);
            this.DDRC.Controls.Add(this.DDRC4);
            this.DDRC.Controls.Add(this.DDRC3);
            this.DDRC.Location = new System.Drawing.Point(209, 244);
            this.DDRC.Name = "DDRC";
            this.DDRC.Size = new System.Drawing.Size(91, 120);
            this.DDRC.TabIndex = 2;
            this.DDRC.TabStop = false;
            this.DDRC.Text = "DDRC";
            // 
            // DDRC7
            // 
            this.DDRC7.AutoSize = true;
            this.DDRC7.Location = new System.Drawing.Point(54, 88);
            this.DDRC7.Name = "DDRC7";
            this.DDRC7.Size = new System.Drawing.Size(32, 17);
            this.DDRC7.TabIndex = 0;
            this.DDRC7.Text = "7";
            this.DDRC7.UseVisualStyleBackColor = true;
            this.DDRC7.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRC0
            // 
            this.DDRC0.AutoSize = true;
            this.DDRC0.Location = new System.Drawing.Point(6, 19);
            this.DDRC0.Name = "DDRC0";
            this.DDRC0.Size = new System.Drawing.Size(32, 17);
            this.DDRC0.TabIndex = 0;
            this.DDRC0.Text = "0";
            this.DDRC0.UseVisualStyleBackColor = true;
            this.DDRC0.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRC6
            // 
            this.DDRC6.AutoSize = true;
            this.DDRC6.Location = new System.Drawing.Point(54, 65);
            this.DDRC6.Name = "DDRC6";
            this.DDRC6.Size = new System.Drawing.Size(32, 17);
            this.DDRC6.TabIndex = 0;
            this.DDRC6.Text = "6";
            this.DDRC6.UseVisualStyleBackColor = true;
            this.DDRC6.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRC1
            // 
            this.DDRC1.AutoSize = true;
            this.DDRC1.Location = new System.Drawing.Point(6, 42);
            this.DDRC1.Name = "DDRC1";
            this.DDRC1.Size = new System.Drawing.Size(32, 17);
            this.DDRC1.TabIndex = 0;
            this.DDRC1.Text = "1";
            this.DDRC1.UseVisualStyleBackColor = true;
            this.DDRC1.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRC5
            // 
            this.DDRC5.AutoSize = true;
            this.DDRC5.Location = new System.Drawing.Point(54, 42);
            this.DDRC5.Name = "DDRC5";
            this.DDRC5.Size = new System.Drawing.Size(32, 17);
            this.DDRC5.TabIndex = 0;
            this.DDRC5.Text = "5";
            this.DDRC5.UseVisualStyleBackColor = true;
            this.DDRC5.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRC2
            // 
            this.DDRC2.AutoSize = true;
            this.DDRC2.Location = new System.Drawing.Point(6, 65);
            this.DDRC2.Name = "DDRC2";
            this.DDRC2.Size = new System.Drawing.Size(32, 17);
            this.DDRC2.TabIndex = 0;
            this.DDRC2.Text = "2";
            this.DDRC2.UseVisualStyleBackColor = true;
            this.DDRC2.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRC4
            // 
            this.DDRC4.AutoSize = true;
            this.DDRC4.Location = new System.Drawing.Point(54, 18);
            this.DDRC4.Name = "DDRC4";
            this.DDRC4.Size = new System.Drawing.Size(32, 17);
            this.DDRC4.TabIndex = 0;
            this.DDRC4.Text = "4";
            this.DDRC4.UseVisualStyleBackColor = true;
            this.DDRC4.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // DDRC3
            // 
            this.DDRC3.AutoSize = true;
            this.DDRC3.Location = new System.Drawing.Point(5, 88);
            this.DDRC3.Name = "DDRC3";
            this.DDRC3.Size = new System.Drawing.Size(32, 17);
            this.DDRC3.TabIndex = 0;
            this.DDRC3.Text = "3";
            this.DDRC3.UseVisualStyleBackColor = true;
            this.DDRC3.CheckedChanged += new System.EventHandler(this.zmena_nastavenia);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Location = new System.Drawing.Point(403, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(378, 120);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ADC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ADC5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ADC4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ADC3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ADC2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADC1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADC0";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(258, 84);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(50, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(258, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(258, 48);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // PORTB_PINB
            // 
            this.PORTB_PINB.Controls.Add(this.PINB6);
            this.PORTB_PINB.Controls.Add(this.PINB5);
            this.PORTB_PINB.Controls.Add(this.PINB4);
            this.PORTB_PINB.Controls.Add(this.PINB3);
            this.PORTB_PINB.Controls.Add(this.PINB2);
            this.PORTB_PINB.Controls.Add(this.PINB1);
            this.PORTB_PINB.Controls.Add(this.PINB0);
            this.PORTB_PINB.Controls.Add(this.PORTB6);
            this.PORTB_PINB.Controls.Add(this.PORTB0);
            this.PORTB_PINB.Controls.Add(this.PORTB5);
            this.PORTB_PINB.Controls.Add(this.PORTB1);
            this.PORTB_PINB.Controls.Add(this.PORTB4);
            this.PORTB_PINB.Controls.Add(this.PORTB2);
            this.PORTB_PINB.Controls.Add(this.PORTB3);
            this.PORTB_PINB.Controls.Add(this.PINB7);
            this.PORTB_PINB.Controls.Add(this.PORTB7);
            this.PORTB_PINB.Location = new System.Drawing.Point(112, 244);
            this.PORTB_PINB.Name = "PORTB_PINB";
            this.PORTB_PINB.Size = new System.Drawing.Size(91, 120);
            this.PORTB_PINB.TabIndex = 2;
            this.PORTB_PINB.TabStop = false;
            this.PORTB_PINB.Text = "PORTB/PINB";
            // 
            // PINB6
            // 
            this.PINB6.AutoSize = true;
            this.PINB6.Enabled = false;
            this.PINB6.Location = new System.Drawing.Point(54, 64);
            this.PINB6.Name = "PINB6";
            this.PINB6.Size = new System.Drawing.Size(31, 17);
            this.PINB6.TabIndex = 0;
            this.PINB6.TabStop = true;
            this.PINB6.Text = "6";
            this.PINB6.UseVisualStyleBackColor = true;
            // 
            // PINB5
            // 
            this.PINB5.AutoSize = true;
            this.PINB5.Enabled = false;
            this.PINB5.Location = new System.Drawing.Point(54, 41);
            this.PINB5.Name = "PINB5";
            this.PINB5.Size = new System.Drawing.Size(31, 17);
            this.PINB5.TabIndex = 0;
            this.PINB5.TabStop = true;
            this.PINB5.Text = "5";
            this.PINB5.UseVisualStyleBackColor = true;
            // 
            // PINB4
            // 
            this.PINB4.AutoSize = true;
            this.PINB4.Enabled = false;
            this.PINB4.Location = new System.Drawing.Point(54, 18);
            this.PINB4.Name = "PINB4";
            this.PINB4.Size = new System.Drawing.Size(31, 17);
            this.PINB4.TabIndex = 0;
            this.PINB4.TabStop = true;
            this.PINB4.Text = "4";
            this.PINB4.UseVisualStyleBackColor = true;
            // 
            // PINB3
            // 
            this.PINB3.AutoSize = true;
            this.PINB3.Enabled = false;
            this.PINB3.Location = new System.Drawing.Point(7, 87);
            this.PINB3.Name = "PINB3";
            this.PINB3.Size = new System.Drawing.Size(31, 17);
            this.PINB3.TabIndex = 0;
            this.PINB3.TabStop = true;
            this.PINB3.Text = "3";
            this.PINB3.UseVisualStyleBackColor = true;
            // 
            // PINB2
            // 
            this.PINB2.AutoSize = true;
            this.PINB2.Enabled = false;
            this.PINB2.Location = new System.Drawing.Point(7, 64);
            this.PINB2.Name = "PINB2";
            this.PINB2.Size = new System.Drawing.Size(31, 17);
            this.PINB2.TabIndex = 0;
            this.PINB2.TabStop = true;
            this.PINB2.Text = "2";
            this.PINB2.UseVisualStyleBackColor = true;
            // 
            // PINB1
            // 
            this.PINB1.AutoSize = true;
            this.PINB1.Enabled = false;
            this.PINB1.Location = new System.Drawing.Point(7, 41);
            this.PINB1.Name = "PINB1";
            this.PINB1.Size = new System.Drawing.Size(31, 17);
            this.PINB1.TabIndex = 0;
            this.PINB1.TabStop = true;
            this.PINB1.Text = "1";
            this.PINB1.UseVisualStyleBackColor = true;
            // 
            // PINB0
            // 
            this.PINB0.AutoSize = true;
            this.PINB0.Enabled = false;
            this.PINB0.Location = new System.Drawing.Point(7, 17);
            this.PINB0.Name = "PINB0";
            this.PINB0.Size = new System.Drawing.Size(31, 17);
            this.PINB0.TabIndex = 0;
            this.PINB0.TabStop = true;
            this.PINB0.Text = "0";
            this.PINB0.UseVisualStyleBackColor = true;
            // 
            // PINB7
            // 
            this.PINB7.AutoSize = true;
            this.PINB7.Enabled = false;
            this.PINB7.Location = new System.Drawing.Point(54, 86);
            this.PINB7.Name = "PINB7";
            this.PINB7.Size = new System.Drawing.Size(31, 17);
            this.PINB7.TabIndex = 0;
            this.PINB7.TabStop = true;
            this.PINB7.Text = "7";
            this.PINB7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.UP_LEFT);
            this.panel1.Controls.Add(this.DOWN_LEFT);
            this.panel1.Controls.Add(this.DOWN_RIGHT);
            this.panel1.Controls.Add(this.UP_RIGHT);
            this.panel1.Controls.Add(this.RIGHT);
            this.panel1.Controls.Add(this.ROTATE_RIGHT);
            this.panel1.Controls.Add(this.ROTATE_LEFT);
            this.panel1.Controls.Add(this.UP);
            this.panel1.Controls.Add(this.LEFT);
            this.panel1.Controls.Add(this.DOWN);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(18, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 222);
            this.panel1.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(661, 215);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Otvor spojenie";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // UP_LEFT
            // 
            this.UP_LEFT.Image = global::Isobot_terminal.Properties.Resources._9;
            this.UP_LEFT.Location = new System.Drawing.Point(0, 0);
            this.UP_LEFT.Name = "UP_LEFT";
            this.UP_LEFT.Size = new System.Drawing.Size(50, 50);
            this.UP_LEFT.TabIndex = 5;
            this.UP_LEFT.UseVisualStyleBackColor = true;
            this.UP_LEFT.Click += new System.EventHandler(this.UP_LEFT_Click);
            // 
            // DOWN_LEFT
            // 
            this.DOWN_LEFT.Image = global::Isobot_terminal.Properties.Resources._12;
            this.DOWN_LEFT.Location = new System.Drawing.Point(0, 172);
            this.DOWN_LEFT.Name = "DOWN_LEFT";
            this.DOWN_LEFT.Size = new System.Drawing.Size(50, 50);
            this.DOWN_LEFT.TabIndex = 5;
            this.DOWN_LEFT.UseVisualStyleBackColor = true;
            this.DOWN_LEFT.Click += new System.EventHandler(this.DOWN_LEFT_Click);
            // 
            // DOWN_RIGHT
            // 
            this.DOWN_RIGHT.Image = global::Isobot_terminal.Properties.Resources._11;
            this.DOWN_RIGHT.Location = new System.Drawing.Point(576, 172);
            this.DOWN_RIGHT.Name = "DOWN_RIGHT";
            this.DOWN_RIGHT.Size = new System.Drawing.Size(50, 50);
            this.DOWN_RIGHT.TabIndex = 5;
            this.DOWN_RIGHT.UseVisualStyleBackColor = true;
            this.DOWN_RIGHT.Click += new System.EventHandler(this.DOWN_RIGHT_Click);
            // 
            // UP_RIGHT
            // 
            this.UP_RIGHT.Image = global::Isobot_terminal.Properties.Resources._10;
            this.UP_RIGHT.Location = new System.Drawing.Point(576, 0);
            this.UP_RIGHT.Name = "UP_RIGHT";
            this.UP_RIGHT.Size = new System.Drawing.Size(50, 50);
            this.UP_RIGHT.TabIndex = 5;
            this.UP_RIGHT.UseVisualStyleBackColor = true;
            this.UP_RIGHT.Click += new System.EventHandler(this.UP_RIGHT_Click);
            // 
            // RIGHT
            // 
            this.RIGHT.Image = global::Isobot_terminal.Properties.Resources._5;
            this.RIGHT.Location = new System.Drawing.Point(576, 81);
            this.RIGHT.Name = "RIGHT";
            this.RIGHT.Size = new System.Drawing.Size(50, 50);
            this.RIGHT.TabIndex = 5;
            this.RIGHT.UseVisualStyleBackColor = true;
            this.RIGHT.Click += new System.EventHandler(this.RIGHT_Click);
            // 
            // ROTATE_RIGHT
            // 
            this.ROTATE_RIGHT.Image = global::Isobot_terminal.Properties.Resources._4;
            this.ROTATE_RIGHT.Location = new System.Drawing.Point(366, 81);
            this.ROTATE_RIGHT.Name = "ROTATE_RIGHT";
            this.ROTATE_RIGHT.Size = new System.Drawing.Size(50, 50);
            this.ROTATE_RIGHT.TabIndex = 5;
            this.ROTATE_RIGHT.UseVisualStyleBackColor = true;
            this.ROTATE_RIGHT.Click += new System.EventHandler(this.ROTATE_RIGHT_Click);
            // 
            // ROTATE_LEFT
            // 
            this.ROTATE_LEFT.Image = global::Isobot_terminal.Properties.Resources._3;
            this.ROTATE_LEFT.Location = new System.Drawing.Point(204, 81);
            this.ROTATE_LEFT.Name = "ROTATE_LEFT";
            this.ROTATE_LEFT.Size = new System.Drawing.Size(50, 50);
            this.ROTATE_LEFT.TabIndex = 5;
            this.ROTATE_LEFT.UseVisualStyleBackColor = true;
            this.ROTATE_LEFT.Click += new System.EventHandler(this.ROTATE_LEFT_Click);
            // 
            // UP
            // 
            this.UP.Image = global::Isobot_terminal.Properties.Resources._8;
            this.UP.Location = new System.Drawing.Point(284, 0);
            this.UP.Name = "UP";
            this.UP.Size = new System.Drawing.Size(50, 50);
            this.UP.TabIndex = 5;
            this.UP.UseVisualStyleBackColor = true;
            this.UP.Click += new System.EventHandler(this.UP_Click);
            // 
            // LEFT
            // 
            this.LEFT.Image = global::Isobot_terminal.Properties.Resources._7;
            this.LEFT.Location = new System.Drawing.Point(0, 81);
            this.LEFT.Name = "LEFT";
            this.LEFT.Size = new System.Drawing.Size(50, 50);
            this.LEFT.TabIndex = 5;
            this.LEFT.UseVisualStyleBackColor = true;
            this.LEFT.Click += new System.EventHandler(this.LEFT_Click);
            // 
            // DOWN
            // 
            this.DOWN.Image = global::Isobot_terminal.Properties.Resources._6;
            this.DOWN.Location = new System.Drawing.Point(284, 169);
            this.DOWN.Name = "DOWN";
            this.DOWN.Size = new System.Drawing.Size(50, 50);
            this.DOWN.TabIndex = 5;
            this.DOWN.UseVisualStyleBackColor = true;
            this.DOWN.Click += new System.EventHandler(this.DOWN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Isobot_terminal.Properties.Resources.obr_isobot1;
            this.pictureBox1.Location = new System.Drawing.Point(49, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 120);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 376);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.DDRC);
            this.Controls.Add(this.DDRB);
            this.Controls.Add(this.command_box);
            this.Controls.Add(this.PORTB_PINB);
            this.Controls.Add(this.PORTC_PINC);
            this.Name = "Form1";
            this.Text = "Isobot terminal";
            this.DDRB.ResumeLayout(false);
            this.DDRB.PerformLayout();
            this.PORTC_PINC.ResumeLayout(false);
            this.PORTC_PINC.PerformLayout();
            this.DDRC.ResumeLayout(false);
            this.DDRC.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.PORTB_PINB.ResumeLayout(false);
            this.PORTB_PINB.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox command_box;
        private System.IO.Ports.SerialPort Isobot_com;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox DDRB;
        private System.Windows.Forms.GroupBox PORTC_PINC;
        private System.Windows.Forms.CheckBox DDRB7;
        private System.Windows.Forms.CheckBox DDRB6;
        private System.Windows.Forms.CheckBox DDRB5;
        private System.Windows.Forms.CheckBox DDRB4;
        private System.Windows.Forms.CheckBox DDRB3;
        private System.Windows.Forms.CheckBox DDRB2;
        private System.Windows.Forms.CheckBox DDRB1;
        private System.Windows.Forms.CheckBox DDRB0;
        private System.Windows.Forms.CheckBox PORTC7;
        private System.Windows.Forms.CheckBox PORTC0;
        private System.Windows.Forms.CheckBox PORTC6;
        private System.Windows.Forms.CheckBox PORTC1;
        private System.Windows.Forms.CheckBox PORTC5;
        private System.Windows.Forms.CheckBox PORTC2;
        private System.Windows.Forms.CheckBox PORTC4;
        private System.Windows.Forms.CheckBox PORTC3;
        private System.Windows.Forms.CheckBox PORTB7;
        private System.Windows.Forms.CheckBox PORTB0;
        private System.Windows.Forms.CheckBox PORTB6;
        private System.Windows.Forms.CheckBox PORTB1;
        private System.Windows.Forms.CheckBox PORTB5;
        private System.Windows.Forms.CheckBox PORTB2;
        private System.Windows.Forms.CheckBox PORTB4;
        private System.Windows.Forms.CheckBox PORTB3;
        private System.Windows.Forms.GroupBox DDRC;
        private System.Windows.Forms.CheckBox DDRC7;
        private System.Windows.Forms.CheckBox DDRC0;
        private System.Windows.Forms.CheckBox DDRC6;
        private System.Windows.Forms.CheckBox DDRC1;
        private System.Windows.Forms.CheckBox DDRC5;
        private System.Windows.Forms.CheckBox DDRC2;
        private System.Windows.Forms.CheckBox DDRC4;
        private System.Windows.Forms.CheckBox DDRC3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton PINC7;
        private System.Windows.Forms.RadioButton PINC6;
        private System.Windows.Forms.RadioButton PINC5;
        private System.Windows.Forms.RadioButton PINC4;
        private System.Windows.Forms.RadioButton PINC3;
        private System.Windows.Forms.RadioButton PINC2;
        private System.Windows.Forms.RadioButton PINC1;
        private System.Windows.Forms.RadioButton PINC0;
        private System.Windows.Forms.GroupBox PORTB_PINB;
        private System.Windows.Forms.RadioButton PINB7;
        private System.Windows.Forms.RadioButton PINB6;
        private System.Windows.Forms.RadioButton PINB5;
        private System.Windows.Forms.RadioButton PINB4;
        private System.Windows.Forms.RadioButton PINB3;
        private System.Windows.Forms.RadioButton PINB2;
        private System.Windows.Forms.RadioButton PINB1;
        private System.Windows.Forms.RadioButton PINB0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UP;
        private System.Windows.Forms.Button LEFT;
        private System.Windows.Forms.Button DOWN;
        private System.Windows.Forms.Button RIGHT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ROTATE_RIGHT;
        private System.Windows.Forms.Button ROTATE_LEFT;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button UP_LEFT;
        private System.Windows.Forms.Button DOWN_LEFT;
        private System.Windows.Forms.Button DOWN_RIGHT;
        private System.Windows.Forms.Button UP_RIGHT;
    }
}

