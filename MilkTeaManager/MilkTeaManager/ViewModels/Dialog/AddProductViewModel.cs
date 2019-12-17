using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaManager.ViewModels.Dialog
{
    class AddProductViewModel : BaseVM
    {
        private string _sTenSP;
        private string _sLoaiSP;
        private string _sNL;

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
        public string SNL
        {
            get => _sNL; set
            {
                _sNL = value;
                OnPropertyChanged();
            }
        }
        public AddProductViewModel() {

        }
    }
}
