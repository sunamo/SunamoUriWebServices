namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

public partial class UriWebServices
{
    public static partial class YouTube
    {
        public static void SearchYouTubeSerialSerie(int partCount, int seasonNumber, string showName)
        {
            partCount++;
            for (var index = 1; index < partCount; index++)
                UriWebServices.OpenUri(GetLinkToSearch(showName + " " + seasonNumber + " x " + index));
        }

        public static string ReplaceOperators(string text) => SHReplace.ReplaceAll(text, "", "OR", "+", "-", "\"", "*");

        public static string ParseYtCode(string uri)
        {
            return ParseYtCode(uri);
        }
    }

    public static class CinemaMsk
    {
        public const string K3bohumin = "https://www.k3bohumin.cz/cz/search/?search_string=s";
        public const string Kosmos = "https://www.google.com/search?q=site%3Akinokosmos.cz+s";
        public const string Dkorlova = "https://www.google.com/search?q=site%3Adkorlova.cz+s";
        public const string Kinokarvina = "https://www.google.com/search?q=site%3Akinokarvina.cz+s";
    }

    public static class TechSitesRss
    {
        public const string FeedsFeedburnerCom = "http://feeds.feedburner.com/TechCrunch/";
        public const string WwwEngadgetCom = "http://www.engadget.com/rss.xml";
        // unknown RSS feed format
        public const string WwwThevergeCom = "http://www.theverge.com/rss/index.xml";
        public const string WwwSciencedailyCom = "https://www.sciencedaily.com/rss/all.xml";
        public const string WwwTechradarCom = "https://www.techradar.com/rss";
        public const string WwwWiredCom = "https://www.wired.com/feed/rss";
        public const string FeedsArstechnicaCom = "http://feeds.arstechnica.com/arstechnica/index";
        public const string ThenextwebCom = "https://thenextweb.com/feed/";
        public const string WwwTomshardwareCom = "https://www.tomshardware.com/feeds/all";
        public static Type ReflectionType = typeof(TechSitesRss);

        public static List<string> SitesWithImages { get; set; } = new List<string>(["thenextwebCom", "wwwEngadgetCom"]);
    }

    public static partial class YouTube
    {
        public const string YtVideoStart = "https://www.youtube.com/watch?v=";

        public static string GetLinkToSearch(string searchQuery) => "https://www.youtube.com/results?search_query=" + HttpUtility.UrlEncode(searchQuery);

        public static string GetLinkToVideo(string videoCode) => YtVideoStart + videoCode;

        public static string GetHtmlAnchor(string videoCode) => "<a href='" + GetLinkToVideo(videoCode) + "'>" + videoCode + "</a>";
    }

    public static class RepasNbPriceAfterSold
    {
        public const string WwwIncomputerCz = "www.incomputer.cz";
        public const string WwwDigifitCz = "www.digifit.cz";
        public const string WwwRepasyEu = "www.repasy.eu";
        public const string WwwPocitace24Cz = "www.pocitace24.cz";
        public const string WwwItBazarCz = "www.it-bazar.cz";
        public const string WwwCCCz = "www.c-c.cz";
        public const string WwwStilcompCz = "www.stilcomp.cz";
        public const string WwwNotebookyNejlevnejiCz = "www.notebooky-nejlevneji.cz";
        public const string WwwFurbifyCz = "www.furbify.cz";
        public const string WwwLevnejsinotebookyCz = "www.levnejsinotebooky.cz";
    }

    public static class RepasNbMaybePriceAfterSold
    {
        public const string SuperlevnapcCz = "superlevnapc.cz";
        public const string WwwRefurbishedCz = "www.refurbished.cz";
        public const string WwwNextwindCz = "www.nextwind.cz";
        public const string WwwDeviceCz = "www.device.cz";
        public const string WwwMalicomputerCz = "www.malicomputer.cz";
        public const string WwwMujnotebookCz = "www.mujnotebook.cz";
        public const string WwwNotebookarnaCz = "www.notebookarna.cz";
        public const string EracompCz = "eracomp.cz";
        public const string WwwZebracompCz = "www.zebracomp.cz";
    }

    public static class RepasNb
    {
        public const string WwwPocitacezababkuCz = "www.pocitacezababku.cz";
        public const string WwwAlzaCz = "www.alza.cz";
        public const string WwwTeraCz = "www.tera.cz";
        public const string WwwImportpcCz = "www.importpc.cz";
        public const string WwwTechnimaxCz = "www.technimax.cz";
        public const string WwwItzooCz = "www.itzoo.cz";
        public const string WwwEurotechCz = "www.eurotech.cz";
        public const string WwwRPassCz = "www.r-pass.cz";
    }

    public static class BrowserExtensions
    {
        public const string EdgeAddons = "https://microsoftedge.microsoft.com/addons/search/%s";
        public const string ChromeWebStore = "https://chrome.google.com/webstore/search/%s?hl=en-US";
    }
}
