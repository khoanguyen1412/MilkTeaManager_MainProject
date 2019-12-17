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
using MilkTeaManager.ViewModels.Dialog;


namespace MilkTeaManager.Views.Dialog
{
    /// <summary>
    /// Interaction logic for EditProduct.xaml
    /// </summary>
    public partial class EditProduct : Window
    {
        public EditProduct()
        {
            this.DataContext = new EditProductViewModel();
            InitializeComponent();
        }

        private void update_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
