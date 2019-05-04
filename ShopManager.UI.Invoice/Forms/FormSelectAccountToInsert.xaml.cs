using ShopManager.UI.Invoice.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace ShopManager.UI.Invoice.Forms
{
    /// <summary>
    /// Interaction logic for FormSelectAccountToInsert.xaml
    /// </summary>
    public partial class FormSelectAccountToInsert : Window
    {
        private readonly List<SelectAccountToInsert> accinvoice;
        private ObservableCollection<SelectAccountToInsert> SelecteSearch;
        private SelectAccountToInsert _SelectItem;
        public FormSelectAccountToInsert(List<SelectAccountToInsert> accinvoice)
        {
            InitializeComponent();
            this.accinvoice = accinvoice;
            SelecteSearch = new ObservableCollection< SelectAccountToInsert>(accinvoice);
            DataGridSelectedAccount.ItemsSource = SelecteSearch;
        }

        public FormSelectAccountToInsert(List<SelectAccountToInsert> accinvoice, string title)
        {
            InitializeComponent();
            this.accinvoice = accinvoice;
            this.Title = title;
            SelecteSearch = new ObservableCollection<SelectAccountToInsert>(accinvoice);
            DataGridSelectedAccount.ItemsSource = SelecteSearch;
        }

        private void SearchText_TextChanged(object sender, TextChangedEventArgs e)
        {
            var result = accinvoice.Where(a => a.Account.ToLower().Contains(SearchText.Text.ToLower()) || a.Company.ToLower().Contains(SearchText.Text.ToLower()));
            SelecteSearch = new ObservableCollection<SelectAccountToInsert>(result);
            if (SelecteSearch.Count > 0)
            {
                SelectItem = SelecteSearch[0];
            }
            
            DataGridSelectedAccount.ItemsSource = SelecteSearch;
        }

        private void ClearSearchCommand_Click(object sender, RoutedEventArgs e)
        {
            SearchText.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        

        public SelectAccountToInsert SelectItem
        {
            get { return _SelectItem; }
            set { _SelectItem = value; }
        }

        private void DataGridSelectedAccount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectItem = (SelectAccountToInsert)DataGridSelectedAccount.SelectedItem;
        }
}
}
