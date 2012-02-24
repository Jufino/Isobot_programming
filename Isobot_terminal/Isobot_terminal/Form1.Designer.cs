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
            this.Scanning = new System.ComponentModel.BackgroundWorker();
            this.DDRB = new System.Windows.Forms.GroupBox();
            this.DDRB5 = new System.Windows.Forms.CheckBox();
            this.DDRB4 = new System.Windows.Forms.CheckBox();
            this.DDRB3 = new System.Windows.Forms.CheckBox();
            this.DDRB2 = new System.Windows.Forms.CheckBox();
            this.DDRB1 = new System.Windows.Forms.CheckBox();
            this.DDRB0 = new System.Windows.Forms.CheckBox();
            this.PORTC_PINC = new System.Windows.Forms.GroupBox();
            this.PORTC0 = new System.Windows.Forms.CheckBox();
            this.PINC0 = new System.Windows.Forms.RadioButton();
            this.PORTC1 = new System.Windows.Forms.CheckBox();
            this.PINC1 = new System.Windows.Forms.RadioButton();
            this.PORTC2 = new System.Windows.Forms.CheckBox();
            this.PINC2 = new System.Windows.Forms.RadioButton();
            this.PORTC3 = new System.Windows.Forms.CheckBox();
            this.PINC3 = new System.Windows.Forms.RadioButton();
            this.PORTC5 = new System.Windows.Forms.CheckBox();
            this.PORTC4 = new System.Windows.Forms.CheckBox();
            this.PINC4 = new System.Windows.Forms.RadioButton();
            this.PINC5 = new System.Windows.Forms.RadioButton();
            this.PORTB0 = new System.Windows.Forms.CheckBox();
            this.PORTB1 = new System.Windows.Forms.CheckBox();
            this.PORTB5 = new System.Windows.Forms.CheckBox();
            this.PORTB2 = new System.Windows.Forms.CheckBox();
            this.PORTB4 = new System.Windows.Forms.CheckBox();
            this.PORTB3 = new System.Windows.Forms.CheckBox();
            this.DDRC = new System.Windows.Forms.GroupBox();
            this.DDRC0 = new System.Windows.Forms.CheckBox();
            this.DDRC1 = new System.Windows.Forms.CheckBox();
            this.DDRC5 = new System.Windows.Forms.CheckBox();
            this.DDRC2 = new System.Windows.Forms.CheckBox();
            this.DDRC4 = new System.Windows.Forms.CheckBox();
            this.DDRC3 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ADC5_progressbar = new System.Windows.Forms.ProgressBar();
            this.ADC4_progressbar = new System.Windows.Forms.ProgressBar();
            this.ADC3_progressbar = new System.Windows.Forms.ProgressBar();
            this.ADC2_progressbar = new System.Windows.Forms.ProgressBar();
            this.ADC1_progressbar = new System.Windows.Forms.ProgressBar();
            this.ADC0_progressbar = new System.Windows.Forms.ProgressBar();
            this.ADC_ON_OFF = new System.Windows.Forms.CheckBox();
            this.ADC1_radiobutton = new System.Windows.Forms.RadioButton();
            this.ADC5_radiobutton = new System.Windows.Forms.RadioButton();
            this.ADC4_radiobutton = new System.Windows.Forms.RadioButton();
            this.ADC3_radiobutton = new System.Windows.Forms.RadioButton();
            this.ADC2_radiobutton = new System.Windows.Forms.RadioButton();
            this.ADC0_radiobutton = new System.Windows.Forms.RadioButton();
            this.ADC5_box = new System.Windows.Forms.TextBox();
            this.ADC2_box = new System.Windows.Forms.TextBox();
            this.ADC3_box = new System.Windows.Forms.TextBox();
            this.ADC4_box = new System.Windows.Forms.TextBox();
            this.ADC1_box = new System.Windows.Forms.TextBox();
            this.ADC0_box = new System.Windows.Forms.TextBox();
            this.PORTB_PINB = new System.Windows.Forms.GroupBox();
            this.PINB4 = new System.Windows.Forms.RadioButton();
            this.PINB3 = new System.Windows.Forms.RadioButton();
            this.PINB5 = new System.Windows.Forms.RadioButton();
            this.PINB2 = new System.Windows.Forms.RadioButton();
            this.PINB1 = new System.Windows.Forms.RadioButton();
            this.PINB0 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zdvih_zozadu = new System.Windows.Forms.Button();
            this.Zdvih_zpredu = new System.Windows.Forms.Button();
            this.zaklon = new System.Windows.Forms.Button();
            this.predklon = new System.Windows.Forms.Button();
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
            this.Open_button = new System.Windows.Forms.Button();
            this.GPIO_refresh = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GPIO_ON_OFF = new System.Windows.Forms.CheckBox();
            this.ADC_refresh = new System.Windows.Forms.Timer(this.components);
            this.DDRB.SuspendLayout();
            this.PORTC_PINC.SuspendLayout();
            this.DDRC.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.PORTB_PINB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // Scanning
            // 
            this.Scanning.DoWork += new System.ComponentModel.DoWorkEventHandler(this.scanning);
            // 
            // DDRB
            // 
            this.DDRB.Controls.Add(this.DDRB5);
            this.DDRB.Controls.Add(this.DDRB4);
            this.DDRB.Controls.Add(this.DDRB3);
            this.DDRB.Controls.Add(this.DDRB2);
            this.DDRB.Controls.Add(this.DDRB1);
            this.DDRB.Controls.Add(this.DDRB0);
            this.DDRB.Enabled = false;
            this.DDRB.Location = new System.Drawing.Point(6, 42);
            this.DDRB.Name = "DDRB";
            this.DDRB.Size = new System.Drawing.Size(94, 103);
            this.DDRB.TabIndex = 2;
            this.DDRB.TabStop = false;
            this.DDRB.Text = "DDRB";
            // 
            // DDRB5
            // 
            this.DDRB5.AutoSize = true;
            this.DDRB5.Location = new System.Drawing.Point(53, 70);
            this.DDRB5.Name = "DDRB5";
            this.DDRB5.Size = new System.Drawing.Size(32, 17);
            this.DDRB5.TabIndex = 0;
            this.DDRB5.Text = "5";
            this.DDRB5.UseVisualStyleBackColor = true;
            this.DDRB5.CheckedChanged += new System.EventHandler(this.zmena_DDRB);
            // 
            // DDRB4
            // 
            this.DDRB4.AutoSize = true;
            this.DDRB4.Location = new System.Drawing.Point(53, 45);
            this.DDRB4.Name = "DDRB4";
            this.DDRB4.Size = new System.Drawing.Size(32, 17);
            this.DDRB4.TabIndex = 0;
            this.DDRB4.Text = "4";
            this.DDRB4.UseVisualStyleBackColor = true;
            this.DDRB4.CheckedChanged += new System.EventHandler(this.zmena_DDRB);
            // 
            // DDRB3
            // 
            this.DDRB3.AutoSize = true;
            this.DDRB3.Location = new System.Drawing.Point(53, 20);
            this.DDRB3.Name = "DDRB3";
            this.DDRB3.Size = new System.Drawing.Size(32, 17);
            this.DDRB3.TabIndex = 0;
            this.DDRB3.Text = "3";
            this.DDRB3.UseVisualStyleBackColor = true;
            this.DDRB3.CheckedChanged += new System.EventHandler(this.zmena_DDRB);
            // 
            // DDRB2
            // 
            this.DDRB2.AutoSize = true;
            this.DDRB2.Location = new System.Drawing.Point(13, 70);
            this.DDRB2.Name = "DDRB2";
            this.DDRB2.Size = new System.Drawing.Size(32, 17);
            this.DDRB2.TabIndex = 0;
            this.DDRB2.Text = "2";
            this.DDRB2.UseVisualStyleBackColor = true;
            this.DDRB2.CheckedChanged += new System.EventHandler(this.zmena_DDRB);
            // 
            // DDRB1
            // 
            this.DDRB1.AutoSize = true;
            this.DDRB1.Location = new System.Drawing.Point(13, 45);
            this.DDRB1.Name = "DDRB1";
            this.DDRB1.Size = new System.Drawing.Size(32, 17);
            this.DDRB1.TabIndex = 0;
            this.DDRB1.Text = "1";
            this.DDRB1.UseVisualStyleBackColor = true;
            this.DDRB1.CheckedChanged += new System.EventHandler(this.zmena_DDRB);
            // 
            // DDRB0
            // 
            this.DDRB0.AutoSize = true;
            this.DDRB0.Location = new System.Drawing.Point(13, 20);
            this.DDRB0.Name = "DDRB0";
            this.DDRB0.Size = new System.Drawing.Size(32, 17);
            this.DDRB0.TabIndex = 0;
            this.DDRB0.Text = "0";
            this.DDRB0.UseVisualStyleBackColor = true;
            this.DDRB0.CheckedChanged += new System.EventHandler(this.zmena_DDRB);
            // 
            // PORTC_PINC
            // 
            this.PORTC_PINC.Controls.Add(this.PORTC0);
            this.PORTC_PINC.Controls.Add(this.PINC0);
            this.PORTC_PINC.Controls.Add(this.PORTC1);
            this.PORTC_PINC.Controls.Add(this.PINC1);
            this.PORTC_PINC.Controls.Add(this.PORTC2);
            this.PORTC_PINC.Controls.Add(this.PINC2);
            this.PORTC_PINC.Controls.Add(this.PORTC3);
            this.PORTC_PINC.Controls.Add(this.PINC3);
            this.PORTC_PINC.Controls.Add(this.PORTC5);
            this.PORTC_PINC.Controls.Add(this.PORTC4);
            this.PORTC_PINC.Controls.Add(this.PINC4);
            this.PORTC_PINC.Controls.Add(this.PINC5);
            this.PORTC_PINC.Enabled = false;
            this.PORTC_PINC.Location = new System.Drawing.Point(300, 42);
            this.PORTC_PINC.Name = "PORTC_PINC";
            this.PORTC_PINC.Size = new System.Drawing.Size(91, 103);
            this.PORTC_PINC.TabIndex = 2;
            this.PORTC_PINC.TabStop = false;
            this.PORTC_PINC.Text = "PORTC/PINC";
            // 
            // PORTC0
            // 
            this.PORTC0.AutoSize = true;
            this.PORTC0.Location = new System.Drawing.Point(10, 20);
            this.PORTC0.Name = "PORTC0";
            this.PORTC0.Size = new System.Drawing.Size(32, 17);
            this.PORTC0.TabIndex = 0;
            this.PORTC0.Text = "0";
            this.PORTC0.UseVisualStyleBackColor = true;
            this.PORTC0.Visible = false;
            this.PORTC0.CheckedChanged += new System.EventHandler(this.zmena_PORTC);
            // 
            // PINC0
            // 
            this.PINC0.AutoCheck = false;
            this.PINC0.AutoSize = true;
            this.PINC0.Enabled = false;
            this.PINC0.Location = new System.Drawing.Point(10, 20);
            this.PINC0.Name = "PINC0";
            this.PINC0.Size = new System.Drawing.Size(31, 17);
            this.PINC0.TabIndex = 0;
            this.PINC0.TabStop = true;
            this.PINC0.Text = "0";
            this.PINC0.UseVisualStyleBackColor = true;
            // 
            // PORTC1
            // 
            this.PORTC1.AutoSize = true;
            this.PORTC1.Location = new System.Drawing.Point(10, 45);
            this.PORTC1.Name = "PORTC1";
            this.PORTC1.Size = new System.Drawing.Size(32, 17);
            this.PORTC1.TabIndex = 0;
            this.PORTC1.Text = "1";
            this.PORTC1.UseVisualStyleBackColor = true;
            this.PORTC1.Visible = false;
            this.PORTC1.CheckedChanged += new System.EventHandler(this.zmena_PORTC);
            // 
            // PINC1
            // 
            this.PINC1.AutoCheck = false;
            this.PINC1.AutoSize = true;
            this.PINC1.Enabled = false;
            this.PINC1.Location = new System.Drawing.Point(10, 45);
            this.PINC1.Name = "PINC1";
            this.PINC1.Size = new System.Drawing.Size(31, 17);
            this.PINC1.TabIndex = 0;
            this.PINC1.TabStop = true;
            this.PINC1.Text = "1";
            this.PINC1.UseVisualStyleBackColor = true;
            // 
            // PORTC2
            // 
            this.PORTC2.AutoSize = true;
            this.PORTC2.Location = new System.Drawing.Point(10, 70);
            this.PORTC2.Name = "PORTC2";
            this.PORTC2.Size = new System.Drawing.Size(32, 17);
            this.PORTC2.TabIndex = 0;
            this.PORTC2.Text = "2";
            this.PORTC2.UseVisualStyleBackColor = true;
            this.PORTC2.Visible = false;
            this.PORTC2.CheckedChanged += new System.EventHandler(this.zmena_PORTC);
            // 
            // PINC2
            // 
            this.PINC2.AutoCheck = false;
            this.PINC2.AutoSize = true;
            this.PINC2.Enabled = false;
            this.PINC2.Location = new System.Drawing.Point(10, 70);
            this.PINC2.Name = "PINC2";
            this.PINC2.Size = new System.Drawing.Size(31, 17);
            this.PINC2.TabIndex = 0;
            this.PINC2.TabStop = true;
            this.PINC2.Text = "2";
            this.PINC2.UseVisualStyleBackColor = true;
            // 
            // PORTC3
            // 
            this.PORTC3.AutoSize = true;
            this.PORTC3.Location = new System.Drawing.Point(50, 20);
            this.PORTC3.Name = "PORTC3";
            this.PORTC3.Size = new System.Drawing.Size(32, 17);
            this.PORTC3.TabIndex = 0;
            this.PORTC3.Text = "3";
            this.PORTC3.UseVisualStyleBackColor = true;
            this.PORTC3.Visible = false;
            this.PORTC3.CheckedChanged += new System.EventHandler(this.zmena_PORTC);
            // 
            // PINC3
            // 
            this.PINC3.AutoCheck = false;
            this.PINC3.AutoSize = true;
            this.PINC3.Enabled = false;
            this.PINC3.Location = new System.Drawing.Point(50, 20);
            this.PINC3.Name = "PINC3";
            this.PINC3.Size = new System.Drawing.Size(31, 17);
            this.PINC3.TabIndex = 0;
            this.PINC3.TabStop = true;
            this.PINC3.Text = "3";
            this.PINC3.UseVisualStyleBackColor = true;
            // 
            // PORTC5
            // 
            this.PORTC5.AutoSize = true;
            this.PORTC5.Location = new System.Drawing.Point(50, 70);
            this.PORTC5.Name = "PORTC5";
            this.PORTC5.Size = new System.Drawing.Size(32, 17);
            this.PORTC5.TabIndex = 0;
            this.PORTC5.Text = "5";
            this.PORTC5.UseVisualStyleBackColor = true;
            this.PORTC5.Visible = false;
            this.PORTC5.CheckedChanged += new System.EventHandler(this.zmena_PORTC);
            // 
            // PORTC4
            // 
            this.PORTC4.AutoSize = true;
            this.PORTC4.Location = new System.Drawing.Point(50, 45);
            this.PORTC4.Name = "PORTC4";
            this.PORTC4.Size = new System.Drawing.Size(32, 17);
            this.PORTC4.TabIndex = 0;
            this.PORTC4.Text = "4";
            this.PORTC4.UseVisualStyleBackColor = true;
            this.PORTC4.Visible = false;
            this.PORTC4.CheckedChanged += new System.EventHandler(this.zmena_PORTC);
            // 
            // PINC4
            // 
            this.PINC4.AutoCheck = false;
            this.PINC4.AutoSize = true;
            this.PINC4.Enabled = false;
            this.PINC4.Location = new System.Drawing.Point(50, 45);
            this.PINC4.Name = "PINC4";
            this.PINC4.Size = new System.Drawing.Size(31, 17);
            this.PINC4.TabIndex = 0;
            this.PINC4.TabStop = true;
            this.PINC4.Text = "4";
            this.PINC4.UseVisualStyleBackColor = true;
            // 
            // PINC5
            // 
            this.PINC5.AutoCheck = false;
            this.PINC5.AutoSize = true;
            this.PINC5.Enabled = false;
            this.PINC5.Location = new System.Drawing.Point(50, 70);
            this.PINC5.Name = "PINC5";
            this.PINC5.Size = new System.Drawing.Size(31, 17);
            this.PINC5.TabIndex = 0;
            this.PINC5.TabStop = true;
            this.PINC5.Text = "5";
            this.PINC5.UseVisualStyleBackColor = true;
            // 
            // PORTB0
            // 
            this.PORTB0.AutoSize = true;
            this.PORTB0.Location = new System.Drawing.Point(10, 20);
            this.PORTB0.Name = "PORTB0";
            this.PORTB0.Size = new System.Drawing.Size(32, 17);
            this.PORTB0.TabIndex = 0;
            this.PORTB0.Text = "0";
            this.PORTB0.UseVisualStyleBackColor = true;
            this.PORTB0.Visible = false;
            this.PORTB0.CheckedChanged += new System.EventHandler(this.zmena_PORTB);
            // 
            // PORTB1
            // 
            this.PORTB1.AutoSize = true;
            this.PORTB1.Location = new System.Drawing.Point(10, 45);
            this.PORTB1.Name = "PORTB1";
            this.PORTB1.Size = new System.Drawing.Size(32, 17);
            this.PORTB1.TabIndex = 0;
            this.PORTB1.Text = "1";
            this.PORTB1.UseVisualStyleBackColor = true;
            this.PORTB1.Visible = false;
            this.PORTB1.CheckedChanged += new System.EventHandler(this.zmena_PORTB);
            // 
            // PORTB5
            // 
            this.PORTB5.AutoSize = true;
            this.PORTB5.Location = new System.Drawing.Point(50, 70);
            this.PORTB5.Name = "PORTB5";
            this.PORTB5.Size = new System.Drawing.Size(32, 17);
            this.PORTB5.TabIndex = 0;
            this.PORTB5.Text = "5";
            this.PORTB5.UseVisualStyleBackColor = true;
            this.PORTB5.Visible = false;
            this.PORTB5.CheckedChanged += new System.EventHandler(this.zmena_PORTB);
            // 
            // PORTB2
            // 
            this.PORTB2.AutoSize = true;
            this.PORTB2.Location = new System.Drawing.Point(10, 70);
            this.PORTB2.Name = "PORTB2";
            this.PORTB2.Size = new System.Drawing.Size(32, 17);
            this.PORTB2.TabIndex = 0;
            this.PORTB2.Text = "2";
            this.PORTB2.UseVisualStyleBackColor = true;
            this.PORTB2.Visible = false;
            this.PORTB2.CheckedChanged += new System.EventHandler(this.zmena_PORTB);
            // 
            // PORTB4
            // 
            this.PORTB4.AutoSize = true;
            this.PORTB4.Location = new System.Drawing.Point(50, 45);
            this.PORTB4.Name = "PORTB4";
            this.PORTB4.Size = new System.Drawing.Size(32, 17);
            this.PORTB4.TabIndex = 0;
            this.PORTB4.Text = "4";
            this.PORTB4.UseVisualStyleBackColor = true;
            this.PORTB4.Visible = false;
            this.PORTB4.CheckedChanged += new System.EventHandler(this.zmena_PORTB);
            // 
            // PORTB3
            // 
            this.PORTB3.AutoSize = true;
            this.PORTB3.Location = new System.Drawing.Point(50, 20);
            this.PORTB3.Name = "PORTB3";
            this.PORTB3.Size = new System.Drawing.Size(32, 17);
            this.PORTB3.TabIndex = 0;
            this.PORTB3.Text = "3";
            this.PORTB3.UseVisualStyleBackColor = true;
            this.PORTB3.Visible = false;
            this.PORTB3.CheckedChanged += new System.EventHandler(this.zmena_PORTB);
            // 
            // DDRC
            // 
            this.DDRC.Controls.Add(this.DDRC0);
            this.DDRC.Controls.Add(this.DDRC1);
            this.DDRC.Controls.Add(this.DDRC5);
            this.DDRC.Controls.Add(this.DDRC2);
            this.DDRC.Controls.Add(this.DDRC4);
            this.DDRC.Controls.Add(this.DDRC3);
            this.DDRC.Enabled = false;
            this.DDRC.Location = new System.Drawing.Point(203, 42);
            this.DDRC.Name = "DDRC";
            this.DDRC.Size = new System.Drawing.Size(91, 103);
            this.DDRC.TabIndex = 2;
            this.DDRC.TabStop = false;
            this.DDRC.Text = "DDRC";
            // 
            // DDRC0
            // 
            this.DDRC0.AutoSize = true;
            this.DDRC0.Location = new System.Drawing.Point(10, 20);
            this.DDRC0.Name = "DDRC0";
            this.DDRC0.Size = new System.Drawing.Size(32, 17);
            this.DDRC0.TabIndex = 0;
            this.DDRC0.Text = "0";
            this.DDRC0.UseVisualStyleBackColor = true;
            this.DDRC0.CheckedChanged += new System.EventHandler(this.zmena_DDRC);
            // 
            // DDRC1
            // 
            this.DDRC1.AutoSize = true;
            this.DDRC1.Location = new System.Drawing.Point(10, 45);
            this.DDRC1.Name = "DDRC1";
            this.DDRC1.Size = new System.Drawing.Size(32, 17);
            this.DDRC1.TabIndex = 0;
            this.DDRC1.Text = "1";
            this.DDRC1.UseVisualStyleBackColor = true;
            this.DDRC1.CheckedChanged += new System.EventHandler(this.zmena_DDRC);
            // 
            // DDRC5
            // 
            this.DDRC5.AutoSize = true;
            this.DDRC5.Location = new System.Drawing.Point(50, 70);
            this.DDRC5.Name = "DDRC5";
            this.DDRC5.Size = new System.Drawing.Size(32, 17);
            this.DDRC5.TabIndex = 0;
            this.DDRC5.Text = "5";
            this.DDRC5.UseVisualStyleBackColor = true;
            this.DDRC5.CheckedChanged += new System.EventHandler(this.zmena_DDRC);
            // 
            // DDRC2
            // 
            this.DDRC2.AutoSize = true;
            this.DDRC2.Location = new System.Drawing.Point(10, 70);
            this.DDRC2.Name = "DDRC2";
            this.DDRC2.Size = new System.Drawing.Size(32, 17);
            this.DDRC2.TabIndex = 0;
            this.DDRC2.Text = "2";
            this.DDRC2.UseVisualStyleBackColor = true;
            this.DDRC2.CheckedChanged += new System.EventHandler(this.zmena_DDRC);
            // 
            // DDRC4
            // 
            this.DDRC4.AutoSize = true;
            this.DDRC4.Location = new System.Drawing.Point(50, 45);
            this.DDRC4.Name = "DDRC4";
            this.DDRC4.Size = new System.Drawing.Size(32, 17);
            this.DDRC4.TabIndex = 0;
            this.DDRC4.Text = "4";
            this.DDRC4.UseVisualStyleBackColor = true;
            this.DDRC4.CheckedChanged += new System.EventHandler(this.zmena_DDRC);
            // 
            // DDRC3
            // 
            this.DDRC3.AutoSize = true;
            this.DDRC3.Location = new System.Drawing.Point(50, 20);
            this.DDRC3.Name = "DDRC3";
            this.DDRC3.Size = new System.Drawing.Size(32, 17);
            this.DDRC3.TabIndex = 0;
            this.DDRC3.Text = "3";
            this.DDRC3.UseVisualStyleBackColor = true;
            this.DDRC3.CheckedChanged += new System.EventHandler(this.zmena_DDRC);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ADC5_progressbar);
            this.groupBox5.Controls.Add(this.ADC4_progressbar);
            this.groupBox5.Controls.Add(this.ADC3_progressbar);
            this.groupBox5.Controls.Add(this.ADC2_progressbar);
            this.groupBox5.Controls.Add(this.ADC1_progressbar);
            this.groupBox5.Controls.Add(this.ADC0_progressbar);
            this.groupBox5.Controls.Add(this.ADC_ON_OFF);
            this.groupBox5.Controls.Add(this.ADC1_radiobutton);
            this.groupBox5.Controls.Add(this.ADC5_radiobutton);
            this.groupBox5.Controls.Add(this.ADC4_radiobutton);
            this.groupBox5.Controls.Add(this.ADC3_radiobutton);
            this.groupBox5.Controls.Add(this.ADC2_radiobutton);
            this.groupBox5.Controls.Add(this.ADC0_radiobutton);
            this.groupBox5.Controls.Add(this.ADC5_box);
            this.groupBox5.Controls.Add(this.ADC2_box);
            this.groupBox5.Controls.Add(this.ADC3_box);
            this.groupBox5.Controls.Add(this.ADC4_box);
            this.groupBox5.Controls.Add(this.ADC1_box);
            this.groupBox5.Controls.Add(this.ADC0_box);
            this.groupBox5.Location = new System.Drawing.Point(422, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(359, 154);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ADC";
            // 
            // ADC5_progressbar
            // 
            this.ADC5_progressbar.Location = new System.Drawing.Point(276, 115);
            this.ADC5_progressbar.Maximum = 255;
            this.ADC5_progressbar.Name = "ADC5_progressbar";
            this.ADC5_progressbar.Size = new System.Drawing.Size(74, 21);
            this.ADC5_progressbar.TabIndex = 4;
            // 
            // ADC4_progressbar
            // 
            this.ADC4_progressbar.Location = new System.Drawing.Point(276, 80);
            this.ADC4_progressbar.Maximum = 255;
            this.ADC4_progressbar.Name = "ADC4_progressbar";
            this.ADC4_progressbar.Size = new System.Drawing.Size(74, 21);
            this.ADC4_progressbar.TabIndex = 4;
            // 
            // ADC3_progressbar
            // 
            this.ADC3_progressbar.Location = new System.Drawing.Point(276, 42);
            this.ADC3_progressbar.Maximum = 255;
            this.ADC3_progressbar.Name = "ADC3_progressbar";
            this.ADC3_progressbar.Size = new System.Drawing.Size(74, 21);
            this.ADC3_progressbar.TabIndex = 4;
            // 
            // ADC2_progressbar
            // 
            this.ADC2_progressbar.Location = new System.Drawing.Point(99, 115);
            this.ADC2_progressbar.Maximum = 255;
            this.ADC2_progressbar.Name = "ADC2_progressbar";
            this.ADC2_progressbar.Size = new System.Drawing.Size(74, 21);
            this.ADC2_progressbar.TabIndex = 4;
            // 
            // ADC1_progressbar
            // 
            this.ADC1_progressbar.Location = new System.Drawing.Point(99, 80);
            this.ADC1_progressbar.Maximum = 255;
            this.ADC1_progressbar.Name = "ADC1_progressbar";
            this.ADC1_progressbar.Size = new System.Drawing.Size(74, 21);
            this.ADC1_progressbar.TabIndex = 4;
            // 
            // ADC0_progressbar
            // 
            this.ADC0_progressbar.Location = new System.Drawing.Point(99, 42);
            this.ADC0_progressbar.Maximum = 255;
            this.ADC0_progressbar.Name = "ADC0_progressbar";
            this.ADC0_progressbar.Size = new System.Drawing.Size(74, 21);
            this.ADC0_progressbar.TabIndex = 4;
            // 
            // ADC_ON_OFF
            // 
            this.ADC_ON_OFF.AutoSize = true;
            this.ADC_ON_OFF.Location = new System.Drawing.Point(9, 19);
            this.ADC_ON_OFF.Name = "ADC_ON_OFF";
            this.ADC_ON_OFF.Size = new System.Drawing.Size(59, 17);
            this.ADC_ON_OFF.TabIndex = 3;
            this.ADC_ON_OFF.Text = "Enable";
            this.ADC_ON_OFF.UseVisualStyleBackColor = true;
            this.ADC_ON_OFF.CheckedChanged += new System.EventHandler(this.zmena_ON_OFF);
            // 
            // ADC1_radiobutton
            // 
            this.ADC1_radiobutton.AutoSize = true;
            this.ADC1_radiobutton.Enabled = false;
            this.ADC1_radiobutton.Location = new System.Drawing.Point(9, 82);
            this.ADC1_radiobutton.Name = "ADC1_radiobutton";
            this.ADC1_radiobutton.Size = new System.Drawing.Size(56, 17);
            this.ADC1_radiobutton.TabIndex = 2;
            this.ADC1_radiobutton.Text = "ADC 1";
            this.ADC1_radiobutton.UseVisualStyleBackColor = true;
            this.ADC1_radiobutton.CheckedChanged += new System.EventHandler(this.zmena_ADC_nastavenia);
            // 
            // ADC5_radiobutton
            // 
            this.ADC5_radiobutton.AutoSize = true;
            this.ADC5_radiobutton.Enabled = false;
            this.ADC5_radiobutton.Location = new System.Drawing.Point(188, 116);
            this.ADC5_radiobutton.Name = "ADC5_radiobutton";
            this.ADC5_radiobutton.Size = new System.Drawing.Size(56, 17);
            this.ADC5_radiobutton.TabIndex = 2;
            this.ADC5_radiobutton.Text = "ADC 5";
            this.ADC5_radiobutton.UseVisualStyleBackColor = true;
            this.ADC5_radiobutton.CheckedChanged += new System.EventHandler(this.zmena_ADC_nastavenia);
            // 
            // ADC4_radiobutton
            // 
            this.ADC4_radiobutton.AutoSize = true;
            this.ADC4_radiobutton.Enabled = false;
            this.ADC4_radiobutton.Location = new System.Drawing.Point(188, 82);
            this.ADC4_radiobutton.Name = "ADC4_radiobutton";
            this.ADC4_radiobutton.Size = new System.Drawing.Size(56, 17);
            this.ADC4_radiobutton.TabIndex = 2;
            this.ADC4_radiobutton.Text = "ADC 4";
            this.ADC4_radiobutton.UseVisualStyleBackColor = true;
            this.ADC4_radiobutton.CheckedChanged += new System.EventHandler(this.zmena_ADC_nastavenia);
            // 
            // ADC3_radiobutton
            // 
            this.ADC3_radiobutton.AutoSize = true;
            this.ADC3_radiobutton.Enabled = false;
            this.ADC3_radiobutton.Location = new System.Drawing.Point(188, 44);
            this.ADC3_radiobutton.Name = "ADC3_radiobutton";
            this.ADC3_radiobutton.Size = new System.Drawing.Size(56, 17);
            this.ADC3_radiobutton.TabIndex = 2;
            this.ADC3_radiobutton.Text = "ADC 3";
            this.ADC3_radiobutton.UseVisualStyleBackColor = true;
            this.ADC3_radiobutton.CheckedChanged += new System.EventHandler(this.zmena_ADC_nastavenia);
            // 
            // ADC2_radiobutton
            // 
            this.ADC2_radiobutton.AutoSize = true;
            this.ADC2_radiobutton.Enabled = false;
            this.ADC2_radiobutton.Location = new System.Drawing.Point(9, 116);
            this.ADC2_radiobutton.Name = "ADC2_radiobutton";
            this.ADC2_radiobutton.Size = new System.Drawing.Size(56, 17);
            this.ADC2_radiobutton.TabIndex = 2;
            this.ADC2_radiobutton.Text = "ADC 2";
            this.ADC2_radiobutton.UseVisualStyleBackColor = true;
            this.ADC2_radiobutton.CheckedChanged += new System.EventHandler(this.zmena_ADC_nastavenia);
            // 
            // ADC0_radiobutton
            // 
            this.ADC0_radiobutton.AutoSize = true;
            this.ADC0_radiobutton.Checked = true;
            this.ADC0_radiobutton.Enabled = false;
            this.ADC0_radiobutton.Location = new System.Drawing.Point(9, 44);
            this.ADC0_radiobutton.Name = "ADC0_radiobutton";
            this.ADC0_radiobutton.Size = new System.Drawing.Size(56, 17);
            this.ADC0_radiobutton.TabIndex = 2;
            this.ADC0_radiobutton.TabStop = true;
            this.ADC0_radiobutton.Text = "ADC 0";
            this.ADC0_radiobutton.UseVisualStyleBackColor = true;
            this.ADC0_radiobutton.CheckedChanged += new System.EventHandler(this.zmena_ADC_nastavenia);
            // 
            // ADC5_box
            // 
            this.ADC5_box.Enabled = false;
            this.ADC5_box.Location = new System.Drawing.Point(245, 115);
            this.ADC5_box.Name = "ADC5_box";
            this.ADC5_box.Size = new System.Drawing.Size(25, 20);
            this.ADC5_box.TabIndex = 0;
            this.ADC5_box.Text = "x";
            this.ADC5_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ADC2_box
            // 
            this.ADC2_box.Enabled = false;
            this.ADC2_box.Location = new System.Drawing.Point(68, 115);
            this.ADC2_box.Name = "ADC2_box";
            this.ADC2_box.Size = new System.Drawing.Size(25, 20);
            this.ADC2_box.TabIndex = 0;
            this.ADC2_box.Text = "x";
            this.ADC2_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ADC3_box
            // 
            this.ADC3_box.Enabled = false;
            this.ADC3_box.Location = new System.Drawing.Point(245, 43);
            this.ADC3_box.Name = "ADC3_box";
            this.ADC3_box.Size = new System.Drawing.Size(25, 20);
            this.ADC3_box.TabIndex = 0;
            this.ADC3_box.Text = "x";
            this.ADC3_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ADC4_box
            // 
            this.ADC4_box.Enabled = false;
            this.ADC4_box.Location = new System.Drawing.Point(245, 81);
            this.ADC4_box.Name = "ADC4_box";
            this.ADC4_box.Size = new System.Drawing.Size(25, 20);
            this.ADC4_box.TabIndex = 0;
            this.ADC4_box.Text = "x";
            this.ADC4_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ADC1_box
            // 
            this.ADC1_box.Enabled = false;
            this.ADC1_box.Location = new System.Drawing.Point(68, 81);
            this.ADC1_box.Name = "ADC1_box";
            this.ADC1_box.Size = new System.Drawing.Size(25, 20);
            this.ADC1_box.TabIndex = 0;
            this.ADC1_box.Text = "x";
            this.ADC1_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ADC0_box
            // 
            this.ADC0_box.Enabled = false;
            this.ADC0_box.Location = new System.Drawing.Point(68, 43);
            this.ADC0_box.Name = "ADC0_box";
            this.ADC0_box.Size = new System.Drawing.Size(25, 20);
            this.ADC0_box.TabIndex = 0;
            this.ADC0_box.Text = "x";
            this.ADC0_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PORTB_PINB
            // 
            this.PORTB_PINB.Controls.Add(this.PORTB4);
            this.PORTB_PINB.Controls.Add(this.PORTB3);
            this.PORTB_PINB.Controls.Add(this.PINB4);
            this.PORTB_PINB.Controls.Add(this.PINB3);
            this.PORTB_PINB.Controls.Add(this.PORTB5);
            this.PORTB_PINB.Controls.Add(this.PINB5);
            this.PORTB_PINB.Controls.Add(this.PORTB2);
            this.PORTB_PINB.Controls.Add(this.PINB2);
            this.PORTB_PINB.Controls.Add(this.PORTB1);
            this.PORTB_PINB.Controls.Add(this.PINB1);
            this.PORTB_PINB.Controls.Add(this.PORTB0);
            this.PORTB_PINB.Controls.Add(this.PINB0);
            this.PORTB_PINB.Enabled = false;
            this.PORTB_PINB.Location = new System.Drawing.Point(106, 42);
            this.PORTB_PINB.Name = "PORTB_PINB";
            this.PORTB_PINB.Size = new System.Drawing.Size(91, 103);
            this.PORTB_PINB.TabIndex = 2;
            this.PORTB_PINB.TabStop = false;
            this.PORTB_PINB.Text = "PORTB/PINB";
            // 
            // PINB4
            // 
            this.PINB4.AutoSize = true;
            this.PINB4.Enabled = false;
            this.PINB4.Location = new System.Drawing.Point(50, 45);
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
            this.PINB3.Location = new System.Drawing.Point(50, 20);
            this.PINB3.Name = "PINB3";
            this.PINB3.Size = new System.Drawing.Size(31, 17);
            this.PINB3.TabIndex = 0;
            this.PINB3.TabStop = true;
            this.PINB3.Text = "3";
            this.PINB3.UseVisualStyleBackColor = true;
            // 
            // PINB5
            // 
            this.PINB5.AutoSize = true;
            this.PINB5.Enabled = false;
            this.PINB5.Location = new System.Drawing.Point(50, 70);
            this.PINB5.Name = "PINB5";
            this.PINB5.Size = new System.Drawing.Size(31, 17);
            this.PINB5.TabIndex = 0;
            this.PINB5.TabStop = true;
            this.PINB5.Text = "5";
            this.PINB5.UseVisualStyleBackColor = true;
            // 
            // PINB2
            // 
            this.PINB2.AutoSize = true;
            this.PINB2.Enabled = false;
            this.PINB2.Location = new System.Drawing.Point(10, 70);
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
            this.PINB1.Location = new System.Drawing.Point(10, 45);
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
            this.PINB0.Location = new System.Drawing.Point(10, 20);
            this.PINB0.Name = "PINB0";
            this.PINB0.Size = new System.Drawing.Size(31, 17);
            this.PINB0.TabIndex = 0;
            this.PINB0.TabStop = true;
            this.PINB0.Text = "0";
            this.PINB0.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.zdvih_zozadu);
            this.panel1.Controls.Add(this.Zdvih_zpredu);
            this.panel1.Controls.Add(this.zaklon);
            this.panel1.Controls.Add(this.predklon);
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
            // zdvih_zozadu
            // 
            this.zdvih_zozadu.BackColor = System.Drawing.Color.Silver;
            this.zdvih_zozadu.Image = global::Isobot_terminal.Properties.Resources.kk;
            this.zdvih_zozadu.Location = new System.Drawing.Point(147, 169);
            this.zdvih_zozadu.Name = "zdvih_zozadu";
            this.zdvih_zozadu.Size = new System.Drawing.Size(50, 50);
            this.zdvih_zozadu.TabIndex = 6;
            this.zdvih_zozadu.UseVisualStyleBackColor = false;
            this.zdvih_zozadu.Click += new System.EventHandler(this.zdvih_zozadu_Click);
            // 
            // Zdvih_zpredu
            // 
            this.Zdvih_zpredu.BackColor = System.Drawing.Color.Silver;
            this.Zdvih_zpredu.Image = global::Isobot_terminal.Properties.Resources.Bez_názvujj;
            this.Zdvih_zpredu.Location = new System.Drawing.Point(204, 169);
            this.Zdvih_zpredu.Name = "Zdvih_zpredu";
            this.Zdvih_zpredu.Size = new System.Drawing.Size(50, 50);
            this.Zdvih_zpredu.TabIndex = 6;
            this.Zdvih_zpredu.UseVisualStyleBackColor = false;
            this.Zdvih_zpredu.Click += new System.EventHandler(this.Zdvih_zpredu_Click);
            // 
            // zaklon
            // 
            this.zaklon.BackColor = System.Drawing.Color.Silver;
            this.zaklon.Image = global::Isobot_terminal.Properties.Resources.Bez_názvu31;
            this.zaklon.Location = new System.Drawing.Point(425, 169);
            this.zaklon.Name = "zaklon";
            this.zaklon.Size = new System.Drawing.Size(50, 50);
            this.zaklon.TabIndex = 6;
            this.zaklon.UseVisualStyleBackColor = false;
            this.zaklon.Click += new System.EventHandler(this.zaklon_Click);
            // 
            // predklon
            // 
            this.predklon.BackColor = System.Drawing.Color.Silver;
            this.predklon.Image = global::Isobot_terminal.Properties.Resources.Bez_názvu11;
            this.predklon.Location = new System.Drawing.Point(366, 169);
            this.predklon.Name = "predklon";
            this.predklon.Size = new System.Drawing.Size(50, 50);
            this.predklon.TabIndex = 6;
            this.predklon.UseVisualStyleBackColor = false;
            this.predklon.Click += new System.EventHandler(this.predklon_Click);
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
            // Open_button
            // 
            this.Open_button.Location = new System.Drawing.Point(661, 215);
            this.Open_button.Name = "Open_button";
            this.Open_button.Size = new System.Drawing.Size(120, 23);
            this.Open_button.TabIndex = 7;
            this.Open_button.Text = "Open connection";
            this.Open_button.UseVisualStyleBackColor = true;
            this.Open_button.Click += new System.EventHandler(this.Open_button_Click);
            // 
            // GPIO_refresh
            // 
            this.GPIO_refresh.Interval = 300;
            this.GPIO_refresh.Tick += new System.EventHandler(this.GPIO_refresh_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GPIO_ON_OFF);
            this.groupBox1.Controls.Add(this.DDRB);
            this.groupBox1.Controls.Add(this.PORTC_PINC);
            this.groupBox1.Controls.Add(this.PORTB_PINB);
            this.groupBox1.Controls.Add(this.DDRC);
            this.groupBox1.Location = new System.Drawing.Point(18, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 154);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPIO";
            // 
            // GPIO_ON_OFF
            // 
            this.GPIO_ON_OFF.AutoSize = true;
            this.GPIO_ON_OFF.Location = new System.Drawing.Point(6, 19);
            this.GPIO_ON_OFF.Name = "GPIO_ON_OFF";
            this.GPIO_ON_OFF.Size = new System.Drawing.Size(59, 17);
            this.GPIO_ON_OFF.TabIndex = 3;
            this.GPIO_ON_OFF.Text = "Enable";
            this.GPIO_ON_OFF.UseVisualStyleBackColor = true;
            this.GPIO_ON_OFF.CheckedChanged += new System.EventHandler(this.zmena_ON_OFF);
            // 
            // ADC_refresh
            // 
            this.ADC_refresh.Tick += new System.EventHandler(this.ADC_refresh_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Open_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.command_box);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox command_box;
        private System.IO.Ports.SerialPort Isobot_com;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker Scanning;
        private System.Windows.Forms.GroupBox DDRB;
        private System.Windows.Forms.GroupBox PORTC_PINC;
        private System.Windows.Forms.CheckBox DDRB5;
        private System.Windows.Forms.CheckBox DDRB4;
        private System.Windows.Forms.CheckBox DDRB3;
        private System.Windows.Forms.CheckBox DDRB2;
        private System.Windows.Forms.CheckBox DDRB1;
        private System.Windows.Forms.CheckBox DDRB0;
        private System.Windows.Forms.CheckBox PORTC0;
        private System.Windows.Forms.CheckBox PORTC1;
        private System.Windows.Forms.CheckBox PORTC5;
        private System.Windows.Forms.CheckBox PORTC2;
        private System.Windows.Forms.CheckBox PORTC4;
        private System.Windows.Forms.CheckBox PORTC3;
        private System.Windows.Forms.CheckBox PORTB0;
        private System.Windows.Forms.CheckBox PORTB1;
        private System.Windows.Forms.CheckBox PORTB5;
        private System.Windows.Forms.CheckBox PORTB2;
        private System.Windows.Forms.CheckBox PORTB4;
        private System.Windows.Forms.CheckBox PORTB3;
        private System.Windows.Forms.GroupBox DDRC;
        private System.Windows.Forms.CheckBox DDRC0;
        private System.Windows.Forms.CheckBox DDRC1;
        private System.Windows.Forms.CheckBox DDRC5;
        private System.Windows.Forms.CheckBox DDRC2;
        private System.Windows.Forms.CheckBox DDRC4;
        private System.Windows.Forms.CheckBox DDRC3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox ADC5_box;
        private System.Windows.Forms.TextBox ADC2_box;
        private System.Windows.Forms.TextBox ADC3_box;
        private System.Windows.Forms.TextBox ADC4_box;
        private System.Windows.Forms.TextBox ADC1_box;
        private System.Windows.Forms.TextBox ADC0_box;
        private System.Windows.Forms.RadioButton PINC5;
        private System.Windows.Forms.RadioButton PINC4;
        private System.Windows.Forms.RadioButton PINC3;
        private System.Windows.Forms.RadioButton PINC2;
        private System.Windows.Forms.RadioButton PINC1;
        private System.Windows.Forms.RadioButton PINC0;
        private System.Windows.Forms.GroupBox PORTB_PINB;
        private System.Windows.Forms.RadioButton PINB5;
        private System.Windows.Forms.RadioButton PINB4;
        private System.Windows.Forms.RadioButton PINB3;
        private System.Windows.Forms.RadioButton PINB2;
        private System.Windows.Forms.RadioButton PINB1;
        private System.Windows.Forms.RadioButton PINB0;
        private System.Windows.Forms.Button UP;
        private System.Windows.Forms.Button LEFT;
        private System.Windows.Forms.Button DOWN;
        private System.Windows.Forms.Button RIGHT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ROTATE_RIGHT;
        private System.Windows.Forms.Button ROTATE_LEFT;
        private System.Windows.Forms.Button Open_button;
        private System.Windows.Forms.Button UP_LEFT;
        private System.Windows.Forms.Button DOWN_LEFT;
        private System.Windows.Forms.Button DOWN_RIGHT;
        private System.Windows.Forms.Button UP_RIGHT;
        private System.Windows.Forms.Timer GPIO_refresh;
        private System.Windows.Forms.RadioButton ADC1_radiobutton;
        private System.Windows.Forms.RadioButton ADC4_radiobutton;
        private System.Windows.Forms.RadioButton ADC3_radiobutton;
        private System.Windows.Forms.RadioButton ADC2_radiobutton;
        private System.Windows.Forms.RadioButton ADC0_radiobutton;
        private System.Windows.Forms.CheckBox ADC_ON_OFF;
        private System.Windows.Forms.RadioButton ADC5_radiobutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox GPIO_ON_OFF;
        private System.Windows.Forms.Timer ADC_refresh;
        private System.Windows.Forms.Button predklon;
        private System.Windows.Forms.Button zaklon;
        private System.Windows.Forms.Button Zdvih_zpredu;
        private System.Windows.Forms.Button zdvih_zozadu;
        private System.Windows.Forms.ProgressBar ADC0_progressbar;
        private System.Windows.Forms.ProgressBar ADC5_progressbar;
        private System.Windows.Forms.ProgressBar ADC4_progressbar;
        private System.Windows.Forms.ProgressBar ADC3_progressbar;
        private System.Windows.Forms.ProgressBar ADC2_progressbar;
        private System.Windows.Forms.ProgressBar ADC1_progressbar;
    }
}

