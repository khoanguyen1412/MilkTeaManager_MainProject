using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MilkTeaManager.Models;
using MilkTeaManager.Views.Pages;

namespace MilkTeaManager.ViewModels.Dialog
{
    class AddStaffViewModel : BaseVM
    {
        public ObservableCollection<string> ChucVu { get; set; }
        private NHANVIEN _nhanvien;

        public NHANVIEN NhanVien
        {
            get { return _nhanvien; }
            set
            {
                _nhanvien = value;
                OnPropertyChanged();
            }
        }

        private string _sTenNV;
        private string _sSDT;
        private string _sDiaChi;
        private string _sEmail;
        private string _sChucVu;
        private DateTime? _sNgaySinh;
        private string _sLuong;

        public string STenNV
        {
            get => _sTenNV; set
            {
                _sTenNV = value;
                OnPropertyChanged();
            }
        }
        public string SSDT
        {
            get => _sSDT; set
            {
                _sSDT = value;
                OnPropertyChanged();
            }
        }
        public string SDiaChi
        {
            get => _sDiaChi; set
            {
                _sDiaChi = value;
                OnPropertyChanged();
            }
        }
        public string SEmail
        {
            get => _sEmail; set
            {
                _sEmail = value;
                OnPropertyChanged();
            }
        }
        public string SChucVu
        {
            get => _sChucVu; set
            {
                _sChucVu = value;
                OnPropertyChanged();
            }
        }
        public DateTime? SNgaySinh
        {
            get => _sNgaySinh; set
            {
                _sNgaySinh = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; set; }
        public string SLuong
        {
            get => _sLuong; set
            {
                _sLuong = value;
                OnPropertyChanged();
            }
        }

        public AddStaffViewModel()
        {
            ChucVu = new ObservableCollection<string>(DataAccess.GetTenLoaiNV());
            SaveCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(STenNV) || string.IsNullOrEmpty(SDiaChi) || string.IsNullOrEmpty(SSDT) || string.IsNullOrEmpty(SEmail) || string.IsNullOrEmpty(SLuong) || string.IsNullOrEmpty(SChucVu))
                {
                    return false;
                }
                return true;

            }, (p) =>
            {

                NhanVien = new NHANVIEN() { HOTEN = STenNV, NGAYSINH = SNgaySinh, SDT = SSDT, EMAIL = SEmail, MALOAINV = DataAccess.GetLoainhanvienbyTenLoaiNV(SChucVu), LUONG = Int32.Parse(SLuong), TT = 1, TINHTRANG = "Đang làm việc" };
                DataAccess.SaveNhanVien(NhanVien);
                ManageStaff ManageStaffWindow = new ManageStaff();
                if (ManageStaffWindow.DataContext == null)
                    return;
                var MStafVM = ManageStaffWindow.DataContext as ManageStaffViewModel;
                MStafVM.NhanViens = new ObservableCollection<NHANVIEN>(DataAccess.GetNhanviens());
            });
        }
    }
}
