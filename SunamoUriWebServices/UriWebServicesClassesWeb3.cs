namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

/// <summary>
/// Contains web service URL definitions for YouTube, cinemas, tech sites, notebooks, and browser extensions.
/// </summary>
public partial class UriWebServices
{
    /// <summary>
    /// Provides YouTube URL building methods.
    /// </summary>
    public static partial class YouTube
    {
        /// <summary>
        /// Searches YouTube for all episodes of a TV show season.
        /// </summary>
        /// <param name="partCount">The total number of episodes.</param>
        /// <param name="seasonNumber">The season number.</param>
        /// <param name="showName">The name of the TV show.</param>
        public static void SearchYouTubeSerialSerie(int partCount, int seasonNumber, string showName)
        {
            partCount++;
            for (var index = 1; index < partCount; index++)
                UriWebServices.OpenUri(GetLinkToSearch(showName + " " + seasonNumber + " x " + index));
        }

        /// <summary>
        /// Removes YouTube search operators from the input text.
        /// </summary>
        /// <param name="text">The input text to process.</param>
        /// <returns>The text with operators removed.</returns>
        public static string ReplaceOperators(string text)
        {
            return SHReplace.ReplaceAll(text, "", "OR", "+", "-", "\"", "*");
        }

        /// <summary>
        /// Parses YouTube video code from a URI. Returns null if the code cannot be extracted.
        /// </summary>
        /// <param name="uri">The YouTube URI to parse.</param>
        /// <returns>The extracted YouTube video code.</returns>
        public static string ParseYtCode(string uri)
        {
            return ParseYtCode(uri);
        }
    }

    /// <summary>
    /// Provides cinema search URL templates for Moravian-Silesian region.
    /// </summary>
    public static class CinemaMsk
    {
        /// <summary> K3 Bohumin cinema search URL template. </summary>
        public const string K3bohumin = "https://www.k3bohumin.cz/cz/search/?search_string=s";
        /// <summary> Kino Kosmos search URL template. </summary>
        public const string Kosmos = "https://www.google.com/search?q=site%3Akinokosmos.cz+s";
        /// <summary> DK Orlova search URL template. </summary>
        public const string Dkorlova = "https://www.google.com/search?q=site%3Adkorlova.cz+s";
        /// <summary> Kino Karvina search URL template. </summary>
        public const string Kinokarvina = "https://www.google.com/search?q=site%3Akinokarvina.cz+s";
    }

    /// <summary>
    /// Provides tech site RSS feed URLs.
    /// </summary>
    public static class TechSitesRss
    {
        /// <summary> TechCrunch RSS feed URL. </summary>
        public const string FeedsFeedburnerCom = "http://feeds.feedburner.com/TechCrunch/";
        /// <summary> Engadget RSS feed URL. </summary>
        public const string WwwEngadgetCom = "http://www.engadget.com/rss.xml";
        /// <summary> The Verge RSS feed URL (unknown RSS feed format). </summary>
        public const string WwwThevergeCom = "http://www.theverge.com/rss/index.xml";
        /// <summary> ScienceDaily RSS feed URL. </summary>
        public const string WwwSciencedailyCom = "https://www.sciencedaily.com/rss/all.xml";
        /// <summary> TechRadar RSS feed URL. </summary>
        public const string WwwTechradarCom = "https://www.techradar.com/rss";
        /// <summary> Wired RSS feed URL. </summary>
        public const string WwwWiredCom = "https://www.wired.com/feed/rss";
        /// <summary> Ars Technica RSS feed URL. </summary>
        public const string FeedsArstechnicaCom = "http://feeds.arstechnica.com/arstechnica/index";
        /// <summary> The Next Web RSS feed URL. </summary>
        public const string ThenextwebCom = "https://thenextweb.com/feed/";
        /// <summary> Tom's Hardware RSS feed URL. </summary>
        public const string WwwTomshardwareCom = "https://www.tomshardware.com/feeds/all";
        /// <summary> Type reference for reflection. </summary>
        public static Type ReflectionType = typeof(TechSitesRss);

        /// <summary>
        /// List of sites that include images in their RSS feeds.
        /// </summary>
        public static List<string> SitesWithImages { get; set; } = new List<string>(["thenextwebCom", "wwwEngadgetCom"]);
    }

    /// <summary>
    /// Provides YouTube URL building methods.
    /// </summary>
    public static partial class YouTube
    {
        /// <summary>
        /// YouTube video URL prefix.
        /// </summary>
        public const string YtVideoStart = "https://www.youtube.com/watch?v=";

        /// <summary>
        /// Gets YouTube search URL for the specified search query.
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>The YouTube search URL.</returns>
        public static string GetLinkToSearch(string searchQuery)
        {
            return "https://www.youtube.com/results?search_query=" + HttpUtility.UrlEncode(searchQuery);
        }

