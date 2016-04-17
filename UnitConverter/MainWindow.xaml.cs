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

namespace UnitConverter
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

        private void celsiusToFahrenheit(object sender, RoutedEventArgs e)
        {
            double C;
            double F;
            C = double.Parse(celsius.Text);
            F = ((9.0 / 5.0) * C + 32);
            CtoF.Text = F.ToString();
        }

        private void kilometersToMiles(object sender, RoutedEventArgs e)
        {
            double Km;
            double Mi;
            Km = double.Parse(kilometers.Text);
            Mi = Km * 0.62137;
            KmtoMi.Text = Mi.ToString();
        }

        private void kilogramsToPounds(object sender, RoutedEventArgs e)
        {
            double Kg;
            double Lbs;
            Kg = double.Parse(kilograms.Text);
            Lbs = Kg * 2.2046;
            KgtoLbs.Text = Lbs.ToString();
        }

        private void inchesToFeet(object sender, RoutedEventArgs e)
        {
            double In;
            double Ft;
            In = double.Parse(inches.Text);
            Ft = In * 0.083333;
            InToFt.Text = Ft.ToString();
        }

        private void feetToYards(object sender, RoutedEventArgs e)
        {
            double Ft;
            double Yd;
            Ft = double.Parse(feet.Text);
            Yd = Ft * 0.33333;
            FtToYd.Text = Yd.ToString();
        }
    }
}
