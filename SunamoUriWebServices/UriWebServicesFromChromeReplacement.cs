namespace SunamoUriWebServices;

/// <summary>
/// Contains methods that build URLs from Chrome search replacement templates.
/// </summary>
public partial class UriWebServices
{
    /// <summary>
    /// Gets Google "I'm Feeling Lucky" URL for the specified search query.
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted Google search URL.</returns>
    public static string GoogleImFeelingLucky(string searchQuery)
    {
        return FromChromeReplacement("https://www.google.com/search?btnI&q=%s", searchQuery);
    }

    /// <summary>
    /// Gets Mapy.cz URL for the specified search query.
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted Mapy.cz URL.</returns>
    public static string MapyCz(string searchQuery)
    {
        return FromChromeReplacement("https://mapy.cz/?q=%s&sourceid=Searchmodule_1", searchQuery);
    }

    /// <summary>
    /// Gets TopRecepty.cz URL for the specified search query.
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted TopRecepty.cz URL.</returns>
    public static string TopRecepty(string searchQuery)
    {
        return FromChromeReplacement("https://www.toprecepty.cz/vyhledavani.php?hledam=%s&kategorie=&autor=&razeni=",
            WebUtility.UrlEncode(searchQuery));
    }

    /// <summary>
    /// Gets Google Maps URL for the specified location.
    /// </summary>
    /// <param name="location">The location to search for.</param>
    /// <returns>The formatted Google Maps URL.</returns>
    private static string GoogleMaps(string location)
    {
        return FromChromeReplacement("https://www.google.com/maps/place/%", location);
    }

    /// <summary>
    /// Opens Google Maps for each location in the list.
    /// </summary>
    /// <param name="list">The list of locations to open.</param>
    public static void GoogleMaps(List<string> list)
    {
        foreach (var item in list) UriWebServices.OpenUri(GoogleMaps(item));
    }

    /// <summary>
    /// Gets KMO library search URL for all branches.
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted KMO search URL.</returns>
    public static string KmoAll(string searchQuery)
    {
        return FromChromeReplacement("https://tritius.kmo.cz/Katalog/search?q=%s&area=247&field=0", searchQuery);
    }

    /// <summary>
    /// Gets KMO library search URL for AV branch.
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted KMO AV search URL.</returns>
    public static string KmoAV(string searchQuery)
    {
        return FromChromeReplacement("https://tritius.kmo.cz/Katalog/search?q=%s&area=238&field=0", searchQuery);
    }

    /// <summary>
    /// Gets KMO library search URL for MP branch.
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted KMO MP search URL.</returns>
    public static string KmoMP(string searchQuery)
    {
        return FromChromeReplacement("https://tritius.kmo.cz/Katalog/search?q=%s&area=242&field=0", searchQuery);
    }
}
