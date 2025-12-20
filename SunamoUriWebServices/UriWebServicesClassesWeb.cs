// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoUriWebServices;
using SunamoUriWebServices.Values;

public partial class UriWebServices
{
    public const string karaokeTexty = "http://www.karaoketexty.cz/search?q=%s&sid=bbrpp&x=36&y=9";
    public const string instagramProfile = "https://www.instagram.com/{0}/";
    public const string heureka = "https://www.heureka.cz/?h[fraze]=%s&ss=1";
    public const string geocachingLog = "https://www.geocaching.com/play/geocache/%s/log";
    public const string amateriComCs = "https://www.amateri.com/cs/lide/search?search=%s";
    public const string amateriComEn = "https://www.amateri.com/en/lide/search?search=%s";
    public const string chromeSearchstringReplacement = "%s";
    private static int opened;
    public static string WikipediaEn = "https://en.wikipedia.org/w/index.php?search=%s";
    /// <summary>
    ///     Insert A1 to every in A2 with %s
    /// </summary>
    /// <param name = "searchTerm"></param>
    /// <param name = "clipboardL"></param>
    public static void SearchAll(string searchTerm, List<string> clipboardL)
    {
        foreach (var item in clipboardL)
        {
            opened++;
            UriWebServices.OpenUri(FromChromeReplacement(item, searchTerm));
            if (opened % 10 == 0)
                Debugger.Break();
        }
    }

    public static void SearchAll(Func<string, string> topRecepty, List<string> clipboardL)
    {
        foreach (var item in clipboardL)
        {
            opened++;
            UriWebServices.OpenUri(topRecepty.Invoke(item));
            if (opened % 10 == 0)
                Debugger.Break();
        }
    }

    public static void GoogleSearch(List<string> list)
    {
        foreach (var item in list)
            UriWebServices.OpenUri(GoogleSearch(item));
    }

    public static string SpritMonitor(string car)
    {
        // https://www.spritmonitor.de/en/overview/45-Skoda/1289-Citigo.html?fueltype=4
        var data = "cng overview -\"/detail/\"" + car;
        return GoogleSearchSite("spritmonitor.de", data);
    }

    public static string SearchGitHub(string item)
    {
        return "https://github.com/search?q=" + item;
    }

    public static string WebShare(string item)
    {
        return "https://webshare.cz/#/search?what=" + UrlEncode(item);
    }

    public static string GooglePlusProfile(string nick)
    {
        return "https://www.google.com/" + nick;
    }

    public static void GoogleSearchInAllSite(List<string> allRepairKitShops, string v)
    {
        foreach (var item in allRepairKitShops)
        {
            if (opened % 10 == 0 && opened != 0)
            {
            //System.Diagnostics.Debugger.Break();
#if DEBUG

#endif
            }

            var uri = GoogleSearchSite(item, v);
            UriWebServices.OpenUri(uri);
            opened++;
        }
    }

    //http://www.bdsluzby.cz/stavebni-cinnost/materialy.htm
    /// <summary>
    ///     A1 už musí být escapováno
    /// </summary>
    /// <param name = "s"></param>
    public static string GoogleSearch(string text)
    {
        // q for reviews in czech and not translated
        return "https://www.google.cz/search?hl=cs&q=" + UrlEncode(text);
    }

    public static string GoogleSearchImages(string text)
    {
        // q for reviews in czech and not translated
        return "https://www.google.cz/search?hl=cs&tbm=isch&q=" + UrlEncode(text);
    }

    public static string GoogleSearchSite(string site, string v)
    {
        site = site.Trim();
        var uri = new Uri(site);
        var host = string.Empty;
        if (uri != null)
            host = uri.Host;
        else
            host = site;
        //https://www.google.cz/search?q=site%3Asunamo.cz+s
        return "https://www.google.cz/search?q=site%3A" + host + "+" + UrlEncode(v);
    }

    /// <summary>
    ///     Point to Repos tab
    ///     Already new radekjancik
    ///     Working with spaces right (SQL Server Scripts1)
    /// </summary>
    /// <param name = "slnName"></param>
    public static string GitRepoInVsts(string slnName)
    {
        return "https://radekjancik.visualstudio.com/_git/" + WebUtility.UrlEncode(slnName);
    }

    /// <summary>
    ///     Just gray screen (22-12-2021)
    /// </summary>
    /// <param name = "slnName"></param>
    /// <returns></returns>
    public static string AzureRepoWebUIFull2(string slnName)
    {
        if (ThrowEx.IsNullOrEmpty(nameof(slnName), slnName))
        {
            return null;
        }

        var enc = WebUtility.UrlEncode(slnName);
        return $"https://radekjancik@dev.azure.com/radekjancik/{enc}/_git/{enc}";
    }

    public static string AzureRepoWebUI(string slnName, AzureBuildUriArgs a = null)
    {
        return AzureRepoWebUIDomain(a) + WebUtility.UrlEncode(slnName);
    }

    public static string AzureRepoWebUISettings(string slnName)
    {
        return AzureRepoWebUI(slnName) + "/_settings/";
    }

    public static string UrlEncode(string text)
    {
        return HttpUtility.UrlEncode(text);
    }

    /// <summary>
    ///     Just gray screen (22-12-2021)
    /// </summary>
    /// <param name = "slnName"></param>
    /// <returns></returns>
    public static string AzureRepoWebUIFull(string slnName, AzureBuildUriArgs a = null)
    {
        var enc = WebUtility.UrlEncode(slnName);
        return AzureRepoWebUIDomain(a) + $"{enc}/_git/{enc}";
    }

    public static string AzureRepoWebUIDomain(AzureBuildUriArgs a = null)
    {
        return "https://" + (a != null && a.withLogin ? "radekjancik@" : "") + (a != null && a.personalAccessToken != null ? a.personalAccessToken + "@" : "") + "radekjancik.visualstudio.com/";
    }

    public static string YouTubeProfile(string nick)
    {
        return "https://www.youtube.com/c/" + nick;
    }

    public static string TwitterProfile(string nick)
    {
        return "https://www.twitter.com/" + nick;
    }

    /// <summary>
    ///     A1 is chrome replacement
    /// </summary>
    /// <param name = "array"></param>
    /// <param name = "what"></param>
    public static void SearchInAll(IList array, string what)
    {
        foreach (var item in array)
        {
            opened++;
            string uri = UriWebServices.FromChromeReplacement(item.ToString(), what);
            UriWebServices.OpenUri(uri);
            if (opened % 10 == 0)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }

    public static string FromChromeReplacement(string uri, string term)
    {
        // UrlEncode is not needed because not encode space to %20
        term = Uri.EscapeUriString(term);
        //term = UH.UrlEncode(term);
        return uri.Replace(chromeSearchstringReplacement, term);
    }

    public static string GoogleMaps(string coordsOrAddress, string center, string zoom)
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("https://maps.google.com/maps?q=" + coordsOrAddress.Replace("", "+") + "&hl=cs&ie=UTF8&t=h");
        if (!string.IsNullOrEmpty(center))
            stringBuilder.Append("&ll=" + center);
        if (!string.IsNullOrEmpty(zoom))
            stringBuilder.Append("&z=" + zoom);
        return stringBuilder.ToString();
    }

    public static class ITJobs
    {
        public const string cooljobs = @"https://www.cooljobs.eu/cz/%s";
    }

    public static class ChromeSearchShortcut
    {
        public const string gp = "https://play.google.com/store/search?q=%s";
        public const string a = "https://chrome.google.com/webstore/search/%s?hl=en&gl=US";
    }
}