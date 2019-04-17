using ShopManager.UI.Invoice.ViewModel;
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
using System.Windows.Shapes;

namespace ShopManager.UI.Invoice.Forms
{
    /// <summary>
    /// Interaction logic for FormChangeOrderQty.xaml
    /// </summary>
    public partial class FormChangeOrderQty : Window
    {
        private readonly ChangeOrderQuantity _editOrderItem;

        public FormChangeOrderQty(ChangeOrderQuantity editOrderItem)
        {
            InitializeComponent();
            _editOrderItem = editOrderItem;
            DataContext = _editOrderItem;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
