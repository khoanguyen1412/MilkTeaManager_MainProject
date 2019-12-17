using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MilkTeaManager.Models;
using MilkTeaManager.Views.Pages;

namespace MilkTeaManager.ViewModels.Dialog
{
    class RevenueFormViewModel:BaseVM
    {
        private string _nguoilap;
        private DateTime _ngaylap;
        private DateTime _tungay;
        private DateTime _denngay;
        private int _tongthu;
        private ObservableCollection<HOADON> _hoadons;

        public int TongThu
        {
            get { return _tongthu; }
            set { _tongthu = value;
                OnPropertyChanged();
            }
        }
        public string NguoiLap
        {
            get { return _nguoilap; }
            set { _nguoilap = value;
                OnPropertyChanged();
            }
        }
        public DateTime NgayLap
        {
            get { return _ngaylap; }
            set { _ngaylap = value;
                OnPropertyChanged();
            }
        }
        public DateTime TuNgay
        {
            get { return _tungay; }
            set
            {
                _tungay = value;
                OnPropertyChanged();
            }
        }
        public DateTime DenNgay
        {
            get { return _denngay; }
            set
            {
                _denngay = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<HOADON> HoaDons
        {
            get { return _hoadons; }
            set { _hoadons = value;
                OnPropertyChanged();
            }
        }
        public RevenueFormViewModel()
        {
            RevenueStatistic wd = new RevenueStatistic();
            var data = wd.DataContext as RevenueStatisticViewModel;
            NgayLap = (DateTime)data.HoaDons.ElementAt(0).NGAYLAP;
            NguoiLap = data.HoaDons.ElementAt(0).NHANVIEN.HOTEN;
            HoaDons = data.HoaDons;
            TongThu = data.TongThu;
        }
    }
}
