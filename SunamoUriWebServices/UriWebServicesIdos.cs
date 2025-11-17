namespace SunamoUriWebServices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

public class UriWebServicesIdos
{
    /// <summary>
    /// EN: Calculates the target date for train timetable based on the input date
    /// CZ: Vypočítá cílové datum pro jízdní řád vlaků na základě vstupního data
    /// </summary>
    /// <param name="inputDate">EN: The date to calculate from / CZ: Datum, ze kterého se počítá</param>
    /// <returns>EN: The calculated target date / CZ: Vypočtené cílové datum</returns>
    public static DateTime CalculateTargetDate(DateTime inputDate)
    {
        // EN: Determine the number of days to add based on whether we're past mid-December
        // CZ: Určíme počet dní k přičtení podle toho, zda jsme po polovině prosince
        // EN: Train timetables typically change twice a year - after mid-December, we need to look 6 months ahead
        // CZ: Jízdní řády vlaků se typicky mění dvakrát ročně - po polovině prosince musíme hledat o 6 měsíců dopředu
        int daysToAdd = (inputDate.Month == 12 && inputDate.Day > 13) ? 180 : 45;

        // EN: Add days to get the approximate timetable end date
        // CZ: Přičteme dny pro získání přibližného data konce jízdního řádu
        DateTime futureDate = inputDate.AddDays(daysToAdd);

        // EN: Get the 13th of the target month
        // CZ: Získáme 13. den cílového měsíce
        DateTime target = new DateTime(futureDate.Year, futureDate.Month, 13);

        // EN: If the 13th is Saturday or Sunday, step back to the last weekday (Fri)
        // CZ: Pokud je 13. sobota nebo neděle, vrátíme se na poslední pracovní den (pátek)
        while (target.DayOfWeek == DayOfWeek.Saturday || target.DayOfWeek == DayOfWeek.Sunday)
        {
            target = target.AddDays(-1);
        }

        return target;
    }

    public static string Train(string from, string to)
    {
        DateTime target = CalculateTargetDate(DateTime.Today);
        string dateStr = target.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);

        return $"https://idos.cz/vlaky/spojeni/vysledky/?date={dateStr}&time=07:00&f={from}&fc=1&t={to}&tc=1";
    }
}