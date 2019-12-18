using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MilkTeaManager.Models;
using System.Windows.Input;

namespace MilkTeaManager.ViewModels
{

    class ExpenditureStatisticViewModel : BaseVM
    {
        private ObservableCollection<PHIEUNHAP> _phieunhaps;
        public ObservableCollection<string> _mpn { get; set; }

        private PHIEUNHAP _sphieunhap;
        private DateTime _ngaylappn;
        private int _tongtienpn;
        private string _mapn;
        private string _text;
        private int _tongchi;
        private int _soluong;
        private string _nhanvien;
        
        public string TenNV
        {
            get { return _nhanvien; }
            set { _nhanvien = value;
                OnPropertyChanged();
            }
        }
        public ICommand SearchClick { get; set; }
        public ICommand ReloadCommand { get; set; }
        public int TongChi
        {
            get { return _tongchi; }
            set { _tongchi = value;
                OnPropertyChanged();
            }
        }
        public int SoLuong
        {
            get { return _soluong; }
            set { _soluong = value;
                OnPropertyChanged();
            }
        }
        public string MaPN
        {
            get { return _mapn; }
            set
            {
                _mapn = value;
                OnPropertyChanged();
            }
        }

        public int TongTienPN
        {
            get { return _tongtienpn; }
            set
            {
                _tongtienpn = value;
                OnPropertyChanged();
            }
        }
        public DateTime NgayLapPN
        {
            get { return _ngaylappn; }
            set
            {
                _ngaylappn = value;
                OnPropertyChanged();
            }
        }

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<PHIEUNHAP> PhieuNhaps
        {
            get { return _phieunhaps; }
            set
            {
                _phieunhaps = value;
                OnPropertyChanged();
                int tong = 0;
        
                TongChi = tong;
            }
        }

        public PHIEUNHAP SPhieuNhap
        {
            get { return _sphieunhap; }
            set
            {
                _sphieunhap = value;
                OnPropertyChanged();
              
                NgayLapPN = (DateTime)SPhieuNhap.NGAYNHAP;
                MaPN = SPhieuNhap.MAPN;
                TongTienPN = 1000000;
            }
        }
        public ExpenditureStatisticViewModel()
        {
            PhieuNhaps = new ObservableCollection<PHIEUNHAP>(DataAccess.GetPhieuNhaps());
            PhieuNhaps.RemoveAt(PhieuNhaps.Count() - 1);
            _mpn = new ObservableCollection<string>(DataAccess.GetMaPN());
            SoLuong = PhieuNhaps.Count();
            int tong = 0;
            if (PhieuNhaps != null)
            {
                foreach (var item in PhieuNhaps)
                {
                    TenNV = item.NHANVIEN.HOTEN;
                    tong += (int)item.TONGTIEN;
                }
            }
            TongChi = tong;
            SearchClick = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                if (Text == "")
                {
                    PhieuNhaps = new ObservableCollection<PHIEUNHAP>(DataAccess.GetPhieuNhaps());
                }
                else
                    PhieuNhaps = new ObservableCollection<PHIEUNHAP>(DataAccess.FilterPhieuNhapByMaPN(Text));
            });
            ReloadCommand = new RelayCommand<object>((p) =>
            {


                return true;

            }, (p) =>
            {
                PhieuNhaps = new ObservableCollection<PHIEUNHAP>(DataAccess.GetPhieuNhaps());
                PhieuNhaps.RemoveAt(PhieuNhaps.Count() - 1);
            });
        }
    }
}
