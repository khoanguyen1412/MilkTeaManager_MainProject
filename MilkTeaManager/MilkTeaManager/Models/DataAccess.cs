﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Controls;
using System.Windows.Data;
using DataException = System.Data.DataException;
using EntityState = System.Data.Entity.EntityState;
using Exception = System.Exception;


namespace MilkTeaManager.Models
{
	public class DataAccess
	{

		public static TRASUAEntities1 GetEntities1()
		{
			return new TRASUAEntities1();
		}

        public static TRASUAEntities1 db = GetEntities1();
		#region Get_Object_By_Id
		public static SANPHAM GetSanphambyMaSP(string maSp)
		{
			 
			{
				try
				{
					var result = db.SANPHAMs.Where(x => x.MASP == maSp).ToList();
					return result.ElementAt(0);
				}
				catch (DataException)
				{
					return new SANPHAM();
				}

			}
		}

		public static LOAISANPHAM GetLoaisanphambyMaLSP(string maLsp)
		{
			 
			{
				try
				{
					var result = db.LOAISANPHAMs.Where(x => x.MALOAISP == maLsp).ToList();
					return result.ElementAt(0);
				}
				catch (DataException)
				{
					return new LOAISANPHAM();
				}
			}
		}

		public static NHANVIEN GetNhanvienByMaNV(string maNv)
		{
			 
			{
				try
				{
					var result = db.NHANVIENs.Where(x => x.MANV == maNv).ToList();
					return result.ElementAt(0);
				}
				catch (DataException)
				{
					return new NHANVIEN();
				}
			}
		}

		public static LOAINHANVIEN GetLoainhanvienbyMaLoaiNV(string maLnv)
		{
			 
			{
				try
				{
					var result = db.LOAINHANVIENs.Where(x => x.MALOAINV == maLnv).ToList();
					return result.ElementAt(0);
				}
				catch (DataException)
				{
					return new LOAINHANVIEN();
				}
			}
		}

		public static KHACHHANG GetKhachhangbyMaKH(string maKh)
		{
			 
			{
				try
				{
					var result = db.KHACHHANGs.Where(x => x.MAKH == maKh).ToList();
					return result.ElementAt(0);
				}
				catch (DataException)
				{
					return new KHACHHANG();
				}
			}
		}

		public static NHACUNGCAP GetNhacungcapByMaNCC(string maNcc)
		{
			 
			{
				try
				{
					var result = db.NHACUNGCAPs.Where(x => x.MANCC == maNcc).ToList();
					return result.ElementAt(0);
				}
				catch (DataException)
				{
					return new NHACUNGCAP();
				}
			}
		}

		public HOADON GetHoadonByMaHD(string maHd)
		{
			 
			{
				try
				{
					var result = db.HOADONs.Where(x => x.MAHD == maHd).ToList();
					return result.ElementAt(0);
				}
				catch (DataException)
				{
					return new HOADON();
				}
			}
		}

		public CHITIETHOADON GetChitiethoadonByMaCTHD(string maCthd)
		{
			 
			{
				try
				{
					var result = db.CHITIETHOADONs.Where(x => x.MACTHD == maCthd);
					return result.ToList().ElementAt(0);
				}
				catch (DataException)
				{
					return new CHITIETHOADON();
				}
			}
		}

		public CHITIETNGUYENLIEU GetChoChitietnguyenlieuByMaCTNL(string maCtnl)
		{
			 
			{
				try
				{
					return db.CHITIETNGUYENLIEUx.Where(x => x.MACTNL == maCtnl).ToList().ElementAt(0);
				}
				catch (DataException)
				{
					return new CHITIETNGUYENLIEU();
				}
			}
		}

		public DONVITINH GetDonvitinhbByMaDVT(string maDvt)
		{
			 
			{
				try
				{
					return db.DONVITINHs.Where(x => x.madvt == maDvt).ToList().ElementAt(0);
				}
				catch (DataException)
				{
					return new DONVITINH();
				}
			}
		}

		public NGUYENLIEU GetNguyenlieuByMaNL(string maNl)
		{
			 
			{
				try
				{
					return db.NGUYENLIEUx.Where(x => x.MANL == maNl).ToList().ElementAt(0);
				}
				catch (DataException)
				{
					return new NGUYENLIEU();
				}
			}
		}

		#endregion

		#region Get_List_Object

