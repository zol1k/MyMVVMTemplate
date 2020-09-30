using System.Collections.ObjectModel;
using MyMvvmTemplate.Helpers;
using MyMvvmTemplate.Model;

namespace MyMvvmTemplate.ViewModel
{
    public class SecondViewModel : ObservableObject, IViewModel
    {
        private Item _selectedItem;
        public RelayCommand ButtonFunction { get; private set; }
        public ObservableCollection<Item> Items { get; private set; }

        public Item SelectedItem
        {
            get => _selectedItem;

            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public SecondViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item(1,"item1"));
            Items.Add(new Item(2,"item2"));
            Items.Add(new Item(3,"item3"));
            //ButtonFunction = new RelayCommand(DeleteItem);
        }

        private void DeleteItem(object obj)
        {
            Items.Remove(SelectedItem);
        }
    }
}
