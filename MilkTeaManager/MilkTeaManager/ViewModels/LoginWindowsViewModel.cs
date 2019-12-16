using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MilkTeaManager.Views;

namespace MilkTeaManager.ViewModels
{
    public class Account
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Key { get; set; }

        public Account(string a, string b, string c)

        {
            UserName = a;
            PassWord = b;
            Key = c;
        }

    }

    class LoginWindowsViewModel : BaseVM
    {
        private string _name;
        private string _pass;
        private string _key;
        public ObservableCollection<Account> LAccount { get; set; }
        //        private bool isLoggedIn = false;
        //        private bool isJustStarted = true;
        //#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        //        public event PropertyChangedEventHandler PropertyChanged;
        //#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

        //        public bool IsLoggedIn
        //        {
        //            get => isLoggedIn;
        //            set
        //            {
        //                isLoggedIn = value;
        //                NotifyPropertyChanged();
        //            }

        //        }

        //        public bool IsJustStarted
        //        {
        //            get => isJustStarted; set
        //            {
        //                isJustStarted = value;
        //                NotifyPropertyChanged();
        //            }
        //        }

        //        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        //        {
        //            if (PropertyChanged != null)
        //            {
        //                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //            }
        //        }

        //        private async Task<bool> validateCreds()
        //        {
        //            await Task.Delay(2000);
        //            Random gen = new Random();
        //            int loginProb = gen.Next(100);
        //            //TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
        //            //tcs.SetResult(loginProb <=40);
        //            return loginProb <= 30;
        //        }

        //        private async void openCB(object sender, MaterialDesignThemes.Wpf.DialogOpenedEventArgs eventArgs)
        //        {
        //            try
        //            {
        //                bool isLoggedIn = await validateCreds();
        //                if (isLoggedIn)
        //                {
        //                    //Close dialog and show login
        //                    eventArgs.Session.Close(true);
        //                }
        //                else
        //                {
        //                    //Invalid Login
        //                    eventArgs.Session.Close(false);
        //                }
        //            }
        //            catch (Exception)
        //            {

        //            }
        //        }

        //        private void closingCB(object sender, MaterialDesignThemes.Wpf.DialogClosingEventArgs eventArgs)
        //        {
        //            if (eventArgs.Parameter != null)
        //            {

        //                //if (((bool)eventArgs.Parameter) == true)
        //                //{
        //                //    IsJustStarted = false;   
        //                //    IsLoggedIn =true;
        //                //}
        //                //else if (((bool)eventArgs.Parameter) == false)
        //                //{
        //                //    IsJustStarted = false;
        //                //    IsLoggedIn = false;
        //                //}
        //                IsJustStarted = false;
        //                IsLoggedIn = !IsLoggedIn;
        //            }
        //        }

        public bool IsLogin { get; set; }
        public ICommand LoginCommad { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public string Name
        {
            get => _name; set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string Pass
        {
            get => _pass; set
            {
                _pass = value;
                OnPropertyChanged();
            }
        }

        public string Key
        {
            get => _key; set
            {
                _key = value;
                OnPropertyChanged();
            }
        }

        public LoginWindowsViewModel()
        {
            //var a = new Account("nhanvien", "nhanvien", "1");
            //try
            //{
            //    LAccount.Add(new Account("admin", "admin", "0"));
            //}
            //catch (Exception)
            //{
            //    //throw
            //}
            LAccount = new ObservableCollection<Account>()
            {
                new Account("admin", "admin", "0"),
                new Account("nhanvien", "nhanvien", "1"),
                new Account("quanli", "quanli", "2"),
            };
            IsLogin = false;
            LoginCommad = new RelayCommand<Window>((p) => { return true; },
                (p) =>
                {
                    Login(p);
                }
                );
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; },
               (p) =>
               {
                   Pass = p.Password;
               }
               );


            //a = new Account("nhanvien", "nhanvien", "1");
            //lAccount.Add(a);
            //a = new Account("quanli", "quanli", "2");
        }
        public void Login(Window p)
        {
            if (p == null)
                return;


            foreach (Account ac in LAccount)
            {
                {
                    if (Name == ac.UserName && Pass == ac.PassWord)
                    {
                        Key = ac.Key;
                        IsLogin = true;
                        p.Close();
                    }
                }
            }


        }

    }
}
