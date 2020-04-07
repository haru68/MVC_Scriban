using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ModelViewController_Scriban.Model;

namespace ModelViewController_Scriban
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ProductPopulator populator = new ProductPopulator();
            populator.Populate(5);
            ModelViewController_Scriban.View.ProductWindow productWindow = new View.ProductWindow();
            productWindow.Show();
        }
    }
}
