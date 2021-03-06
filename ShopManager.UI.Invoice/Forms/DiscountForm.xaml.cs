﻿using System;
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
    /// Interaction logic for DeleteForm.xaml
    /// </summary>
    public partial class DiscountForm : Window
    {
        public DiscountForm(string Message)
        {
            InitializeComponent();
            DisplayRecordeToDelete.Text = Message;
            this.TxtDiscount.Focus();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void TxtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.DialogResult = true;
            }
        }
    }
}
