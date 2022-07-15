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

namespace Для_отчёта_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            /*List<data> x = new List<data>();
            x.Add(new data() { barValue = 100 });
            DataList.ItemsSource = x;
            this.DataContext = x;*/
            
           
        }
       
        public int counter = 1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            progressBar1.Value = counter * 25;
        }

        private void chb1_Checked(object sender, RoutedEventArgs e)
        {
            counter++;
        }

        private void chb2_Checked(object sender, RoutedEventArgs e)
        {
            counter--;
        }

        private void chb3_Checked(object sender, RoutedEventArgs e)
        {
            counter++;
        }

        private void chb4_Checked(object sender, RoutedEventArgs e)
        {
            counter++;
        }

        private void chb1_Unchecked(object sender, RoutedEventArgs e)
        {
            counter--;
        }

        private void chb2_Unchecked(object sender, RoutedEventArgs e)
        {
            counter++;
        }

        private void chb3_Unchecked(object sender, RoutedEventArgs e)
        {
            counter--;
        }

        private void chb4_Unchecked(object sender, RoutedEventArgs e)
        {
            counter--;
        }
    }
}