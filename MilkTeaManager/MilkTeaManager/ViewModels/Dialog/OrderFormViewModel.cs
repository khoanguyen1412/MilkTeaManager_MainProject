using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MilkTeaManager.Models;
using MilkTeaManager.Views.Pages;

namespace MilkTeaManager.ViewModels.Dialog
{
    class OrderFormViewModel : BaseVM
    {
        private ObservableCollection<CHITIETHOADON> _cthds;

        private int _tongtien;
        private int _tienkhachdua;
        private int _tienthua;
        private DateTime _ngayban;
        private string _tenkh;
        private string _mahd;
        private string _manv;
        public string TenKH
        {
            get { return _tenkh; }
            set
            {
                _tenkh = value;
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
        public string MaNV
        {
            get { return _manv; }
            set
            {
                _manv = value;
                OnPropertyChanged();
            }
        }
        public DateTime NgayBan
        {
            get { return _ngayban; }
            set
            {
                _ngayban = value;
                OnPropertyChanged();
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
        public int TienThua
        {
            get { return _tienthua; }
            set
            {
                _tienthua = value;
                OnPropertyChanged();
            }
        }

        public int TongTien
        {
            get { return _tongtien; }
            set
            {
                _tongtien = value;
                OnPropertyChanged();
            }
        }
        public int TienKhachDua
        {
            get { return _tienkhachdua; }
            set
            {
                _tienkhachdua = value;
                OnPropertyChanged();
            }
        }

        public OrderFormViewModel()
        {
            SellProduct wd = new SellProduct();
            var data = wd.DataContext as SellProductViewModel;
            
            CTHDs = new ObservableCollection<CHITIETHOADON>(DataAccess.GetChitiethoadonsByMaHD(data.mahd));
            NgayBan = DateTime.Now;
            MaHD =  CTHDs.ElementAt(0).MAHD;
            MaNV =  CTHDs.ElementAt(0).HOADON.MANV;
            if (string.IsNullOrEmpty(data.STenKH))
                TenKH = "Khách";
            else
                TenKH = data.STenKH;
           

            TongTien = data.TongTien;
            TienKhachDua = data.TienKhachDua;
            TienThua = data.TienThua;
        }
    }
}
