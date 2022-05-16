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

namespace SYNC_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 son;
        public MainWindow()
        {
            InitializeComponent();
            color1.Background = Brushes.Red;
            
            color2.Background = Brushes.Red;
            color3.Background = Brushes.Red;
            color4.Background = Brushes.Red;
            color5.Background = Brushes.Red;
            color6.Background = Brushes.Red;
            son = new Window1(this);
        }

        private void choose_Color(Brush current, int index)
        {
            index--;
            if (current == Brushes.Green)
            {
                son.Greens[index].IsChecked = true;
            }
            if (current == Brushes.Blue)
            {
                son.Blues[index].IsChecked = true;
            }
            if (current == Brushes.Red)
            {
                son.Reds[index].IsChecked = true;
            }
        }
        private void show_click(object sender, RoutedEventArgs e)
        {
            son.Show();
            choose_Color(color1.Background, 1);
            choose_Color(color2.Background, 2);
            choose_Color(color3.Background, 3);
            choose_Color(color4.Background, 4);
            choose_Color(color5.Background, 5);
            choose_Color(color6.Background, 6);
        }

        private Brush next_Color(int index, Brush current)
        {
            --index;
            if (current == Brushes.Red)
            {
                if (son.IsVisible)
                    son.Greens[index].IsChecked = true;
                return Brushes.Green;
            }
            else if (current == Brushes.Green)
            {
                if (son.IsVisible)
                    son.Blues[index].IsChecked = true;
                return Brushes.Blue;
            }
            else if (current == Brushes.Blue)
            {
                if (son.IsVisible)
                    son.Reds[index].IsChecked = true;
                return Brushes.Red;
            }
            return Brushes.Black;
        }
        private void color1_MouseLeftButtonUp(object sender, EventArgs e)
        {
            color1.Background = next_Color(1, color1.Background);
        }
        private void color2_MouseLeftButtonUp(object sender, EventArgs e)
        {
            color2.Background = next_Color(2, color2.Background);
        }
        private void color3_MouseLeftButtonUp(object sender, EventArgs e)
        {
            color3.Background = next_Color(3, color3.Background);
        }
        private void color4_MouseLeftButtonUp(object sender, EventArgs e)
        {
            color4.Background = next_Color(4, color4.Background);
        }
        private void color5_MouseLeftButtonUp(object sender, EventArgs e)
        {
            color5.Background = next_Color(5, color5.Background);
        }
        private void color6_MouseLeftButtonUp(object sender, EventArgs e)
        {
            color6.Background = next_Color(6, color6.Background);
        }
    }
}
