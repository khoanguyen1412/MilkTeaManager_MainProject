using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MilkTeaManager.Models;
using MilkTeaManager.Views.Dialog;

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
        private int _tongthu;
        public ICommand PrintCommand { get; set; }
        public ICommand ReloadCommand { get; set; }
        public int TongThu
        {
            get { return _tongthu; }
            set { _tongthu = value;
                OnPropertyChanged();
            }
        }

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
                TongThu = 0;
                
            }
        }
        public RevenueStatisticViewModel()
        {
            TongThu = 0;
            HoaDons = new ObservableCollection<HOADON>(DataAccess.GetHoadons());
            HoaDons.Remove(HoaDons.ElementAt(HoaDons.Count() - 1));

                foreach (var item in HoaDons)
                {
                    TongThu += (int)item.TONGTIEN;
                }
            PrintCommand = new RelayCommand<object>((p) =>
            {

                if (HoaDons == null)
                    return false;
                return true;

            }, (p) =>
            {
                RevenueForm wd = new RevenueForm();
                wd.ShowDialog();
            });
            ReloadCommand = new RelayCommand<object>((p) =>
            {

                
                return true;

            }, (p) =>
            {
                HoaDons = new ObservableCollection<HOADON>(DataAccess.GetHoadons());
                 HoaDons.Remove(HoaDons.ElementAt(HoaDons.Count() - 1));
            });
        }
    }
}
