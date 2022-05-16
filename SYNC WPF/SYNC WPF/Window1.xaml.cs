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

namespace SYNC_WPF
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow main;

        public RadioButton[] Reds;
        public RadioButton[] Greens;
        public RadioButton[] Blues;
        public Window1(MainWindow _main)
        {
            InitializeComponent();
            main = _main;
            Reds = new RadioButton[6];
            Reds[0] = Red1; Reds[1] = Red2; Reds[2] = Red3; Reds[3] = Red4; Reds[4] = Red5; Reds[5] = Red6;
            Greens = new RadioButton[6];
            Greens[0] = Green1; Greens[1] = Green2; Greens[2] = Green3; Greens[3] = Green4; Greens[4] = Green5; Greens[5] = Green6;
            Blues = new RadioButton[6];
            Blues[0] = Blue1; Blues[1] = Blue2; Blues[2] = Blue3; Blues[3] = Blue4; Blues[4] = Blue5; Blues[5] = Blue6;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private Brush CheckButton(object sender)
        {
            if ((sender as RadioButton).Name[0] == 'R')
                return Brushes.Red;
            else if ((sender as RadioButton).Name[0] == 'G')
                return Brushes.Green;
            else if ((sender as RadioButton).Name[0] == 'B')
                return Brushes.Blue;
            return Brushes.Black;
        }

        private void red1_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)!(sender as RadioButton).IsChecked || main == null)
                return;
            main.color1.Background = CheckButton(sender);
        }
        private void red2_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)!(sender as RadioButton).IsChecked || main == null )
                return;
            main.color2.Background = CheckButton(sender);
        }
        private void red3_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)!(sender as RadioButton).IsChecked || main == null)
                return;
            main.color3.Background = CheckButton(sender);
        }
        private void red4_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)!(sender as RadioButton).IsChecked || main == null)
                return;
            main.color4.Background = CheckButton(sender);
        }
        private void red5_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)!(sender as RadioButton).IsChecked || main == null)
                return;
            main.color5.Background = CheckButton(sender);
        }
        private void red6_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)!(sender as RadioButton).IsChecked || main == null)
                return;
            main.color6.Background = CheckButton(sender);
        }
    }
}
