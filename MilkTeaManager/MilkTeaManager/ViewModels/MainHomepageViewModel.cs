using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MilkTeaManager.Models;
using MilkTeaManager.Views;

namespace MilkTeaManager.ViewModels
{
    public class MainHomepageViewModel : BaseVM
    {
        public ICommand LoadKhachHangPageCommand { get; set; }
        public ICommand LoadedWindowsCommnad { get; set; }
        public MainHomepageViewModel()
        {
            
            LoadKhachHangPageCommand = new RelayCommand<object>((p) =>
            {

                return true;
            }, (p) =>
            {
                MessageBox.Show("main");
            });
            LoadedWindowsCommnad = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                p.Hide();
                LoginWindows loginWindow = new LoginWindows();
                loginWindow.ShowDialog();
                p.Show();
            });
        }
    }
}
