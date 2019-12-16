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
    class ImportMaterialViewModel : BaseVM
    {
        private ObservableCollection<NHACUNGCAP> _nccs;
        private ObservableCollection<CHITIETPHIEUNHAP> _ctpns;

        private CHITIETPHIEUNHAP _sctpn;
        private NHACUNGCAP _sncc;
        private int _soluong;
        private int _tienhang;
        private string _ghichu;

        public ICommand ThemCTPNCommand { get; set; }
        public ICommand SuaCTPNCommand { get; set; }
        public ICommand XoaCTPNCommand { get; set; }
        public ICommand LuuPhieuNhapCommand { get; set; }
        public ICommand ThemNCC { get; set; }
        public ObservableCollection<CHITIETPHIEUNHAP> CTPNs
        {
            get { return _ctpns; }
            set { _ctpns = value;
                OnPropertyChanged();
            }
        }
        public CHITIETPHIEUNHAP SCTPN
        {
            get { return _sctpn; }
            set { _sctpn = value;
                OnPropertyChanged();
            }
        }
        public int TienHang
        {
            get { return _tienhang; }
            set { _tienhang = value;
                OnPropertyChanged();
            }
        }
        public int SoLuong
        {
            get { return _tienhang; }
            set { _tienhang = value;
                OnPropertyChanged();
            }
        }
        public string GhiChu
        {
            get { return _ghichu; }
            set { _ghichu = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<NHACUNGCAP> NCCs
        {
            get { return _nccs; }
            set
            {
                _nccs = value;
                OnPropertyChanged();
            }
        }
        public NHACUNGCAP SNCC
        {
            get { return _sncc; }
            set
            {
                _sncc = value;
                OnPropertyChanged();           

            }
        }
        public ImportMaterialViewModel()
        {
            NCCs = new ObservableCollection<NHACUNGCAP>(DataAccess.GetNhacungcaps());
            SoLuong = 0;
            TienHang = 0;
            GhiChu = "Ghi chus";
        }
    }
}
