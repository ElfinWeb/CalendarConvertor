using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderConvertor
{
    public static class MainService
    {
        private static DateTime date;
        private static string currentDate;

        public static string FromPersianToOther(string[] dates)
        {
            date = new DateTime(int.Parse(dates[0]), int.Parse(dates[1]),
               int.Parse(dates[2]), new PersianCalendar());

            currentDate = date.ToPersianCalendar();

            string dateTime = "Current Date : "+ currentDate + "\r\n" + 
                "To Gregorian Calendar : " + date.ToGregorianCalendar() + "\r\n" + "To Hijri Calendar : " +
                date.ToHijriCalendar();

            return dateTime;
        }

        public static string FromHijriToOther(string[] dates)
        {
            date = new DateTime(int.Parse(dates[0]), int.Parse(dates[1]),
               int.Parse(dates[2]), new HijriCalendar());

            currentDate = date.ToHijriCalendar();

            string dateTime = "Current Date : " + currentDate + "\r\n" +
                "To Persian Calendar : " + date.ToPersianCalendar() + "\r\n" + "To Gregorian Calendar : " +
                date.ToGregorianCalendar();

            return dateTime;
        }
        public static string FromGregorianToOther(string[] dates)
        {
            date = new DateTime(int.Parse(dates[0]), int.Parse(dates[1]),
               int.Parse(dates[2]), new GregorianCalendar());

            currentDate = date.ToGregorianCalendar();

            string dateTime = "Current Date : " + currentDate + "\r\n" +
                "To Persian Calendar : " + date.ToPersianCalendar() + "\r\n" + "To Hijri Calendar : " +
                date.ToHijriCalendar();

            return dateTime;
        }
    }
}
