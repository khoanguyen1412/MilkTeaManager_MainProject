using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaManager.ViewModels.Dialog
{
    class EditMaterialViewModel : BaseVM
    {
        private string _sTenNL;
        private string _sGiaNhap;
        private string _sGiaBan;
        private string _sNhaCC;

        public string SNhaCC
        {
            get => _sNhaCC; set
            {
                _sNhaCC = value;
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
        public string SGiaNhap
        {
            get => _sGiaNhap; set
            {
                _sGiaNhap = value;
                OnPropertyChanged();
            }
        }
        public string STenNL
        {
            get => _sTenNL; set
            {
                _sTenNL = value;
                OnPropertyChanged();
            }
        }
        public EditMaterialViewModel()
        {

        }
    }
}
