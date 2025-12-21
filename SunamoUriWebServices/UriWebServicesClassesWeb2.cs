namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

public partial class UriWebServices
{
    public static class SpiceMarks
    {
        private static List<string> s_list;
        public static void SearchInAll(string spicyName)
        {
            if (s_list == null)
            {
                s_list = new List<string>(new List<string>(["kotanyi", "avok\u00E1do", "nadir", "Orient", "Drago", "Vitana", "sv\u011Bt bylinek"]));
            }

            foreach (var item in s_list)
                UriWebServices.OpenUri(GoogleSearch($"{item} koření {spicyName}"));
        }
    }

    public static class CashBack
    {
        public const string vratnepenize = "https://www.vratnepenize.cz/zbozi/hledej?g=%s";
        public const string tipli = "https://www.tipli.cz/hledat/%s";
        public const string plnapenezenka = "https://www.plnapenezenka.cz/hledej/%s";
        public static readonly List<string> All = new List<string>([vratnepenize, tipli, plnapenezenka]);
    }

    public static class HorticultureWholeCzech
    {
        public const string wwwZahradnictviFlosCz = "https://www.zahradnictvi-flos.cz/vyhledavani/%s?productFilter-s%5B13%5D=%s";
        public const string eshopStarklCom = "https://eshop.starkl.com/search/?q=%s";
        public const string wwwHornbachCz = "https://www.hornbach.cz/shop/vyhledavani/sortiment/%s";
        public const string wwwObiCz = "https://www.obi.cz/search/%s/";
        public static readonly List<string> All = new List<string>([wwwZahradnictviFlosCz, eshopStarklCom, wwwHornbachCz, wwwObiCz]);
    }

