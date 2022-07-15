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

namespace WpfApp4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        bool isWiden = false;
        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isWiden = true;
        }
        
        private void Rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isWiden = false;
            Rectangle rect = (Rectangle)sender;
            rect.ReleaseMouseCapture();
        }

        private void Rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle rect = (Rectangle)sender;
            if (isWiden)
            {
                rect.CaptureMouse();
                double newWidth = e.GetPosition(this).X + 5;
                if (newWidth > 0) this.Width = newWidth;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int from = Convert.ToInt32(fromTB.Text);
            int to = Convert.ToInt32(toTB.Text);
            resultTB.Text =Convert.ToString (r.Next(from, to));
        }
        bool IsMaxed=false;
        Rect restoreBounds;
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (IsMaxed)
            {
                WindowState = WindowState.Normal;
                this.Left = restoreBounds.Left;
                this.Top = restoreBounds.Top;
                this.Width = restoreBounds.Width;
                this.Height = restoreBounds.Height;
            }
            else
            {
                
                WindowState = WindowState.Maximized;

                restoreBounds = this.RestoreBounds;
            }
            IsMaxed = !IsMaxed;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            WindowState = WindowState.Minimized;
            //this.ShowInTaskbar = true;
        }

        
    }
}
