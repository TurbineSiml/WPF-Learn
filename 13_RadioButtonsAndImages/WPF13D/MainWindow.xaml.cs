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

namespace WPF13D
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbMaybe.IsChecked = true;
        }

        private void Ja_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Danke, dass du mich magst.");
        }

        private void Nein_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Schade, dass du mich nicht magst.");
        }

        private void Vielleicht_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Was muss ich tun, um dich zu überzeugen.");
        }
    }
}
