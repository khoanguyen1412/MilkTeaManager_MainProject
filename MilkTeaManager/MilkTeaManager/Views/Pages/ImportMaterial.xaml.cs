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
    /// Interaction logic for ImportMaterial.xaml
    /// </summary>
    public partial class ImportMaterial : Page
    {
        public ImportMaterial()
        {
            InitializeComponent();
        }

        private void addMaterial_click(object sender, RoutedEventArgs e)
        {
            AddMaterial x = new AddMaterial();
            x.ShowDialog();
        }

        private void editImportBill_click(object sender, RoutedEventArgs e)
        {
            EditImportBill x = new EditImportBill();
            x.ShowDialog();
        }

        private void addSupplier_click(object sender, RoutedEventArgs e)
        {
            AddSupplier x = new AddSupplier();
            x.ShowDialog();
        }

    }
}
