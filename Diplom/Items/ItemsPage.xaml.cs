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

namespace Diplom.Items
{
    /// <summary>
    /// Логика взаимодействия для ItemsPage.xaml
    /// </summary>
    public partial class ItemsPage : Page
    {
        public ItemsPage()
        {
            InitializeComponent();
            var allTypes = DiplomEntities.GetContext().TItemsTypes.OrderBy(p => p.ItemTypeName).ToList();
            var allMarks = DiplomEntities.GetContext().TMark.OrderBy(p => p.MarkName).ToList();
            allTypes.Insert(0, new TItemsTypes
            {
                ItemTypeName = "Bсе"
            });
            allMarks.Insert(0, new TMark
            {
                MarkName = "Bсе"
            });
            ComboType.ItemsSource = allTypes;
            ComboType.SelectedIndex = 0;
            ComboMark.ItemsSource = allMarks;
            ComboMark.SelectedIndex = 0;
            UpdateItems();        
        }

        public void UpdateItems()
        {
            DiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            if (Manager.CRU != 1) 
            {
                NewMark.Visibility = Visibility.Hidden;
                NewMark.IsEnabled = false;
                NewTypeItem.Visibility = Visibility.Hidden;
                NewTypeItem.IsEnabled = false;
                DeleteItem.Visibility = Visibility.Hidden;
                DeleteItem.IsEnabled = false;
                NewItem.Visibility = Visibility.Hidden;
                NewItem.IsEnabled = false;
            }
            else
            {
                NewMark.Visibility = Visibility.Visible;
                NewMark.IsEnabled = true;
                NewTypeItem.Visibility = Visibility.Visible;
                NewTypeItem.IsEnabled = true;
                DeleteItem.Visibility = Visibility.Visible;
                DeleteItem.IsEnabled = true;
                NewItem.Visibility = Visibility.Visible;
                NewItem.IsEnabled = true;
            }

            ComboType.ItemsSource = DiplomEntities.GetContext().TItemsTypes.OrderBy(p => p.ItemTypeName).ToList();
            ComboMark.ItemsSource = DiplomEntities.GetContext().TMark.OrderBy(p => p.MarkName).ToList();

            DiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var currentItems = DiplomEntities.GetContext().TItems.ToList();

            if (DownCost.IsChecked == true)
            {
                currentItems = currentItems.OrderByDescending(p => p.ItemCost).ToList();
            }
            else if (UpCost.IsChecked == true)
            {
                currentItems = currentItems.OrderBy(p => p.ItemCost).ToList();
            }
                currentItems = currentItems.Where(p => p.ItemName.ToLower().ToString().Contains(ItemSearchBox.Text.ToLower())).ToList();

            if (ComboType.SelectedIndex > 0)
                currentItems = currentItems.Where(p => p.TItemsTypes == (ComboType.SelectedItem as TItemsTypes)).ToList();
            if (ComboMark.SelectedIndex > 0)
                currentItems = currentItems.Where(p => p.TMark == (ComboMark.SelectedItem as TMark)).ToList();

            ItemsList.ItemsSource = currentItems;
        }

        private void DownCostCheck(object sender, RoutedEventArgs e)
        {
            if (UpCost.IsChecked == true) 
            {
                UpCost.IsChecked = false;
            }
            UpdateItems();
        }

        private void UpCostCheck(object sender, RoutedEventArgs e)
        {
            if (DownCost.IsChecked == true)
            {
                DownCost.IsChecked = false;
            }
            UpdateItems();
        }

        private void NewItemClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddItem(null));
        }

        private void ItemSearch(object sender, TextChangedEventArgs e)
        {
            UpdateItems();
        }

        private void DeleteItemClick(object sender, RoutedEventArgs e)
        {
            var ItemsForRemoving = ItemsList.SelectedItems.Cast<TItems>().ToList();
            if (ItemsForRemoving.Count != 0)
            {
                if (MessageBox.Show($"Вы точно хотите удалить выбранный товар?", "Внимание!",
                                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        DiplomEntities.GetContext().TItems.RemoveRange(ItemsForRemoving);
                        DiplomEntities.GetContext().SaveChanges();
                        MessageBox.Show("Товар удален", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    DiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    UpdateItems();
                }
            }
            else
            {
                MessageBox.Show("Выберите товар для удаления", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void ItemsListMouseEnter(object sender, MouseEventArgs e)
        {
            UpdateItems();
        }

        private void ItemsListItemMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddItem((sender as ListViewItem).DataContext as TItems));
        }

        private void ComboTypeSelect(object sender, SelectionChangedEventArgs e)
        {
            UpdateItems();
        }

        private void ComboMarkSelect(object sender, SelectionChangedEventArgs e)
        {
            UpdateItems();
        }

        private void ItemsListMouseEnter(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateItems();
        }

        private void NewMarkClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddMark(null));
        }

        private void NewTypeItemClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddTypeItem(null));
        }
    }
}
