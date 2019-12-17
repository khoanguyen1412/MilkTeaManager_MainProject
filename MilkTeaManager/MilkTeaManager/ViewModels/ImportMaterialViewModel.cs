using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MilkTeaManager.Models;
using System.Windows.Input;
using MilkTeaManager.Views.Dialog;
using MilkTeaManager.ViewModels.Dialog;
using System.Windows;

namespace MilkTeaManager.ViewModels
{
    class ImportMaterialViewModel : BaseVM
    {
        public string mapn;
        public string mactpn;
        public int dongia;
        public int soluong;
        public NGUYENLIEU nl;
        public DONVITINH dvt;

        public CHITIETPHIEUNHAP ctpn;
        public PHIEUNHAP _phieunhap;
        private ObservableCollection<NHACUNGCAP> _nccs;
        private ObservableCollection<CHITIETPHIEUNHAP> _ctpns;

        private CHITIETPHIEUNHAP _sctpn;
        private NHACUNGCAP _sncc;
        private int _soluong;
        private int _tienhang;
        private string _ghichu;

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand XoaCTPNCommand { get; set; }
        public ICommand LuuPhieuNhapCommand { get; set; }
        public ICommand ThemNCC { get; set; }
        public ObservableCollection<CHITIETPHIEUNHAP> CTPNs
        {
            get { return _ctpns; }
            set { _ctpns = value;
                OnPropertyChanged();
                
                TienHang = 0;
                foreach (var item in CTPNs)
                {
                 
                    TienHang += (int)item.TONGTIEN;
                }
            }
        }
        public CHITIETPHIEUNHAP SCTPN
        {
            get { return _sctpn; }
            set { _sctpn = value;
                OnPropertyChanged();
                dvt = SCTPN.DONVITINH;
                dongia = (int)SCTPN.DONGIA;
                soluong = (int) SCTPN.DINHLUONG;
                nl = SCTPN.NGUYENLIEU;
                mapn = SCTPN.MAPN;
                mactpn = SCTPN.MACTPN;
               
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
            _phieunhap = new PHIEUNHAP() { MANV = "NV001" };
            DataAccess.SaveLoaiPhieuNhap(_phieunhap);
            NCCs = new ObservableCollection<NHACUNGCAP>(DataAccess.GetNhacungcaps());
            CTPNs = new ObservableCollection<CHITIETPHIEUNHAP>();
            SoLuong = 0;
            TienHang = 0;
            GhiChu = "Ghi chus";

            AddCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                AddMaterial wd = new AddMaterial();
                wd.ShowDialog();
                var dc = wd.DataContext as AddMaterialViewModel;
                if (dc.CTPN !=null)
                    CTPNs = new ObservableCollection<CHITIETPHIEUNHAP>(DataAccess.GetChitietPHIEUNHAPsByMaPN(_phieunhap.MAPN));
                SoLuong = CTPNs.Count();
            });
            EditCommand = new RelayCommand<object>((p) => {
                if (SCTPN == null)
                    return false;
                return true;
            }, (p) => {
                EditImportBill wd = new EditImportBill();
                wd.ShowDialog();
                var dc = wd.DataContext as EditImportBillViewModel;
                if (dc.CTPN != null)
                    CTPNs = new ObservableCollection<CHITIETPHIEUNHAP>(DataAccess.GetChitietPHIEUNHAPsByMaPN(_phieunhap.MAPN));
                SoLuong = CTPNs.Count();
            });
        }
    }
}
