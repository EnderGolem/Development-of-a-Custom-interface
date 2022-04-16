using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIALOGS_WF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Ok_click(object sender, EventArgs e)
        {
            Sib.Size = Size;
        }

        private void Cancel_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Enter(object sender, EventArgs e)
        {
            Sib.Size = Size;
        }

    }
}
