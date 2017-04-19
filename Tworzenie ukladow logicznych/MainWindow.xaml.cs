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

namespace Tworzenie_ukladow_logicznych
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RadioButton AND;
        RadioButton OR;
        RadioButton NOT;

        public MainWindow()
        {
            InitializeComponent();
            AND = Bramka_And;
            OR = Bramka_Or;
            NOT = Bramka_Not;
            AND.IsChecked = true;
            NOT.IsChecked = false;
            OR.IsChecked = false;
        }

        private void Tworzenie_Bramki_Click(object sender, RoutedEventArgs e)
        {
            Line Linia = new Line();
            Linia.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            Linia.X1 = 20;
            Linia.Y1 = 20;
            Linia.X2 = 400;
            Linia.Y2 = 400;
            Linia.HorizontalAlignment = HorizontalAlignment.Center;
            Linia.VerticalAlignment = VerticalAlignment.Center;
            Linia.StrokeThickness = 2;
            Rysowanie.Children.Add(Linia);
        }

        private void And_Checked(object sender, RoutedEventArgs e)
        {
            AND.IsChecked = true;
            NOT.IsChecked = false;
            OR.IsChecked = false;
        }
        
        private void Or_Checked(object sender, RoutedEventArgs e)
        {
            AND.IsChecked = false;
            NOT.IsChecked = false;
            OR.IsChecked = true;
        }

        private void Not_Checked(object sender, RoutedEventArgs e)
        {
            AND.IsChecked = false;
            NOT.IsChecked = true;
            OR.IsChecked = false;
        }

        private void Bramki_Expanded(object sender, RoutedEventArgs e)
        {
            Wejscie.IsExpanded = false;
        }

        private void Wejscie_Expanded(object sender, RoutedEventArgs e)
        {
            Bramki.IsExpanded = false;
        }
    }
}
