namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

public partial class UriWebServices
{
    /// <summary>
    ///     Summary description for YouTube
    /// </summary>
    public static partial class YouTube
    {
        public static void SearchYouTubeSerialSerie(int parts, int serie, string name)
        {
            parts++;
            for (var index = 1; index < parts; index++)
                UriWebServices.OpenUri(GetLinkToSearch(name + " " + serie + " x " + index));
        }

        public static string ReplaceOperators(string vstup)
        {
            return SHReplace.ReplaceAll(vstup, "", "OR", "+", "-", "\"", "*");
        }

        /// <summary>
        ///     G null pokud se YT kód nepodaří získat
        /// </summary>
        /// <param name = "uri"></param>
        public static string ParseYtCode(string uri)
        {
            return ParseYtCode(uri);
        }
    }

    public static class CinemaMsk
    {
        public const string k3bohumin = "https://www.k3bohumin.cz/cz/search/?search_string=s";
        public const string kosmos = "https://www.google.com/search?q=site%3Akinokosmos.cz+s";
        public const string dkorlova = "https://www.google.com/search?q=site%3Adkorlova.cz+s";
        public const string kinokarvina = "https://www.google.com/search?q=site%3Akinokarvina.cz+s";
    }

    public static class TechSitesRss
    {
        public const string feedsFeedburnerCom = "http://feeds.feedburner.com/TechCrunch/";
        public const string wwwEngadgetCom = "http://www.engadget.com/rss.xml";
        /// <summary>
        ///     Unknown rss feed
        /// </summary>
        public const string wwwThevergeCom = "http://www.theverge.com/rss/index.xml";
        public const string wwwSciencedailyCom = "https://www.sciencedaily.com/rss/all.xml";
        public const string wwwTechradarCom = "https://www.techradar.com/rss";
        public const string wwwWiredCom = "https://www.wired.com/feed/rss";
        public const string feedsArstechnicaCom = "http://feeds.arstechnica.com/arstechnica/index";
        public const string thenextwebCom = "https://thenextweb.com/feed/";
        public const string wwwTomshardwareCom = "https://www.tomshardware.com/feeds/all";
        public static Type type = typeof(TechSitesRss);
        public static List<string> haveImages = new List<string>(["thenextwebCom", "wwwEngadgetCom"]);
    }

    public static partial class YouTube
    {
        public const string ytVideoStart = "https://www.youtube.com/watch?v=";
        public static string GetLinkToSearch(string co)
        {
            return "https://www.youtube.com/results?search_query=" + HttpUtility.UrlEncode(co);
        }

        public static string GetLinkToVideo(string kod)
        {
            return ytVideoStart + kod;
        }

        public static string GetHtmlAnchor(string kod)
        {
            return "<a href='" + GetLinkToVideo(kod) + "'>" + kod + "</a>";
        }
    }

    // Zakomentoval jsem, kdyžtak odkomentovat a udělat to naopak ve UriWebServices.cs
    //public static Action<IList, string> SearchInAll;
    public static class RepasNbPriceAfterSold
    {
        public const string wwwIncomputerCz = "www.incomputer.cz";
        public const string wwwDigifitCz = "www.digifit.cz";
        public const string wwwRepasyEu = "www.repasy.eu";
        public const string wwwPocitace24Cz = "www.pocitace24.cz";
        public const string wwwItBazarCz = "www.it-bazar.cz";
        public const string wwwCCCz = "www.c-c.cz";
        public const string wwwStilcompCz = "www.stilcomp.cz";
        public const string wwwNotebookyNejlevnejiCz = "www.notebooky-nejlevneji.cz";
        public const string wwwFurbifyCz = "www.furbify.cz";
        public const string wwwLevnejsinotebookyCz = "www.levnejsinotebooky.cz";
    }

    public static class RepasNbMaybePriceAfterSold
    {
        public const string superlevnapcCz = "superlevnapc.cz";
        public const string wwwRefurbishedCz = "www.refurbished.cz";
        public const string wwwNextwindCz = "www.nextwind.cz";
        public const string wwwDeviceCz = "www.device.cz";
        public const string wwwMalicomputerCz = "www.malicomputer.cz";
        public const string wwwMujnotebookCz = "www.mujnotebook.cz";
        public const string wwwNotebookarnaCz = "www.notebookarna.cz";
        public const string eracompCz = "eracomp.cz";
        public const string wwwZebracompCz = "www.zebracomp.cz";
    }

    public static class RepasNb
    {
        public const string wwwPocitacezababkuCz = "www.pocitacezababku.cz";
        public const string wwwAlzaCz = "www.alza.cz";
        public const string wwwTeraCz = "www.tera.cz";
        public const string wwwImportpcCz = "www.importpc.cz";
        public const string wwwTechnimaxCz = "www.technimax.cz";
        public const string wwwItzooCz = "www.itzoo.cz";
        public const string wwwEurotechCz = "www.eurotech.cz";
        public const string wwwRPassCz = "www.r-pass.cz";
    }

    public static class BrowserExtensions
    {
        public const string edgeAddons = "https://microsoftedge.microsoft.com/addons/search/%s";
        public const string chromeWebStore = "https://chrome.google.com/webstore/search/%s?hl=en-US";
    }
}