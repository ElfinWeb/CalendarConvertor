using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderConvertor
{
    public static class DateConvertor
    {
        public static string ToPersianCalendar(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();

            string dateTime = pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00")
                + "/" + pc.GetDayOfMonth(value).ToString("00");
            return dateTime;
        }

        public static string ToGregorianCalendar(this DateTime value)
        {
            GregorianCalendar gc = new GregorianCalendar();

            string dateTime = gc.GetYear(value) + "/" + gc.GetMonth(value).ToString("00")
                + "/" + gc.GetDayOfMonth(value).ToString("00");
            return dateTime;
        }

        public static string ToHijriCalendar(this DateTime value)
        {
            HijriCalendar hc = new HijriCalendar();

            string dateTime = hc.GetYear(value) + "/" + hc.GetMonth(value).ToString("00")
                + "/" + hc.GetDayOfMonth(value).ToString("00");
            return dateTime;
        }
    }
}
