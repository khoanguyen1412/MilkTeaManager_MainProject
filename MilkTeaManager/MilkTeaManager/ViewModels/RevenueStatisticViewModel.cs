using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MilkTeaManager.Models;
namespace MilkTeaManager.ViewModels
{
    class RevenueStatisticViewModel:BaseVM
    {
        private ObservableCollection<HOADON> _hoadons;
        private ObservableCollection<CHITIETHOADON> _cthds;
        private HOADON _shoadon;
        private string _tenkh;
        private string _soluong;
        private int _tongtien;
        private string _mahd;

        public string MaHD
        {
            get { return _mahd; }
            set
            {
                _mahd = value;
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
        public string SoLuong
        {
            get { return _soluong; }
            set
            {
                _soluong = value;
                OnPropertyChanged();
            }
        }
        public int TongTien
        {
            get { return _tongtien; }
            set { _tongtien = value;
                OnPropertyChanged();
            }
        }
        public HOADON SHoaDon
        {
            get { return _shoadon; }
            set
            {
                _shoadon = value;
                OnPropertyChanged();
                if(SHoaDon != null)
                {
                    MaHD = SHoaDon.MAHD;
                    CTHDs = new ObservableCollection<CHITIETHOADON>(DataAccess.GetChitiethoadonsByMaHD(MaHD));
                   
                    TenKH = SHoaDon.KHACHHANG.TENKH;
                    SoLuong = CTHDs.Count().ToString();
                    TongTien = (int)SHoaDon.TONGTIEN;

                }
            }
        }
        public ObservableCollection<CHITIETHOADON> CTHDs
        {
            get { return _cthds; }
            set
            {
                _cthds = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<HOADON> HoaDons
        {
            get { return _hoadons; }
            set
            {
                _hoadons = value;
                OnPropertyChanged();
            }
        }
        public RevenueStatisticViewModel()
        {
           
            HoaDons = new ObservableCollection<HOADON>(DataAccess.GetHoadons());
        }
    }
}
