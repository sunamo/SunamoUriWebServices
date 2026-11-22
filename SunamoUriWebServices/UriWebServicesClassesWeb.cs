namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

public partial class UriWebServices
{
    /// <summary>
    /// The karaoke texty constant.
    /// </summary>
    public const string KaraokeTexty = "http://www.karaoketexty.cz/search?q=%s&sid=bbrpp&x=36&y=9";

    /// <summary>
    /// The instagram profile constant.
    /// </summary>
    public const string InstagramProfile = "https://www.instagram.com/{0}/";

    /// <summary>
    /// The heureka constant.
    /// </summary>
    public const string Heureka = "https://www.heureka.cz/?h[fraze]=%s&ss=1";

    /// <summary>
    /// The geocaching log constant.
    /// </summary>
    public const string GeocachingLog = "https://www.geocaching.com/play/geocache/%s/log";

    /// <summary>
    /// The amateri com cs constant.
    /// </summary>
    public const string AmateriComCs = "https://www.amateri.com/cs/lide/search?search=%s";

    /// <summary>
    /// The amateri com en constant.
    /// </summary>
    public const string AmateriComEn = "https://www.amateri.com/en/lide/search?search=%s";

    /// <summary>
    /// The chrome searchstring replacement constant.
    /// </summary>
    public const string ChromeSearchstringReplacement = "%s";

    private static int opened;

    /// <summary>
    /// The wikipedia en.
    /// </summary>
    public static string WikipediaEn = "https://en.wikipedia.org/w/index.php?search=%s";

    /// <summary>
    /// Search all.
    /// </summary>
    /// <param name="searchTerm">The search term.</param>
    /// <param name="list">The list.</param>
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

    /// <summary>
    /// Search all.
    /// </summary>
    /// <param name="urlBuilder">The url builder.</param>
    /// <param name="list">The list.</param>
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

    /// <summary>
    /// Google search.
    /// </summary>
    /// <param name="searchTerm">The search term.</param>
    /// <param name="list">The list.</param>
    /// <returns>The google search result.</returns>
    public static void GoogleSearch(List<string> list)
    {
        foreach (var item in list)
            UriWebServices.OpenUri(GoogleSearch(item));
    }

    /// <summary>
    /// Sprit monitor.
    /// </summary>
    /// <param name="searchTerm)">The search term.</param>
    /// <returns>The sprit monitor result.</returns>
    public static string SpritMonitor(string searchQuery)
    {
        var data = "cng overview -\"/detail/\"" + searchQuery;
        return GoogleSearchSite("spritmonitor.de", data);
    }

    /// <summary>
    /// Gets the URL of the search on spritmonitor.de itself (not a Google site search) for the car model.
    /// </summary>
    /// <param name="carModel">The car model to search for.</param>
    /// <returns>The search URL with the escaped car model.</returns>
    public static string SpritMonitorSearch(string carModel)
    {
        if (carModel == null) throw new ArgumentNullException(nameof(carModel));
        return "https://www.spritmonitor.de/en/search.html?searchterm=" + Uri.EscapeDataString(carModel);
    }

    /// <summary>
    /// Gets GitHub search URL for the specified search query.
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted GitHub search URL.</returns>
    public static string SearchGitHub(string searchQuery) => "https://github.com/search?q=" + searchQuery;

    /// <summary>
    /// Gets WebShare search URL for the specified search query.
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted WebShare search URL.</returns>
    public static string WebShare(string searchQuery) => "https://webshare.cz/#/search?what=" + UrlEncode(searchQuery);

    /// <summary>
    /// Gets Google Plus profile URL for the specified nickname.
    /// </summary>
    /// <param name="nickname">The Google Plus username.</param>
    /// <returns>The Google Plus profile URL.</returns>
    public static string GooglePlusProfile(string nickname) => "https://www.google.com/" + nickname;

    /// <summary>
    /// Google search in all site.
    /// </summary>
    /// <param name=""spritmonitor.de"">The spritmonitor de.</param>
    /// <param name="data">The data.</param>
    /// <returns>The google search in all site result.</returns>
    public static void GoogleSearchInAllSite(List<string> list, string searchQuery)
    {
        foreach (var item in list)
        {
            var uri = GoogleSearchSite(item, searchQuery);
            UriWebServices.OpenUri(uri);
            opened++;
        }
    }

    /// <summary>
    /// Gets Google search URL for the specified text.
    /// </summary>
    /// <param name="text">The search text.</param>
    /// <returns>The formatted Google search URL.</returns>
    public static string GoogleSearch(string text) => "https://www.google.cz/search?hl=cs&q=" + UrlEncode(text);

    /// <summary>
    /// Gets Google Images search URL for the specified text.
    /// </summary>
    /// <param name="text">The search text.</param>
    /// <returns>The formatted Google Images search URL.</returns>
    public static string GoogleSearchImages(string text) => "https://www.google.cz/search?hl=cs&tbm=isch&q=" + UrlEncode(text);

    /// <summary>
    /// Google search site.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="searchQuery">The search query.</param>
    public static string GoogleSearchSite(string site, string searchQuery)
    {
        site = site.Trim();
        var parsedUri = new Uri(site);
        var host = parsedUri.Host;
        return "https://www.google.cz/search?q=site%3A" + host + "+" + UrlEncode(searchQuery);
    }

