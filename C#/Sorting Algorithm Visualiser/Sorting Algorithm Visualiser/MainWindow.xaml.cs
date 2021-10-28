using System;
using System.Collections;
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

namespace Sorting_Algorithm_Visualiser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //StackPanel stackPanel = new StackPanel();
            //stackPanel.Orientation = Orientation.Horizontal;
            //stackPanel.VerticalAlignment = VerticalAlignment.Bottom;
            //this.Content = stackPanel;
            //int number = 10;

            //ArrayList item = generateRandomNumberIntoArrayList(number);
            //createTheGraph(item, stackPanel);
            //System.Threading.Thread.Sleep(5000);
            ////Bubble sort
            //int t;

            //for (int p = 0; p <= item.Count- 2; p++)
            //{
            //    for (int i = 0; i <= item.Count - 2; i++)
            //    {
            //        if (Convert.ToInt32(item[i]) > Convert.ToInt32(item[i + 1]))
            //        {
            //            t = Convert.ToInt32(item[i + 1]);
            //            item[i + 1] = item[i];
            //            item[i] = t;
            //        }
            //    }
            //}
            
            //createTheGraph(item,stackPanel);

            //initialise the graph.








        }
        public void createTheGraph(ArrayList item,StackPanel stackPanel)
        {
            Rectangle rect = new Rectangle();
            for (int i = 0; i < item.Count; i++)
            {

                rect = new Rectangle();
                rect.Width = 10;
                rect.Fill = Brushes.Purple;
                rect.Height = Convert.ToInt32(item[i]);
                rect.VerticalAlignment = VerticalAlignment.Bottom;

                stackPanel.Children.Add(rect);
            }


        }
        public ArrayList generateRandomNumberIntoArrayList(int numberOfItemToGenerate)
        {
            ArrayList item = new ArrayList();
            Random rand = new Random();
            int number = rand.Next(1, 10);

            for (int i = 0; i < numberOfItemToGenerate; i++)
            {
                number = rand.Next(1, 100);
                item.Add((double)number);
            }
            return item;
        }

        private void Close_The_App(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Reset(object sender, RoutedEventArgs e)
        {

        }



        private void Start_Sorting(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorting has started");
        }

        private void Initilise_The_Graph(object sender, RoutedEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 10;
            rect.Fill = Brushes.Red;
            rect.Height = Convert.ToInt32(20);
            rect.VerticalAlignment = VerticalAlignment.Bottom;
            this.
        }
    }
}
