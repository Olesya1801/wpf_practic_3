using System.Windows;
using System.Windows.Controls;

namespace practic_3.Pages
{
    public partial class Autho : Page
    {
        public Autho()
        {
            InitializeComponent();
        }

        // Обработчик кнопки "Войти как гость"
        private void btnEnterGuests_Click(object sender, RoutedEventArgs e)
        {
            // Переход на страницу Client
            NavigationService.Navigate(new Client());
        }

        // Обработчик кнопки "Войти"
        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            // Здесь будет логика авторизации (пока пусто)
            MessageBox.Show("Функция авторизации пока не реализована");
        }
    }
}