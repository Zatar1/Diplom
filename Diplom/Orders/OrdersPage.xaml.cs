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

namespace Diplom.Orders
{
    /// <summary>
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        private TOrders cl = new TOrders();
        public OrdersPage()
        {
            InitializeComponent();

            var allTypes = DiplomEntities.GetContext().TOrdersTypes.ToList();
            allTypes.Insert(0, new TOrdersTypes
            {
                OrderTypeName = "Bсе"
            });
            ComboTypeOrder.ItemsSource = allTypes;
            ComboTypeOrder.SelectedIndex = 0;

            var allClients = DiplomEntities.GetContext().TClients.ToList();
            allClients.Insert(0, new TClients
            {
                ClientFIO = "Bсе"
            });
            ComboClientOrder.ItemsSource = allClients;
            ComboClientOrder.SelectedIndex = 0;
            UpdateOrders();
        }

        public void UpdateOrders()
        {
            DiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var currentOrders = DiplomEntities.GetContext().TOrders.ToList();

            if (Complete.IsChecked == true)
            {
                currentOrders = currentOrders.Where(p => p.OrderComplete == true).ToList();
            }
            else if (UnComplete.IsChecked == true)
            {
                currentOrders = currentOrders.Where(p => p.OrderComplete == false).ToList();
            }
            currentOrders = currentOrders.Where(p => p.OrderDetails.ToLower().ToString().Contains(OrderSearchBox.Text.ToLower())).ToList();

            if (ComboTypeOrder.SelectedIndex > 0)
                currentOrders = currentOrders.Where(p => p.TOrdersTypes == (ComboTypeOrder.SelectedItem as TOrdersTypes)).ToList();

            if (ComboClientOrder.SelectedIndex > 0)
                currentOrders = currentOrders.Where(p => p.TClients == (ComboClientOrder.SelectedItem as TClients)).ToList();

            currentOrders = currentOrders.OrderByDescending(p => p.OrderDate).ToList();
            OrdersList.ItemsSource = currentOrders;
        }

        private void NewOrderClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddOrder(null));
        }

        private void DeleteOrderClick(object sender, RoutedEventArgs e)
        {
            var OrdersForRemoving = OrdersList.SelectedItems.Cast<TOrders>().ToList();
            if (OrdersForRemoving.Count != 0)
            {
                if (MessageBox.Show($"Вы точно хотите удалить выбранный заказ?", "Внимание!",
                                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        DiplomEntities.GetContext().TOrders.RemoveRange(OrdersForRemoving);
                        DiplomEntities.GetContext().SaveChanges();
                        MessageBox.Show("Заказ удален", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    DiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    UpdateOrders();
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ для удаления", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void OrderSearch(object sender, TextChangedEventArgs e)
        {
            UpdateOrders();
        }

        private void OrdersListItemMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddOrder((sender as ListViewItem).DataContext as TOrders));
        }

        private void ComboTypeOrderSelect(object sender, SelectionChangedEventArgs e)
        {
            UpdateOrders();
        }

        private void CompleteCheck(object sender, RoutedEventArgs e)
        {
            UnComplete.IsChecked = false;
            UpdateOrders();
        }

        private void UnCompleteCheck(object sender, RoutedEventArgs e)
        {
            Complete.IsChecked = false;
            UpdateOrders();
        }

        private void OrdersListMouseEnter(object sender, MouseEventArgs e)
        {
            UpdateOrders();
        }

        private void ComboClientSelect(object sender, SelectionChangedEventArgs e)
        {
            UpdateOrders();
        }

        private void OrdersListMouseEnter(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateOrders();
        }
    }
}
