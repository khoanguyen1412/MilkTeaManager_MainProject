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
			foreach (var item in DataAccess.GetLoaisanphams())
			{
				Console.WriteLine(item.TENLOAISP);
			}

			Console.Read();
		}
	}
}
