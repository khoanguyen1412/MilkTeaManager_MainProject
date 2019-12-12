using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilkTeaManager.Models;

namespace MilkTeaManager.ViewModels
{
    class ManageProductViewModel:BaseVM
    {
        private ObservableCollection<SANPHAM> _sanphams;
        private ObservableCollection<LOAISANPHAM> _loaisps;

        private SANPHAM _ssanpham;
        private LOAISANPHAM _sloaisp;

        public SANPHAM SSanPham
        {
            get { return _ssanpham; }
            set
            {
                _ssanpham = value;
                OnPropertyChanged();
            }
        }
        public LOAISANPHAM SLoaiSP
        {
            get { return _sloaisp; }
            set
            {
                _sloaisp = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<SANPHAM> SanPhams
        {
            get { return _sanphams; }
            set
            {
                _sanphams = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<LOAISANPHAM> LoaiSPs
        {
            get { return _loaisps; }
            set
            {
                _loaisps = value;
                OnPropertyChanged();
            }
        }
        public ManageProductViewModel()
        {
            SanPhams = new ObservableCollection<SANPHAM>(DataAccess.GetSanphams());
            LoaiSPs = new ObservableCollection<LOAISANPHAM>(DataAccess.GetLoaisanphams());
        }
    }
}
