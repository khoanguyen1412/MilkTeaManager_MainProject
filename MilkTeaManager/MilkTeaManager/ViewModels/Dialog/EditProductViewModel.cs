using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaManager.ViewModels.Dialog
{
    class EditProductViewModel : BaseVM
    {
        private string _sTenSP;
        private string _sLoaiSP;
        private string _sSize;
        private string _sNguyenLieu;

        public string STenSP
        {
            get => _sTenSP; set
            {
                _sTenSP = value;
                OnPropertyChanged();
            }
        }
        public string SLoaiSP
        {
            get => _sLoaiSP; set
            {
                _sLoaiSP = value;
                OnPropertyChanged();
            }
        }
        public string SSize
        {
            get => _sSize; set
            {
                _sSize = value;
                OnPropertyChanged();
            }
        }
        public string SNguyenLieu
        {
            get => _sNguyenLieu; set
            {
                _sNguyenLieu = value;
                OnPropertyChanged();
            }
        }
        public EditProductViewModel()
        {
        }
    }
}
