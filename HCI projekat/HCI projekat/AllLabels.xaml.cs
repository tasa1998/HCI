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
    /// Interaction logic for AllLabels.xaml
    /// </summary>
    public partial class AllLabels : Window
    {
        public AllLabels()
        {
            InitializeComponent();
            etiketeGrid.ItemsSource = App.LabelController.GetLabels();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(etiketeGrid.ItemsSource);
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void etiketeGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Model.Label label = (Model.Label)etiketeGrid.SelectedItem;
            var win2 = new EditLabel(label);
            win2.Show();
            this.Close();

        }
    }
}
