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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbAllCheckeChanges(object sender, RoutedEventArgs e)
        {
            bool newVal = (CbAllToppings.IsChecked == true);
            cbMushrooms.IsChecked = newVal;
            cbSalami.IsChecked = newVal;
            cbMozzarella.IsChecked = newVal;

        }

        private void cbSingleCheckedChanged(object sender, RoutedEventArgs e)
        {
            CbAllToppings.IsChecked = null;
            if((cbSalami.IsChecked == true) && (cbMozzarella.IsChecked == true) && (cbMushrooms.IsChecked == true))
            {
                CbAllToppings.IsChecked = true;
            }

            if ((cbSalami.IsChecked == false) && (cbMozzarella.IsChecked == false) && (cbMushrooms.IsChecked == false))
            {
                CbAllToppings.IsChecked = false;
            }
        }

    }
}
