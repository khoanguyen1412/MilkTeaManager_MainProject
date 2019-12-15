using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MilkTeaManager.Models;
namespace MilkTeaManager.ViewModels
{
    public class MainHomepageViewModel : BaseVM
    {
        public ICommand LoadKhachHangPageCommand { get; set; }
        public MainHomepageViewModel()
        {
            
            LoadKhachHangPageCommand = new RelayCommand<object>((p) =>
            {

                return true;
            }, (p) =>
            {
                MessageBox.Show("main");
            });

        }
    }
}
