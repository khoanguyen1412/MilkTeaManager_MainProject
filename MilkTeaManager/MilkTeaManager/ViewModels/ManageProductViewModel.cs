using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MilkTeaManager.Models;

namespace MilkTeaManager.ViewModels
{
    class ManageProductViewModel:BaseVM
    {
        private ObservableCollection<SANPHAM> _sanphams;
        private ObservableCollection<LOAISANPHAM> _loaisps;
<<<<<<< HEAD
        private ObservableCollection<CHITIETNGUYENLIEU> _ctnls;
=======
        public ObservableCollection<string> _msp { get; set; }
>>>>>>> 9fb626847e6efe4f278439f429660f54cbfbc7a2

        private SANPHAM _ssanpham;
        private LOAISANPHAM _sloaisp;
        private int _ketquatimthay;
<<<<<<< HEAD
        private int soluong;
        private string _tensp;
        private string _tenlsp;
        private string _masp;
=======
        private string _text;

        public ICommand SearchClick { get; set; }
>>>>>>> 9fb626847e6efe4f278439f429660f54cbfbc7a2

        public string MaSP
        {
            get { return _masp; }
            set { _masp = value;
                OnPropertyChanged();
            }
        }
        public string TenSP
        {
            get { return _tensp; }
            set { _tensp = value;
                OnPropertyChanged();
            }
        }
        public string TenLoaiSP
        {
            get { return _tenlsp; }
            set { _tenlsp = value;
                OnPropertyChanged();
            }
        }
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value;
                OnPropertyChanged();
            }
        }
        public int KQTT
        {
            get { return _ketquatimthay; }
            set { _ketquatimthay = value;
                OnPropertyChanged();
            }
        }
        public SANPHAM SSanPham
        {
            get { return _ssanpham; }
            set
            {
                _ssanpham = value;
                OnPropertyChanged();
                CTNLs = new ObservableCollection<CHITIETNGUYENLIEU>(DataAccess.GetChitietnguyenlieusByMaSp(SSanPham.MASP));
                foreach (var item in CTNLs)
                {
                    item.MACTNL = DataAccess.TenNl(item.MANL);
                }
                TenLoaiSP = SSanPham.LOAISANPHAM.TENLOAISP;
                TenSP = SSanPham.TENSP;
                MaSP = SSanPham.MASP;
            }
        }
        public LOAISANPHAM SLoaiSP
        {
            get { return _sloaisp; }
            set
            {
                _sloaisp = value;
                OnPropertyChanged();
                SanPhams = new ObservableCollection<SANPHAM>(DataAccess.GetSanphambyMaMaLoaiSP(SLoaiSP.MALOAISP));
                KQTT = SanPhams.Count();
            }
        }
        public ObservableCollection<SANPHAM> SanPhams
        {
            get { return _sanphams; }
            set
            {
                _sanphams = value;
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
<<<<<<< HEAD
        public ObservableCollection<CHITIETNGUYENLIEU> CTNLs
        {
            get { return _ctnls; }
            set { _ctnls = value;
=======
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
>>>>>>> 9fb626847e6efe4f278439f429660f54cbfbc7a2
                OnPropertyChanged();
            }
        }
        public ManageProductViewModel()
        {
           
            LoaiSPs = new ObservableCollection<LOAISANPHAM>(DataAccess.GetLoaisanphams());
<<<<<<< HEAD
            SanPhams = new ObservableCollection<SANPHAM>(DataAccess.GetSanphams());
            SoLuong = SanPhams.Count();
            KQTT = SoLuong;
=======
            _msp = new ObservableCollection<string>(DataAccess.GetTenSP());

            SearchClick = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                if (Text == "")
                {
                    LoaiSPs = new ObservableCollection<LOAISANPHAM>(DataAccess.GetLoaisanphams());
                }
                //else
                    //LoaiSPs = new ObservableCollection<LOAISANPHAM>(DataAccess.(Text));
            });
>>>>>>> 9fb626847e6efe4f278439f429660f54cbfbc7a2
        }
    }
}
