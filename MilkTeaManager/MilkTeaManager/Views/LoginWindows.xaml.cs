using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace MilkTeaManager.Views
{
    /// <summary>
    /// Interaction logic for LoginWindows.xaml
    /// </summary>
    public partial class LoginWindows : Window,INotifyPropertyChanged
    {
        private bool isLoggedIn = false;
        private bool isJustStarted = true;
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsLoggedIn {
            get => isLoggedIn;
            set
            {
                isLoggedIn = value;
                NotifyPropertyChanged();
            }

            }

        public bool IsJustStarted
        {
            get => isJustStarted; set
            {
                isJustStarted = value;
                NotifyPropertyChanged();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public LoginWindows()
        {
            InitializeComponent(); 
        }

        private void dragme(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private async Task<bool> validateCreds() {
            await Task.Delay(2000);
            Random gen = new Random();
            int loginProb = gen.Next(100);
            //TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            //tcs.SetResult(loginProb <=40);
            return loginProb <= 30;
        }

        private async void openCB(object sender, MaterialDesignThemes.Wpf.DialogOpenedEventArgs eventArgs)
        {
            try
            {
                bool isLoggedIn = await validateCreds();
                if(isLoggedIn)
                {
                    //Close dialog and show login
                    eventArgs.Session.Close(true);
                }
                else
                {
                    //Invalid Login
                    eventArgs.Session.Close(false);
                }
            }
            catch(Exception)
            {

            }
        }

        private void closingCB(object sender, MaterialDesignThemes.Wpf.DialogClosingEventArgs eventArgs)
        {
            if (eventArgs.Parameter != null)
            {

                //if (((bool)eventArgs.Parameter) == true)
                //{
                //    IsJustStarted = false;   
                //    IsLoggedIn =true;
                //}
                //else if (((bool)eventArgs.Parameter) == false)
                //{
                //    IsJustStarted = false;
                //    IsLoggedIn = false;
                //}
                IsJustStarted = false;
                IsLoggedIn = !IsLoggedIn;
            }
        }
    }
}
