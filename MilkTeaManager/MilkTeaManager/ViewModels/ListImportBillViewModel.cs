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
   
    class ListImportBillViewModel:BaseVM
    {
        private ObservableCollection<PHIEUNHAP> _phieunhaps;
        private ObservableCollection<CHITIETPHIEUNHAP> _ctpns;
        public ObservableCollection<string> _mpn { get; set; }

        private PHIEUNHAP _sphieunhap;
        private DateTime _ngaylappn;
        private int _tongtienpn;
        private string _mapn;
        private string _text;

        public ICommand SearchClick { get; set; }

        public string MaPN
        {
            get { return _mapn; }
            set { _mapn = value;
                OnPropertyChanged();
            }
        }

        public int TongTienPN
        {
            get { return _tongtienpn; }
            set { _tongtienpn = value;
                OnPropertyChanged();
            }
        }
        public DateTime NgayLapPN
        {
            get { return _ngaylappn; }
            set { _ngaylappn = value;
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
            set { _phieunhaps = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<CHITIETPHIEUNHAP> CTPNs
        {
            get { return _ctpns; }
            set { _ctpns = value;
                OnPropertyChanged();
            }
        }
        public PHIEUNHAP SPhieuNhap
        {
            get { return _sphieunhap; }
            set { _sphieunhap = value;
                OnPropertyChanged();
                CTPNs = new ObservableCollection<CHITIETPHIEUNHAP>(DataAccess.GetChitietPHIEUNHAPsByMaPN(SPhieuNhap.MAPN));
                NgayLapPN =(DateTime) SPhieuNhap.NGAYNHAP;
                MaPN = SPhieuNhap.MAPN;
                TongTienPN = 1000000;
            }
        }
        public ListImportBillViewModel()
        {
            PhieuNhaps = new ObservableCollection<PHIEUNHAP>(DataAccess.GetPhieuNhaps());
            _mpn = new ObservableCollection<string>(DataAccess.GetMaPN());
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
        }
    }
}
