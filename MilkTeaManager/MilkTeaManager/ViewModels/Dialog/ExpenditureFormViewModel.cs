using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MilkTeaManager.Models;
namespace MilkTeaManager.ViewModels.Dialog
{
    class ExpenditureFormViewModel : BaseVM
    {
        private string _nguoilap;
        private DateTime _ngaylap;
        private DateTime _tungay;
        private DateTime _denngay;
        private int _tongthu;
        private ObservableCollection<PHIEUNHAP> _phieunhaps;

        public int TongThu
        {
            get { return _tongthu; }
            set
            {
                _tongthu = value;
                OnPropertyChanged();
            }
        }
        public string NguoiLap
        {
            get { return _nguoilap; }
            set
            {
                _nguoilap = value;
                OnPropertyChanged();
            }
        }
        public DateTime NgayLap
        {
            get { return _ngaylap; }
            set
            {
                _ngaylap = value;
                OnPropertyChanged();
            }
        }
        public DateTime TuNgay
        {
            get { return _tungay; }
            set
            {
                _tungay = value;
                OnPropertyChanged();
            }
        }
        public DateTime DenNgay
        {
            get { return _denngay; }
            set
            {
                _denngay = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<PHIEUNHAP> PhieuNhaps
        {
            get { return _phieunhaps; }
            set
            {
                _phieunhaps = value;
                OnPropertyChanged();
            }
        }
        public ExpenditureFormViewModel()
        {
            NgayLap = DateTime.Now;
            PhieuNhaps = new ObservableCollection<PHIEUNHAP>(DataAccess.GetPhieuNhaps());
            var tongthu = 0;
            foreach (var item in PhieuNhaps)
            {
                
            }
            TongThu = tongthu;
        }
    }
}
