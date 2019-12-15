using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilkTeaManager.Models;

namespace MilkTeaManager.ViewModels
{
    class ManageCustomerViewModel : BaseVM
    {
        private ObservableCollection<KHACHHANG> _khachhangs;
        public ObservableCollection<string> _mhk { get; set; }

        private string _makh;
        private string _sdt;
        private string _diachi;
        private string _email;
        private string _tenkh;
        private KHACHHANG _skhachhang;

      
       public string MaKH
        {
            get { return _makh; }
            set { _makh = value;
                OnPropertyChanged();
            }
        }
        public string TenKH
        {
            get { return _tenkh; }
            set
            {
                _tenkh = value;
                OnPropertyChanged();
            }
        }
       
        public string Email
        {
            get { return _email; }
            set { _email = value;
                OnPropertyChanged();
            }
        }
        public string SDT
        {
            get { return _sdt; }
            set
            {
                _sdt = value;
                OnPropertyChanged();
            }
        }
        public string DiaChi
        {
            get { return _diachi; }
            set { _diachi = value;
                OnPropertyChanged();
            }
        }
        public KHACHHANG SKhachHang
        {
            get { return _skhachhang; }
            set
            {
                _skhachhang = value;
                OnPropertyChanged();
                if(SKhachHang != null)
                {
                    MaKH = SKhachHang.MAKH;
                    SDT = SKhachHang.SDT;
                    DiaChi = SKhachHang.DIACHI;
                    Email = SKhachHang.EMAIL;
                    TenKH = SKhachHang.TENKH;
                }
            }
        }
      
        public ObservableCollection<KHACHHANG> KhachHangs
        {
            get { return _khachhangs; }
            set
            {
                _khachhangs = value;
                OnPropertyChanged();
            }
        }
       
        public ManageCustomerViewModel()
        {
            KhachHangs = new ObservableCollection<KHACHHANG>(DataAccess.GetKhachhangs());
            _mhk = new ObservableCollection<string>(DataAccess.GetMaKh());
        }
    }
}
