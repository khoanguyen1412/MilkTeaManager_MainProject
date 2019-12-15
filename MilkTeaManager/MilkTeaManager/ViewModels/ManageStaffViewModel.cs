using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilkTeaManager.Models;

namespace MilkTeaManager.ViewModels
{
    class ManageStaffViewModel : BaseVM
    {
        private ObservableCollection<NHANVIEN> _nhanviens;
        public ObservableCollection<string> _mnv { get; set; }

        private DateTime _nsinh;
        private string _sdt;
        private string _diachi;
        private string _tennv;
        private string _luong;
        private string _chucvu;
        private NHANVIEN _snhanvien;

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
        public string DiaChi
        {
            get { return _diachi; }
            set
            {
                _diachi = value;
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
                }
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



        public ManageStaffViewModel()
        {
            NhanViens = new ObservableCollection<NHANVIEN>(DataAccess.GetNhanviens());
            _mnv = new ObservableCollection<string>(DataAccess.GetMaNV());

        }
    }
}
