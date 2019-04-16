using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ShopManager.UI.Customers
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainWindowViewModel _viewModel;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            _viewModel = new MainWindowViewModel();
           var mainWindows = new MainWindow(_viewModel);
            mainWindows.Show();
        }
    }
}
