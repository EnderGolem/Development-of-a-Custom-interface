using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYNC_WF
{
    public partial class Form2 : Form
    {
        Form1 main;
        public RadioButton[] Reds;
        public RadioButton[] Greens;
        public RadioButton[] Blues;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 mainer)
        {
            InitializeComponent();
            main = mainer;
            Reds = new RadioButton[6];
            Reds[0] = Red1; Reds[1] = Red2; Reds[2] = Red3; Reds[3] = Red4; Reds[4] = Red5; Reds[5] = Red6;
            Greens = new RadioButton[6];
            Greens[0] = Green1; Greens[1] = Green2; Greens[2] = Green3; Greens[3] = Green4; Greens[4] = Green5; Greens[5] = Green6;
            Blues = new RadioButton[6];
            Blues[0] = Blue1; Blues[1] = Blue2; Blues[2] = Blue3; Blues[3] = Blue4; Blues[4] = Blue5;  Blues[5] = Blue6;
        }
        private Color CheckButton(object sender)
        {
            if ((sender as RadioButton).Name[0] == 'R')
                return Color.Red;
            else if ((sender as RadioButton).Name[0] == 'G')
                return Color.Green;
            else if ((sender as RadioButton).Name[0] == 'B')
                return Color.Blue;
            return Color.Black;
        }
        private void red1_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                return;
            main.color1.BackColor = CheckButton(sender);

        }

        private void red2_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                return;
            main.color2.BackColor = CheckButton(sender);
        }

        private void red3_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                return;
            main.color3.BackColor = CheckButton(sender);
        }

        private void red4_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                return;
            main.color4.BackColor = CheckButton(sender);
        }

        private void red5_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                return;
            main.color5.BackColor = CheckButton(sender);
        }

        private void red6_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                return;
            main.color6.BackColor = CheckButton(sender);
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }

        }
    }
}
