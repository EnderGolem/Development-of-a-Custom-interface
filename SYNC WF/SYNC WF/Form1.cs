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
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            AddOwnedForm(form2);
            color1.BackColor = Color.Red;
            color2.BackColor = Color.Red;
            color3.BackColor = Color.Red;
            color4.BackColor = Color.Red;
            color5.BackColor = Color.Red;
            color6.BackColor = Color.Red;

            form2.Red1.Checked = true;
            form2.Red2.Checked = true;
            form2.Red3.Checked = true;
            form2.Red4.Checked = true;
            form2.Red5.Checked = true;
            form2.Red6.Checked = true;

        }

        private void choose_Color(Color current, int index)
        {
            index--;
            if(current == Color.Green)
            {
                form2.Greens[index].Checked = true;
            }        
            if(current == Color.Blue)
            {
                form2.Blues[index].Checked = true;
            }        
            if(current == Color.Red)
            {
                form2.Reds[index].Checked = true;
            }
        }
        private void show_MouseClick(object sender, MouseEventArgs e)
        {
            form2.Show();
            choose_Color(color1.BackColor, 1);
            choose_Color(color2.BackColor, 2);
            choose_Color(color3.BackColor, 3);
            choose_Color(color4.BackColor, 4);
            choose_Color(color5.BackColor, 5);
            choose_Color(color6.BackColor, 6);
          
        }
        private Color next_Color(int index, Color current)
        {
            --index;
            if (current == Color.Red)
            {
                if(form2.Visible)
                    form2.Greens[index].Checked = true;
                return Color.Green;
            }
            else if (current == Color.Green)
            {
                if (form2.Visible)
                    form2.Blues[index].Checked = true;
                return Color.Blue;
            }
            else if (current == Color.Blue)
            {
                if (form2.Visible)
                    form2.Reds[index].Checked = true;
                return Color.Red;
            }
            return Color.Black;
        }
        private void color1_click(object sender, EventArgs e)
        {
            color1.BackColor = next_Color(1, color1.BackColor);
        }
        private void color2_click(object sender, EventArgs e)
        {
            color2.BackColor = next_Color(2, color2.BackColor);
        }
        private void color3_click(object sender, EventArgs e)
        {
            color3.BackColor = next_Color(3, color3.BackColor);
        }
        private void color4_click(object sender, EventArgs e)
        {
            color4.BackColor = next_Color(4, color4.BackColor);
        }
        private void color5_click(object sender, EventArgs e)
        {
            color5.BackColor = next_Color(5, color5.BackColor);
        }
        private void color6_click(object sender, EventArgs e)
        {
            color6.BackColor = next_Color(6, color6.BackColor);
        }
    }
}
