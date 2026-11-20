namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

public partial class UriWebServices
{
    /// <summary>
    /// Represents the you tube type.
    /// </summary>
    public static partial class YouTube
    {
        /// <summary>
        /// Search you tube serial serie.
        /// </summary>
        /// <param name="partCount">The part count.</param>
        /// <param name="seasonNumber">The season number.</param>
        /// <param name="showName">The show name.</param>
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
        public static string ReplaceOperators(string text) => SHReplace.ReplaceAll(text, "", "OR", "+", "-", "\"", "*");

        /// <summary>
        /// Parse yt code.
        /// </summary>
        /// <param name="uri">The uri.</param>
        /// <returns>The parse yt code result.</returns>
        public static string ParseYtCode(string uri)
        {
            return ParseYtCode(uri);
        }
    }

    /// <summary>
    /// Represents the cinema msk type.
    /// </summary>
    public static class CinemaMsk
    {
        /// <summary>
        /// The k 3 bohumin constant.
        /// </summary>
        public const string K3bohumin = "https://www.k3bohumin.cz/cz/search/?search_string=s";
        /// <summary>
        /// The kosmos constant.
        /// </summary>
        public const string Kosmos = "https://www.google.com/search?q=site%3Akinokosmos.cz+s";
        /// <summary>
        /// The dkorlova constant.
        /// </summary>
        public const string Dkorlova = "https://www.google.com/search?q=site%3Adkorlova.cz+s";
        /// <summary>
        /// The kinokarvina constant.
        /// </summary>
        public const string Kinokarvina = "https://www.google.com/search?q=site%3Akinokarvina.cz+s";
    }

    /// <summary>
    /// Represents the tech sites rss type.
    /// </summary>
    public static class TechSitesRss
    {
        /// <summary>
        /// The feeds feedburner com constant.
        /// </summary>
        public const string FeedsFeedburnerCom = "http://feeds.feedburner.com/TechCrunch/";
        /// <summary>
        /// The www engadget com constant.
        /// </summary>
        public const string WwwEngadgetCom = "http://www.engadget.com/rss.xml";
        // unknown RSS feed format
        /// <summary>
        /// The www theverge com constant.
        /// </summary>
        public const string WwwThevergeCom = "http://www.theverge.com/rss/index.xml";
        /// <summary>
        /// The www sciencedaily com constant.
        /// </summary>
        public const string WwwSciencedailyCom = "https://www.sciencedaily.com/rss/all.xml";
        /// <summary>
        /// The www techradar com constant.
        /// </summary>
        public const string WwwTechradarCom = "https://www.techradar.com/rss";
        /// <summary>
        /// The www wired com constant.
        /// </summary>
        public const string WwwWiredCom = "https://www.wired.com/feed/rss";
        /// <summary>
        /// The feeds arstechnica com constant.
        /// </summary>
        public const string FeedsArstechnicaCom = "http://feeds.arstechnica.com/arstechnica/index";
        /// <summary>
        /// The thenextweb com constant.
        /// </summary>
        public const string ThenextwebCom = "https://thenextweb.com/feed/";
        /// <summary>
        /// The www tomshardware com constant.
        /// </summary>
        public const string WwwTomshardwareCom = "https://www.tomshardware.com/feeds/all";
        /// <summary>
        /// The reflection type.
        /// </summary>
        public static Type ReflectionType = typeof(TechSitesRss);

        /// <summary>
        /// Gets or sets the sites with images.
        /// </summary>
        public static List<string> SitesWithImages { get; set; } = new List<string>(["thenextwebCom", "wwwEngadgetCom"]);
    }

    public static partial class YouTube
    {
        /// <summary>
        /// The yt video start constant.
        /// </summary>
        public const string YtVideoStart = "https://www.youtube.com/watch?v=";

        /// <summary>
        /// Gets YouTube search URL for the specified search query.
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>The YouTube search URL.</returns>
        public static string GetLinkToSearch(string searchQuery) => "https://www.youtube.com/results?search_query=" + HttpUtility.UrlEncode(searchQuery);

        /// <summary>
        /// Gets YouTube video URL for the specified video code.
        /// </summary>
        /// <param name="videoCode">The YouTube video code.</param>
        /// <returns>The YouTube video URL.</returns>
        public static string GetLinkToVideo(string videoCode) => YtVideoStart + videoCode;

        /// <summary>
        /// Gets HTML anchor element for the specified YouTube video code.
        /// </summary>
        /// <param name="videoCode">The YouTube video code.</param>
        /// <returns>An HTML anchor element linking to the video.</returns>
        public static string GetHtmlAnchor(string videoCode) => "<a href='" + GetLinkToVideo(videoCode) + "'>" + videoCode + "</a>";
    }

