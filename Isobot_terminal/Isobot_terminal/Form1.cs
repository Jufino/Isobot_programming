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
        int poc_com = 0;
        void scan()
        {
            for (poc_com = 0; poc_com < 20; poc_com++)
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
                    Isobot_com.ReadTimeout = 200;
                    if (Isobot_com.ReadByte() == 5)
                    {
                        MessageBox.Show("BT open");
                        poc_com = 21;

                    }
                }
                catch { }
            }
            if (Isobot_com.IsOpen == false)
            {
                MessageBox.Show("Zariadenie nie je zapnute");
            }
        }
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
        Image transform(Button old)
        {
            int width = old.Width - 2;
            int height = old.Height - 2;
            return new Bitmap(old.Image, width, height);
        }
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
            commands_load();
            pictureBox1.Image = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);

            UP.Image = transform(UP);
            UP_LEFT.Image = transform(UP_LEFT);
            UP_RIGHT.Image = transform(UP_RIGHT);
            LEFT.Image = transform(LEFT);
            DOWN.Image = transform(DOWN);
            DOWN_LEFT.Image = transform(DOWN_LEFT);
            DOWN_RIGHT.Image = transform(DOWN_RIGHT);
            RIGHT.Image = transform(RIGHT);
            ROTATE_LEFT.Image = transform(ROTATE_LEFT);
            ROTATE_RIGHT.Image = transform(ROTATE_RIGHT);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            scan();
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
                Isobot_com.Write(pomocny, 0, 1);
                System.Threading.Thread.Sleep(2);
                //-----------------------------------------------
                for (int p=0;p<parameter.Length;p++){
                    pomocny[0] = Convert.ToByte(parameter[p]);
                    Isobot_com.Write(pomocny, 0, 1);
                    System.Threading.Thread.Sleep(2);
                }
            }
            catch (SystemException i)
            {
                MessageBox.Show(i.Message.ToString());
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
            catch (SystemException i)
            {
                MessageBox.Show(i.Message.ToString());
            }
        }

        private void zmena_nastavenia(object sender, EventArgs e)
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
                PINB6.Visible = !DDRB6.Checked;
                PORTB6.Visible = DDRB6.Checked;
                //------------------------------
                PINB7.Visible = !DDRB7.Checked;
                PORTB7.Visible = DDRB7.Checked;
                //------------------------------
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
                PINC6.Visible = !DDRC6.Checked;
                PORTC6.Visible = DDRC6.Checked;
                //------------------------------
                PINC7.Visible = !DDRC7.Checked;
                PORTC7.Visible = DDRC7.Checked;
            //------------------------------
        }



        private void button7_Click(object sender, EventArgs e)
        {
            scan();
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
    }
}
