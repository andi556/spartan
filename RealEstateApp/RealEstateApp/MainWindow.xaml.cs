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

namespace RealEstateApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Locuinta loc;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox c = sender as ComboBox;
            switch(c.SelectedItem)
            {
                case "Casa":
                    loc = new Casa();
                    LabelNumarCamere.Visibility = Visibility.Hidden;
                    ComboBoxNumarCamere.Visibility = Visibility.Hidden;
                    LabelNivele.Visibility = Visibility.Visible;
                    ComboBoxNivele.Visibility = Visibility.Visible;
                    break;
                case "Apartament":
                    loc = new Apartment();
                    LabelNivele.Visibility = Visibility.Hidden;
                    ComboBoxNivele.Visibility = Visibility.Hidden;
                    LabelNumarCamere.Visibility = Visibility.Visible;
                    ComboBoxNumarCamere.Visibility = Visibility.Visible;
                    break;
                case "Garsoniera":
                    loc = new Garsoniera();
                    break;
                case "Studio":
                    loc = new Studio();
                    break;
            }
            LabelTotalPret.Visibility = Visibility.Hidden;
            LabelTotal.Visibility = Visibility.Hidden;
            LabelTotal.Content = "";
        }

        private void ComboBoxNumarCamere_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox c = sender as ComboBox;
            switch (c.SelectedItem.ToString())
            {
                case "2":
                    loc.Suprafata = 60;
                    break;
                case "3":
                    loc.Suprafata = 80;
                    break;
                case "4":
                    loc.Suprafata = 100;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int _result = 0;
            _result = 1000 * loc.Suprafata;
            if((bool)CheckBoxAC.IsChecked)
            {
                _result += 500;
            }
            if ((bool)CheckBoxPriveliste.IsChecked)
            {
                _result += 5000;
            }
            if ((bool)CheckBoxGaz.IsChecked)
            {
                _result += 1000;
            }
            if ((bool)CheckBoxUtilitatiSmart.IsChecked)
            {
                _result += 3000;
            }

            LabelTotalPret.Visibility = Visibility.Visible;
            LabelTotal.Visibility = Visibility.Visible;
            LabelTotal.Content = _result;
        }
    }
}
