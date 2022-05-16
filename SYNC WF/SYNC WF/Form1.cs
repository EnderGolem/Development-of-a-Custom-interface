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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void show_MouseClick(object sender, MouseEventArgs e)
        {
            form2.Show();
        }
    }
}
