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
        private KHACHHANG _khachhang;

        public KHACHHANG KhachHang
        {
            get { return _khachhang; }
            set
            {
                _khachhang = value;
                OnPropertyChanged();
            }
        }
        private string _stenkh;
        private string _sdiachi;
        private string _ssdt;
        private string _semail;
        
        public string SEmail
        {
            get { return _semail; }
            set
            {
                _semail = value;
                OnPropertyChanged();
            }
        }
        public string SSDT
        {
            get { return _ssdt; }
            set
            {
                _ssdt = value;
                OnPropertyChanged();
            }
        }
        public string SDiaChi
        {
            get { return _sdiachi; }
            set
            {
                _sdiachi = value;
                OnPropertyChanged();
            }
        }
        public string STenKH
        {
            get { return _stenkh; }
            set { _stenkh = value;
                OnPropertyChanged();
            }
        }
        public ICommand SaveCommand { get; set; }
        public AddCustomerViewModel()
        {
           

            SaveCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(STenKH) || string.IsNullOrEmpty(SSDT))
                    return false;

                return true;

            }, (p) =>
            {

              KhachHang = new KHACHHANG() { TENKH ="new", DIACHI = SDiaChi, SDT = SSDT, EMAIL = SEmail };
              DataAccess.SaveKhachHang(KhachHang);
            });
        }
    }
}
