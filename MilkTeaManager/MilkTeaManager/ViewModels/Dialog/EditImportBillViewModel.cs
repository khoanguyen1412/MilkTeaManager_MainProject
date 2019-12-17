using MilkTeaManager.Models;
using MilkTeaManager.Views.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MilkTeaManager.ViewModels.Dialog
{
    class EditImportBillViewModel : BaseVM
    {
        private CHITIETPHIEUNHAP _ctpn;
        private string _sTenNL;
        private string _sSoLuong;
        private int _dongia;
        private ObservableCollection<NGUYENLIEU> _nguyenlieus;
        private ObservableCollection<DONVITINH> _dvts;
        private NGUYENLIEU _snguyenlieu;
        private DONVITINH _sdvt;

        public CHITIETPHIEUNHAP CTPN
        {
            get { return _ctpn; }
            set
            {
                _ctpn = value;
                OnPropertyChanged();
            }
        }
        public NGUYENLIEU SNguyenLieu
        {
            get { return _snguyenlieu; }
            set
            {
                _snguyenlieu = value;
                OnPropertyChanged();
            }
        }
        public DONVITINH SDVT
        {
            get { return _sdvt; }
            set
            {
                _sdvt = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<NGUYENLIEU> NguyenLieus
        {
            get { return _nguyenlieus; }
            set
            {
                _nguyenlieus = value;
                OnPropertyChanged();
            }

        }
        public ObservableCollection<DONVITINH> DVTs
        {
            get { return _dvts; }
            set
            {
                _dvts = value;
                OnPropertyChanged();
            }
        }
        public int DonGia
        {
            get { return _dongia; }
            set
            {
                _dongia = value;
                OnPropertyChanged();
            }
        }

        public string STenNL
        {
            get => _sTenNL;
            set
            {
                _sTenNL = value;
                OnPropertyChanged();
            }
        }

        public string SSoLuong
        {
            get => _sSoLuong;
            set
            {
                _sSoLuong = value;
                OnPropertyChanged();
            }
        }
        public ICommand SaveCommand { get; set; }
        public EditImportBillViewModel()
        {

            DonGia = 0;
            NguyenLieus = new ObservableCollection<NGUYENLIEU>(DataAccess.GetNguyenlieus());
            DVTs = new ObservableCollection<DONVITINH>(DataAccess.GetDonvitinhs());
            ImportMaterial wd = new ImportMaterial();
            var dc = wd.DataContext as ImportMaterialViewModel;
            DonGia = dc.dongia;
            SSoLuong =  dc.soluong.ToString();
            SDVT = dc.dvt;
            DonGia = dc.dongia;
            SaveCommand = new RelayCommand<object>((p) =>
            {
                if (SDVT == null || SNguyenLieu == null || string.IsNullOrEmpty(SSoLuong))
                    return false;

                return true;

            }, (p) =>
            {

                CTPN = new CHITIETPHIEUNHAP() { MADVT = SDVT.madvt, DINHLUONG = int.Parse(SSoLuong), DONGIA = DonGia, MANL = SNguyenLieu.MANL, MAPN = dc.mapn , MACTPN = dc.mactpn};
                DataAccess.SaveCTPN(CTPN);
            });
        }
    }
}
