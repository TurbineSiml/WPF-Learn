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

namespace WPF09D
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Bayern München", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 86 });
            matches.Add(new Match() { Team1 = "PSG", Team2 = "BVB", Score1 = 1, Score2 = 1, Completion = 32 });
            matches.Add(new Match() { Team1 = "VFB", Team2 = "HSV", Score1 = 2, Score2 = 1, Completion = 15 });
            matches.Add(new Match() { Team1 = "FC Barcelona", Team2 = "Malaga", Score1 = 2, Score2 = 1, Completion = 15 });
            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Ausgewähltes Spiel: "
                + (lbMatches.SelectedItem as Match).Team1 + " " +
                (lbMatches.SelectedItem as Match).Score1 + " " +
                (lbMatches.SelectedItem as Match).Score2 + " " +
                (lbMatches.SelectedItem as Match).Team2);
            }
            
        }
    }
}
