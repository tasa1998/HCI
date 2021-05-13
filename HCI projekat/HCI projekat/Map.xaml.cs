using HCI_projekat.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace HCI_projekat
{
    /// <summary>
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : Window
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Point startPoint;
        public virtual void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }
        private ObservableCollection<Event> events;

        public ObservableCollection<Event> Events
        {
            get { return events; }
            set
            {
                if (events != value)
                {

                    events = value;
                    OnPropertyChanged("Events");
                }
            }
        }
        public Map()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.DataContext = this;
            dogadjajiGrid.ItemsSource = App.EventController.GetEvents();
            loadAll();
        }

        private void dogadjajiGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dogadjajiGrid.SelectedValue is Event)
            {
                Event eventt = (Event)dogadjajiGrid.SelectedValue;
                if (!eventt.Icon.Equals(""))
                    PrikazIkone.Source = new BitmapImage(new Uri(eventt.Icon));
                    


            }
            else { PrikazIkone.Source = null; }

        }

        private void PrikazIkone_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void mapa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Right)
            {
                
            }
        }

        private void mapa_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("event"))
            {
                Event eventt = e.Data.GetData("event") as Event;

                bool result = mapa.Children.Cast<Image>().Any(x => x.Tag != null && x.Tag.ToString() == eventt.Mark);

                Point d0 = e.GetPosition(mapa);
                foreach(Event e1 in App.EventController.GetEvents())
                {
                    if(eventt.Mark != e1.Mark)
                    {
                        if(e1.x !=0 && e1.y != 0)
                        {
                            if(Math.Abs(e1.x-d0.X)<= 30 && Math.Abs(e1.y - d0.Y) <= 30) {
                                System.Windows.MessageBox.Show("Event with this location already exists!", "Event already exists");
                                loadAll();
                                return;
                            }
                        }
                    }
                }
                if(result == false)
                {
                    Image img = new Image();
                    if (!eventt.Icon.Equals(""))
                        img.Source = new BitmapImage(new Uri(eventt.Icon));
                    img.Width = 30;
                    img.Height = 30;
                    img.Tag = eventt.Mark;
                    var positionX = e.GetPosition(mapa).X;
                    var positionY = e.GetPosition(mapa).Y;

                    eventt.x = positionX;
                    eventt.y = positionY;
                    App.EventController.EditEvent(eventt);
                    WrapPanel wrap = new WrapPanel();
                    wrap.Orientation = Orientation.Vertical;

                    TextBox mark = new TextBox();
                    mark.IsEnabled = false;
                    mark.Text = "Mark: " +eventt.Mark;
                    wrap.Children.Add(mark);

                    TextBox name = new TextBox();
                    name.IsEnabled = false;
                    name.Text = "Name: " + eventt.Name;
                    wrap.Children.Add(name);

                    TextBox type = new TextBox();
                    type.IsEnabled = false;
                    type.Text = "Type: " + eventt.Type;
                    wrap.Children.Add(type);

                    TextBox description = new TextBox();
                    description.IsEnabled = false;
                    description.Text = "description: " + eventt.Description;
                    wrap.Children.Add(description);

                    TextBox date = new TextBox();
                    date.IsEnabled = false;
                    date.Text = "Date: " + eventt.Date.ToShortDateString();
                    wrap.Children.Add(date);

                    ToolTip tool = new ToolTip();
                    tool.Content = wrap;
                    img.ToolTip = tool;
                    img.PreviewMouseLeftButtonDown += DraggedImagePreviewMouseLeftButtonDown;
                    img.MouseMove += DraggedImageMouseMove;

                    List<Event> events1 = App.EventController.GetEvents();
                    int id = 0;
                    foreach(Event e4 in events1)
                    {
                        if (e4.Mark.Equals(eventt.Mark))
                            break;
                        id++;
                    }
                    events1[id] = eventt;
                    mapa.Children.Add(img);
                    App.EventController.SaveEvents(events1);
                    Canvas.SetLeft(img, positionX - 20);
                    Canvas.SetTop(img, positionY - 20);
                }
                else
                {
                    System.Windows.MessageBox.Show("This event already exists on map", "Add event on map");
                }
            }
        }

        private void loadAll()
        {
            foreach(Event eventt in App.EventController.GetEvents())
            {
                bool result = mapa.Children.Cast<Image>().Any(x => x.Tag != null && x.Tag.ToString() == eventt.Mark);
                if (result)
                    continue;
                if(eventt.x!=-1 || eventt.y != -1)
                {
                    Image img = new Image();
                    if (!eventt.Icon.Equals(""))
                        img.Source = new BitmapImage(new Uri(eventt.Icon));

                    img.Width = 30;
                    img.Height = 30;
                    img.Tag = eventt.Mark;
                    WrapPanel wrap = new WrapPanel();
                    wrap.Orientation = Orientation.Vertical;

                    TextBox mark = new TextBox();
                    mark.IsEnabled = false;
                    mark.Text = "Mark: " + eventt.Mark;
                    wrap.Children.Add(mark);

                    TextBox name = new TextBox();
                    name.IsEnabled = false;
                    name.Text = "Name: " + eventt.Name;
                    wrap.Children.Add(name);

                    TextBox type = new TextBox();
                    type.IsEnabled = false;
                    type.Text = "Type: " + eventt.Type;
                    wrap.Children.Add(type);

                    TextBox description = new TextBox();
                    description.IsEnabled = false;
                    description.Text = "description: " + eventt.Description;
                    wrap.Children.Add(description);

                    TextBox date = new TextBox();
                    date.IsEnabled = false;
                    date.Text = "Date: " + eventt.Date.ToShortDateString();
                    wrap.Children.Add(date);

                    ToolTip tool = new ToolTip();
                    tool.Content = wrap;
                    img.ToolTip = tool;
                    img.PreviewMouseLeftButtonDown += DraggedImagePreviewMouseLeftButtonDown;
                    img.MouseMove += DraggedImageMouseMove;

                    List<Event> events1 = App.EventController.GetEvents();
                    int id = 0;
                    foreach (Event e4 in events1)
                    {
                        if (e4.Mark.Equals(eventt.Mark))
                            break;
                        id++;
                    }
                    events1[id] = eventt;
                    mapa.Children.Add(img);
                    App.EventController.SaveEvents(events1);
                    Canvas.SetLeft(img, eventt.x - 20);
                    Canvas.SetTop(img, eventt.y - 20);
                }
            }
        }

        private void DraggedImageMouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Point mousePos = e.GetPosition(null);
            Vector diff = startPoint - mousePos;
            if (e.LeftButton == MouseButtonState.Pressed &&
               (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
               Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {


                Event selected = (Event)dogadjajiGrid.SelectedValue;

                if (selected != null)
                {
                    Image img = sender as Image;
                    mapa.Children.Remove(img);
                    DataObject dragData = new DataObject("event", selected);
                    DragDrop.DoDragDrop(img, dragData, DragDropEffects.Move);

                }

            }

        }

        private void mapa_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void PrikazIkone_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Point mousePos = e.GetPosition(null);
            Vector diff = startPoint - mousePos;
            if (e.LeftButton == MouseButtonState.Pressed &&
               (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
               Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                try
                {
                    Model.Event selektovan = (Model.Event)dogadjajiGrid.SelectedValue;
                    if (selektovan != null)
                    {
                        DataObject dragData = new DataObject("event", selektovan);
                        DragDrop.DoDragDrop(PrikazIkone, dragData, DragDropEffects.Move);
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        private void PrikazIkone_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void DraggedImagePreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            startPoint = e.GetPosition(null);
            Image img = sender as Image;

            foreach (Event eventt in Events)
            {
                if (eventt.Mark.Equals(img.Tag))
                {
                    dogadjajiGrid.SelectedValue = eventt;
                    if (!eventt.Icon.Equals(""))
                        PrikazIkone.Source = new BitmapImage(new Uri(eventt.Icon));

                }
            }
            if (e.LeftButton == MouseButtonState.Released)
                e.Handled = true;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Event evennt = (Event)dogadjajiGrid.SelectedItem;
            if(evennt!= null)
            {
                bool result = mapa.Children.Cast<Image>().Any(x => x.Tag != null && x.Tag.ToString() == evennt.Mark);
                if (result)
                {
                    Image img = null;
                    foreach (Image i in mapa.Children)
                    {
                        
                        if (i.Tag.Equals(evennt.Mark))
                            img = i;
                    }
                    mapa.Children.Remove(img);

                    evennt.x = -1;
                    evennt.y = -1;
                    App.EventController.EditEvent(evennt);
                    loadAll();
                }
            }
        }
    }
}
