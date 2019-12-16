using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilkTeaManager.Models;
using System.Windows;
using MilkTeaManager.Views.Dialog;
using MilkTeaManager.ViewModels.Dialog;

namespace MilkTeaManager.ViewModels
{
    public class SellProductViewModel : BaseVM
    {

        private ObservableCollection<SANPHAM> _sanphams;
        private ObservableCollection<SANPHAM> _toppings;
        private ObservableCollection<SIZE> _sizes;
        private ObservableCollection<CHITIETHOADON> _cthds;
        private HOADON _hoadon;

       
        private string _sdiachi;
        private string _ssdt;
        private string _stenkh;
        private string _soluong;
        private SANPHAM _ssanpham;
        private CHITIETHOADON _scthd;
        private SANPHAM _stopping;
        private SIZE _ssize;
        private int _tongtien;
        private int _tienkhachdua;
        private int _tienthua;
        public int TienThua
        {
            get { return _tienthua; }
            set { _tienthua = value;
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

        public string STenKH
        {
            get { return _stenkh; }
            set
            {
                _stenkh = value;
                OnPropertyChanged();
            }
        }
        public string SSDT
        {
            get { return _ssdt; }
            set
            {
                _ssdt = value;
                OnPropertyChanged();
            }
        }
        public string SDiaChi
        {
            get { return _sdiachi; }
            set
            {
                _sdiachi = value;
                OnPropertyChanged();
            }
        }
        public string SoLuong
        {
            get { return _soluong; }
            set
            {
                _soluong = value;
                OnPropertyChanged();
            }
        }
        public SANPHAM SSanPham
        {
            get { return _ssanpham; }
            set
            {
                _ssanpham = value;
                OnPropertyChanged();
            }
        }
        public CHITIETHOADON SCTHD
        {
            get { return _scthd; }
            set
            {
                _scthd = value;

                OnPropertyChanged();
                if (SCTHD != null)
                {
                    if (SCTHD.MASIZE == 1)
                        return;
                    SoLuong = SCTHD.SOLUONG.ToString();
                    SSanPham = SCTHD.SANPHAM;
                    SSize = SCTHD.SIZE;

                }
            }
        }
        public SANPHAM STopping
        {
            get { return _stopping; }
            set
            {
                _stopping = value;
                OnPropertyChanged();
            }
        }
        public SIZE SSize
        {
            get { return _ssize; }
            set
            {
                _ssize = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<SIZE> Sizes
        {
            get { return _sizes; }
            set
            {
                _sizes = value;
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
        public ObservableCollection<SANPHAM> Toppings
        {
            get { return _toppings; }
            set
            {
                _toppings = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<CHITIETHOADON> CTHDs
        {
            get { return _cthds; }
            set
            {
                _cthds = value;
                OnPropertyChanged();

            }
        }
        public void TinhTong()
        {
            var tong = 0;
            foreach (var item in CTHDs)
            {
                tong += (int)item.THANHTIEN;
            }

            TongTien = tong;
        }
        #region command
        public ICommand AddSanPhamCommand { get; set; }
        public ICommand AddToppingCommand { get; set; }
        public ICommand EditSanPhamCommand { get; set; }
        public ICommand LoadKhachHangCommand { get; set; }
        public ICommand DeleteSanPhamCommand { get; set; }
        public ICommand ThanhToanCommand { get; set; }


        #endregion

        public SellProductViewModel()
        {
            //int indexOfLastHD = DataAccess.db.HOADONs.Count();
            //if (DataAccess.db.HOADONs.ElementAt(indexOfLastHD).TONGTIEN == null)
            //{
            //    _hoadon = DataAccess.db.HOADONs.ElementAt(indexOfLastHD);
            //    _hoadon.NGAYLAP = DateTime.Now;
            //}
            //else
            _hoadon = new HOADON() { MANV = "NV001", NGAYLAP = DateTime.Now };
            _tongtien = 0;


            DataAccess.SaveHoaDon(_hoadon);
            SoLuong = "1";
            SanPhams = new ObservableCollection<SANPHAM>(DataAccess.GetSanphams());
            Toppings = new ObservableCollection<SANPHAM>(DataAccess.GetTopping());
            //CTHDs = new ObservableCollection<CHITIETHOADON>(DataAccess.GetChitiethoadonsByMaHD("HD001"));
            CTHDs = new ObservableCollection<CHITIETHOADON>();

            Sizes = new ObservableCollection<SIZE>(DataAccess.db.SIZEs.ToList());
            AddSanPhamCommand = new RelayCommand<object>((p) =>
            {
                if (SSanPham == null || SSize == null || string.IsNullOrEmpty(SoLuong))
                    return false;
                if (int.Parse(SoLuong) <= 0 || int.Parse(SoLuong) > 99)
                    return false;

                return true;

            }, (p) =>
            {

                var cthd = new CHITIETHOADON() { MASP = SSanPham.MASP, MASIZE = SSize.MASIZE, DONGIA = SSanPham.GIABAN, SOLUONG = int.Parse(SoLuong), MAHD = _hoadon.MAHD };
                DataAccess.SaveChiTietHoaDon(cthd);
                CTHDs.Add(cthd);
                TinhTong();
            });
            EditSanPhamCommand = new RelayCommand<object>((p) =>
            {

                if (SSanPham == null || SSize == null || SCTHD == null || SCTHD.SANPHAM.MALOAISP =="LSP001")
                    return false;
                if (int.Parse(SoLuong) <= 0 || int.Parse(SoLuong) > 99)
                    return false;
                return true;

            }, (p) =>
            {

                var cthd = new CHITIETHOADON() { MACTHD = SCTHD.MACTHD, MASP = SSanPham.MASP, MASIZE = SSize.MASIZE, DONGIA = SSanPham.GIABAN, SOLUONG = int.Parse(SoLuong), MAHD = _hoadon.MAHD };
                DataAccess.SaveChiTietHoaDon(cthd);
                SCTHD.MASP = cthd.MASP;
                SCTHD.MASIZE = cthd.MASIZE;
                SCTHD.SOLUONG = cthd.SOLUONG;
                TinhTong();
            });

            AddToppingCommand = new RelayCommand<object>((p) =>
            {
                if (STopping == null)
                    return false;

                return true;

            }, (p) =>
            {

                //var cthd = new CHITIETHOADON() { MASP = STopping.MASP, SOLUONG = 1, MASIZE = 1, MAHD = _hoadon.MAHD, DONGIA = STopping.GIABAN };

                //DataAccess.SaveChiTietHoaDon(cthd);
                //CTHDs.Add(cthd);
                var cthd = new CHITIETHOADON() { MASP = STopping.MASP, MASIZE = 1, DONGIA = STopping.GIABAN, SOLUONG = 1, MAHD = _hoadon.MAHD };
                DataAccess.SaveChiTietHoaDon(cthd);
                CTHDs.Add(cthd);
                TinhTong();
      
            });
            DeleteSanPhamCommand = new RelayCommand<object>((p) =>
            {

                if (SCTHD == null)
                    return false;
                return true;

            }, (p) =>
            {

                var cthd = DataAccess.db.CHITIETHOADONs.Where(x => x.MACTHD == SCTHD.MACTHD).ToList().ElementAt(0);

                DataAccess.DeleteChiTietHoaDon(cthd);
                CTHDs.Remove(SCTHD);
                TinhTong();
            });

           ThanhToanCommand = new RelayCommand<object>((p) =>
            {

                if (TongTien == 0 || TienKhachDua < TongTien)
                    return false;
                return true;

            }, (p) =>
            {
                _hoadon.TONGTIEN = TongTien;
                DataAccess.SaveHoaDon(_hoadon);
                OrderForm orderWD = new OrderForm();
                //var addVM2 = orderWD.DataContext as OrderFormViewModel;
                //addVM2.TongTien = _tongtien;
                orderWD.Show();
                //reset page
                //_hoadon = new HOADON { MANV = "NV001", NGAYLAP = DateTime.Now };
                //DataAccess.SaveHoaDon(_hoadon);
                //TongTien = 0;
                //TienKhachDua = 0;
                //TienThua = 0;
                //CTHDs.Clear();
                //SCTHD = new CHITIETHOADON();

            });
            LoadKhachHangCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                AddCustomer wd = new AddCustomer();
                wd.ShowDialog();
                var addVM = wd.DataContext as AddCustomerViewModel;
                if (addVM.KhachHang != null)
                {
                    STenKH = addVM.KhachHang.TENKH;
                    SSDT = addVM.KhachHang.SDT;
                    SDiaChi = addVM.KhachHang.DIACHI;
                    _hoadon.MAKH = addVM.KhachHang.MAKH;
                    DataAccess.SaveHoaDon(_hoadon);
                }
            });
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
