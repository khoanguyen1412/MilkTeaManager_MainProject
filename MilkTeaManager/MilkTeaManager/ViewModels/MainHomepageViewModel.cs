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

        private string _hKey;
        public ICommand LoadKhachHangPageCommand { get; set; }
        public ICommand LoadedWindowsCommnad { get; set; }
        public string HKey { get => _hKey; set => _hKey = value; }

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
                if (p == null)
                    return;
                p.Hide();
                LoginWindows loginWindow = new LoginWindows();
                loginWindow.ShowDialog();

                if (loginWindow.DataContext == null)
                    return;
                var loginVM = loginWindow.DataContext as LoginWindowsViewModel;

                if (loginVM.IsLogin)
                {
                    HKey = loginVM.Key;
                    p.Show();
                }
                else
                {
                    p.Close();
                }

            });
        }
    }
}
