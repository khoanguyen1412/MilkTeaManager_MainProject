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
    /// Interaction logic for ManageMaterial.xaml
    /// </summary>
    public partial class ManageMaterial : Page
    {
        public ManageMaterial()
        {
            InitializeComponent();
        }

        private void addMaterial_click(object sender, RoutedEventArgs e)
        {
            AddNewMaterial x = new AddNewMaterial();
            x.ShowDialog();
        }

        private void editMaterial_click(object sender, RoutedEventArgs e)
        {
            EditMaterial x = new EditMaterial();
            x.ShowDialog();
        }
    }
}
