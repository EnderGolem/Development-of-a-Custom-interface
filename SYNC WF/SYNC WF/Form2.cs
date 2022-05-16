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
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 mainer)
        {
            InitializeComponent();
            main = mainer;
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
