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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DIALOG_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Window1 newWindow;
        private void Twin_Click(object sender, RoutedEventArgs e)
        {
            if (newWindow == null || !newWindow.IsActive)
            {
                newWindow = new Window1();
                newWindow.Show();
                newWindow.SizeToContent = this.SizeToContent;
                newWindow.Height = Height;
                newWindow.Width = Width;
                newWindow.Owner = this;
             /*   newWindow.Ok.Location = new System.Drawing.Point(Size.Width / 2 - 100, Size.Height / 2);
                newWindow.Cancel.Location = new System.Drawing.Point(Size.Width / 2 + 100, Size.Height / 2);
                newWindow.Sib = this;
             */
            }
        }
    }
}
