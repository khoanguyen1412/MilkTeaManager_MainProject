using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilkTeaManager.Models;
namespace DataTesting
{
	 public class main
	{

		static void Main()
		{
            Console.OutputEncoding = Encoding.UTF8;
            foreach (var item in DataAccess.GetSanphams())
            {
                Console.WriteLine(item.TENSP);
            }
            NHACUNGCAP ncc = new NHACUNGCAP() { TENNCC = "ncc", DIACHINCC = "diachi" ,SDTNCC="012"};
            DataAccess.AddNCC(ncc);
            Console.Read();
		}
	}
}
    