using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MilkTeaManager.Models;
using MilkTeaManager.Views.Pages;

namespace MilkTeaManager.ViewModels.Dialog
{
    class AddNewMaterialViewModel : BaseVM
    {
        public ObservableCollection<string> NhaCC { get; set; }

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
        public string SNhaCC
        {
            get => _sNhaCC;
            set
            {
                _sNhaCC = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; set; }
        public NGUYENLIEU NguyenLieu
        {
            get => _nguyenLieu; set
            {
                _nguyenLieu = value;
                OnPropertyChanged();
            }
        }

        public AddNewMaterialViewModel()
        {
            NhaCC = new ObservableCollection<string>(DataAccess.GetTenNCC());
            SaveCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(STenNL) || string.IsNullOrEmpty(SNhaCC) || string.IsNullOrEmpty(SGiaBan) || string.IsNullOrEmpty(SGiaNhap))
                {
                    return false;
                }
                return true;

            }, (p) =>
            {

                NguyenLieu = new NGUYENLIEU() {TENNL=STenNL, GIANHAP=Int32.Parse(SGiaNhap), GIAXUAT=Int32.Parse(SGiaBan),MANCC=DataAccess.GetNhacungcapByTenNCC(SNhaCC).MANCC};
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
