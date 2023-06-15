using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Collections.ObjectModel;

namespace Diplom
{
    class Manager
    {
        public static Frame MainFrame { get; set; }
        public ObservableCollection<ItemsViewModel> listItemsViewModel { get; set; } = new ObservableCollection<ItemsViewModel>();
        public ItemsViewModel SelectedElement { get; set; }
        public static int CRU { get; set; }
        public static int CU { get; set; }

        public class ItemsViewModel
        { 
            public List<TItems> ManyItem { get; set; } = DiplomEntities.GetContext().TItems.ToList();
            
            public TItems selectedItem { get; set; } = DiplomEntities.GetContext().TItems.ToList().First();
        }
    }
}
