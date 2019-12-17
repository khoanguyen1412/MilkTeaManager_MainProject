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
    /// Interaction logic for AddSupplier.xaml
    /// </summary>
    public partial class AddSupplier : Window
    {
        public AddSupplier()
        {
            this.DataContext = new AddSupplierViewModel();
            InitializeComponent();
        }
        private void save_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
