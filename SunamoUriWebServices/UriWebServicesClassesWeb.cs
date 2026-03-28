namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

/// <summary>
/// Provides URI building methods for various web services and search engines.
/// </summary>
public partial class UriWebServices
{
    /// <summary>
    /// Karaoke texty search URL template.
    /// </summary>
    public const string KaraokeTexty = "http://www.karaoketexty.cz/search?q=%s&sid=bbrpp&x=36&y=9";

    /// <summary>
    /// Instagram profile URL template.
    /// </summary>
    public const string InstagramProfile = "https://www.instagram.com/{0}/";

    /// <summary>
    /// Heureka search URL template.
    /// </summary>
    public const string Heureka = "https://www.heureka.cz/?h[fraze]=%s&ss=1";

    /// <summary>
    /// Geocaching log URL template.
    /// </summary>
    public const string GeocachingLog = "https://www.geocaching.com/play/geocache/%s/log";

    /// <summary>
    /// Amateri.com Czech search URL template.
    /// </summary>
    public const string AmateriComCs = "https://www.amateri.com/cs/lide/search?search=%s";

    /// <summary>
    /// Amateri.com English search URL template.
    /// </summary>
    public const string AmateriComEn = "https://www.amateri.com/en/lide/search?search=%s";

    /// <summary>
    /// Chrome search string replacement placeholder.
    /// </summary>
    public const string ChromeSearchstringReplacement = "%s";

    private static int opened;

    /// <summary>
    /// Wikipedia English search URL template.
    /// </summary>
    public static string WikipediaEn = "https://en.wikipedia.org/w/index.php?search=%s";

    /// <summary>
    /// Searches for a term across all provided Chrome replacement URL templates.
    /// </summary>
    /// <param name="searchTerm">The search term to insert.</param>
    /// <param name="list">The list of Chrome replacement URL templates.</param>
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
    /// Searches using a URL builder function across all items in the list.
    /// </summary>
    /// <param name="urlBuilder">The function that builds a URL from a search term.</param>
    /// <param name="list">The list of search terms.</param>
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
    /// Opens Google search for each item in the list.
    /// </summary>
    /// <param name="list">The list of search queries.</param>
    public static void GoogleSearch(List<string> list)
    {
        foreach (var item in list)
            UriWebServices.OpenUri(GoogleSearch(item));
    }

    /// <summary>
    /// Gets SpritMonitor search URL for the specified search query.
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted SpritMonitor search URL.</returns>
    public static string SpritMonitor(string searchQuery)
    {
        var data = "cng overview -\"/detail/\"" + searchQuery;
        return GoogleSearchSite("spritmonitor.de", data);
    }

    /// <summary>
    /// Gets GitHub search URL for the specified search query.
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted GitHub search URL.</returns>
    public static string SearchGitHub(string searchQuery)
    {
        return "https://github.com/search?q=" + searchQuery;
    }

    /// <summary>
    /// Gets WebShare search URL for the specified search query.
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted WebShare search URL.</returns>
    public static string WebShare(string searchQuery)
    {
        return "https://webshare.cz/#/search?what=" + UrlEncode(searchQuery);
    }

    /// <summary>
    /// Gets Google Plus profile URL for the specified nickname.
    /// </summary>
    /// <param name="nickname">The Google Plus username.</param>
    /// <returns>The Google Plus profile URL.</returns>
    public static string GooglePlusProfile(string nickname)
    {
        return "https://www.google.com/" + nickname;
    }

    /// <summary>
    /// Searches Google for a query across all provided sites.
    /// </summary>
    /// <param name="list">The list of sites to search.</param>
    /// <param name="searchQuery">The search query.</param>
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
    public static string GoogleSearch(string text)
    {
        return "https://www.google.cz/search?hl=cs&q=" + UrlEncode(text);
    }

    /// <summary>
    /// Gets Google Images search URL for the specified text.
    /// </summary>
    /// <param name="text">The search text.</param>
    /// <returns>The formatted Google Images search URL.</returns>
    public static string GoogleSearchImages(string text)
    {
        return "https://www.google.cz/search?hl=cs&tbm=isch&q=" + UrlEncode(text);
    }

    /// <summary>
    /// Gets Google site-specific search URL.
    /// </summary>
    /// <param name="site">The site to search within.</param>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted Google site-specific search URL.</returns>
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
    public static string GitRepoInVsts(string solutionName)
    {
        return "https://radekjancik.visualstudio.com/_git/" + WebUtility.UrlEncode(solutionName);
    }

