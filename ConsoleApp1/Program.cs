using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiwanStock.Utilities;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("請輸入交易日期，例如2022/10/31 9:00:");
			
			string input=Console.ReadLine();
			bool isDate=DateTime.TryParse(input, out DateTime dt);
			if(isDate==false)
			{
				Console.WriteLine("請輸入正確日期格式");
				return;	
			}	
			var tradeDay = new TaiwanStockUtility().IsTradingTime(dt);
			Console.WriteLine($"是否為交易時間:{tradeDay}");
			



		}
	}
}
