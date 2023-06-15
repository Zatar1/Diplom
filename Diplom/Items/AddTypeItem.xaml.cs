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
    /// Логика взаимодействия для AddTypeItem.xaml
    /// </summary>
    public partial class AddTypeItem : Page
    {
        private TItemsTypes cl = new TItemsTypes();
        public AddTypeItem(TItemsTypes selectedItem)
        {
            InitializeComponent();

            if (selectedItem != null)
            {
                cl = selectedItem;
            }
            DataContext = cl;
        }
        private void BtnSaveItemTypeClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(cl.ItemTypeName))
                errors.AppendLine("Укажите наименование типа товара");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (cl.ItemTypeId == 0)
            {
                DiplomEntities.GetContext().TItemsTypes.Add(cl);
            }

            try
            {
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
    }
}
