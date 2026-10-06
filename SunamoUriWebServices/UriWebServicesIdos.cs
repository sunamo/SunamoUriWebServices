namespace SunamoUriWebServices;

using System.Globalization;

public class UriWebServicesIdos
{
    // Train timetables change twice a year - after mid-December, look 6 months ahead.
    public static DateTime CalculateTargetDate(DateTime inputDate)
    {
        int daysToAdd = (inputDate.Month == 12 && inputDate.Day > 13) ? 180 : 45;

        var futureDate = inputDate.AddDays(daysToAdd);

        var target = new DateTime(futureDate.Year, futureDate.Month, 13);

        while (target.DayOfWeek == DayOfWeek.Saturday || target.DayOfWeek == DayOfWeek.Sunday)
        {
            target = target.AddDays(-1);
        }

        return target;
    }

    public static string Train(string departureStation, string arrivalStation)
    {
        var target = CalculateTargetDate(DateTime.Today);
        string formattedDate = target.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);

        return $"https://idos.cz/vlaky/spojeni/vysledky/?date={formattedDate}&time=07:00&f={departureStation}&fc=1&t={arrivalStation}&tc=1";
    }
}
