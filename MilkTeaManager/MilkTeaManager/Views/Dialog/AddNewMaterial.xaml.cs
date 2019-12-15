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

namespace MilkTeaManager.Views.Dialog
{
    /// <summary>
    /// Interaction logic for AddNewMaterial.xaml
    /// </summary>
    public partial class AddNewMaterial : Window
    {
        public AddNewMaterial()
        {
            InitializeComponent();
        }


        private void add_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
