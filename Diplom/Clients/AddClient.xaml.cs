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

namespace Diplom.Clients
{
    /// <summary>
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Page
    {
        private TClients cl = new TClients();

        public AddClient(TClients selectedClient)
        {
            InitializeComponent();
            if (selectedClient != null)
            {
                cl = selectedClient;
            }
            DataContext = cl;
        }


        private void BtnSaveClientClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(cl.ClientSurname))
                errors.AppendLine("Укажите фамилию клиента");
            if (string.IsNullOrWhiteSpace(cl.ClientName))
                errors.AppendLine("Укажите имя клиента");

            try
            {
                string PhoneFirstNumber = Convert.ToString(TxtPhone.Text[0]);
                if (Convert.ToInt32(PhoneFirstNumber) != 8)
                    errors.AppendLine("Введите телефон клиента c цифры 8" + PhoneFirstNumber);
                if (TxtPhone.Text.Length != 11)
                    errors.AppendLine("Введите телефон клиента корректно (81234567890)");
            }
            catch
            {
                errors.AppendLine("Укажите телефон клиента");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (cl.ClientId == 0)
            {
               DiplomEntities.GetContext().TClients.Add(cl);
            }
            
            try
            {
                cl.ClientFIO = cl.ClientSurname+" "+cl.ClientName+" "+cl.ClientPatronymic;
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

        private void TxtPhoneChanged(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
