using MilkTeaManager.Models;
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
using System.Text.RegularExpressions;

namespace MilkTeaManager.Views.Dialog
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        Boolean flag;
        public AddProduct()
        {
            InitializeComponent();
            this.DataContext = new AddProductViewModel();
            flag = false;
        }
        private void save_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void exit_click(object sender, RoutedEventArgs e)
        {
            flag = true;
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
          
         if(flag)
            {
                int index = DataAccess.db.SANPHAMs.Count() - 1;
                SANPHAM a = DataAccess.db.SANPHAMs.ToList().ElementAt(index);
                DataAccess.DeleteSanPhamByKey(a.MASP);
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
