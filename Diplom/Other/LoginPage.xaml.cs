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

namespace Diplom.Other
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {           
        public LoginPage()
        {
            InitializeComponent();           
        }

        private void onLoginClick(object sender, RoutedEventArgs e)
        {
            bool missUser = false;

            if (TxtLogin.Text == "" && TxtPassword.Text == "")
            {
                MessageBox.Show("Введите логин и пароль", "", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
            else if (TxtLogin.Text == "")
            {
                MessageBox.Show("Введите логин", "", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
            else if (TxtPassword.Text == "")
            {
                MessageBox.Show("Введите пароль", "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                foreach (var user in DiplomEntities.GetContext().TUsers.ToList())
                {
                    
                    if (TxtLogin.Text == user.UserLogin && TxtPassword.Text == user.UserPassword)
                    {
                        missUser = true;
                        Manager.MainFrame.Navigate(new MenuPage());
                        TxtLogin.Text = "";
                        TxtPassword.Text = "";
                        Manager.CU = user.UserId;
                        Manager.CRU = user.UserRole;
                        (Application.Current.MainWindow as MainWindow).UserSurname.Text = user.UserSurname +" "+ user.UserName + " " + user.UserPatronymic;
                        break;
                    }
                    else
                    {
                        missUser = false;
                    }
                }
                if (missUser == false)
                {
                    MessageBox.Show("Логин и/или пароль не совпадают!", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
        }

        private void TxtLoginKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void TxtPasswordKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }
}
