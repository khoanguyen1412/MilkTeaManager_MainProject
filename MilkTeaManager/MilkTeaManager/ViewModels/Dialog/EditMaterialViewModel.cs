using MilkTeaManager.Models;
using MilkTeaManager.Views.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MilkTeaManager.ViewModels.Dialog
{
    class EditMaterialViewModel : BaseVM
    {
        public ObservableCollection<NHACUNGCAP> NhaCC { get; set; }
        private ObservableCollection<NGUYENLIEU> _nguyenlieus;
        private ObservableCollection<DONVITINH> _dvts;

        private string _sTenNL;
        private string _sGiaNhap;
        private string _sGiaBan;
        private string _sNhaCC;
        private NGUYENLIEU _nguyenLieu;
        

        public string STenNL
        {
            get => _sTenNL; set
            {
                _sTenNL = value;
                OnPropertyChanged();
            }
        }
        public string SGiaNhap
        {
            get => _sGiaNhap;
            set
            {
                _sGiaNhap = value;
                OnPropertyChanged();
            }
        }
        public string SGiaBan
        {
            get => _sGiaBan; set
            {
                _sGiaBan = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<DONVITINH> DVTs
        {
            get { return _dvts; }
            set
            {
                _dvts = value;
                OnPropertyChanged();
            }
        }
        public string SNhaCC
        {
            get => _sNhaCC;
            set
            {
                _sNhaCC = value;
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

        public ICommand UpdateCommand { get; set; }
        public NGUYENLIEU NguyenLieu
        {
            get => _nguyenLieu; set
            {
                _nguyenLieu = value;
                OnPropertyChanged();
            }
        }
        public EditMaterialViewModel()
        {
            ManageMaterial wd = new ManageMaterial();
            var dc = wd.DataContext as ManageMaterialViewModel;
            STenNL = dc.TenNL;
            SGiaNhap = dc.SNguyenLieu.GIANHAP.ToString();
            SGiaBan = dc.SNguyenLieu.GIAXUAT.ToString();
            SNhaCC = dc.TenNCC;
            NhaCC = dc.NCCs;
            NguyenLieus = dc.NguyenLieus;
            DVTs = new ObservableCollection<DONVITINH>(DataAccess.GetDonvitinhs());
            UpdateCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(STenNL) || string.IsNullOrEmpty(SNhaCC) || string.IsNullOrEmpty(SGiaBan) || string.IsNullOrEmpty(SGiaNhap))
                {
                    return false;
                }
                return true;

            }, (p) =>
            {

                NguyenLieu = new NGUYENLIEU() { TENNL = STenNL, GIANHAP = Int32.Parse(SGiaNhap), GIAXUAT = Int32.Parse(SGiaBan), MANCC = DataAccess.GetNhacungcapByTenNCC(SNhaCC).MANCC, MANL = dc.MaNL };
                DataAccess.SaveNguyenLieu(NguyenLieu);
                ManageMaterial NguyenLieuWindow = new ManageMaterial();
                if (NguyenLieuWindow.DataContext == null)
                    return;
                var MMaterialVM = NguyenLieuWindow.DataContext as ManageMaterialViewModel;
                MMaterialVM.NguyenLieus = new ObservableCollection<NGUYENLIEU>(DataAccess.GetNguyenlieus());
            });


        }
    }
}
