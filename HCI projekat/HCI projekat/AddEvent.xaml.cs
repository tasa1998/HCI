using HCI_projekat.Controller;
using HCI_projekat.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace HCI_projekat
{
    /// <summary>
    /// Interaction logic for AddEvent.xaml
    /// </summary>
    public partial class AddEvent : Window
    {
        private Event eventt;
        public DateTime Date { get; set; }
        public List<DateTime> Dates { get; set; }
        public AddEvent()
        {
            InitializeComponent();
            eventt = new Event();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Event> events =App.EventController.GetEvents();
            bool exists = false;
            if(events!= null) {
                foreach (Event eventt in events)
                {
                    if (eventt.Mark == mark.Text)
                    {
                        exists = true;
                        var win3 = new AlreadyExist();
                        win3.Show();
                        this.Close();
                    }
                }
            }
            

            eventt.Mark = mark.Text;
            eventt.Name = name.Text;
            eventt.Description = description.Text;
            ComboBoxItem typeItem = (ComboBoxItem)typeCB.SelectedItem;
            string value = typeItem.Content.ToString();
            ComboBoxItem typeItem1 = (ComboBoxItem)attendanceCB.SelectedItem;
            string value1 = typeItem1.Content.ToString();
            eventt.Type = value;
            eventt.Attendance = value1;

            
            
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
                if (typeCB.SelectedItem.Equals("Sport"))
                {
                    eventt.Icon = System.IO.Path.GetFullPath(@"..\..\") + "Images\\R35a560436de1298fa8737e81355984bb.png";
                }
                else if (typeCB.SelectedItem.Equals("Music"))
                {
                    eventt.Icon = System.IO.Path.GetFullPath(@"..\..\") + "Images\\iconlab-itunes-itunes-glow-music-icon-png-clip-art.png";
                }
                else if (typeCB.SelectedItem.Equals("Political"))
                {
                    eventt.Icon = System.IO.Path.GetFullPath(@"..\..\") + "Images\\neutral-p005-512.png";
                }
                else if (typeCB.SelectedItem.Equals("Film"))
                {
                    eventt.Icon = System.IO.Path.GetFullPath(@"..\..\") + "Images\\R5817f5719e45b7bd70f3718779e4cd0f.png";
                }
                else
                {
                    eventt.Icon = System.IO.Path.GetFullPath(@"..\..\") + "Images\\R12b12cc186cec1c0caedcbbb3f3122a9.png";
                }
            }

            if (exists == false)
                App.EventController.CreateEvent(eventt);

            var win1 = new SuccessfullyAdded();
            win1.Show();
            this.Close();

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
            if(attendanceCB.SelectedItem == null)
                attendanceCB.IsDropDownOpen = true;
        }

        private void date_KeyDown(object sender, KeyEventArgs e)
        {
            if(!date.SelectedDate.HasValue)
                date.IsDropDownOpen = true;
        }

        private void price_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
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

        private void labelCB_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void chooseLabels_Click(object sender, RoutedEventArgs e)
        {
            var win2 = new ChooseLabel();
            win2.Show();
        }
    }
}
