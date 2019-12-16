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

        private readonly ICommand disableButton;

        public ICommand LoadKhachHangPageCommand { get; set; }
        private bool _disableBH;
        private bool _disableQL;
        private bool _disableTK;
        public ICommand LoadedWindowsCommnad { get; set; }
        public string HKey { get => _hKey;
            set {
                _hKey = value;
                if (HKey == "1")
                    DisableBH = true;
                if (HKey == "0")
                {
                    DisableBH = true;
                    DisableQL = true;
                    DisableTK = true;
                }
                if (HKey == "2")
                {
                    DisableQL = true;
                    DisableTK = true;
                }
            }
        }
        public ICommand DisableButton
        {
            get { return this.disableButton; }
        }

        public bool DisableBH
        {
            get => _disableBH;
            set
            {
                _disableBH = value;
                OnPropertyChanged();
            }
        }

        public bool DisableQL { get => _disableQL;
            set {
                _disableQL = value;
                OnPropertyChanged();
            }
        }
        public bool DisableTK { get => _disableTK;
            set {
                _disableTK = value;
                OnPropertyChanged();
            }
        }
        public MainHomepageViewModel()
        {
           
            this.disableButton = new DelegateCommand(this.DoSomething, this.CanDoSomething);



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
        private void DoSomething(object state)
        {
            // do something here
        }

        private bool CanDoSomething(object state)
        {
            // return true/false here is enabled/disable button
            return true;
        }
    }
}
