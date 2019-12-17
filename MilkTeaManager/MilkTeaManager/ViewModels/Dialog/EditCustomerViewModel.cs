using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaManager.ViewModels.Dialog
{
    class EditCustomerViewModel : BaseVM
    {
        private string _sTenKH;
        private string _sSDT;
        private string _sDiaChi;
        private string _sEmail;

        public string SEmail
        {
            get => _sEmail; set
            {
                _sEmail = value;
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
        public string SSDT
        {
            get => _sSDT; set
            {
                _sSDT = value;
                OnPropertyChanged();

            }
        }
        public string STenKH
        {
            get => _sTenKH; set
            {
                _sTenKH = value;
                OnPropertyChanged();

            }
        }
        public EditCustomerViewModel()
        {
        }
    }
}
