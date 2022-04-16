using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DIALOG_WPF
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();

        }

        private void Ok_click(object sender, RoutedEventArgs e)
        {
            this.Owner.Width = Width;
            this.Owner.Height = Height;
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Enter_drag(object sender, DragEventArgs e)
        {
            this.Owner.Width = Width;
            this.Owner.Height = Height;
        }


        private void KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
