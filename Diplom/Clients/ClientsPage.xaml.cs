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
using System.Text.RegularExpressions;

namespace Diplom.Clients
{
    /// <summary>
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        public ClientsPage()
        {
            InitializeComponent();
            UpdateClients();
        }

        public void UpdateClients()
        {
            if (Manager.CRU != 1)
            {
                DeleteClient.Visibility = Visibility.Hidden;
                DeleteClient.IsEnabled = false;
            }
            else
            {
                DeleteClient.Visibility = Visibility.Visible;
                DeleteClient.IsEnabled = true;
            }

            DiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var currentClients = DiplomEntities.GetContext().TClients.ToList().Where(p => p.ClientId != 1);

            currentClients = currentClients.Where(p => p.ClientSurname.ToLower().Contains(ClientSearchBox.Text.ToLower())).ToList();
            currentClients = currentClients.Where(p => p.ClientPhone.ToLower().Contains(PhoneSearchBox.Text.ToLower())).ToList();

            ClientsList.ItemsSource = currentClients;
        }

        private void ClientSearch(object sender, TextChangedEventArgs e)
        {
            UpdateClients();
        }

        private void NewClientClick(object sender, RoutedEventArgs e)
        {
                Manager.MainFrame.Navigate(new AddClient(null));
                ClientSearchBox.Text = "";
        }

        private void ClientsListItemMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
                Manager.MainFrame.Navigate(new AddClient((sender as ListViewItem).DataContext as TClients));
                ClientSearchBox.Text = "";
        }

        private void DeleteClientClick(object sender, RoutedEventArgs e)
        {
            var currentUser = DiplomEntities.GetContext().TUsers.ToList();
            bool CanDeleteClient = true;
            var ClientsForRemoving = ClientsList.SelectedItems.Cast<TClients>().ToList();
            if (ClientsForRemoving.Count != 0)
            {                
                if (MessageBox.Show($"Вы точно хотите удалить выбранного клиента?", "Внимание!",
                                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                    foreach (var P in DiplomEntities.GetContext().TOrders.ToList())
                    {
                        if (ClientsForRemoving[0].ClientId == P.OrderClient)
                        {
                            CanDeleteClient = false;
                            MessageBox.Show("Этот клиент есть в заказах!", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            break;
                        }
                    }
                    foreach (var P in DiplomEntities.GetContext().TSales.ToList())
                    {
                        if (ClientsForRemoving[0].ClientId == P.SaleClient)
                        {
                            CanDeleteClient = false;
                            MessageBox.Show("Этот клиент есть в продажах!", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            break;
                        }
                    }
                    if (CanDeleteClient == true) 
                    {
                        try
                            {
                                DiplomEntities.GetContext().TClients.RemoveRange(ClientsForRemoving);
                                DiplomEntities.GetContext().SaveChanges();
                                MessageBox.Show("Клиент удален", "", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message.ToString());
                            }
                            DiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                            UpdateClients();
                        }
                    }

                    
                    
            }
            else
            {
                MessageBox.Show("Выберите клиента для удаления", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }  
            
                     
        }

        private void ClientsPageMouseEnter(object sender, MouseEventArgs e)
        {
            UpdateClients();
        }

        private void ClientsListMouseEnter(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateClients();
        }

        private void PhoneSearch(object sender, TextChangedEventArgs e)
        {
            UpdateClients();
        }

        private void TxtPhoneChanged(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