    public static class HorticultureHavirovAndSurroundings
    {
        public const string wwwZahradnictviporubaCz = "https://www.zahradnictviporuba.cz/";
        public const string wwwKornerCz = "https://www.korner.cz";
        public const string wwwHavlinaCz = "https://www.havlina.cz/";
        public const string wwwZahradnictviSimkovaCz = "https://www.zahradnictvi-simkova.cz";
        public const string zahradnictviDetmaroviceWebnodeCz = "https://zahradnictvi-detmarovice.webnode.cz/";
        public const string wwwFrutoCz = "https://www.fruto.cz/";
        public const string wwwZahradnictvikrhutCz = "https://www.zahradnictvikrhut.cz";
        public const string wwwZupazCz = "https://www.zupaz.cz/";
        public const string wwwVahamoCz = "https://www.vahamo.cz";
        public const string eshopPasicCz = "https://eshop.pasic.cz";
        public static List<string> All()
        {
            var fi = typeof(HorticultureHavirovAndSurroundings).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly && fi.FieldType == typeof(string)).Select(x => (string)x.GetRawConstantValue()).ToList();
            return fi;
        }
    }

    public static class EnglishMobileParts
    {
        /// <summary>
        ///     eb
        /// </summary>
        public const string ebay = "https://www.ebay.com/sch/i.html?_nkw=%";
        /// <summary>
        ///     wt
        /// </summary>
        public const string witrigs = "https://www.witrigs.com/searchautocomplete/autoresult?q=%";
        /// <summary>
        ///     ae
        /// </summary>
        public const string aliexpress = "https://www.aliexpress.com/wholesale?SearchText=%s";
        public static readonly List<string> All = new()
        {
            ebay,
            witrigs,
            aliexpress
        };
        public static void SearchInAll(string what)
        {
            UriWebServices.SearchInAll(All, what);
        }
    }

    public static class Business
    {
        public const string wwwFirmoCz = "www.firmo.cz";
        public const string rejstrikPenizeCz = "rejstrik.penize.cz";
        public const string wwwFirmyCz = "www.firmy.cz";
        public const string rejstrikFiremKurzyCz = "rejstrik-firem.kurzy.cz";
        public const string wwwPodnikatelCz = "www.podnikatel.cz";
        public const string rejstrikyFinanceCz = "rejstriky.finance.cz";
        public static List<string> All = new List<string>([wwwFirmoCz, rejstrikPenizeCz, wwwFirmyCz, rejstrikFiremKurzyCz, wwwPodnikatelCz, rejstrikyFinanceCz]);
    }

    public static class MyBlogs
    {
        public const string jpnAdminAllPosts = @"https://jepsano.net/wp-admin/edit.php?s=%s&post_status=all&post_type=post&action=-1&m=0&cat=0&seo_filter&readability_filter&paged=1&action2=-1";
    }

    public static class AutomotiveSpareParts
    {
        public const string wwwAutokseftCz = "https://www.autokseft.cz/index.php?main_page=shop_search&keyword=%s";
        public const string wwwAutodocCz = "https://www.autodoc.cz/search?keyword=%";
        public const string wwwNahradniDilyZhCz = "https://www.nahradni-dily-zh.cz/search.asp?searchinput=%";
        public const string wwwAutomobilovedilyCz = "https://www.automobilovedily24.cz/search?keyword=%";
        public static List<string> All = new List<string>([wwwAutokseftCz, wwwAutodocCz, wwwNahradniDilyZhCz, wwwAutomobilovedilyCz]);
    }

    public static class UriShareService
    {
        public static List<string> domains;
        static UriShareService()
        {
            domains = new List<string>(["mega.co", "uploading.com", "zippyshare.com", "box.com", "rapidshare.com", "dfiles.eu", "4shared.com", "mediafire.com", "dropbox.com", "bayfiles.com", "divxstage.eu", "hulkshare.com", "megashares", "files.fm", "wetransfer.com", "filehosting.org", "yourfilelink.com"]);
        }
    }

    public static class CdnProviders
    {
        //
        public const string cdnjs = "https://api.cdnjs.com/libraries?search=%";
        /// <summary>
        ///     Search for everything on npm
        /// </summary>
        public const string npmjs = "https://www.npmjs.com/search?q=%";
        public const string npmjsp = "https://www.npmjs.com/package/%s";
        //public const string cdnjs = "";
        //public const string cdnjs = "";
        //public const string cdnjs = "";
        //public const string cdnjs = "";
        public static readonly List<string> All = new List<string>([cdnjs, npmjs]);
    }

    public static class RemoteJobs
    {
        public const string WwwFlexjobsCom = "https://www.flexjobs.com/search?search=%s&location=";
        public const string AngelCo = "https://angel.co/jobs#find/f!%7B%22remote%22%3Atrue%2C%22keywords%22%3A%5B%22%s%22%5D%7D";
        public const string TalentHubstaffCom = "https://talent.hubstaff.com/search/jobs?search%5Bkeywords%5D=%s&page=1&search%5Btype%5D=&search%5Blast_slider%5D=&search%5Bnewer_than%5D=&search%5Bnewer_than%5D=&search%5Bpayrate_start%5D=1&search%5Bpayrate_end%5D=100%2B&search%5Bpayrate_null%5D=0&search%5Bpayrate_null%5D=1&search%5Bbudget_start%5D=1&search%5Bbudget_end%5D=100000%2B&search%5Bbudget_null%5D=0&search%5Bbudget_null%5D=1&search%5Bexperience_level%5D=-1&search%5Bcountries%5D%5B%5D=&search%5Blanguages%5D%5B%5D=&search%5Bsort_by%5D=relevance";
        // not fulltext, always search only for exact position https://pangian.com/job-travel-remote/
        //public const string PangianCom = "";
        public const string RemoteCom = "https://remote.com/jobs/browse?keyword=%";
        // https://remote.co/search-results/?cx=009859377982936732048%3Awihm_nznrgm
        public const string RemoteCo = "https://remote.co/remote-jobs/search/?search_keywords=%";
        public const string WeworkremotelyCom = "https://weworkremotely.com/remote-jobs/search?utf8=%E2%9C%93&term=%s";
        public const string JobspressoCo = "https://jobspresso.co/remote-work/#%s=1";
        //https://remoteok.io/remote-virtual-assistant-jobs
        public const string RemoteokIo = "https://remoteok.io/";
        //https://www.workingnomads.co/jobs
        public const string WwwWorkingnomadsCo = "https://www.workingnomads.co";
        public const string StackoverflowCom = "https://stackoverflow.com/jobs?q=%";
        public static List<string> All = new List<string>([WwwFlexjobsCom, AngelCo, TalentHubstaffCom, RemoteCo, WeworkremotelyCom, JobspressoCo, StackoverflowCom]);
    }

    public static class Libraries
    {
        /// <summary>
        ///     Narodni knihovna
        /// </summary>
        public const string nkp = @"https://aleph.nkp.cz/F/K1AF26NFNIRG8S216J2Q7YBV19F2F8LF11VEA4AY4I2L2Y42M3-55374?func=find-b&find_code=WRD&x=0&y=0&request=%s&filter_code_1=WTP&filter_request_1=&filter_code_2=WLN&adjacent=N";
        public const string vsb = "https://katalog.vsb.cz/search?type=global&q=%s";
        /// <summary>
        ///     Knihovna akademie ved
        /// </summary>
        public const string cas = @"https://vufind.lib.cas.cz/ustav/KNAV/Search/Results?type=AllFields&institution=KNAV&filter%5B%5D=institution%3AKNAV&lookfor=%s&rQhtuXCSid=04u.IQRKfg&swLoQZTxFJEVbrgB=_oD3lR7wWZ6Sx0yt&umXNFi=c5lOmp&rQhtuXCSid=04u.IQRKfg&swLoQZTxFJEVbrgB=_oD3lR7wWZ6Sx0yt&umXNFi=c5lOmp";
        public const string mlp = "https://search.mlp.cz/en/?query=%s&kde=all#/c_s_ol=query-eq:%s";
        public const string kmoAll = "https://tritius.kmo.cz/Katalog/search?q=%s&area=247&field=0";
        public const string kmoAV = "https://tritius.kmo.cz/Katalog/search?q=%s&area=238&field=0";
        public const string kmoMP = "https://tritius.kmo.cz/Katalog/search?q=%s&area=242&field=0";
        public const string svkos = "https://katalog.svkos.cz/F/JSAUCF45R2HDYLIMN5CFCRTY5LIRAYKG33QJR7IT42N8G4X53M-60701?func=find-b&request=%s&x=0&y=0&find_code=WRD&adjacent=N&local_base=KATALOG&filter_code_4=WFM&filter_request_4=&filter_code_1=WLN&filter_request_1=&filter_code_2=WYR&filter_request_2=&filter_code_3=WYR&filter_request_3=";
        public const string dk = "https://www.databazeknih.cz/search?q=%s&hledat=";
    }

    /// <summary>
    ///     Is possible user also OpenInBrowser.OpenCachesFromCacheList
    /// </summary>
    public class GeoCachingComSite
    {
        public static string CacheDetails(string cacheGuid)
        {
            return "https://www.geocaching.com/seek/cache_details.aspx?guid=" + cacheGuid;
        }

        public static string Gallery(string cacheGuid)
        {
            return "https://www.geocaching.com/seek/gallery.aspx?guid=" + cacheGuid;
        }

        public static string Log(string cacheGuid)
        {
            return "https://www.geocaching.com/seek/log.aspx?guid=" + cacheGuid;
        }

        public static string CoordsInfo(string f)
        {
            return "https://coords.info/" + f;
        }

        public static string GC(string f)
        {
            return "https://coords.info/GC" + f;
        }
    }

    public partial class Facebook
    {
        public static string FbTopSearch(string q)
        {
            return FromChromeReplacement("https://www.facebook.com/search/top/?q=%s&epa=SEARCH_BOX", q);
        }
    }
}