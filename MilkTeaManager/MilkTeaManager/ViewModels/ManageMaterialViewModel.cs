using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilkTeaManager.Models;

namespace MilkTeaManager.ViewModels
{
    class ManageMaterialViewModel:BaseVM
    {
        private ObservableCollection<NHACUNGCAP> _nccs;
        private ObservableCollection<NGUYENLIEU> _nguyenlieus;

        private NGUYENLIEU _snguyenlieu;
        private NHACUNGCAP _sncc;
        private string _tennl;
        private string _mancc;
        private string _manl;
        private int _ketquatimthay;
        private int soluong;
        private string _tenncc;
        public string TenNCC
        {
            get { return _tenncc; }
            set { _tenncc = value;
                OnPropertyChanged();
            }
        }

        public string MaNL
        {
            get { return _mancc; }
            set { _mancc = value;
                OnPropertyChanged();
            }
        }
        public string TenNL
        {
            get { return _tennl; }
            set { _tennl = value;
                OnPropertyChanged();
            }
        }
        public string MaNCC
        {
            get { return _mancc; }
            set { _mancc = value;
                OnPropertyChanged();
            }
        }
        public NGUYENLIEU SNguyenLieu
        {
            get { return _snguyenlieu; }
            set { _snguyenlieu = value;
                OnPropertyChanged();
                MaNL = SNguyenLieu.MANL;
                TenNL = SNguyenLieu.TENNL;
                MaNCC = SNguyenLieu.MANCC;
                TenNCC = SNguyenLieu.NHACUNGCAP.TENNCC;
            }
        }
        public NHACUNGCAP SNCC
        {
            get { return _sncc; }
            set { _sncc = value;
                OnPropertyChanged();
                NguyenLieus = new ObservableCollection<NGUYENLIEU>(DataAccess.GetNguyenLieuByMaNCC(SNCC.MANCC));
                KQTT = NguyenLieus.Count();

            }
        }
        public int SoLuong
        {
            get { return soluong; }
            set
            {
                soluong = value;
                OnPropertyChanged();
            }
        }
        public int KQTT
        {
            get { return _ketquatimthay; }
            set
            {
                _ketquatimthay = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<NHACUNGCAP> NCCs
        {
            get { return _nccs; }
            set { _nccs = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<NGUYENLIEU> NguyenLieus
        {
            get { return _nguyenlieus; }
            set { _nguyenlieus = value;
                OnPropertyChanged();
            }
        }
        public ManageMaterialViewModel()
        {
            NCCs = new ObservableCollection<NHACUNGCAP>(DataAccess.GetNhacungcaps().ToList());
            NguyenLieus = new ObservableCollection<NGUYENLIEU>(DataAccess.GetNguyenlieus().ToList());
            SoLuong = NguyenLieus.Count();
            KQTT = SoLuong;
        }
    }
}
