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
        private DateTime _date;
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
               if(SNhaCungCap!=null)
                {
                    DiaChi = SNhaCungCap.DIACHINCC;
                    SDT = SNhaCungCap.SDTNCC;
                    MaNCC = SNhaCungCap.MANCC;
                    Email = SNhaCungCap.EMAILNCC;
                    Date = (DateTime)SNhaCungCap.NGAYHTNCC;
                }
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

        public DateTime Date {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        public ManageSupplierViewModel()
        {
            NhaCungCaps = new ObservableCollection<NHACUNGCAP>(DataAccess.GetNhacungcaps());

        }
    }
}
