using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaManager.ViewModels.Dialog
{
    class EditSupplierViewModel : BaseVM
    {
        private string _sTenNCC;
        private string _sSDT;
        private string _sDiaChi;
        private string _sEmail;
        private DateTime _sNgayHT;

        public DateTime SNgayHT
        {
            get => _sNgayHT; set
            {
                _sNgayHT = value;
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
        public string STenNCC
        {
            get => _sTenNCC; set
            {
                _sTenNCC = value;
                OnPropertyChanged();
            }
        }
    }
}
