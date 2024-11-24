using System.Windows;
using System.Windows.Media.Imaging;

namespace Program
{
    public partial class OknoGalerii : Window
    {
        private string[] sciezkiDoZdjec =
        {
            "Images/zdjecie1.jpg",
            "Images/zdjecie2.jpg",
            "Images/zdjecie3.jpg",
            "Images/zdjecie4.jpg"
        };

        private int aktualneZdjecieIndex = 0;

        public OknoGalerii()
        {
            InitializeComponent();
            PokazZdjecie();
        }

        private void PokazZdjecie()
        {
            BitmapImage bitmap = new BitmapImage(new Uri(sciezkiDoZdjec[aktualneZdjecieIndex], UriKind.Relative));
            Obrazek.Source = bitmap;
        }

        private void PrzyciskPoprzednie_Click(object sender, RoutedEventArgs e)
        {
            aktualneZdjecieIndex = (aktualneZdjecieIndex == 0) ? sciezkiDoZdjec.Length - 1 : aktualneZdjecieIndex - 1;
            PokazZdjecie();
        }

        private void PrzyciskNastepne_Click(object sender, RoutedEventArgs e)
        {
            aktualneZdjecieIndex = (aktualneZdjecieIndex == sciezkiDoZdjec.Length - 1) ? 0 : aktualneZdjecieIndex + 1;
            PokazZdjecie();
        }
    }
}
