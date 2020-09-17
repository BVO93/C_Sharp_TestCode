using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
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
using System.Threading;

namespace WPFTasks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
<<<<<<< HEAD
        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached(
            "Html",
            typeof(string),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(OnHtmlChanged));


=======
>>>>>>> 2fa024ebe7865c3e39ca85b89d777ea82daecfb1
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            Task.Run(() =>
                {

                    Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");

                    HttpClient webClient = new HttpClient();
                    string html = webClient.GetStringAsync("http://ipv4.download.thinkbroadband.com/20MB.zip").Result;


                    // Invoke the  thread that the operation has been done 
                    MyButton.Dispatcher.Invoke(() =>
                    {
                        Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} Owns my button");
                        MyButton.Content = "Done";

                    });

            });
        }

        // Other way

        private async void MyButton_Click2(object sender, RoutedEventArgs e)
        {
            // Placeholder 
            string myHtml = "Bla";
            await Task.Run(async() =>
            {

                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");

                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("https://google.com").Result;
                myHtml = html;
            });

            MyButton.Content = "Done Donwload";
            myWebBrowser.SetValue(HtmlProperty, myHtml);
        }

        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            if(webBrowser != null)
            {
                webBrowser.NavigateToString(e.NewValue as string);
            }


        }


=======
            Task.Run(()=>
                {

                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread}");

                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("http://ipv4.download.thinkbroadband.com/20MB.zip").Result;

                MyButton.Content = "Done";
            });
        }
>>>>>>> 2fa024ebe7865c3e39ca85b89d777ea82daecfb1
    }
}
