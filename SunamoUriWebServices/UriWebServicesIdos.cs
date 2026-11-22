namespace SunamoUriWebServices;

using System.Globalization;

/// <summary>
/// Represents the uri web services idos type.
/// </summary>
public class UriWebServicesIdos
{
    // Train timetables change twice a year - after mid-December, look 6 months ahead.
    /// <summary>
    /// Calculate target date.
    /// </summary>
    /// <param name="inputDate">The input date.</param>
    /// <returns>The calculate target date result.</returns>
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

    /// <summary>
    /// Train.
    /// </summary>
    /// <param name="departureStation">The departure station.</param>
    /// <param name="arrivalStation">The arrival station.</param>
    /// <returns>The train result.</returns>
    public static string Train(string departureStation, string arrivalStation)
    {
        var target = CalculateTargetDate(DateTime.Today);
        string formattedDate = target.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);

        return $"https://idos.cz/vlaky/spojeni/vysledky/?date={formattedDate}&time=07:00&f={departureStation}&fc=1&t={arrivalStation}&tc=1";
    }
}
