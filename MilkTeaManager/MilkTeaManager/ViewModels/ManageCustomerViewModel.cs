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

        private string _makh;
        private string _sdt;
        private KHACHHANG _skhachhang;
      
        private string MaKH
        {
            get { return _makh; }
            set { _makh = value;
                OnPropertyChanged();
            }
        }
        private string SDT
        {
            get { return _sdt; }
            set { _sdt = value;
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
            
        }
    }
}
