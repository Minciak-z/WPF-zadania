using System.Collections.Generic;
using System.Windows;

namespace Pensje
{
    public partial class Kalkulator : Window
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Oblicz(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(txtBrutto.Text, out decimal brutto) && brutto > 0)
            {
                decimal netto = brutto - brutto * 0.12m;

                listBrutto.Items.Add(brutto.ToString("C"));
                listNetto.Items.Add(netto.ToString("C"));

                txtBrutto.Clear();
            }
            else
            {
                MessageBox.Show("Wprowadź poprawną wartość  brutto.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
