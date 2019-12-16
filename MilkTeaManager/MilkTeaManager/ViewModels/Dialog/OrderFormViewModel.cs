using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilkTeaManager.Models;
namespace MilkTeaManager.ViewModels.Dialog
{
    class OrderFormViewModel:BaseVM
    {
        private ObservableCollection<CHITIETHOADON> _cthds;
        private int _tongtien;
        private int _tienkhachdua;
        private int _tienthua;
        public ObservableCollection<CHITIETHOADON> CTHDs
        {
            get { return _cthds; }
            set
            {
                _cthds = value;
                OnPropertyChanged();

            }
        }
        public int TienThua
        {
            get { return _tienthua; }
            set
            {
                _tienthua = value;
                OnPropertyChanged();
            }
        }

        public int TongTien
        {
            get { return _tongtien; }
            set
            {
                _tongtien = value;
                OnPropertyChanged();
            }
        }
        public int TienKhachDua
        {
            get { return _tienkhachdua; }
            set
            {
                _tienkhachdua = value;
                OnPropertyChanged();
                TienThua = TienKhachDua - TongTien;
            }
        }

        public OrderFormViewModel()
        {
            

        }
    }
}
