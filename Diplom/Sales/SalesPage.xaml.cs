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

namespace Diplom.Sales
{
    /// <summary>
    /// Логика взаимодействия для SalesPage.xaml
    /// </summary>
    public partial class SalesPage : Page
    {
        public SalesPage()
        {
            InitializeComponent();

            var allClients = DiplomEntities.GetContext().TClients.ToList();
            allClients.Insert(0, new TClients
            {
                ClientFIO = "Bсе"
            });
            ComboClientSale.ItemsSource = allClients;
            ComboClientSale.SelectedIndex = 0;
            UpdateSales();
        }

        public void UpdateSales()
        {
            var currentSales = DiplomEntities.GetContext().TSales.ToList();

            currentSales = currentSales.Where(p => p.SaleDetails.ToLower().ToString().Contains(SaleSearchBox.Text.ToLower())).ToList();

            if (ComboClientSale.SelectedIndex > 0)
                currentSales = currentSales.Where(p => p.TClients == (ComboClientSale.SelectedItem as TClients)).ToList();

            currentSales = currentSales.OrderByDescending(p => p.SaleDate).ToList();

            DiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            SalesList.ItemsSource = currentSales;
            
        }

        private void SaleSearch(object sender, TextChangedEventArgs e)
        {
            UpdateSales();
        }

        private void NewSaleClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddSalePage(null));
        }

        private void DeleteSaleClick(object sender, RoutedEventArgs e)
        {
            var SalesForRemoving = SalesList.SelectedItems.Cast<TSales>().ToList();
            if (SalesForRemoving.Count != 0)
            {
                if (MessageBox.Show($"Вы точно хотите удалить выбранную продажу?", "Внимание!",
                                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        DiplomEntities.GetContext().TSales.RemoveRange(SalesForRemoving);
                        DiplomEntities.GetContext().SaveChanges();
                        MessageBox.Show("Продажа удалена", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    DiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    UpdateSales();
                }
            }
            else
            {
                MessageBox.Show("Выберите продажу для удаления", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void ComboTypeItemSelect(object sender, SelectionChangedEventArgs e)
        {
            UpdateSales();
        }

        private void ComboClientSelect(object sender, SelectionChangedEventArgs e)
        {
            UpdateSales();
        }

        private void SalesListMouseEnter(object sender, MouseEventArgs e)
        {
            UpdateSales();
        }
        private void SalesListItemMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddSalePage((sender as ListViewItem).DataContext as TSales));
        }

        private void SalesListMouseEnter(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateSales();
        }
    }
}