    /// <summary>
    /// Gets VSTS Git repository URL for the specified solution name.
    /// </summary>
    /// <param name="solutionName">The solution name.</param>
    /// <returns>The VSTS Git repository URL.</returns>
    public static string GitRepoInVsts(string solutionName) => "https://radekjancik.visualstudio.com/_git/" + WebUtility.UrlEncode(solutionName);

    /// <summary>
    /// Azure repo web UI full 2.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The azure repo web UI full 2 result.</returns>
    public static string? AzureRepoWebUIFull2(string solutionName)
    {
        if (ThrowEx.IsNullOrEmpty(nameof(solutionName), solutionName))
        {
            return null;
        }

        var encodedName = WebUtility.UrlEncode(solutionName);
        return $"https://radekjancik@dev.azure.com/radekjancik/{encodedName}/_git/{encodedName}";
    }

    /// <summary>
    /// Gets Azure Repo Web UI URL for the specified solution name.
    /// </summary>
    /// <param name="solutionName">The solution name.</param>
    /// <param name="args">Optional Azure build URI arguments.</param>
    /// <returns>The Azure Repo Web UI URL.</returns>
    public static string AzureRepoWebUI(string solutionName, AzureBuildUriArgs? args = null) => AzureRepoWebUIDomain(args) + WebUtility.UrlEncode(solutionName);

    /// <summary>
    /// Gets Azure Repo Web UI settings URL for the specified solution name.
    /// </summary>
    /// <param name="solutionName">The solution name.</param>
    /// <returns>The Azure Repo Web UI settings URL.</returns>
    public static string AzureRepoWebUISettings(string solutionName) => AzureRepoWebUI(solutionName) + "/_settings/";

    /// <summary>
    /// URL-encodes the specified text.
    /// </summary>
    /// <param name="text">The text to encode.</param>
    /// <returns>The URL-encoded text.</returns>
    public static string UrlEncode(string text) => HttpUtility.UrlEncode(text);

    /// <summary>
    /// Azure repo web UI full.
    /// </summary>
    /// <param name="solutionName">The solution name.</param>
    /// <param name="args">The args.</param>
    /// <returns>The azure repo web UI full result.</returns>
    public static string AzureRepoWebUIFull(string solutionName, AzureBuildUriArgs? args = null)
    {
        var encodedName = WebUtility.UrlEncode(solutionName);
        return AzureRepoWebUIDomain(args) + $"{encodedName}/_git/{encodedName}";
    }

    /// <summary>
    /// Azure repo web UI domain.
    /// </summary>
    /// <param name="solutionName">The solution name.</param>
    /// <param name="args">The args.</param>
    /// <returns>The azure repo web UI domain result.</returns>
    public static string AzureRepoWebUIDomain(AzureBuildUriArgs? args = null)
    {
        return "https://" + (args != null && args.IsWithLogin ? "radekjancik@" : "") + (args != null && args.PersonalAccessToken != null ? args.PersonalAccessToken + "@" : "") + "radekjancik.visualstudio.com/";
    }

    /// <summary>
    /// Gets YouTube profile URL for the specified nickname.
    /// </summary>
    /// <param name="nickname">The YouTube username.</param>
    /// <returns>The YouTube profile URL.</returns>
    public static string YouTubeProfile(string nickname) => "https://www.youtube.com/c/" + nickname;

    /// <summary>
    /// Gets Twitter profile URL for the specified nickname.
    /// </summary>
    /// <param name="nickname">The Twitter username.</param>
    /// <returns>The Twitter profile URL.</returns>
    public static string TwitterProfile(string nickname) => "https://www.twitter.com/" + nickname;

    /// <summary>
    /// Search in all.
    /// </summary>
    /// <param name="solutionName">The solution name.</param>
    /// <returns>The search in all result.</returns>
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

    /// <summary>
    /// From chrome replacement.
    /// </summary>
    /// <param name="nickname">The nickname.</param>
    /// <returns>The from chrome replacement result.</returns>
    public static string FromChromeReplacement(string uri, string term)
    {
        term = Uri.EscapeDataString(term);
        return uri.Replace(ChromeSearchstringReplacement, term);
    }

    /// <summary>
    /// Google maps.
    /// </summary>
    /// <param name="nickname">The nickname.</param>
    /// <returns>The google maps result.</returns>
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

    /// <summary>
    /// Represents the IT jobs type.
    /// </summary>
    public static class ITJobs
    {
        /// <summary>
        /// The cooljobs constant.
        /// </summary>
        public const string Cooljobs = @"https://www.cooljobs.eu/cz/%s";
    }

    /// <summary>
    /// Represents the chrome search shortcut type.
    /// </summary>
    public static class ChromeSearchShortcut
    {
        /// <summary>
        /// The google play constant.
        /// </summary>
        public const string GooglePlay = "https://play.google.com/store/search?q=%s";

        /// <summary>
        /// The chrome web store search constant.
        /// </summary>
        public const string ChromeWebStoreSearch = "https://chrome.google.com/webstore/search/%s?hl=en&gl=US";
    }
}
