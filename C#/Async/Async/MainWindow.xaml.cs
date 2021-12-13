using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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

namespace Async
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

        private void Test_Button(object sender, RoutedEventArgs e)
        {
            DownloadHtml("https://en.wikipedia.org/wiki/Main_Page");
        }
        //If return void Task other Task<>
        public async Task DownloadHtmlAsync(string url)
        {
            var webC = new WebClient();
            webC.UseDefaultCredentials = true;
            //Marker for the compiler and know that it may take of time, and instead of wait return control immediatly.
            var html = await webC.DownloadStringTaskAsync(url);
            using (var streamWriter = new StreamWriter(@"C:\Users\supaw\Documents\result.html"))
            {
                Thread.Sleep(2000);
                //All blocking application contain Async
                await streamWriter.WriteAsync(html);
            }
        }
        public void DownloadHtml(string url)
        {
            var webC = new WebClient();
            webC.UseDefaultCredentials = true;
            var html = webC.DownloadString(url);
            using (var streamWriter = new StreamWriter(@"C:\Users\supaw\Documents\result.html"))
            {
                Thread.Sleep(2000);
                streamWriter.Write(html);
            }
        }

        private void Test_Click_Async(object sender, RoutedEventArgs e)
        {
            DownloadHtmlAsync("https://en.wikipedia.org/wiki/Main_Page");
        }
    }
}