        /// <summary>
        /// Gets YouTube video URL for the specified video code.
        /// </summary>
        /// <param name="videoCode">The YouTube video code.</param>
        /// <returns>The YouTube video URL.</returns>
        public static string GetLinkToVideo(string videoCode)
        {
            return YtVideoStart + videoCode;
        }

        /// <summary>
        /// Gets HTML anchor element for the specified YouTube video code.
        /// </summary>
        /// <param name="videoCode">The YouTube video code.</param>
        /// <returns>An HTML anchor element linking to the video.</returns>
        public static string GetHtmlAnchor(string videoCode)
        {
            return "<a href='" + GetLinkToVideo(videoCode) + "'>" + videoCode + "</a>";
        }
    }

    /// <summary>
    /// Provides refurbished notebook price-after-sold comparison sites.
    /// </summary>
    public static class RepasNbPriceAfterSold
    {
        /// <summary> InComputer.cz URL. </summary>
        public const string WwwIncomputerCz = "www.incomputer.cz";
        /// <summary> DigiFit.cz URL. </summary>
        public const string WwwDigifitCz = "www.digifit.cz";
        /// <summary> Repasy.eu URL. </summary>
        public const string WwwRepasyEu = "www.repasy.eu";
        /// <summary> Pocitace24.cz URL. </summary>
        public const string WwwPocitace24Cz = "www.pocitace24.cz";
        /// <summary> IT-Bazar.cz URL. </summary>
        public const string WwwItBazarCz = "www.it-bazar.cz";
        /// <summary> C-C.cz URL. </summary>
        public const string WwwCCCz = "www.c-c.cz";
        /// <summary> StilComp.cz URL. </summary>
        public const string WwwStilcompCz = "www.stilcomp.cz";
        /// <summary> NotebookyNejlevneji.cz URL. </summary>
        public const string WwwNotebookyNejlevnejiCz = "www.notebooky-nejlevneji.cz";
        /// <summary> Furbify.cz URL. </summary>
        public const string WwwFurbifyCz = "www.furbify.cz";
        /// <summary> LevnejsiNotebooky.cz URL. </summary>
        public const string WwwLevnejsinotebookyCz = "www.levnejsinotebooky.cz";
    }

    /// <summary>
    /// Provides refurbished notebook sites that might have price-after-sold.
    /// </summary>
    public static class RepasNbMaybePriceAfterSold
    {
        /// <summary> SuperLevnaPC.cz URL. </summary>
        public const string SuperlevnapcCz = "superlevnapc.cz";
        /// <summary> Refurbished.cz URL. </summary>
        public const string WwwRefurbishedCz = "www.refurbished.cz";
        /// <summary> NextWind.cz URL. </summary>
        public const string WwwNextwindCz = "www.nextwind.cz";
        /// <summary> Device.cz URL. </summary>
        public const string WwwDeviceCz = "www.device.cz";
        /// <summary> MaliComputer.cz URL. </summary>
        public const string WwwMalicomputerCz = "www.malicomputer.cz";
        /// <summary> MujNotebook.cz URL. </summary>
        public const string WwwMujnotebookCz = "www.mujnotebook.cz";
        /// <summary> Notebookarna.cz URL. </summary>
        public const string WwwNotebookarnaCz = "www.notebookarna.cz";
        /// <summary> EraComp.cz URL. </summary>
        public const string EracompCz = "eracomp.cz";
        /// <summary> ZebraComp.cz URL. </summary>
        public const string WwwZebracompCz = "www.zebracomp.cz";
    }

    /// <summary>
    /// Provides refurbished notebook shop URLs.
    /// </summary>
    public static class RepasNb
    {
        /// <summary> PocitaceZaBabku.cz URL. </summary>
        public const string WwwPocitacezababkuCz = "www.pocitacezababku.cz";
        /// <summary> Alza.cz URL. </summary>
        public const string WwwAlzaCz = "www.alza.cz";
        /// <summary> Tera.cz URL. </summary>
        public const string WwwTeraCz = "www.tera.cz";
        /// <summary> ImportPC.cz URL. </summary>
        public const string WwwImportpcCz = "www.importpc.cz";
        /// <summary> Technimax.cz URL. </summary>
        public const string WwwTechnimaxCz = "www.technimax.cz";
        /// <summary> ITZoo.cz URL. </summary>
        public const string WwwItzooCz = "www.itzoo.cz";
        /// <summary> EuroTech.cz URL. </summary>
        public const string WwwEurotechCz = "www.eurotech.cz";
        /// <summary> R-Pass.cz URL. </summary>
        public const string WwwRPassCz = "www.r-pass.cz";
    }

    /// <summary>
    /// Provides browser extension store search URL templates.
    /// </summary>
    public static class BrowserExtensions
    {
        /// <summary> Edge Add-ons search URL template. </summary>
        public const string EdgeAddons = "https://microsoftedge.microsoft.com/addons/search/%s";
        /// <summary> Chrome Web Store search URL template. </summary>
        public const string ChromeWebStore = "https://chrome.google.com/webstore/search/%s?hl=en-US";
    }
}
