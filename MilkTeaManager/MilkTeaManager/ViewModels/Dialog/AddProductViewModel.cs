using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MilkTeaManager.Models;
namespace MilkTeaManager.ViewModels.Dialog
{
    class AddProductViewModel : BaseVM
    {
        public SANPHAM sp;
        private string _sTenSP;
        private int _giaban;
        private string _sNL;
        private CHITIETNGUYENLIEU _sctnl;
        private int _dinhluong;
        private SANPHAM _sanpham;
        private ObservableCollection<LOAISANPHAM> _loaisps;
        private LOAISANPHAM _sloaisp;
        private ObservableCollection<NGUYENLIEU> _nguyenlieus;
        private NGUYENLIEU _snguyenlieu;
        private ObservableCollection<CHITIETNGUYENLIEU> _ctnls;

        public ICommand AddNLCommand { get; set; }
        public ICommand DeleteCTNLCommand { get; set; }
        public ICommand SaveSPCommand { get; set; }
        public ObservableCollection<CHITIETNGUYENLIEU> CTNLs
        {
            get { return _ctnls; }
            set
            {
                _ctnls = value;
                OnPropertyChanged();
            }
        }
        public int DinhLuong
        {
            get { return _dinhluong; }
            set
            {
                _dinhluong = value;
                OnPropertyChanged();
            }
        }
        public CHITIETNGUYENLIEU SCTNL
        {
            get { return _sctnl; }
            set
            {
                _sctnl = value;
                OnPropertyChanged();
                CTNLs.Add(SCTNL);
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
        public ObservableCollection<NGUYENLIEU> NguyenLieus
        {
            get { return _nguyenlieus; }
            set
            {
                _nguyenlieus = value;
                OnPropertyChanged();
            }
        }
        public int GiaBan
        {
            get { return _giaban; }
            set
            {
                _giaban = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<LOAISANPHAM> LoaiSPs
        {
            get { return _loaisps; }
            set
            {
                _loaisps = value;
                OnPropertyChanged();
            }
        }
        public LOAISANPHAM SLoaiSP
        {
            get { return _sloaisp; }
            set
            {
                _sloaisp = value;
                OnPropertyChanged();

            }
        }
        public string STenSP
        {
            get => _sTenSP; set
            {
                _sTenSP = value;
                OnPropertyChanged();
            }
        }

        public string SNL
        {
            get => _sNL; set
            {
                _sNL = value;
                OnPropertyChanged();
            }
        }
        public AddProductViewModel()
        {
   
            _sanpham = null;
            _sanpham = new SANPHAM();
            DinhLuong = 1;
            DataAccess.SaveSanPham(_sanpham);
            LoaiSPs = new ObservableCollection<LOAISANPHAM>(DataAccess.GetLoaisanphams());

            NguyenLieus = new ObservableCollection<NGUYENLIEU>(DataAccess.GetNguyenlieus());
            AddNLCommand = new RelayCommand<object>((p) =>
            {
                if (SNguyenLieu == null)
                    return false;
                return true;

            }, (p) =>
            {

                var ctnl = new CHITIETNGUYENLIEU() { MANL = SNguyenLieu.MANL, GIABAN = 0, MASP = _sanpham.MASP, MADVT = "DVT002", SOLUONG = DinhLuong };
                DataAccess.SaveChiTietNguyenLieu(ctnl);
                if (CTNLs == null)
                    CTNLs = new ObservableCollection<CHITIETNGUYENLIEU>() { ctnl };
                else
                    CTNLs.Add(ctnl);
                ctnl = null;
            });
            DeleteCTNLCommand = new RelayCommand<object>((p) =>
            {

                if (SCTNL == null)
                    return false;
                return true;

            }, (p) =>
            {

                var cthd = DataAccess.db.CHITIETNGUYENLIEUx.Where(x => x.MACTNL == SCTNL.MACTNL).ToList().ElementAt(0);

                DataAccess.DeleteChiTieNguyenLieu(cthd);
                CTNLs.Remove(SCTNL);
                cthd = null;

            });
            SaveSPCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(STenSP) || SLoaiSP == null || string.IsNullOrEmpty(GiaBan.ToString()))
                    return false;

                return true;

            }, (p) =>
            {
                _sanpham.TENSP = STenSP;
                _sanpham.GIABAN = GiaBan;
                _sanpham.MALOAISP = SLoaiSP.MALOAISP;
                sp = new SANPHAM();
               
                DataAccess.SaveSanPham(_sanpham);
                _sanpham = null;
                sp = null;
            });
        }
    }
}
