using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace HCI_projekat
{
    /// <summary>
    /// Interaction logic for EditLabel.xaml
    /// </summary>
    public partial class EditLabel : Window
    {
        private Model.Label labell = new Model.Label();
        public EditLabel(Model.Label label)
        {           
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            mark.Text = (String)label.Mark;
            description.Text = (String)label.Description;
            colorPicker.SelectedColor = label.Colorr;
        }

        private void sacuvaj_Click(object sender, RoutedEventArgs e)
        {
            labell.Mark = mark.Text;
            labell.Description = description.Text;
            labell.Colorr = (Color)colorPicker.SelectedColor;

            App.LabelController.EditLabel(labell);
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

        private void colorPicker_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void colorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {

        }
    }
}
