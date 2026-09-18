using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserAdmin.Services;

namespace UserAdmin.Views
{
    /// <summary>
    /// Interaction logic for MembersPage.xaml
    /// </summary>
    public partial class MembersPage : Page
    {
        private readonly UserDbService _userDbService = new();
        public MembersPage()
        {
            InitializeComponent();
            MembersGrid.ItemsSource = _userDbService.GetAll();
        }

        private void ContactMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kapcsolat:\ninfo@info.com\n06-30648-78-50","Kapcsolat",MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void HelpMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Súgó:\nAz új 'Új tag' gombbal új felhasználót vehetsz fel.\nA táblázat soraiban 'Szerkesztéssel' módosíthatod, a 'törléssel' eltávolíthatod a tagot.\nA 'Kijelentkezés' gombbal visszatérhetsz a bejeletkező oldalra", "Súgó", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