    /// <summary>
    /// Gets Azure Repo Web UI full URL (alternative format, currently shows gray screen).
    /// </summary>
    /// <param name="solutionName">The solution name.</param>
    /// <returns>The Azure Repo Web UI URL.</returns>
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
    public static string AzureRepoWebUI(string solutionName, AzureBuildUriArgs? args = null)
    {
        return AzureRepoWebUIDomain(args) + WebUtility.UrlEncode(solutionName);
    }

    /// <summary>
    /// Gets Azure Repo Web UI settings URL for the specified solution name.
    /// </summary>
    /// <param name="solutionName">The solution name.</param>
    /// <returns>The Azure Repo Web UI settings URL.</returns>
    public static string AzureRepoWebUISettings(string solutionName)
    {
        return AzureRepoWebUI(solutionName) + "/_settings/";
    }

    /// <summary>
    /// URL-encodes the specified text.
    /// </summary>
    /// <param name="text">The text to encode.</param>
    /// <returns>The URL-encoded text.</returns>
    public static string UrlEncode(string text)
    {
        return HttpUtility.UrlEncode(text);
    }

    /// <summary>
    /// Gets Azure Repo Web UI full URL (currently shows gray screen).
    /// </summary>
    /// <param name="solutionName">The solution name.</param>
    /// <param name="args">Optional Azure build URI arguments.</param>
    /// <returns>The Azure Repo Web UI full URL.</returns>
    public static string AzureRepoWebUIFull(string solutionName, AzureBuildUriArgs? args = null)
    {
        var encodedName = WebUtility.UrlEncode(solutionName);
        return AzureRepoWebUIDomain(args) + $"{encodedName}/_git/{encodedName}";
    }

    /// <summary>
    /// Gets Azure Repo Web UI domain URL.
    /// </summary>
    /// <param name="args">Optional Azure build URI arguments.</param>
    /// <returns>The Azure Repo Web UI domain URL.</returns>
    public static string AzureRepoWebUIDomain(AzureBuildUriArgs? args = null)
    {
        return "https://" + (args != null && args.IsWithLogin ? "radekjancik@" : "") + (args != null && args.PersonalAccessToken != null ? args.PersonalAccessToken + "@" : "") + "radekjancik.visualstudio.com/";
    }

    /// <summary>
    /// Gets YouTube profile URL for the specified nickname.
    /// </summary>
    /// <param name="nickname">The YouTube username.</param>
    /// <returns>The YouTube profile URL.</returns>
    public static string YouTubeProfile(string nickname)
    {
        return "https://www.youtube.com/c/" + nickname;
    }

    /// <summary>
    /// Gets Twitter profile URL for the specified nickname.
    /// </summary>
    /// <param name="nickname">The Twitter username.</param>
    /// <returns>The Twitter profile URL.</returns>
    public static string TwitterProfile(string nickname)
    {
        return "https://www.twitter.com/" + nickname;
    }

    /// <summary>
    /// Searches in all provided Chrome replacement URL templates for the specified query.
    /// </summary>
    /// <param name="list">The list of Chrome replacement URL templates.</param>
    /// <param name="searchQuery">The search query.</param>
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
    /// Replaces Chrome search placeholder in a URI with the specified term.
    /// </summary>
    /// <param name="uri">The URI template containing %s placeholder.</param>
    /// <param name="term">The search term to insert.</param>
    /// <returns>The URI with the placeholder replaced.</returns>
    public static string FromChromeReplacement(string uri, string term)
    {
        term = Uri.EscapeDataString(term);
        return uri.Replace(ChromeSearchstringReplacement, term);
    }

    /// <summary>
    /// Gets Google Maps URL for the specified coordinates or address.
    /// </summary>
    /// <param name="coordsOrAddress">The coordinates or address to search for.</param>
    /// <param name="center">The map center coordinates.</param>
    /// <param name="zoom">The map zoom level.</param>
    /// <returns>The formatted Google Maps URL.</returns>
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

    /// <summary>
    /// Provides IT job search URL templates.
    /// </summary>
    public static class ITJobs
    {
        /// <summary>
        /// CoolJobs.eu search URL template.
        /// </summary>
        public const string Cooljobs = @"https://www.cooljobs.eu/cz/%s";
    }

    /// <summary>
    /// Provides Chrome search shortcut URL templates.
    /// </summary>
    public static class ChromeSearchShortcut
    {
        /// <summary>
        /// Google Play Store search URL template.
        /// </summary>
        public const string GooglePlay = "https://play.google.com/store/search?q=%s";

        /// <summary>
        /// Chrome Web Store search URL template.
        /// </summary>
        public const string ChromeWebStoreSearch = "https://chrome.google.com/webstore/search/%s?hl=en&gl=US";
    }
}
