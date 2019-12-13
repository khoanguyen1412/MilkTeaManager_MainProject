using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilkTeaManager.Models;

namespace MilkTeaManager.ViewModels
{
    class MaterialReportViewModel:BaseVM
    {
        private ObservableCollection<NHACUNGCAP> _nhaccs;
        private NHACUNGCAP _snhacc;
        private ObservableCollection<NGUYENLIEU> _nguyenlieus;
        private NGUYENLIEU _snguyenlieu;
        public ObservableCollection<NGUYENLIEU> NguyenLieus
        {
            get { return _nguyenlieus; }
            set
            {
                _nguyenlieus = value;
                OnPropertyChanged();
            }
        }
        public NGUYENLIEU SNguyenLieu
        {
            get { return _snguyenlieu; }
            set
            {
                _snguyenlieu = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<NHACUNGCAP> NhaCCs
        {
            get { return _nhaccs; }
            set { _nhaccs = value;
                OnPropertyChanged();
            }
        }
        public NHACUNGCAP SNhaCC
        {
            get { return _snhacc; }
            set
            {
                _snhacc = value;
                OnPropertyChanged();
            }
        }
        public MaterialReportViewModel()
        {

        }
    }
}