        public static List<SANPHAM> GetTopping()
        {
            using (var db=GetEntities1())
            {
                try
                {
                    return db.SANPHAMs.Where(x => x.LOAISANPHAM.MALOAISP.ToString() == "loaisp02").ToList();
                }
                catch (DataException)
                {
                    return new List<SANPHAM>();
                }
            }
        }
        
		public static List<CHITIETHOADON> GetChitiethoadonsByMaHD(string maHd)
		{
			 
			{
				try
				{
					return db.CHITIETHOADONs.Where(x => x.MAHD == maHd).ToList();
				}
				catch (DataException)
				{
                   
					return new List<CHITIETHOADON>();
				}
			}
		}

		public static List<CHITIETNGUYENLIEU> GetChitietnguyenlieusByMaSp(string maSp)
		{
			 
			{
				try
				{
					return db.CHITIETNGUYENLIEUx.Where(x => x.MASP == maSp).ToList();
				}
				catch (DataException)
				{
					return new List<CHITIETNGUYENLIEU>();
				}
			}
		}

		public static List<DONVITINH> GetDonvitinhs()
		{
			 
			{
				try
				{
					return db.DONVITINHs.ToList();
				}
				catch (DataException)
				{
					return new List<DONVITINH>();
				}
			}
		}

		public static List<HOADON> GetHoadons()
		{
			 
			{
				try
				{
					return db.HOADONs.ToList();
				}
				catch (DataException)
				{
					return new List<HOADON>();
				}
			}
		}

		public static List<KHACHHANG> GetKhachhangs()
		{
			 
			{
				try
				{
					return db.KHACHHANGs.ToList();
				}
				catch (DataException)
				{
					return new List<KHACHHANG>();
				}
			}
		}

		public static List<LOAINHANVIEN> GetLoainhanviens()
		{
			 
			{
				try
				{
					return db.LOAINHANVIENs.ToList();
				}
				catch (DataException)
				{
					return new List<LOAINHANVIEN>();
				}
			}
		}

		public static List<LOAISANPHAM> GetLoaisanphams()
		{
			 
			{
				try
				{
					return db.LOAISANPHAMs.ToList();
				}
				catch (DataException)
				{
					return new List<LOAISANPHAM>();
				}
			}
		}

		public static List<NGUYENLIEU> GetNguyenlieus()
		{
			 
			{
				try
				{
					return db.NGUYENLIEUx.ToList();
				}
				catch (DataException)
				{
					return new List<NGUYENLIEU>();
				}
			}
		}


		public static List<NHACUNGCAP> GetNhacungcaps()
		{
			 
			{
				try
				{
					return db.NHACUNGCAPs.ToList();
				}
				catch (DataException)
				{
					return new List<NHACUNGCAP>();
				}
			}
		}

		public static List<NHANVIEN> GetNhanviens()
		{
			 
			{
				try
				{
					return db.NHANVIENs.ToList();
				}
				catch (DataException)
				{
					return new List<NHANVIEN>();
				}
			}
		}

		public static List<SANPHAM> GetSanphams()
		{
			 
			{
				try
				{
					return db.SANPHAMs.ToList();
				}
				catch (DataException)
				{
					return new List<SANPHAM>();
				}
			}
		}
        public static List<SIZE> GetSizes()
        {

            {
                try
                {
                    return db.SIZEs.ToList();
                }
                catch (DataException)
                {
                    return new List<SIZE>();
                }
            }
        }
        #endregion

        #region Add_Or_Update  //Không chắc xài được

        public static void SaveChiTietHoaDon(CHITIETHOADON cthd)
		{
			 
			{
				try
				{
					db.CHITIETHOADONs.AddOrUpdate(cthd);
					db.SaveChanges();
				}
				catch (DataException)
				{
					return;
				}
			}
		}


		public static void SaveChiTietNguyenLieu(CHITIETNGUYENLIEU ctnl)
		{
			 
			{
				try
				{
					db.CHITIETNGUYENLIEUx.AddOrUpdate(ctnl);
					db.SaveChanges();
				}
				catch (DataException)
				{
					return;
				}
			}
		}

		public static void SaveDonViTinh(DONVITINH dvt)
		{
			 
			{
				db.DONVITINHs.AddOrUpdate(dvt);
				db.SaveChanges();
			}

		}

		public static void SaveHoaDon(HOADON hd)
		{
			 
			{
				try
				{
					db.HOADONs.AddOrUpdate(hd);
					db.SaveChanges();
				}
				catch (DataException)
				{
					return;
				}
			}
		}

