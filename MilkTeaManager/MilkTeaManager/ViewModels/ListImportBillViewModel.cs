using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MilkTeaManager.Models;

namespace MilkTeaManager.ViewModels
{
   
    class ListImportBillViewModel:BaseVM
    {
        private ObservableCollection<PHIEUNHAP> _phieunhaps;
        private ObservableCollection<CHITIETPHIEUNHAP> _ctpns;
        private PHIEUNHAP _sphieunhap;
        private DateTime _ngaylappn;
        private int _tongtienpn;
        private string _mapn;

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
        }
    }
}
