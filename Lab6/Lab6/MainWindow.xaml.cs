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
using System.Windows.Threading;

namespace Lab6
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

        Thickness tmp_location;
        double tmp_width, tmp_height;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("OK button has been pressed");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.GetPosition(this);
            if (p.X > button1.Margin.Left - button1.Width / 2 && p.X < button1.Margin.Left + button1.Width / 2 && p.Y > button1.Margin.Top - button1.Height / 2 && p.Y < button1.Margin.Top + button1.Height / 2)
            {
                tmp_location = button1.Margin;
                tmp_location.Left += 10;
                tmp_location.Top += 10;
                button1.Margin = new Thickness(tmp_location.Left, tmp_location.Top, 0, 0);
                tmp_width = button1.Width;
                tmp_height = button1.Height;
                tmp_width -= 1;
                tmp_height -= 1;
                button1.Width = tmp_width;
                button1.Height = tmp_height;
            }
            if (p.X > button1.Margin.Left + button1.Width / 2 && p.X < button1.Margin.Left + button1.Width * 1.5 && p.Y > button1.Margin.Top - button1.Height / 2 && p.Y < button1.Margin.Top + button1.Height / 2)
            {
                tmp_location = button1.Margin;
                tmp_location.Left -= 10;
                tmp_location.Top += 10;
                button1.Margin = new Thickness(tmp_location.Left, tmp_location.Top, 0, 0);
                tmp_width = button1.Width;
                tmp_height = button1.Height;
                tmp_width -= 1;
                tmp_height -= 1;
                button1.Width = tmp_width;
                button1.Height = tmp_height;
            }
            if (p.X > button1.Margin.Left - button1.Width / 2 && p.X < button1.Margin.Left + button1.Width / 2 && p.Y > button1.Margin.Top + button1.Height / 2 && p.Y < button1.Margin.Top + button1.Height * 1.5)
            {
                tmp_location = button1.Margin;
                tmp_location.Left += 10;
                tmp_location.Top -= 10;
                button1.Margin = new Thickness(tmp_location.Left, tmp_location.Top, 0, 0);
                tmp_width = button1.Width;
                tmp_height = button1.Height;
                tmp_width -= 1;
                tmp_height -= 1;
                button1.Width = tmp_width;
                button1.Height = tmp_height;
            }
            if (p.X > button1.Margin.Left + button1.Width / 2 && p.X < button1.Margin.Left + button1.Width * 1.5 && p.Y > button1.Margin.Top + button1.Height / 2 && p.Y < button1.Margin.Top + button1.Height * 1.5)
            {
                tmp_location = button1.Margin;
                tmp_location.Left -= 10;
                tmp_location.Top -= 10;
                button1.Margin = new Thickness(tmp_location.Left, tmp_location.Top, 0, 0);
                tmp_width = button1.Width;
                tmp_height = button1.Height;
                tmp_width -= 1;
                tmp_height -= 1;
                button1.Width = tmp_width;
                button1.Height = tmp_height;
            }
            if (tmp_height == 0 && tmp_width == 0)
            {
                MessageBox.Show("OK button cannot be pressed");
            }
        }
    }
}
