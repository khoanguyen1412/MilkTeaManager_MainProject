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
using MilkTeaManager.Views.Dialog;
namespace MilkTeaManager.Views.Pages
{
    /// <summary>
    /// Interaction logic for SellProduct.xaml
    /// </summary>
    public partial class SellProduct : Page
    {
        public SellProduct()
        {
            InitializeComponent();
        }
        //addCustomer_click
        private void addCustomer_click(object sender, RoutedEventArgs e)
        {
            AddCustomer x = new AddCustomer();
            x.ShowDialog();
        }
        

        private void ThanhToan_click(object sender, RoutedEventArgs e)
        {
            OrderForm x = new OrderForm();
            x.ShowDialog();
        }
    }
}
