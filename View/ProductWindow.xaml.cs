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
using Scriban;
using Scriban.Parsing;
using Scriban.Functions;
using Scriban.Runtime.Accessors;
using Scriban.Syntax;
using ModelViewController_Scriban.Model;
using ModelViewController_Scriban.Controller;
using System.IO;

namespace ModelViewController_Scriban.View
{
    /// <summary>
    /// Logique d'interaction pour ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
            ProductController pc = new ProductController();
            ProductList = pc.GetAllProducts();
            ProductTextBlock.Text = DisplayHTML();
        }
        public List<Product> ProductList { get; set; }

        public string DisplayHTML()
        {
            string text = File.ReadAllText(@"./../../View/ScribanHtml.html");

            var template = Scriban.Template.Parse(text);
            var result = template.Render(new { products = ProductList });

            /*var template = Scriban.Template.Parse("Hello {{name}}!");
            var result = template.Render(new { Name = "World" });*/
            return result;
        }

    }
}
