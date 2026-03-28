namespace SunamoUriWebServices;

using System.Globalization;

/// <summary>
/// Provides methods for building IDOS train timetable URLs.
/// </summary>
public class UriWebServicesIdos
{
    /// <summary>
    /// Calculates the target date for train timetable based on the input date.
    /// Train timetables typically change twice a year - after mid-December, we need to look 6 months ahead.
    /// </summary>
    /// <param name="inputDate">The date to calculate from.</param>
    /// <returns>The calculated target date.</returns>
    public static DateTime CalculateTargetDate(DateTime inputDate)
    {
        int daysToAdd = (inputDate.Month == 12 && inputDate.Day > 13) ? 180 : 45;

        DateTime futureDate = inputDate.AddDays(daysToAdd);

        DateTime target = new DateTime(futureDate.Year, futureDate.Month, 13);

        while (target.DayOfWeek == DayOfWeek.Saturday || target.DayOfWeek == DayOfWeek.Sunday)
        {
            target = target.AddDays(-1);
        }

        return target;
    }

    /// <summary>
    /// Builds an IDOS train connection search URL between two stations.
    /// </summary>
    /// <param name="departureStation">The departure station name.</param>
    /// <param name="arrivalStation">The arrival station name.</param>
    /// <returns>The formatted IDOS train search URL.</returns>
    public static string Train(string departureStation, string arrivalStation)
    {
        DateTime target = CalculateTargetDate(DateTime.Today);
        string formattedDate = target.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);

        return $"https://idos.cz/vlaky/spojeni/vysledky/?date={formattedDate}&time=07:00&f={departureStation}&fc=1&t={arrivalStation}&tc=1";
    }
}
