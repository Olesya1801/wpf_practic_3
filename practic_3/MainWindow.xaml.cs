using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;

namespace practic_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrmMain.Navigate(new Pages.Autho());
        }

        private void FrmMain_ContentRendered(object sender, System.EventArgs e)
        {
            if (FrmMain.Content is Pages.Autho)
            {
                btnBack.Visibility = Visibility.Collapsed;
            }
            else
            {
                btnBack.Visibility = Visibility.Visible;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (FrmMain.CanGoBack)
            {
                FrmMain.GoBack();
            }
        }
    }
}