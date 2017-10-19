using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MoneyControl.Pages;
using Windows.UI.Xaml.Controls;

namespace MoneyControl.Models
{
    class Items
    {
       public string Image { get; set; }
       public string Text { get; set; }
       public Page page { get; set; }
    }

    class MenuItems
    {
        public static ObservableCollection<Items> GetMenuItems()
        {
            var tmp = new ObservableCollection<Items>()
            {
                new Items { Image = "/Images/pachka.png", Text = "Операции", page = new Operations()},
                new Items { Image = "/Images/koshel.png", Text = "Доходы", page = new Income() },
                new Items { Image = "/Images/vklad.png", Text = "Накопления", page = new Acum()},
                new Items { Image = "/Images/Other.png", Text = "Статистика", page = new Stat()},
                // Долги должники, повторяющиеся операции
                // Доходы когда следующая зарплата
            };
            return tmp;
        }
    }
}
