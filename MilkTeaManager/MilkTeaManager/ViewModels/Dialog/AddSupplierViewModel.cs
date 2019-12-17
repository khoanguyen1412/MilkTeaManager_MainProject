using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaManager.ViewModels.Dialog
{
    class AddSupplierViewModel : BaseVM
    {
        private string _sTenNCC;
        private string _sSDT;
        private string _sDiaChi;
        private string _sEmail;
        private DateTime _sNgayHopTac;
        private string _sNL;

        public string STenNCC
        {
            get => _sTenNCC; set
            {
                _sTenNCC = value;
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
        public DateTime SNgayHopTac
        {
            get => _sNgayHopTac; set
            {
                _sNgayHopTac = value;
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
        public AddSupplierViewModel()
        {

        }
    }
}
