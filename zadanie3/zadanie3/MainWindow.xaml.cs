using System.Windows;
using pensja;

namespace Program2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameInput.Text;
            string password = PasswordInput.Password;

            if (username == "Admin" && password == "Owca")
            {
                Program calculatorWindow = new Program();
                calculatorWindow.Show();
                this.Close(); 
            }
            else
            {
                ErrorText.Text = "Niepoprawna nazwa użytkownika lub hasło.";
            }
        }
    }
}
