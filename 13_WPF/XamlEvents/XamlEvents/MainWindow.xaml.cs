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

namespace XamlEvents
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

        //Direct event
        private void Button_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button is pressed - Direct event  ");

        }

        // Bubbling event  Is catch higher up
        /*
        private void Mouse_Button(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse button was release");

        }
        */

        // Tunneling event, is catched further down
        private void Previeuw_Mouse_up(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse wet up / released");
        }
    }
}
