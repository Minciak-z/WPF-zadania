using System.Windows;

namespace Pensja
{
    public partial class MainWindow : Window
    {
        private decimal pensja = 0.12m; 

        public MainWindow()
        {
            InitializeComponent();
        }

        private decimal ObliczPensje(decimal brutto)
        {
            return brutto - brutto * pensja;  
        }

        private void Oblicz(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(txtBrutto.Text, out decimal brutto) && brutto > 0)
            {
                decimal netto = ObliczPensje(brutto);

                listBrutto.Items.Add(brutto.ToString("C"));
                listNetto.Items.Add(netto.ToString("C"));

                txtBrutto.Clear();
            }
            else
            {
                MessageBox.Show("Wprowadź poprawną wartość brutto.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Check(object sender, RoutedEventArgs e)
        {
            if (radioButton8_5.IsChecked == true)
                pensja = 0.085m;
            else if (radioButton12.IsChecked == true)
                pensja = 0.12m;
            else if (radioButton19.IsChecked == true)
                pensja = 0.19m;
        }
    }
}