		public static void SaveKhachHang(KHACHHANG kh)
		{
			 
			{
				try
				{
					db.KHACHHANGs.AddOrUpdate(kh);
					db.SaveChanges();
				}
				catch (DataException)
				{
					return;
				}
			}
		}

		public static void SaveLoaiNhanVien(LOAINHANVIEN lnv)
		{
			 
			{
				try
				{
					db.LOAINHANVIENs.AddOrUpdate(lnv);
					db.SaveChanges();
				}
				catch (DataException)
				{
					return;
				}
			}
		}

		public static void SaveLoaiSanPham(LOAISANPHAM lsp)
		{
			 
			{
				try
				{
					db.LOAISANPHAMs.AddOrUpdate(lsp);
					db.SaveChanges();
				}
				catch (DataException)
				{
					return;
				}
			}
		}

		public static void SaveNguyenLieu(NGUYENLIEU nl)
		{
			 
			{
				try
				{
					db.NGUYENLIEUx.AddOrUpdate(nl);
					db.SaveChanges();
				}
				catch (DataException)
				{
					return;
				}
			}
		}

		public static void SaveNhaCungCap(NHACUNGCAP ncc)
		{
			 
			{
				try
				{
					db.NHACUNGCAPs.AddOrUpdate(ncc);
					db.SaveChanges();
				}
				catch (DataException)
				{
					return;
				}
			}
		}

		public static void SaveNhanVien(NHANVIEN nv)
		{
			 
			{
				try
				{
					db.NHANVIENs.AddOrUpdate(nv);
					db.SaveChanges();
				}
				catch (DataException)
				{
					return;
				}
			}
		}

		public static void SaveSanPham(SANPHAM sp)
		{
			 
			{
				try
				{
					db.SANPHAMs.AddOrUpdate(sp);
					db.SaveChanges();
				}
				catch (DataException)
				{
					return;
				}
			}
		}
		#endregion


		#region Filter_By_ten

		public static List<SANPHAM> FilterSanPhamByTenSP(string tenSp)
		{
			 
			{
				try
				{
					var matches = from m in db.SANPHAMs where m.TENSP.ToLower().Contains(tenSp.ToLower()) select m;
					return matches.ToList();
				}
				catch (DataException)
				{
					return new List<SANPHAM>();
				}
			}
		}

		public static List<KHACHHANG> FilterKhachhangByTenKH(string tenKh)
		{
			 
			{
				try
				{
					var matches = from m in db.KHACHHANGs where m.TENKH.ToLower().Contains(tenKh.ToLower()) select m;
					return matches.ToList();

				}
				catch (DataException)
				{
					return new List<KHACHHANG>();
				}
			}
		}

		public static List<NHANVIEN> FilterNhanvienByTenNV(string tenNv)
		{
			 
			{
				try
				{
					var matches = from m in db.NHANVIENs where m.HOTEN.ToLower().Contains(tenNv.ToLower()) select m;
					return matches.ToList();
				}
				catch (DataException)
				{
					return new List<NHANVIEN>();
				}
			}
		}
		#endregion


		#region Filter_Object_By_LikeID

		public static List<CHITIETHOADON> FilterChitiethoadonsByID(string maCthd)
		{
			 
			{
				try
				{
					var matches = from m in db.CHITIETHOADONs where m.MACTHD.ToLower().Contains(maCthd.ToLower()) select m;
					return matches.ToList();
				}
				catch (DataException)
				{
					return new List<CHITIETHOADON>();
				}
			}
		}

		public static List<NHANVIEN> FilterNhanvienByMaNV(string maNv)
		{
			 
			{
				try
				{
					var matches = from m in db.NHANVIENs where m.MANV.ToLower().Contains(maNv.ToLower()) select m;
					return matches.ToList();
				}
				catch (DataException)
				{
					return new List<NHANVIEN>();
				}
			}
		}

		public static List<NGUYENLIEU> FilterNguyenlieuByMaNL(string maNl)
		{
			 
			{
				try
				{
					var matches = from m in db.NGUYENLIEUx where m.MANL.ToLower().Contains(maNl.ToLower()) select m;
					return matches.ToList();
				}
				catch (DataException)
				{
					return new List<NGUYENLIEU>();
				}
			}
		}


		#endregion

	}
}