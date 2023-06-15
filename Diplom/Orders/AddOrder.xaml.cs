using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Page
    {

        private TOrders cl = new TOrders();
        public AddOrder(TOrders selectedOrder)
        {            
            InitializeComponent();
            if (selectedOrder != null)
            {
                 cl = selectedOrder;
            }
           
            DataContext = cl;

            ComboClientOrder.ItemsSource = DiplomEntities.GetContext().TClients.ToList();
            ComboTypeOrder.ItemsSource = DiplomEntities.GetContext().TOrdersTypes.ToList();
        }

        private void BtnSaveOrderClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            
            if (ComboTypeOrder.SelectedIndex <0)
                errors.AppendLine("Укажите тип заказа");
            if (ComboClientOrder.SelectedIndex < 0)
                errors.AppendLine("Укажите клиента");
            if (string.IsNullOrWhiteSpace(cl.OrderDetails))
                errors.AppendLine("Укажите подробности заказа");
            if (cl.OrderCost == 0)
                errors.AppendLine("Цена не может быть равна 0");
            if (ComboClientOrder.SelectedIndex < 0)
                cl.OrderClient = 1;
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (cl.OrderId == 0)
            {
                DiplomEntities.GetContext().TOrders.Add(cl);
            }

            try
            {
                cl.OrderUser = Manager.CU;
                cl.OrderDate = DateTime.Today;
                DiplomEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена", "", MessageBoxButton.OK, MessageBoxImage.Information);
                DiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                Manager.MainFrame.GoBack();
            }
            catch
            {
                MessageBox.Show("Не сохранено", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TxtCostChanged(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
