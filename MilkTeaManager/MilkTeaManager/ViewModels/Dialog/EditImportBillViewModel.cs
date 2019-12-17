using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaManager.ViewModels.Dialog
{
    class EditImportBillViewModel : BaseVM
    {
        private string _sTenNL;
        private string _sGiaNhap;
        private string _sGiaBan;
        private string _sSoLuong;
        private string _sNhaCungCap;

        public string STenNL
        {
            get => _sTenNL; set
            {
                _sTenNL = value;
                OnPropertyChanged();
            }
        }
        public string SGiaNhap
        {
            get => _sGiaNhap; set
            {
                _sGiaNhap = value;
                OnPropertyChanged();
            }
        }
        public string SGiaBan
        {
            get => _sGiaBan; set
            {
                _sGiaBan = value;
                OnPropertyChanged();
            }
        }
        public string SSoLuong
        {
            get => _sSoLuong; set
            {
                _sSoLuong = value;
                OnPropertyChanged();
            }
        }
        public string SNhaCungCap
        {
            get => _sNhaCungCap; set
            {
                _sNhaCungCap = value;
                OnPropertyChanged();
            }
        }
        public EditImportBillViewModel()
        {
        }
    }
}
