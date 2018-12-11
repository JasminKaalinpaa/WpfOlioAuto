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

namespace WpfOlioAuto
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

        private void BtnKaynnista_Click(object sender, RoutedEventArgs e)
        {
            Car Ferrari = new Car();
            Car Toyota = new Car();

            Ferrari.Color = txtVari.Text;
            Ferrari.MaxSpeed = int.Parse(txtHuippuNopeus.Text);
            MessageBox.Show("Ferrarin väri on: " + Ferrari.Color + " ja huippunopeus on: " + Ferrari.MaxSpeed.ToString());

            Toyota.Color = "Vihreä";
            Toyota.SetMaxSpeed(175);
            MessageBox.Show("Toyotan väri on: " + Toyota.Color + " ja huippunopeus on: " + Toyota.GetMaxSpeed().ToString());

        }
    }
}
