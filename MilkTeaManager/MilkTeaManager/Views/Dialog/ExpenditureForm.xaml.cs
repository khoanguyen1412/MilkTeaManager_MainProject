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
    /// Interaction logic for ExpenditureForm.xaml
    /// </summary>
    public partial class ExpenditureForm : Window
    {
        public ExpenditureForm()
        {
            InitializeComponent();
            this.DataContext = new ExpenditureFormViewModel();
        }
    }
}
