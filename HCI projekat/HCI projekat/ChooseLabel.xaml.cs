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
    /// Interaction logic for ChooseLabel.xaml
    /// </summary>
    public partial class ChooseLabel : Window
    {
        private List<Model.Label> selectedLabels = new List<Model.Label>();
        private Model.Event eventt;
        public ChooseLabel(Model.Event event1)
        {
            InitializeComponent();
            etiketeGrid.ItemsSource = App.LabelController.GetLabels();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(etiketeGrid.ItemsSource);
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            eventt = event1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void etiketeGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Model.Label label = (Model.Label)etiketeGrid.SelectedItem;
                selectedLabels.Add(label);
                if (eventt.labels == null)
                    eventt.labels = new List<Model.Label>();
                eventt.labels.Add(label);
                MessageBox.Show("Successfully added label", "Added label");
            }
        }
    }
}
