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
    class AddCustomerViewModel:BaseVM
    {
        //private KHACHHANG _khachhang;
        //public KHACHHANG KhachHang
        //{
        //    get { return _khachhang; }
        //    set { _khachhang = value;
        //        OnPropertyChanged();
        //    }
        //}
        private string _tenkh;
        public string TENKH
        {
            get { return _tenkh; }
            set { _tenkh = value;
                OnPropertyChanged();
            }
        }
        public ICommand SaveCommand { get; set; }
        public AddCustomerViewModel()
        {
           

            SaveCommand = new RelayCommand<object>((p) =>
            {
                if (TENKH == null)
                    return false;

                return true;

            }, (p) =>
            {
                
            });
        }
    }
}
