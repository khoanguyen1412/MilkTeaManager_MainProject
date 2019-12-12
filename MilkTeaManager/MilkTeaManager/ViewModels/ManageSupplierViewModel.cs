using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilkTeaManager.Models;

namespace MilkTeaManager.ViewModels
{
    class ManageSupplierViewModel : BaseVM
    {
        private ObservableCollection<NHACUNGCAP> _nhacungcaps;

        private string _sdt;
        private string _diachi;
        private string _email;
        private string _mancc;
        private NHACUNGCAP _snhacungcap;

        public string MaNCC
        {
            get { return _mancc; }
            set { _mancc = value;
                OnPropertyChanged();
            }
        }
        public string SDT
        {
            get { return _sdt; }
            set
            {
                _sdt = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        public string DiaChi
        {
            get { return _diachi; }
            set
            {
                _diachi = value;
                OnPropertyChanged();
            }
        }
        public NHACUNGCAP SNhaCungCap
        {
            get { return _snhacungcap; }
            set
            {
                _snhacungcap = value;
                OnPropertyChanged();
                DiaChi = SNhaCungCap.DIACHINCC;
                SDT = SNhaCungCap.SDTNCC;
                MaNCC = SNhaCungCap.MANCC;   
            }
        }

        public ObservableCollection<NHACUNGCAP> NhaCungCaps
        {
            get { return _nhacungcaps; }
            set
            {
                _nhacungcaps = value;
                OnPropertyChanged();
            }
        }

        public ManageSupplierViewModel()
        {
            NhaCungCaps = new ObservableCollection<NHACUNGCAP>(DataAccess.GetNhacungcaps());

        }
    }
}
