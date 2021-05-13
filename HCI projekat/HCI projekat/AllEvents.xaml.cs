using HCI_projekat.Model;
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
    /// Interaction logic for AllEvents.xaml
    /// </summary>
    public partial class AllEvents : Window
    {
        public AllEvents()
        {
            InitializeComponent();
            dogadjajiGrid.ItemsSource = App.EventController.GetEvents();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(dogadjajiGrid.ItemsSource);
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void dogadjajiGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Event eventt = (Event)dogadjajiGrid.SelectedItem;
            var win2 = new EditEvent(eventt);
            win2.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Event eventt = (Event)dogadjajiGrid.SelectedItem;
            App.EventController.DeleteEvent(eventt);

        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            var tbx = sender as TextBox;
            if(tbx.Text != "")
            {
                var filteredList = App.EventController.GetEvents().Where(x=> x.Name.ToLower().Contains(tbx.Text.ToLower())
                || x.Description.ToLower().Contains(tbx.Text.ToLower()) 
                || x.Country.ToLower().Contains(tbx.Text.ToLower()) 
                || x.City.ToLower().Contains(tbx.Text.ToLower())
                || x.Price.ToString().ToLower().Contains(tbx.Text.ToLower())
                || x.Attendance.ToLower().Contains(tbx.Text.ToLower()));
                dogadjajiGrid.ItemsSource = null;
                dogadjajiGrid.ItemsSource = filteredList;
            }
            else
            {
                dogadjajiGrid.ItemsSource = App.EventController.GetEvents();
            }
        }

        private void dogadjajiGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Event eventt = (Event)dogadjajiGrid.SelectedItem;
                var win2 = new EditEvent(eventt);
                win2.Show();
                this.Close();
            }
        }
    }
}
