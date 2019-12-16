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
    class ManageProductViewModel:BaseVM
    {
        private ObservableCollection<SANPHAM> _sanphams;
        private ObservableCollection<LOAISANPHAM> _loaisps;
        public ObservableCollection<string> _msp { get; set; }

        private SANPHAM _ssanpham;
        private LOAISANPHAM _sloaisp;
        private int _ketquatimthay;
        private string _text;

        public ICommand SearchClick { get; set; }

        public int KQTT
        {
            get { return _ketquatimthay; }
            set { _ketquatimthay = value;
                OnPropertyChanged();
            }
        }
        public SANPHAM SSanPham
        {
            get { return _ssanpham; }
            set
            {
                _ssanpham = value;
                OnPropertyChanged();
            }
        }
        public LOAISANPHAM SLoaiSP
        {
            get { return _sloaisp; }
            set
            {
                _sloaisp = value;
                OnPropertyChanged();
                SanPhams = new ObservableCollection<SANPHAM>(DataAccess.GetSanphambyMaMaLoaiSP(SLoaiSP.MALOAISP));
                KQTT = SanPhams.Count();
            }
        }
        public ObservableCollection<SANPHAM> SanPhams
        {
            get { return _sanphams; }
            set
            {
                _sanphams = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<LOAISANPHAM> LoaiSPs
        {
            get { return _loaisps; }
            set
            {
                _loaisps = value;
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
        public ManageProductViewModel()
        {
           
            LoaiSPs = new ObservableCollection<LOAISANPHAM>(DataAccess.GetLoaisanphams());
            _msp = new ObservableCollection<string>(DataAccess.GetTenSP());

            SearchClick = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                if (Text == "")
                {
                    LoaiSPs = new ObservableCollection<LOAISANPHAM>(DataAccess.GetLoaisanphams());
                }
                //else
                    //LoaiSPs = new ObservableCollection<LOAISANPHAM>(DataAccess.(Text));
            });
        }
    }
}
