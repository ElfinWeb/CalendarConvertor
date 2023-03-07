using CalenderConvertor;
using System.Globalization;

Console.WriteLine("Please choose the calender type :");
Console.WriteLine("Persian calendar / Gregorian calendar / Hijri calendar");

string calendarType = Console.ReadLine();

Console.WriteLine("Please enter the date (Example : 2000/10/10) : ");

string dateInput = Console.ReadLine();

try
{
    if (dateInput != null)
    {
        string[] dates = dateInput.Split("/");

        if (calendarType.ToLower().Trim() == "gregoriancalendar")
        {
            Console.WriteLine(MainService.FromGregorianToOther(dates));
        }
        else if (calendarType.ToLower().Trim() == "persiancalendar")
        {
            Console.WriteLine(MainService.FromPersianToOther(dates));
        }
        else if (calendarType.ToLower().Trim() == "hijricalendar")
        {
            Console.WriteLine(MainService.FromHijriToOther(dates));
        }
    }
}
catch
{
    Console.WriteLine("Not Valid!");
}