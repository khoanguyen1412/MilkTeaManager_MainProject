//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using MilkTeaManager.ViewModels;
namespace MilkTeaManager.Models
{
    using System;
    using System.Collections.Generic;

    public partial class CHITIETHOADON : BaseVM
    {
        private SANPHAM _sp;
        private SIZE _size;
        private int _soluong;
        private int _dongia;
        private int _thanhtien;
        public string MACTHD { get; set; }
        public string MASP { get; set; }
        public Nullable<int> SOLUONG
        {
            get { return _soluong; }
            set
            {
                _soluong = (int)value;
                OnPropertyChanged();
            }
        }
        public Nullable<int> DONGIA { get { return _dongia; } set { _dongia = (int)value; OnPropertyChanged(); } }
        public string MAHD { get; set; }
        public Nullable<int> MASIZE
        {
            get;
            set;
        }
        public Nullable<int> THANHTIEN { get { return _thanhtien; } set { _thanhtien = (int)value; OnPropertyChanged(); } }

        public virtual HOADON HOADON { get; set; }
        public virtual SANPHAM SANPHAM { get { return _sp; } set { _sp = value; OnPropertyChanged(); } }
        public virtual SIZE SIZE { get { return _size; } set { _size = value; OnPropertyChanged(); } }
    }
}
