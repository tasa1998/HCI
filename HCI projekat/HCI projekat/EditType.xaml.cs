using Microsoft.Win32;
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

namespace HCI_projekat
{
    /// <summary>
    /// Interaction logic for EditType.xaml
    /// </summary>
    public partial class EditType : Window
    {
        private Model.Type type1;
        public EditType(Model.Type type)
        {
            InitializeComponent();
            type1 = new Model.Type();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            oznaka_textBox.Text = type.Mark;
            textBox_Copy1.Text = type.Description;
            oznaka_textBox_Copy.Text = type.Name;
            ikonica.Source = new BitmapImage(new Uri(type.Icon));

        }

        private void sacuvaj_Click(object sender, RoutedEventArgs e)
        {
            type1.Mark = oznaka_textBox.Text;
            type1.Name = oznaka_textBox_Copy.Text;
            type1.Description = textBox_Copy1.Text;
            type1.Icon = ikonica.Source.ToString();
            App.TypeController.EditType(type1);
            var win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void odustani_Click(object sender, RoutedEventArgs e)
        {
            var win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void choose_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();


            fileDialog.Title = "Izaberi ikonicu";
            fileDialog.Filter = "Images|*.jpg;*.jpeg;*.png|" +
                                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                                "Portable Network Graphic (*.png)|*.png";
            if (fileDialog.ShowDialog() == true)
            {
                ikonica.Source = new BitmapImage(new Uri(fileDialog.FileName));
                type1.Icon = ikonica.Source.ToString();
            }
        }
    }
}
