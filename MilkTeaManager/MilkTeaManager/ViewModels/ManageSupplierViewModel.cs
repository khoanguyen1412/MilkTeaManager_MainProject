using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MilkTeaManager.Models;

namespace MilkTeaManager.ViewModels
{
    class ManageSupplierViewModel : BaseVM
    {
        private ObservableCollection<NHACUNGCAP> _nhacungcaps;
        public ObservableCollection<string> _mncc { get; set; }


        private string _sdt;
        private string _diachi;
        private string _email;
        private string _mancc;
        private DateTime _date;
        private NHACUNGCAP _snhacungcap;
        private string _text;

        public ICommand SearchClick { get; set; }

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

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
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
            _mncc = new ObservableCollection<string>(DataAccess.GetTenNCC());

            SearchClick = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                if (Text == "")
                {
                    NhaCungCaps = new ObservableCollection<NHACUNGCAP>(DataAccess.GetNhacungcaps());
                }
                else
                    NhaCungCaps = new ObservableCollection<NHACUNGCAP>(DataAccess.FilterNhaCungCapByTenNCC(Text));
            });
        }
    }
}
