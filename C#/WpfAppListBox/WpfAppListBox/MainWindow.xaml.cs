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

namespace WpfAppListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Bayarn Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 85 });
            matches.Add(new Match() { Team1 = "Arsenal", Team2 = "Real Madrid", Score1 = 4, Score2 = 3, Completion = 5 });
            matches.Add(new Match() { Team1 = "Chelsea", Team2 = "Real Madrid", Score1 = 10, Score2 = 2, Completion = 55 });
            matches.Add(new Match() { Team1 = "Bayarn Munich", Team2 = "Everton", Score1 = 0, Score2 = 0, Completion = 50 });
            matches.Add(new Match() { Team1 = "Chelsea", Team2 = "Arsenal", Score1 = 2, Score2 = 2, Completion = 85 });

            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: " +
                    (lbMatches.SelectedItem as Match).Team1 + " " +
                    (lbMatches.SelectedItem as Match).Score1 + " " + "-" +
                    (lbMatches.SelectedItem as Match).Score2 + " " +
                    (lbMatches.SelectedItem as Match).Team2 + " "
                    );
            }
        }
    }
    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }

        public string Team1 { get; set; }
        public string Team2 { get; set; }

        public int Completion { get; set; }

    }
}
