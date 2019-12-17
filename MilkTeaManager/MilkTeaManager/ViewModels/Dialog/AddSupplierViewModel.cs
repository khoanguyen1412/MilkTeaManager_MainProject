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
    class AddSupplierViewModel : BaseVM
    {
        private string _sTenNCC;
        private string _sSDT;
        private string _sDiaChi;
        private string _sEmail;
        private DateTime? _sNgayHopTac;
        private string _sNL;
        private NHACUNGCAP _nhaCungCap;

        public string STenNCC
        {
            get => _sTenNCC; set
            {
                _sTenNCC = value;
                OnPropertyChanged();
            }
        }
        public string SSDT
        {
            get => _sSDT; set
            {
                _sSDT = value;
                OnPropertyChanged();
            }
        }
        public string SDiaChi
        {
            get => _sDiaChi; set
            {
                _sDiaChi = value;
                OnPropertyChanged();
            }
        }
        public string SEmail
        {
            get => _sEmail; set
            {
                _sEmail = value;
                OnPropertyChanged();
            }
        }
        public DateTime? SNgayHopTac
        {
            get => _sNgayHopTac; set
            {
                _sNgayHopTac = value;
                OnPropertyChanged();
            }
        }
        public string SNL
        {
            get => _sNL; set
            {
                _sNL = value;
                OnPropertyChanged();
            }
        }

        public NHACUNGCAP NhaCungCap
        {
            get => _nhaCungCap; set
            {
                _nhaCungCap = value;
            }
        }

        public ICommand SaveCommand { get; set; }

        public AddSupplierViewModel()
        {
            SaveCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(STenNCC) || string.IsNullOrEmpty(SDiaChi) || string.IsNullOrEmpty(SSDT) || string.IsNullOrEmpty(SEmail) )
                {
                    return false;
                }
                return true;

            }, (p) =>
            {

                NhaCungCap = new NHACUNGCAP() { TENNCC = STenNCC,DIACHINCC=SDiaChi, NGAYHOPTAC = SNgayHopTac, SDTNCC = SSDT, EMAILNCC = SEmail, TT = 1, TINHTRANG = "Hợp tác" };
                DataAccess.SaveNhaCungCap(NhaCungCap);
                ManageSupplier ManageSupplierWindow = new ManageSupplier();
                if (ManageSupplierWindow.DataContext == null)
                    return;
                var MSupVM = ManageSupplierWindow.DataContext as ManageSupplierViewModel;
                MSupVM.NhaCungCaps = new ObservableCollection<NHACUNGCAP>(DataAccess.GetNhacungcaps());
            });
        }
    }
}