    /// <summary>
    /// Represents the repas nb price after sold type.
    /// </summary>
    public static class RepasNbPriceAfterSold
    {
        /// <summary>
        /// The www incomputer cz constant.
        /// </summary>
        public const string WwwIncomputerCz = "www.incomputer.cz";
        /// <summary>
        /// The www digifit cz constant.
        /// </summary>
        public const string WwwDigifitCz = "www.digifit.cz";
        /// <summary>
        /// The www repasy eu constant.
        /// </summary>
        public const string WwwRepasyEu = "www.repasy.eu";
        /// <summary>
        /// The www pocitace 24 cz constant.
        /// </summary>
        public const string WwwPocitace24Cz = "www.pocitace24.cz";
        /// <summary>
        /// The www it bazar cz constant.
        /// </summary>
        public const string WwwItBazarCz = "www.it-bazar.cz";
        /// <summary>
        /// The www CC cz constant.
        /// </summary>
        public const string WwwCCCz = "www.c-c.cz";
        /// <summary>
        /// The www stilcomp cz constant.
        /// </summary>
        public const string WwwStilcompCz = "www.stilcomp.cz";
        /// <summary>
        /// The www notebooky nejlevneji cz constant.
        /// </summary>
        public const string WwwNotebookyNejlevnejiCz = "www.notebooky-nejlevneji.cz";
        /// <summary>
        /// The www furbify cz constant.
        /// </summary>
        public const string WwwFurbifyCz = "www.furbify.cz";
        /// <summary>
        /// The www levnejsinotebooky cz constant.
        /// </summary>
        public const string WwwLevnejsinotebookyCz = "www.levnejsinotebooky.cz";
    }

    /// <summary>
    /// Represents the repas nb maybe price after sold type.
    /// </summary>
    public static class RepasNbMaybePriceAfterSold
    {
        /// <summary>
        /// The superlevnapc cz constant.
        /// </summary>
        public const string SuperlevnapcCz = "superlevnapc.cz";
        /// <summary>
        /// The www refurbished cz constant.
        /// </summary>
        public const string WwwRefurbishedCz = "www.refurbished.cz";
        /// <summary>
        /// The www nextwind cz constant.
        /// </summary>
        public const string WwwNextwindCz = "www.nextwind.cz";
        /// <summary>
        /// The www device cz constant.
        /// </summary>
        public const string WwwDeviceCz = "www.device.cz";
        /// <summary>
        /// The www malicomputer cz constant.
        /// </summary>
        public const string WwwMalicomputerCz = "www.malicomputer.cz";
        /// <summary>
        /// The www mujnotebook cz constant.
        /// </summary>
        public const string WwwMujnotebookCz = "www.mujnotebook.cz";
        /// <summary>
        /// The www notebookarna cz constant.
        /// </summary>
        public const string WwwNotebookarnaCz = "www.notebookarna.cz";
        /// <summary>
        /// The eracomp cz constant.
        /// </summary>
        public const string EracompCz = "eracomp.cz";
        /// <summary>
        /// The www zebracomp cz constant.
        /// </summary>
        public const string WwwZebracompCz = "www.zebracomp.cz";
    }

    /// <summary>
    /// Represents the repas nb type.
    /// </summary>
    public static class RepasNb
    {
        /// <summary>
        /// The www pocitacezababku cz constant.
        /// </summary>
        public const string WwwPocitacezababkuCz = "www.pocitacezababku.cz";
        /// <summary>
        /// The www alza cz constant.
        /// </summary>
        public const string WwwAlzaCz = "www.alza.cz";
        /// <summary>
        /// The www tera cz constant.
        /// </summary>
        public const string WwwTeraCz = "www.tera.cz";
        /// <summary>
        /// The www importpc cz constant.
        /// </summary>
        public const string WwwImportpcCz = "www.importpc.cz";
        /// <summary>
        /// The www technimax cz constant.
        /// </summary>
        public const string WwwTechnimaxCz = "www.technimax.cz";
        /// <summary>
        /// The www itzoo cz constant.
        /// </summary>
        public const string WwwItzooCz = "www.itzoo.cz";
        /// <summary>
        /// The www eurotech cz constant.
        /// </summary>
        public const string WwwEurotechCz = "www.eurotech.cz";
        /// <summary>
        /// The www r pass cz constant.
        /// </summary>
        public const string WwwRPassCz = "www.r-pass.cz";
    }

    /// <summary>
    /// Represents the browser extensions type.
    /// </summary>
    public static class BrowserExtensions
    {
        /// <summary>
        /// The edge addons constant.
        /// </summary>
        public const string EdgeAddons = "https://microsoftedge.microsoft.com/addons/search/%s";
        /// <summary>
        /// The chrome web store constant.
        /// </summary>
        public const string ChromeWebStore = "https://chrome.google.com/webstore/search/%s?hl=en-US";
    }
}
