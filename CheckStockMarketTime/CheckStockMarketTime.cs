using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckStockMarketTime
{
    public static class StockMarket
    {
        /// <summary>
        /// 判斷是否為台灣股市時間
        /// 周1-周5營業日, 9AM-1:30PM 是營業時間
        /// </summary>
        /// <param name="insertTime">輸入時間</param>
        /// <returns></returns>
        public static bool CheckTWStockMarketTime(DateTime insertTime) 
        { 
        if(insertTime.DayOfWeek.Equals(DayOfWeek.Saturday) || insertTime.DayOfWeek.Equals(DayOfWeek.Sunday)) return false;
        if(insertTime.TimeOfDay < new TimeSpan(9,0,0) || insertTime.TimeOfDay > new TimeSpan(13, 30, 0) ) return false; 
            
        return true;
        }
    }
}
