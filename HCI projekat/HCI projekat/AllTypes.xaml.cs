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
    public partial class AllTypes : Window
    {
        public AllTypes()
        {
            InitializeComponent();
            etiketeGrid.ItemsSource = App.TypeController.GetTypes();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(etiketeGrid.ItemsSource);
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void etiketeGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Model.Type label = (Model.Type)etiketeGrid.SelectedItem;
            var win2 = new EditType(label);
            win2.Show();
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win2 = new MainWindow();
            win2.Show();
            this.Close();
        }
    }
}
