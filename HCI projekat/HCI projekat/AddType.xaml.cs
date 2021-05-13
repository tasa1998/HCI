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
    /// Interaction logic for AddType.xaml
    /// </summary>
    public partial class AddType : Window
    {
        private Model.Type type;
        public AddType()
        {
            type = new Model.Type();
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void sacuvaj_Click(object sender, RoutedEventArgs e)
        {

            List<Model.Type> labels = App.TypeController.GetTypes();
            bool exists = false;
            if (labels != null)
            {
                foreach (Model.Type label in labels)
                {
                    if (label.Mark == oznaka_textBox.Text)
                    {
                        exists = true;
                        var win3 = new AlreadyExist();
                        win3.Show();
                        this.Close();
                    }
                }
            }
            type.Mark = oznaka_textBox.Text;
            type.Name = oznaka_textBox_Copy.Text;
            type.Description = textBox_Copy1.Text;

            if(exists == false) {
                App.TypeController.CreateType(type);
                var win1 = new SuccessfullyAdded();
                win1.Show();
                this.Close();
            }
                
        }

        private void odustani_Click(object sender, RoutedEventArgs e)
        {
            var win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();


            fileDialog.Title = "Izaberi ikonicu";
            fileDialog.Filter = "Images|*.jpg;*.jpeg;*.png|" +
                                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                                "Portable Network Graphic (*.png)|*.png";
            if (fileDialog.ShowDialog() == true)
            {
                ikonica.Source = new BitmapImage(new Uri(fileDialog.FileName));
                type.Icon = ikonica.Source.ToString();
            }
        }
    }
}
