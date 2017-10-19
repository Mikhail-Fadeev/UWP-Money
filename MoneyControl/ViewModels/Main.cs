using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MoneyControl.Models;
using System.Collections.ObjectModel;

namespace MoneyControl.ViewModels
{
    class Main : INotifyPropertyChanged
    {
        private ObservableCollection<Items> menu { get; set; }

        public ObservableCollection<Items>  Menu
        {
            get
            {
                return menu;
            }
            set
            {
                menu = value;
                OnPropertyChange("Menu");
            }
        }
       

        public Main()
        {
            Menu = MenuItems.GetMenuItems();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChange(string param)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(param));
            }
        }
    }
}
