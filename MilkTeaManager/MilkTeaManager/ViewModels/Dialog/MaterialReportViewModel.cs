using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MilkTeaManager.Models;
namespace MilkTeaManager.ViewModels.Dialog
{
    class MaterialReportViewModel : BaseVM
    {
        private string _nguoilap;
        private DateTime _ngaylap;
        private DateTime _tungay;
        private DateTime _denngay;
        private int _tongthu;
        private int _soluong;
        private ObservableCollection<NGUYENLIEU> _nguyenlieus;

        public int SoLuong
        {
            get { return _soluong; }
            set { _soluong = value;
                OnPropertyChanged();
            }
        }
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
        public ObservableCollection<NGUYENLIEU> NguyenLieus
        {
            get { return _nguyenlieus; }
            set
            {
                _nguyenlieus = value;
                OnPropertyChanged();
            }
        }
        public MaterialReportViewModel()
        {
            NgayLap = DateTime.Now;
            NguyenLieus = new ObservableCollection<NGUYENLIEU>(DataAccess.GetNguyenlieus());
            var tongthu = 0;
            foreach (var item in NguyenLieus)
            {

            }
            TongThu = tongthu;
        }
    }
}
