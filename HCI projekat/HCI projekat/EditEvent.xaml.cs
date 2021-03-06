using HCI_projekat.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for EditEvent.xaml
    /// </summary>
    public partial class EditEvent : Window
    {
        private Event eventt = new Event();
        public DateTime Date { get; set; }
        public EditEvent(Event even)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            List<Model.Type> types = App.TypeController.GetTypes();
            List<String> names = new List<String>();
            foreach (Model.Type type in types)
            {
                names.Add(type.Name);
            }
            typeCB.ItemsSource = names;
            mark.Text = (String)even.Mark;
            name.Text = (String)even.Name;
            description.Text = (String)even.Description;
            typeCB.Text = (String)even.Type;
            attendanceCB.Text = (String)even.Attendance;
            date.Text = even.Date.ToString("dd.MM.yyyy");
            if (even.Humanitarian == true)
                humanitarian.IsChecked = true;
            country.Text = (String)even.Country;
            city.Text = (String)even.City;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void typeCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (typeCB.SelectedItem == null)
                typeCB.IsDropDownOpen = true;
        }

        private void attendanceCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (attendanceCB.SelectedItem == null)
                attendanceCB.IsDropDownOpen = true;
        }
        private void price_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void date_KeyDown(object sender, KeyEventArgs e)
        {
            if (!date.SelectedDate.HasValue)
                date.IsDropDownOpen = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            eventt.Mark = mark.Text;
            eventt.Name = name.Text;
            eventt.Description = description.Text;
            ComboBoxItem typeItem1 = (ComboBoxItem)attendanceCB.SelectedItem;
            string value1 = typeItem1.Content.ToString();
            eventt.Attendance = value1;
            String tip = (string)typeCB.SelectedItem;
            List<Model.Type> types = App.TypeController.GetTypes();
            foreach (Model.Type type in types)
            {
                if (type.Name == tip)
                    eventt.Type = type.Name;
            }
            if (date.SelectedDate.HasValue)
            {
                string dateCalendar = date.SelectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                Date = (DateTime)date.SelectedDate;
            }
            eventt.Date = new DateTime(Date.Year, Date.Month, Date.Day);
            eventt.Price = int.Parse(price.Text);
            if ((bool)humanitarian.IsChecked)
                eventt.Humanitarian = true;
            else
                eventt.Humanitarian = false;
            eventt.Country = country.Text;
            eventt.City = city.Text;
            if (ikonica.Source == null)
            {
                foreach (Model.Type type in types)
                {
                    if (type.Name == tip)
                    {
                        eventt.Icon = type.Icon;
                    }
                }
            }

            App.EventController.EditEvent(eventt);
            var win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void izaberiIkonicu_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();


            fileDialog.Title = "Izaberi ikonicu";
            fileDialog.Filter = "Images|*.jpg;*.jpeg;*.png|" +
                                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                                "Portable Network Graphic (*.png)|*.png";
            if (fileDialog.ShowDialog() == true)
            {
                ikonica.Source = new BitmapImage(new Uri(fileDialog.FileName));
                eventt.Icon = ikonica.Source.ToString();
            }
        }
    }
}
