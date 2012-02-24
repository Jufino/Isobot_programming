using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Isobot_terminal
{
    public partial class Form1 : Form
    {
        byte[,] data = new byte[100, 4];
        
        void commands_load()
        {
            StreamReader data_isobot = new StreamReader(@"commands.txt");
            string data_vstup;
            string[] data_listbox = new string[4];
            char[] separator = new char[5];
            command_box.Items.Clear();
            for (int x = 0; x != separator.Length; x++)
            {
                separator[x] = ' ';
            }
            try
            {
                for (int x = 0; x != (data.Length / 4); x++)
                {
                    data_vstup = data_isobot.ReadLine();
                    data_listbox = data_vstup.Split(separator);
                    command_box.Items.Add(data_listbox[0]);
                    for (int y = 0; y != 4; y++)
                        data[x, y] = Convert.ToByte(data_listbox[y + 1]);
                }
            }
            catch { }
        }
        
        Image transform(Button old,int okraj)
        {
            int width = old.Width - okraj;
            int height = old.Height - okraj;
            return new Bitmap(old.Image, width, height);
        }
       
        public Form1()
        {
            InitializeComponent();
            commands_load();
            pictureBox1.Image = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);

            UP.Image = transform(UP,2);
            UP_LEFT.Image = transform(UP_LEFT, 2);
            UP_RIGHT.Image = transform(UP_RIGHT, 2);
            LEFT.Image = transform(LEFT, 2);
            DOWN.Image = transform(DOWN, 2);
            DOWN_LEFT.Image = transform(DOWN_LEFT, 2);
            DOWN_RIGHT.Image = transform(DOWN_RIGHT, 2);
            RIGHT.Image = transform(RIGHT, 2);
            ROTATE_LEFT.Image = transform(ROTATE_LEFT, 2);
            ROTATE_RIGHT.Image = transform(ROTATE_RIGHT, 2);
            predklon.Image = transform(predklon,20);
            zaklon.Image = transform(zaklon, 20);
            Zdvih_zpredu.Image = transform(Zdvih_zpredu, 10);
            zdvih_zozadu.Image = transform(zdvih_zozadu, 10);
        }
       
        private void scanning(object sender, DoWorkEventArgs e)
        {
            for (int opakuj = 0; opakuj < 10; opakuj++)
            {
                for (int poc_com = 0; poc_com < 20; poc_com++)
                {
                    if (Isobot_com.IsOpen == true)
                    {
                        Isobot_com.Close();
                    }
                    Isobot_com.PortName = "COM" + poc_com.ToString();
                    try
                    {
                        Isobot_com.Open();
                        System.Threading.Thread.Sleep(200);
                        Isobot_com.Write("A");
                        Isobot_com.ReadTimeout = 500;
                        if (Isobot_com.ReadByte() == 5)
                        {
                            MessageBox.Show("Connection established");
                            poc_com = 21;
                            opakuj = 11;

                        }
                    }
                    catch { }
                }
            }
            if (Isobot_com.IsOpen == false)
            {
                MessageBox.Show("Connection has not been established");
            }
        }

        private void Dvojklik_commands(object sender, MouseEventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[command_box.SelectedIndex, 0].ToString();
            prikazy[1] = data[command_box.SelectedIndex, 1].ToString();
            prikazy[2] = data[command_box.SelectedIndex, 2].ToString();
            prikazy[3] = data[command_box.SelectedIndex, 3].ToString();
            Send_command("0", prikazy);
        }

        void Send_command(string command,string[] parameter)
        {
            try
            {
                byte[] pomocny = new byte[1];
                pomocny[0] = Convert.ToByte(command);
                Isobot_com.WriteTimeout = 100;
                Isobot_com.Write(pomocny, 0, 1);
                System.Threading.Thread.Sleep(2);
                //-----------------------------------------------
                for (int p=0;p<parameter.Length;p++){
                    pomocny[0] = Convert.ToByte(parameter[p]);
                    Isobot_com.Write(pomocny, 0, 1);
                    System.Threading.Thread.Sleep(2);
                }
            }
            catch
            {
                MessageBox.Show("Connection has not been established");
            }
        }
        
        void Send_onlycommand(string command)
        {
            try
            {
                byte[] pomocny = new byte[1];
                pomocny[0] = Convert.ToByte(command);
                Isobot_com.Write(pomocny, 0, 1);
            }
            catch
            {
                MessageBox.Show("Connection has not been established");
            }
        }

        private void Open_button_Click(object sender, EventArgs e)
        {
            if (Scanning.IsBusy == false)
            {
                Scanning.RunWorkerAsync();
            }
        }

        private void UP_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[4, 0].ToString();
            prikazy[1] = data[4, 1].ToString();
            prikazy[2] = data[4, 2].ToString();
            prikazy[3] = data[4, 3].ToString();
            Send_command("0", prikazy);
        }

        private void UP_RIGHT_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[9, 0].ToString();
            prikazy[1] = data[9, 1].ToString();
            prikazy[2] = data[9, 2].ToString();
            prikazy[3] = data[9, 3].ToString();
            Send_command("0", prikazy);
        }

        private void RIGHT_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[7, 0].ToString();
            prikazy[1] = data[7, 1].ToString();
            prikazy[2] = data[7, 2].ToString();
            prikazy[3] = data[7, 3].ToString();
            Send_command("0", prikazy);
        }

        private void DOWN_RIGHT_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[11, 0].ToString();
            prikazy[1] = data[11, 1].ToString();
            prikazy[2] = data[11, 2].ToString();
            prikazy[3] = data[11, 3].ToString();
            Send_command("0", prikazy);
        }

        private void DOWN_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[5, 0].ToString();
            prikazy[1] = data[5, 1].ToString();
            prikazy[2] = data[5, 2].ToString();
            prikazy[3] = data[5, 3].ToString();
            Send_command("0", prikazy);
        }

        private void DOWN_LEFT_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[10, 0].ToString();
            prikazy[1] = data[10, 1].ToString();
            prikazy[2] = data[10, 2].ToString();
            prikazy[3] = data[10, 3].ToString();
            Send_command("0", prikazy);
        }

        private void LEFT_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[6, 0].ToString();
            prikazy[1] = data[6, 1].ToString();
            prikazy[2] = data[6, 2].ToString();
            prikazy[3] = data[6, 3].ToString();
            Send_command("0", prikazy);
        }

        private void UP_LEFT_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[8, 0].ToString();
            prikazy[1] = data[8, 1].ToString();
            prikazy[2] = data[8, 2].ToString();
            prikazy[3] = data[8, 3].ToString();
            Send_command("0", prikazy);
        }

        private void ROTATE_LEFT_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[0, 0].ToString();
            prikazy[1] = data[0, 1].ToString();
            prikazy[2] = data[0, 2].ToString();
            prikazy[3] = data[0, 3].ToString();
            Send_command("0", prikazy);
        }

        private void ROTATE_RIGHT_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[1, 0].ToString();
            prikazy[1] = data[1, 1].ToString();
            prikazy[2] = data[1, 2].ToString();
            prikazy[3] = data[1, 3].ToString();
            Send_command("0", prikazy);
        }

        private void GPIO_refresh_Tick(object sender, EventArgs e)
        {
                if (Isobot_com.IsOpen == true)
                {
                    Send_onlycommand("11");
                    try
                    {
                        int PINC = Isobot_com.ReadByte();
                        if ((PINC & 0x20) == 0x20)
                        {
                            PINC5.Checked = true;
                        }
                        else
                        {
                            PINC5.Checked = false;
                        }
                        if ((PINC & 0x10) == 0x10)
                        {
                            PINC4.Checked = true;
                        }
                        else
                        {
                            PINC4.Checked = false;
                        }
                        if ((PINC & 0x08) == 0x08)
                        {
                            PINC3.Checked = true;
                        }
                        else
                        {
                            PINC3.Checked = false;
                        }
                        if ((PINC & 0x04) == 0x04)
                        {
                            PINC2.Checked = true;
                        }
                        else
                        {
                            PINC2.Checked = false;
                        }
                        if ((PINC & 0x02) == 0x02)
                        {
                            PINC1.Checked = true;
                        }
                        else
                        {
                            PINC1.Checked = false;
                        }
                        if ((PINC & 0x01) == 0x01)
                        {
                            PINC0.Checked = true;
                        }
                        else
                        {
                            PINC0.Checked = false;
                        }
                    }
                    catch {}
                    Send_onlycommand("4");
                    try{
                        int PINB = Isobot_com.ReadByte();
                        if ((PINB & 0x20) == 0x20)
                        {
                            PINB5.Checked = true;
                        }
                        else
                        {
                            PINB5.Checked = false;
                        }
                        if ((PINB & 0x10) == 0x10)
                        {
                            PINB4.Checked = true;
                        }
                        else
                        {
                            PINB4.Checked = false;
                        }
                        if ((PINB & 0x08) == 0x08)
                        {
                            PINB3.Checked = true;
                        }
                        else
                        {
                            PINB3.Checked = false;
                        }
                        if ((PINB & 0x04) == 0x04)
                        {
                            PINB2.Checked = true;
                        }
                        else
                        {
                            PINB2.Checked = false;
                        }
                        if ((PINB & 0x02) == 0x02)
                        {
                            PINB1.Checked = true;
                        }
                        else
                        {
                            PINB1.Checked = false;
                        }
                        if ((PINB & 0x01) == 0x01)
                        {
                            PINB0.Checked = true;
                        }
                        else
                        {
                            PINB0.Checked = false;
                        }
                    }
                    catch {
                        GPIO_refresh.Enabled = false;
                        GPIO_ON_OFF.Checked = false;
                        MessageBox.Show("Connection lost");
                    }
                }  
        }

        private void ADC_refresh_Tick(object sender, EventArgs e)
        {
            if (Isobot_com.IsOpen == true)
            {
                if (ADC0_radiobutton.Checked == true)
                {
                    Send_onlycommand("5");
                    try
                    {
                        ADC0_box.Text = Isobot_com.ReadByte().ToString();
                        ADC0_progressbar.Value = Convert.ToInt16(ADC0_box.Text);
                    }
                    catch
                    {
                        ADC_refresh.Enabled = false;
                        ADC_ON_OFF.Checked = false;
                        MessageBox.Show("Connection lost");
                    }

                }
                else if (ADC1_radiobutton.Checked == true)
                {
                    Send_onlycommand("6");
                    try
                    {
                        ADC1_box.Text = Isobot_com.ReadByte().ToString();
                        ADC1_progressbar.Value = Convert.ToInt16(ADC1_box.Text);
                    }
                    catch
                    {
                        ADC_refresh.Enabled = false;
                        ADC_ON_OFF.Checked = false;
                        MessageBox.Show("Connection lost");
                    }
                }
                else if (ADC2_radiobutton.Checked == true)
                {
                    Send_onlycommand("7");
                    try
                    {
                        ADC2_box.Text = Isobot_com.ReadByte().ToString();
                        ADC2_progressbar.Value = Convert.ToInt16(ADC2_box.Text);
                    }
                    catch
                    {
                        ADC_refresh.Enabled = false;
                        ADC_ON_OFF.Checked = false;
                        MessageBox.Show("Connection lost");
                    }
                }
                else if (ADC3_radiobutton.Checked == true)
                {
                    Send_onlycommand("8");
                    try
                    {
                        ADC3_box.Text = Isobot_com.ReadByte().ToString();
                        ADC3_progressbar.Value = Convert.ToInt16(ADC3_box.Text);
                    }
                    catch
                    {
                        ADC_refresh.Enabled = false;
                        ADC_ON_OFF.Checked = false;
                        MessageBox.Show("Connection lost");
                    }
                }
                else if (ADC4_radiobutton.Checked == true)
                {
                    Send_onlycommand("9");
                    try
                    {
                        ADC4_box.Text = Isobot_com.ReadByte().ToString();
                        ADC4_progressbar.Value = Convert.ToInt16(ADC4_box.Text);
                    }
                    catch
                    {
                        ADC_refresh.Enabled = false;
                        ADC_ON_OFF.Checked = false;
                        MessageBox.Show("Connection lost");
                    }
                }
                else
                {
                    Send_onlycommand("10");
                    try
                    {
                        ADC5_box.Text = Isobot_com.ReadByte().ToString();
                        ADC5_progressbar.Value = Convert.ToInt16(ADC5_box.Text);
                    }
                    catch {
                        ADC_refresh.Enabled = false;
                        ADC_ON_OFF.Checked = false;
                        MessageBox.Show("Connection lost");
                    }
                }

            }
        }
   
        private void zmena_DDRC(object sender, EventArgs e)
        {
            PINC0.Visible = !DDRC0.Checked;
            PORTC0.Visible = DDRC0.Checked;
            //------------------------------
            PINC1.Visible = !DDRC1.Checked;
            PORTC1.Visible = DDRC1.Checked;
            //------------------------------
            PINC2.Visible = !DDRC2.Checked;
            PORTC2.Visible = DDRC2.Checked;
            //------------------------------
            PINC3.Visible = !DDRC3.Checked;
            PORTC3.Visible = DDRC3.Checked;
            //------------------------------
            PINC4.Visible = !DDRC4.Checked;
            PORTC4.Visible = DDRC4.Checked;
            //------------------------------
            PINC5.Visible = !DDRC5.Checked;
            PORTC5.Visible = DDRC5.Checked;
            //------------------------------
            int DDRC = 0;
            if (DDRC0.Checked == true)
            {
                DDRC += 1;
            }
            if (DDRC1.Checked == true)
            {
                DDRC += 2;
            }
            if (DDRC2.Checked == true)
            {
                DDRC += 4;
            }
            if (DDRC3.Checked == true)
            {
                DDRC += 8;
            }
            if (DDRC4.Checked == true)
            {
                DDRC += 16;
            }
            if (DDRC5.Checked == true)
            {
                DDRC += 32;
            }
            string[] prikazy = new string[1];
            prikazy[0] = DDRC.ToString();
            Send_command("1", prikazy);
        }

        private void zmena_DDRB(object sender, EventArgs e)
        {
            PINB0.Visible = !DDRB0.Checked;
            PORTB0.Visible = DDRB0.Checked;
            //------------------------------
            PINB1.Visible = !DDRB1.Checked;
            PORTB1.Visible = DDRB1.Checked;
            //------------------------------
            PINB2.Visible = !DDRB2.Checked;
            PORTB2.Visible = DDRB2.Checked;
            //------------------------------
            PINB3.Visible = !DDRB3.Checked;
            PORTB3.Visible = DDRB3.Checked;
            //------------------------------
            PINB4.Visible = !DDRB4.Checked;
            PORTB4.Visible = DDRB4.Checked;
            //------------------------------
            PINB5.Visible = !DDRB5.Checked;
            PORTB5.Visible = DDRB5.Checked;
            //------------------------------
            int DDRB = 0;
            if (DDRB0.Checked == true)
            {
                DDRB += 1;
            }
            if (DDRB1.Checked == true)
            {
                DDRB += 2;
            }
            if (DDRB2.Checked == true)
            {
                DDRB += 4;
            }
            if (DDRB3.Checked == true)
            {
                DDRB += 8;
            }
            if (DDRB4.Checked == true)
            {
                DDRB += 16;
            }
            if (DDRB5.Checked == true)
            {
                DDRB += 32;
            }
            string[] prikazy = new string[1];
            prikazy[0] = DDRB.ToString();
            Send_command("2", prikazy);
        }

        private void zmena_PORTC(object sender, EventArgs e)
        {
            int PORTC = 0;
            if (PORTC0.Checked == true)
            {
                PORTC += 1;
            }
            if (PORTC1.Checked == true)
            {
                PORTC += 2;
            }
            if (PORTC2.Checked == true)
            {
                PORTC += 4;
            }
            if (PORTC3.Checked == true)
            {
                PORTC += 8;
            }
            if (PORTC4.Checked == true)
            {
                PORTC += 16;
            }
            if (PORTC5.Checked == true)
            {
                PORTC += 32;
            }
            string[] prikazy = new string[1];
            prikazy[0] = PORTC.ToString();
            Send_command("12", prikazy);
        }

        private void zmena_PORTB(object sender, EventArgs e)
        {
            int PORTB = 0;
            if (PORTB0.Checked == true)
            {
                PORTB += 1;
            }
            if (PORTB1.Checked == true)
            {
                PORTB += 2;
            }
            if (PORTB2.Checked == true)
            {
                PORTB += 4;
            }
            if (PORTB3.Checked == true)
            {
                PORTB += 8;
            }
            if (PORTB4.Checked == true)
            {
                PORTB += 16;
            }
            if (PORTB5.Checked == true)
            {
                PORTB += 32;
            }
            string[] prikazy = new string[1];
            prikazy[0] = PORTB.ToString();
            Send_command("3", prikazy);
        }

        private void zmena_ON_OFF(object sender, EventArgs e)
        {
            if (Scanning.IsBusy == false & Isobot_com.IsOpen == true)
            {
                DDRB.Enabled = GPIO_ON_OFF.Checked;
                DDRC.Enabled = GPIO_ON_OFF.Checked;
                PORTB_PINB.Enabled = GPIO_ON_OFF.Checked;
                PORTC_PINC.Enabled = GPIO_ON_OFF.Checked;
                ADC0_box.Enabled = ADC_ON_OFF.Checked;
                ADC1_box.Enabled = ADC_ON_OFF.Checked;
                ADC2_box.Enabled = ADC_ON_OFF.Checked;
                ADC3_box.Enabled = ADC_ON_OFF.Checked;
                ADC4_box.Enabled = ADC_ON_OFF.Checked;
                ADC5_box.Enabled = ADC_ON_OFF.Checked;
                ADC0_radiobutton.Enabled = ADC_ON_OFF.Checked;
                ADC1_radiobutton.Enabled = ADC_ON_OFF.Checked;
                ADC2_radiobutton.Enabled = ADC_ON_OFF.Checked;
                ADC3_radiobutton.Enabled = ADC_ON_OFF.Checked;
                ADC4_radiobutton.Enabled = ADC_ON_OFF.Checked;
                ADC5_radiobutton.Enabled = ADC_ON_OFF.Checked;
                GPIO_ON_OFF.Enabled = !ADC_ON_OFF.Checked;
                ADC_ON_OFF.Enabled = !GPIO_ON_OFF.Checked;
                GPIO_refresh.Enabled = GPIO_ON_OFF.Checked;
                ADC_refresh.Enabled = ADC_ON_OFF.Checked;
                ADC0_box.Text = "x";
                ADC1_box.Text = "x";
                ADC2_box.Text = "x";
                ADC3_box.Text = "x";
                ADC4_box.Text = "x";
                ADC5_box.Text = "x";
                ADC0_progressbar.Value = 0;
                ADC1_progressbar.Value = 0;
                ADC2_progressbar.Value = 0;
                ADC3_progressbar.Value = 0;
                ADC4_progressbar.Value = 0;
                ADC5_progressbar.Value = 0;
            }
            else
            {
                if (ADC_ON_OFF.Checked == true | GPIO_ON_OFF.Checked == true)
                {
                    MessageBox.Show("Connection has not been established");
                }
                ADC_ON_OFF.Checked = false;
                GPIO_ON_OFF.Checked = false;
            }
        }

        private void predklon_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[2, 0].ToString();
            prikazy[1] = data[2, 1].ToString();
            prikazy[2] = data[2, 2].ToString();
            prikazy[3] = data[2, 3].ToString();
            Send_command("0", prikazy);
        }

        private void zaklon_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[3, 0].ToString();
            prikazy[1] = data[3, 1].ToString();
            prikazy[2] = data[3, 2].ToString();
            prikazy[3] = data[3, 3].ToString();
            Send_command("0", prikazy);
        }

        private void Zdvih_zpredu_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[14, 0].ToString();
            prikazy[1] = data[14, 1].ToString();
            prikazy[2] = data[14, 2].ToString();
            prikazy[3] = data[14, 3].ToString();
            Send_command("0", prikazy);
        }

        private void zdvih_zozadu_Click(object sender, EventArgs e)
        {
            string[] prikazy = new string[4];
            prikazy[0] = data[13, 0].ToString();
            prikazy[1] = data[13, 1].ToString();
            prikazy[2] = data[13, 2].ToString();
            prikazy[3] = data[13, 3].ToString();
            Send_command("0", prikazy);
        }

        private void zmena_ADC_nastavenia(object sender, EventArgs e)
        {
            ADC0_box.Text = "x";
            ADC1_box.Text = "x";
            ADC2_box.Text = "x";
            ADC3_box.Text = "x";
            ADC4_box.Text = "x";
            ADC5_box.Text = "x";
            ADC0_progressbar.Value = 0;
            ADC1_progressbar.Value = 0;
            ADC2_progressbar.Value = 0;
            ADC3_progressbar.Value = 0;
            ADC4_progressbar.Value = 0;
            ADC5_progressbar.Value = 0;
        }

 
    
    }
}
