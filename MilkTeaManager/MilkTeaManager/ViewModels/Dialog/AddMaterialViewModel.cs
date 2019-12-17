using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaManager.ViewModels.Dialog
{
    class AddMaterialViewModel : BaseVM
    {
        private string _sTenNL;
        private string _sSoLuong;
        public AddMaterialViewModel()
        {

        }

        public string STenNL
        {
            get => _sTenNL;
            set
            {
                _sTenNL = value;
                OnPropertyChanged();
            }
        }

        public string SSoLuong
        {
            get => _sSoLuong;
            set
            {
                _sSoLuong = value;
                OnPropertyChanged();
            }
        }
    }
}
