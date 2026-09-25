namespace SunamoUriWebServices;

public partial class UriWebServices
{
    public static string GoogleImFeelingLucky(string searchQuery) => FromChromeReplacement("https://www.google.com/search?btnI&q=%s", searchQuery);

    public static string MapyCz(string searchQuery) => FromChromeReplacement("https://mapy.cz/?q=%s&sourceid=Searchmodule_1", searchQuery);

    public static string TopRecepty(string searchQuery)
    {
        return FromChromeReplacement("https://www.toprecepty.cz/vyhledavani.php?hledam=%s&kategorie=&autor=&razeni=",
            WebUtility.UrlEncode(searchQuery));
    }

    private static string GoogleMaps(string location) => FromChromeReplacement("https://www.google.com/maps/place/%", location);

    public static void GoogleMaps(List<string> list)
    {
        foreach (var item in list) UriWebServices.OpenUri(GoogleMaps(item));
    }

    public static string KmoAll(string searchQuery) => FromChromeReplacement("https://tritius.kmo.cz/Katalog/search?q=%s&area=247&field=0", searchQuery);

    public static string KmoAV(string searchQuery) => FromChromeReplacement("https://tritius.kmo.cz/Katalog/search?q=%s&area=238&field=0", searchQuery);

    public static string KmoMP(string searchQuery) => FromChromeReplacement("https://tritius.kmo.cz/Katalog/search?q=%s&area=242&field=0", searchQuery);
}
