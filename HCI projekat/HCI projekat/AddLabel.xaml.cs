using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCI_projekat.Model;
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
    /// Interaction logic for AddLabel.xaml
    /// </summary>
    public partial class AddLabel : Window
    {
        private Model.Label label1;
        public AddLabel()
        {
            InitializeComponent();
            label1 = new Model.Label();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void sacuvaj_Click(object sender, RoutedEventArgs e)
        {
            List<Model.Label> labels = App.LabelController.GetLabels();
            bool exists = false;
            if (labels != null) {
                foreach (Model.Label label in labels)
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
            
            label1.Mark = oznaka_textBox.Text;
            label1.Description = textBox_Copy1.Text;
            if(exists == false)
            {
                App.LabelController.CreateLabel(label1);
            }
            var win1 = new SuccessfullyAdded();
            win1.Show();
            this.Close();

        }

        private void odustani_Click(object sender, RoutedEventArgs e)
        {
            var win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void colorPicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (!colorPicker.SelectedColor.HasValue)
                colorPicker.IsOpen = true;
        }

        private void colorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            Color color = (Color)colorPicker.SelectedColor;
            label1.Colorr = color;
        }
    }
}
