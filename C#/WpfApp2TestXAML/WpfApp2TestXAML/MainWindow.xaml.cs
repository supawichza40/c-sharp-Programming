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

namespace WpfApp2TestXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this initialise the title and code.
            Grid grid = new Grid();
            this.Content = grid;
            //This mean that the content of the window will be grid like the XAML file.
            Button btn = new Button();
            btn.FontSize = 25;
            WrapPanel wrapPanel = new WrapPanel();
            TextBlock text1 = new TextBlock();
            text1.Text = "Multi";
            text1.Foreground = Brushes.Blue;
            TextBlock text2 = new TextBlock();
            text2.Text = "Color";
            text2.Foreground = Brushes.Red;
            TextBlock text3 = new TextBlock();
            text3.Text = "Button";
            text3.Foreground = Brushes.Brown;


            wrapPanel.Children.Add(text1);
            wrapPanel.Children.Add(text2);
            wrapPanel.Children.Add(text3);
            btn.Content = wrapPanel;
            grid.Children.Add(btn);



        }
    }
}
