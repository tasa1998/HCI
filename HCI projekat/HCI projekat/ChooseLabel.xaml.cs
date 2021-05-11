﻿using System;
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
        public ChooseLabel()
        {
            InitializeComponent();
            etiketeGrid.ItemsSource = App.LabelController.GetLabels();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(etiketeGrid.ItemsSource);
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
