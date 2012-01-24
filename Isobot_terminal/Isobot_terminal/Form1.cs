using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Isobot_terminal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = velkost_picture_box(pictureBox1, 5);
        }

        Image velkost_picture_box(PictureBox old, int posun)
        {
            return new Bitmap(old.Image, old.Width - posun, old.Height - posun);
        }

        Image velkost_button(Button old, int posun)
        {
            return new Bitmap(old.Image, old.Width - posun, old.Height - posun);
        }

        private void vystup_0_zmena(object sender, EventArgs e)
        {
                OC0.Enabled = SIOC0.Checked;
                IC0.Enabled = !SIOC0.Checked;
        }

        private void vystup_1_zmena(object sender, EventArgs e)
        {
            OC1.Enabled = SIOC1.Checked;
            IC1.Enabled = !SIOC1.Checked;
        }

        private void vystup_2_zmena(object sender, EventArgs e)
        {
            OC2.Enabled = SIOC2.Checked;
            IC2.Enabled = !SIOC2.Checked;
        }

        private void vystup_3_zmena(object sender, EventArgs e)
        {
            OC3.Enabled = SIOC3.Checked;
            IC3.Enabled = !SIOC3.Checked;
        }

        private void vystup_4_zmena(object sender, EventArgs e)
        {
            OC4.Enabled = SIOC4.Checked;
            IC4.Enabled = !SIOC4.Checked;
        }

        private void vystup_5_zmena(object sender, EventArgs e)
        {
            OC5.Enabled = SIOC5.Checked;
            IC5.Enabled = !SIOC5.Checked;
        }

        private void vystup_B3_zmena(object sender, EventArgs e)
        {
            OB3.Enabled = SIOB3.Checked;
            IB3.Enabled = !SIOB3.Checked;
        }

        private void vystup_B4_zmena(object sender, EventArgs e)
        {
            OB4.Enabled = SIOB4.Checked;
            IB4.Enabled = !SIOB4.Checked;
        }

        private void vystup_B5_zmena(object sender, EventArgs e)
        {
            OB5.Enabled = SIOB5.Checked;
            IB5.Enabled = !SIOB5.Checked;
        }
    }
}
