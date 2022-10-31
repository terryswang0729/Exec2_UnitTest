using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiwanStock.Utilities
{
	public class TaiwanStockUtility
	{
		public bool IsTradingTime(DateTime dt)
		{
			
			int dayOfWeek=(int)dt.DayOfWeek;
		    int tradeEndDay = 5, tradeStartDay = 1;
			TimeSpan tradeTime=dt.TimeOfDay;
			TimeSpan tradeTimeStart = new TimeSpan(9, 0, 0);
			TimeSpan tradeTimeEnd = new TimeSpan(13,30, 0);
			if (dayOfWeek > tradeEndDay||dayOfWeek<tradeStartDay) 
			{
				return false;
			}
			else if(tradeTime < tradeTimeStart || tradeTime > tradeTimeEnd)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	
	
		 
	}
}
