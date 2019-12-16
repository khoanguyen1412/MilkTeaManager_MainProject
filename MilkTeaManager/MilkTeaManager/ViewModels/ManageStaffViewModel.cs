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
    class ManageStaffViewModel : BaseVM
    {
        private ObservableCollection<NHANVIEN> _nhanviens;
        private ObservableCollection<LOAINHANVIEN> _loainhanviens;
        private LOAINHANVIEN _sloainv;
        private int _ketquatimthay;
        private int soluong;
        public ObservableCollection<string> _mnv { get; set; }
        private DateTime _nsinh;
        private string _sdt;
        private string _email;
        private string _tennv;
        private string _luong;
        private string _chucvu;
        private NHANVIEN _snhanvien;
        
        private string _manv;

        public LOAINHANVIEN SLoaiNV
        {
            get { return _sloainv; }
            set
            {
                _sloainv = value;
                OnPropertyChanged();
                NhanViens = new ObservableCollection<NHANVIEN>(DataAccess.GetNHANVIENByMALOAINV(SLoaiNV.MALOAINV));
                KQTT = NhanViens.Count();
            }
        }
        public int SoLuong
        {
            get { return soluong; }
            set
            {
                soluong = value;
                OnPropertyChanged();
            }
        }
        public int KQTT
        {
            get { return _ketquatimthay; }
            set
            {
                _ketquatimthay = value;
                OnPropertyChanged();
            }
        }
        public string MaNV
        {
            get { return _manv; }
            set { _manv = value;
            OnPropertyChanged();}
        }
        private string _text;

        public ICommand SearchClick { get; set; }

        public DateTime NgaySinh
        {
            get { return _nsinh; }
            set { _nsinh = value;
                OnPropertyChanged();
            }
        }
        public string TenNV
        {
            get { return _tennv; }
            set { _tennv = value;
                OnPropertyChanged();
            }
        }
        public string Luong
        {
            get { return _luong; }
            set { _luong = value;
                OnPropertyChanged();
            }
        }
        public string ChucVu
        {
            get { return _chucvu;  }
            set { _chucvu = value;
                OnPropertyChanged();
            }
        }
        public string SDT
        {
            get { return _sdt; }
            set
            {
                _sdt = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        public NHANVIEN SNhanVien
        {
            get { return _snhanvien; }
            set
            {
                _snhanvien = value;
                OnPropertyChanged();
               
                if(SNhanVien != null)
                {
                    TenNV = SNhanVien.HOTEN;
                    SDT = SNhanVien.SDT;
                    ChucVu = SNhanVien.LOAINHANVIEN.TENLOAINV;
                    NgaySinh =(DateTime) SNhanVien.NGAYSINH;
                    MaNV = SNhanVien.MANV;
                    Email = SNhanVien.EMAIL;
                }
            }
        }
        public  ObservableCollection<LOAINHANVIEN> LoaiNVs
        {
            get { return _loainhanviens; }
            set { _loainhanviens = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<NHANVIEN> NhanViens
        {
            get { return _nhanviens; }
            set
            {
                _nhanviens = value;
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


        public ManageStaffViewModel()
        {
            NhanViens = new ObservableCollection<NHANVIEN>(DataAccess.GetNhanviens());
            LoaiNVs = new ObservableCollection<LOAINHANVIEN>(DataAccess.GetLoainhanviens());
            SoLuong = NhanViens.Count();
            KQTT = SoLuong;
            _mnv = new ObservableCollection<string>(DataAccess.GetTenNV());

            SearchClick = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                if (Text == "")
                {
                    NhanViens = new ObservableCollection<NHANVIEN>(DataAccess.GetNhanviens());
                }
                else
                    NhanViens = new ObservableCollection<NHANVIEN>(DataAccess.FilterNhanvienByTenNV(Text));
            });

        }
    }
}
