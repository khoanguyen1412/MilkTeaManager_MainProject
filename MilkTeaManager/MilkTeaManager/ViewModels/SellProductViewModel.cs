﻿using System;
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

namespace MilkTeaManager.ViewModels
{
    public class SellProductViewModel: BaseVM
    {
        private ObservableCollection<SANPHAM> _sanphams;
        private ObservableCollection<SANPHAM> _toppings;
        private ObservableCollection<SIZE> _sizes;
        private ObservableCollection<CHITIETHOADON> _cthds;

        private int _soluong;
        private SANPHAM _ssanpham;
        private CHITIETHOADON _scthd;
        private SANPHAM _stopping;
        private SIZE _ssize;

        public int SoLuong
        {
            get { return _soluong; }
            set { _soluong = value;
                OnPropertyChanged();
            }
        }
        public SANPHAM SSanPham
        {
            get { return _ssanpham; }
            set { _ssanpham = value;
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
                    SoLuong = (int)SCTHD.SOLUONG;
                    SSanPham = SCTHD.SANPHAM;
                    SSize = SCTHD.SIZE;
                }
            }
        }
        public SANPHAM STopping
        {
            get { return _stopping; }
            set { _stopping = value;
                OnPropertyChanged();
            }
        }
        public SIZE SSize
        {
            get { return _ssize; }
            set { _ssize = value;
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
            set { _sanphams = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<SANPHAM> Toppings
        {
            get { return _toppings; }
            set { _toppings = value;
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

        #region command
        public ICommand AddSanPhamCommand { get; set; }
        public ICommand AddToppingCommand { get; set; }
        public ICommand EditSanPhamCommand { get; set; }
        public ICommand LoadKhachHangCommand { get; set; }
        public ICommand DeleteSanPham { get; set; }
        #endregion

        public SellProductViewModel()
        {
            SoLuong = 1;
            SanPhams = new ObservableCollection<SANPHAM>(DataAccess.GetSanphams());
            Toppings = new ObservableCollection<SANPHAM>(DataAccess.GetTopping());
            CTHDs = new ObservableCollection<CHITIETHOADON>(DataAccess.GetChitiethoadonsByMaHD("hd01"));
            Sizes = new ObservableCollection<SIZE>(DataAccess.GetSizes());
            AddSanPhamCommand = new RelayCommand<object>((p) =>
            {
                if (SSanPham == null || SSize == null || SoLuong <= 0 || SCTHD != null)
                    return false;

                return true;

            }, (p) =>
            {
               
                var cthd = new CHITIETHOADON() { MASP = SSanPham.MASP, MASIZE = SSize.MASIZE,DONGIA=SSanPham.GIABAN, SOLUONG = SoLuong };
                DataAccess.SaveChiTietHoaDon(cthd);
                CTHDs.Add(cthd);
            });
            EditSanPhamCommand = new RelayCommand<object>((p) =>
            {

                if (SSanPham == null || SSize == null || SCTHD == null)
                    return false;

                return true;

            }, (p) =>
            {
               
                var cthd = new CHITIETHOADON() { MACTHD = "00002", MASP = SSanPham.MASP, MASIZE = SSize.MASIZE, DONGIA = SSanPham.GIABAN, SOLUONG = SoLuong };
                DataAccess.SaveChiTietHoaDon(cthd);
                SCTHD.MASP = SSanPham.MASP;
                SCTHD.MASIZE = SSize.MASIZE;
                SCTHD.SOLUONG = SoLuong;
            });
           
            AddToppingCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(SCTHD.MASP))
                    return false;

                return true;

            }, (p) =>
            {

                var cthd = new CHITIETHOADON() { MASP = STopping.MASP, SOLUONG = 1, MASIZE=1  };

                DataAccess.SaveChiTietHoaDon(cthd);
                CTHDs.Add(cthd);
            });
            LoadKhachHangCommand = new RelayCommand<object>((p) => { return true; }, (p) => { AddCustomer wd = new AddCustomer(); wd.ShowDialog(); });
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