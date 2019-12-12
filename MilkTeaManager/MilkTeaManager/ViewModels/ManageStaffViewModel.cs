using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilkTeaManager.Models;

namespace MilkTeaManager.ViewModels
{
    class ManageStaffViewModel : BaseVM
    {
        private ObservableCollection<NHANVIEN> _nhanviens;


        private NHANVIEN _snhanvien;


        public NHANVIEN SNhanVien
        {
            get { return _snhanvien; }
            set
            {
                _snhanvien = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<NHANVIEN> NhanViens
        {
            get { return _nhanviens; }
            set
            {
                _nhanviens = value;
                OnPropertyChanged();
            }
        }

        public ManageStaffViewModel()
        {
            NhanViens = new ObservableCollection<NHANVIEN>(DataAccess.GetNhanviens());

        }
    }
}
