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
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Diplom.Sales
{
    /// <summary>
    /// Логика взаимодействия для AddSalePage.xaml
    /// </summary>
    public partial class AddSalePage : Page
    {
        private Manager MainViewModel { get; } = new Manager();
        private ObservableCollection<Manager> colect { get; } = new ObservableCollection<Manager>();
        private TItems iti = new TItems();
        private TSales cl = new TSales();
        private SalesItems cac = new SalesItems();
        private List<TSales> SlsList = new List<TSales>();
        private List<TItems> ItmList = new List<TItems>();
        public AddSalePage(TSales selectedSale)
        {
            InitializeComponent();
            
            if (selectedSale != null)
            {
                cl = selectedSale;
            }
            DataContext = cl;

            
            if (cl.SaleId == 0) 
            {
                ComboClientSale.IsEnabled=true;
                ItemsDataGrid.Visibility = Visibility.Visible;
                ItemsListBox.Visibility = Visibility.Hidden;
                ItemsDataGrid.DataContext = MainViewModel;  
                TxtBlockItem.Text = "Выберите товары*";
                Itm.ItemsSource = DiplomEntities.GetContext().TItems.ToList();
            }
            else
            {
                int a = selectedSale.SaleId;
                ItemsListBox.Items.Clear();
                TxtBlockItem.Text = "Товары ";
                var grqz = DiplomEntities.GetContext().SalesItems.Where(p => p.SaleId == a).ToList();
                foreach (var item in grqz)
                {                    
                    ItemsListBox.Visibility = Visibility.Visible;
                    ItemsDataGrid.Visibility = Visibility.Hidden;
                    ItemsListBox.Items.Add(item);
                    DiplomEntities.GetContext().SaveChanges();
                    DiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                }
            }
            MainViewModel.listItemsViewModel.CollectionChanged += new NotifyCollectionChangedEventHandler(CollectChng);
            ComboClientSale.ItemsSource=DiplomEntities.GetContext().TClients.ToList();
        }
        private void CollectChng(object sender, NotifyCollectionChangedEventArgs e)
        {
            cl.SaleCost = 0;
            foreach (var item in MainViewModel.listItemsViewModel)
            {
                cl.SaleCost += item.selectedItem.ItemCost;
            }
            TxtCost.Text = cl.SaleCost.ToString();
        }
        private void TxtCountChanged(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TxtCostChanged(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BtnSaveSaleClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (ComboClientSale.SelectedIndex < 0)
                errors.AppendLine("Укажите клиента");
            if (cl.SaleCost == 0)
                errors.AppendLine("Стоимость товаров не может быть равна 0");
            if (ComboClientSale.SelectedIndex < 0)
                cl.SaleClient = 1;
            if (string.IsNullOrWhiteSpace(cl.SaleDetails))
                cl.SaleDetails=" ";

           var newLsit = MainViewModel.listItemsViewModel;
            foreach (var sI in DiplomEntities.GetContext().TItems.ToList())
            {
                int countItems = 0;
                foreach (var vm in newLsit)
                {
                    if (vm.selectedItem == sI)
                    {
                        
                        countItems++;
                    }
                }
                if (countItems > 1)
                {
                    errors.AppendLine("Удалите дубликаты товаров");
                    break;
                }
                countItems = 0;
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (cl.SaleId == 0)
            {
                cl.SaleDate = DateTime.Today;
                DiplomEntities.GetContext().TSales.Add(cl);
            }
            try
            {
                cl.SaleUser = Manager.CU;
                foreach (var s in newLsit)
                {
                    if (s == null)
                        continue;
                        DiplomEntities.GetContext().SalesItems.Add(cac);
                    cac.SaleId = cl.SaleId;
                    cac.ItemId= s.selectedItem.ItemId;
                    cac.Info = s.selectedItem.ItemInf;
                    DiplomEntities.GetContext().SaveChanges();
                    DiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                }
                if (string.IsNullOrWhiteSpace(cl.SaleDetails))
                {
                    TxtDetails.Text = "Нет подробностей";
                    cl.SaleDetails = "Нет подробностей";
                }                               
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

        private void ItemsDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            ComboBox comboBox = e.EditingElement as ComboBox;

            if (comboBox != null && e.EditingElement != e.Row.Item)
            {
                var selectedValue = comboBox.SelectedItem as TItems;
                if (selectedValue.ItemCount>0)
                {                    
                    cl.SaleCost -= (e.Row.Item as Manager.ItemsViewModel).selectedItem.ItemCost;
                    cl.SaleCost += selectedValue.ItemCost;
                    selectedValue.ItemCount = selectedValue.ItemCount - 1;
                    TxtCost.Text = cl.SaleCost.ToString();
                }
                else
                {
                    comboBox.SelectedItem = null;
                    MessageBox.Show("Отсутствующий товар " + selectedValue.TMark.MarkName +" "+ selectedValue.ItemName + " был автоматически удален из списка", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    e.Cancel = true;
                }
            }
            
        }
    }
}
