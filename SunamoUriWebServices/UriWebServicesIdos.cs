namespace SunamoUriWebServices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

public class UriWebServicesIdos
{
    public static string Train(string from, string to)
    {
        // Determine which month's 13th is the end of the current timetable.
        DateTime today = DateTime.Today;
        int year = today.Year;
        int month = today.Month;

        // If we're past the 13th of the current month, the current timetable ends on the 13th of the next month
        if (today.Day > 13)
        {
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
        }

        DateTime target = new DateTime(year, month, 13);

        // If the 13th is Saturday or Sunday, step back to the last weekday (Fri)
        while (target.DayOfWeek == DayOfWeek.Saturday || target.DayOfWeek == DayOfWeek.Sunday)
        {
            target = target.AddDays(-1);
        }

        string dateStr = target.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);

        return $"https://idos.cz/vlaky/spojeni/vysledky/?date={dateStr}&time=07:00&f={from}&fc=1&t={to}&tc=1";
    }
}