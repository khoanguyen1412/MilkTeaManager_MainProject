using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilkTeaManager.Models;
namespace MilkTeaManager.ViewModels
{
    public class SellProductViewModel
    {
        private ObservableCollection<SANPHAM> _sanphams;
        

        private SANPHAM _ssanpham;

        public SANPHAM SSanPham
        {
            get { return _ssanpham; }
            set { _ssanpham = value; }
        }
        public ObservableCollection<SANPHAM> SanPhams
        {
            get { return _sanphams; }
            set { _sanphams = value; }
        }


        public SellProductViewModel()
        {
            SanPhams = new ObservableCollection<SANPHAM>(DataAccess.GetSanphams());
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        
        public List<HOADON> getChiTiet
        {
            get
            {
                return DataAccess.GetHoadons();
            }
        }
    }
}
