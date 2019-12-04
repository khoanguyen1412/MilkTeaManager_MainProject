using MilkTeaManager.Views.Dialog;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MilkTeaManager.Views.Pages
{
    /// <summary>
    /// Interaction logic for ManageProduct.xaml
    /// </summary>
    public partial class ManageProduct : Page
    {
        public ManageProduct()
        {
            InitializeComponent();
        }
        private void addProduct_click(object sender, RoutedEventArgs e)
        {
            AddProduct x = new AddProduct();
            x.ShowDialog();
        }
        //editProduct_click
        private void editProduct_click(object sender, RoutedEventArgs e)
        {
            EditProduct x = new EditProduct();
            x.ShowDialog();
        }
    }
}
