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

        public ObservableCollection<TRANGTHAI> _tts;
        public TRANGTHAI _strangthai;

        public ObservableCollection<TRANGTHAI> TTs
        {
            get { return _tts; }
            set
            {
                _tts = value;
                OnPropertyChanged();
            }
        }
        public TRANGTHAI STrangThai
        {
            get { return _strangthai; }
            set
            {
                _strangthai = value;
                OnPropertyChanged();
                NhaCungCaps = new ObservableCollection<NHACUNGCAP>(DataAccess.GetNhacungcapsByTT(STrangThai.MATT));
                
            }
        }
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
                    Email = SNhaCungCap.EMAILNCC;
                    Date = (DateTime)SNhaCungCap.NGAYHOPTAC;
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
            TTs = new ObservableCollection<TRANGTHAI>();
            TRANGTHAI tt1 = new TRANGTHAI("Hợp tác", 1);
            TTs.Add(tt1);
            TRANGTHAI tt2 = new TRANGTHAI("Dừng hợp tác", 0);
            TTs.Add(tt2);

            NhaCungCaps = new ObservableCollection<NHACUNGCAP>(DataAccess.GetNhacungcaps());
            _mncc = new ObservableCollection<string>(DataAccess.GetTenNCC());
            foreach (var item in NhaCungCaps)
            {
                if (item.TT == 1)
                    item.TINHTRANG = "Hợp tác";
                else
                    item.TINHTRANG = "Dừng hợp tác";
            }
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
