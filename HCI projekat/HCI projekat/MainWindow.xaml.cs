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
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace HCI_projekat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
              new BitmapImage(new Uri("C:/Users/Nastasja/Desktop/HCI github/HCI/HCI projekat/HCI projekat/Images/light-blue-marble-background.2019.jpg", UriKind.Absolute));
            this.Background = myBrush;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win2 = new AddEvent();
            win2.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var win2 = new AllEvents();
            win2.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var win2 = new Map();
            win2.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var win2 = new AddLabel();
            win2.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var win2 = new AllLabels();
            win2.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var win2 = new AddType();
            win2.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var win2 = new AllTypes();
            win2.Show();
            this.Close();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(null, @"C:/Users/Nastasja/Desktop/Help/HCIHelp.chm");
        }
    }
}
