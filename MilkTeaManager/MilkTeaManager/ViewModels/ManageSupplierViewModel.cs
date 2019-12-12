using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilkTeaManager.Models;

namespace MilkTeaManager.ViewModels
{
    class ManageSupplierViewModel : BaseVM
    {
        private ObservableCollection<NHACUNGCAP> _nhacungcaps;


        private NHACUNGCAP _snhacungcap;


        public NHACUNGCAP SNhaCungCap
        {
            get { return _snhacungcap; }
            set
            {
                _snhacungcap = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<NHACUNGCAP> NhaCungCaps
        {
            get { return _nhacungcaps; }
            set
            {
                _nhacungcaps = value;
                OnPropertyChanged();
            }
        }

        public ManageSupplierViewModel()
        {
            NhaCungCaps = new ObservableCollection<NHACUNGCAP>(DataAccess.GetNhacungcaps());

        }
    }
}
