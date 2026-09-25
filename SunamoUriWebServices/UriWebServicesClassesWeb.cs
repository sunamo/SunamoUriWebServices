namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

public partial class UriWebServices
{
    public const string KaraokeTexty = "http://www.karaoketexty.cz/search?q=%s&sid=bbrpp&x=36&y=9";

    public const string InstagramProfile = "https://www.instagram.com/{0}/";

    public const string Heureka = "https://www.heureka.cz/?h[fraze]=%s&ss=1";

    public const string GeocachingLog = "https://www.geocaching.com/play/geocache/%s/log";

    public const string AmateriComCs = "https://www.amateri.com/cs/lide/search?search=%s";

    public const string AmateriComEn = "https://www.amateri.com/en/lide/search?search=%s";

    public const string ChromeSearchstringReplacement = "%s";

    private static int opened;

    public static string WikipediaEn = "https://en.wikipedia.org/w/index.php?search=%s";

    public static void SearchAll(string searchTerm, List<string> list)
    {
        foreach (var item in list)
        {
            opened++;
            UriWebServices.OpenUri(FromChromeReplacement(item, searchTerm));
            if (opened % 10 == 0)
                Debugger.Break();
        }
    }

    public static void SearchAll(Func<string, string> urlBuilder, List<string> list)
    {
        foreach (var item in list)
        {
            opened++;
            UriWebServices.OpenUri(urlBuilder.Invoke(item));
            if (opened % 10 == 0)
                Debugger.Break();
        }
    }

    public static void GoogleSearch(List<string> list)
    {
        foreach (var item in list)
            UriWebServices.OpenUri(GoogleSearch(item));
    }

    public static string SpritMonitor(string searchQuery)
    {
        var data = "cng overview -\"/detail/\"" + searchQuery;
        return GoogleSearchSite("spritmonitor.de", data);
    }

    public static string SearchGitHub(string searchQuery) => "https://github.com/search?q=" + searchQuery;

    public static string WebShare(string searchQuery) => "https://webshare.cz/#/search?what=" + UrlEncode(searchQuery);

    public static string GooglePlusProfile(string nickname) => "https://www.google.com/" + nickname;

    public static void GoogleSearchInAllSite(List<string> list, string searchQuery)
    {
        foreach (var item in list)
        {
            var uri = GoogleSearchSite(item, searchQuery);
            UriWebServices.OpenUri(uri);
            opened++;
        }
    }

    public static string GoogleSearch(string text) => "https://www.google.cz/search?hl=cs&q=" + UrlEncode(text);

    public static string GoogleSearchImages(string text) => "https://www.google.cz/search?hl=cs&tbm=isch&q=" + UrlEncode(text);

    public static string GoogleSearchSite(string site, string searchQuery)
    {
        site = site.Trim();
        var parsedUri = new Uri(site);
        var host = parsedUri.Host;
        return "https://www.google.cz/search?q=site%3A" + host + "+" + UrlEncode(searchQuery);
    }

    public static string GitRepoInVsts(string solutionName) => "https://radekjancik.visualstudio.com/_git/" + WebUtility.UrlEncode(solutionName);

    public static string? AzureRepoWebUIFull2(string solutionName)
    {
        if (ThrowEx.IsNullOrEmpty(nameof(solutionName), solutionName))
        {
            return null;
        }

        var encodedName = WebUtility.UrlEncode(solutionName);
        return $"https://radekjancik@dev.azure.com/radekjancik/{encodedName}/_git/{encodedName}";
    }

    public static string AzureRepoWebUI(string solutionName, AzureBuildUriArgs? args = null) => AzureRepoWebUIDomain(args) + WebUtility.UrlEncode(solutionName);

    public static string AzureRepoWebUISettings(string solutionName) => AzureRepoWebUI(solutionName) + "/_settings/";

    public static string UrlEncode(string text) => HttpUtility.UrlEncode(text);

    public static string AzureRepoWebUIFull(string solutionName, AzureBuildUriArgs? args = null)
    {
        var encodedName = WebUtility.UrlEncode(solutionName);
        return AzureRepoWebUIDomain(args) + $"{encodedName}/_git/{encodedName}";
    }

    public static string AzureRepoWebUIDomain(AzureBuildUriArgs? args = null)
    {
        return "https://" + (args != null && args.IsWithLogin ? "radekjancik@" : "") + (args != null && args.PersonalAccessToken != null ? args.PersonalAccessToken + "@" : "") + "radekjancik.visualstudio.com/";
    }

    public static string YouTubeProfile(string nickname) => "https://www.youtube.com/c/" + nickname;

    public static string TwitterProfile(string nickname) => "https://www.twitter.com/" + nickname;

    public static void SearchInAll(IList list, string searchQuery)
    {
        foreach (var item in list)
        {
            opened++;
            string uri = UriWebServices.FromChromeReplacement(item.ToString()!, searchQuery);
            UriWebServices.OpenUri(uri);
            if (opened % 10 == 0)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }

    public static string FromChromeReplacement(string uri, string term)
    {
        term = Uri.EscapeDataString(term);
        return uri.Replace(ChromeSearchstringReplacement, term);
    }

    public static string GoogleMaps(string coordsOrAddress, string center, string zoom)
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("https://maps.google.com/maps?q=" + coordsOrAddress.Replace(" ", "+") + "&hl=cs&ie=UTF8&t=h");
        if (!string.IsNullOrEmpty(center))
            stringBuilder.Append("&ll=" + center);
        if (!string.IsNullOrEmpty(zoom))
            stringBuilder.Append("&z=" + zoom);
        return stringBuilder.ToString();
    }

    public static class ITJobs
    {
        public const string Cooljobs = @"https://www.cooljobs.eu/cz/%s";
    }

    public static class ChromeSearchShortcut
    {
        public const string GooglePlay = "https://play.google.com/store/search?q=%s";

        public const string ChromeWebStoreSearch = "https://chrome.google.com/webstore/search/%s?hl=en&gl=US";
    }
}
