using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaManager.ViewModels.Dialog
{
    class EditStaffViewModel : BaseVM
    {
        private string _sTenNV;
        private string _sSDT;
        private string _sDiaChi;
        private string _sEmail;
        private string _sChucVu;
        private DateTime _sNgaySinh;

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
        public DateTime SNgaySinh
        {
            get => _sNgaySinh; set
            {
                _sNgaySinh = value;
                OnPropertyChanged();
            }
        }
        public EditStaffViewModel()
        {
        }
    }
}
