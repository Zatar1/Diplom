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

namespace Diplom.Items
{
    /// <summary>
    /// Логика взаимодействия для AddItem.xaml
    /// </summary>
    public partial class AddItem : Page
    {
        private TItems cl = new TItems();
        public AddItem(TItems selectedItem)
        {
            InitializeComponent();
            if(selectedItem != null)
            {
                cl = selectedItem;
            }
            if (Manager.CRU!=1) 
            {
                NewMark.Visibility = Visibility.Hidden;
                NewMark.IsEnabled = false;
                NewTypeItem.Visibility = Visibility.Hidden;
                NewTypeItem.IsEnabled = false;
                ComboTypeItem.IsEnabled = false;
                ComboMarkItem.IsEnabled = false;
                TxtItemName.IsEnabled = false;
                TxtCost.IsEnabled = false;

            }
            DataContext = cl;

            ComboMarkItem.ItemsSource = DiplomEntities.GetContext().TMark.OrderBy(p => p.MarkName).ToList();
            ComboTypeItem.ItemsSource = DiplomEntities.GetContext().TItemsTypes.OrderBy(p => p.ItemTypeName).ToList();
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

        private void BtnSaveItemClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (ComboTypeItem.SelectedIndex < 0)
                errors.AppendLine("Укажите тип товара");
            if (ComboMarkItem.SelectedIndex < 0)
                errors.AppendLine("Укажите производителя");
            if (string.IsNullOrWhiteSpace(cl.ItemName))
                errors.AppendLine("Укажите модель товара");
            if (string.IsNullOrWhiteSpace(cl.ItemDetails))
                errors.AppendLine("Укажите описание товара");
            if (cl.ItemCost == 0)
                errors.AppendLine("Цена не может быть равна 0");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (cl.ItemId == 0)
            {
                DiplomEntities.GetContext().TItems.Add(cl);
            }

            try
            {
                cl.ItemInf = cl.TItemsTypes.ItemTypeName + " " + cl.TMark.MarkName + " " + cl.ItemName;
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

        private void NewTypeItemClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddTypeItem(null));
        }

        private void NewMarkClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddMark(null));
        }

        private void VisibleChg(object sender, DependencyPropertyChangedEventArgs e)
        {
            ComboMarkItem.ItemsSource = DiplomEntities.GetContext().TMark.OrderBy(p => p.MarkName).ToList();
            ComboTypeItem.ItemsSource = DiplomEntities.GetContext().TItemsTypes.OrderBy(p => p.ItemTypeName).ToList();
        }
    }
}
