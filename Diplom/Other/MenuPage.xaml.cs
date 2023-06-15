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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void onOrderClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Orders.OrdersPage());
        }

        private void onSalesClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Sales.SalesPage());
        }

        private void onItemsClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Items.ItemsPage());
        }

        private void onClientsClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Clients.ClientsPage());
        }
    }
}
