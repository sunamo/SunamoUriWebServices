namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

public partial class UriWebServices
{
    /// <summary>
    /// Represents the spice marks type.
    /// </summary>
    public static class SpiceMarks
    {
        private static List<string>? brandsList;

        /// <summary>
        /// Search in all.
        /// </summary>
        /// <param name="spicyName">The spicy name.</param>
        public static void SearchInAll(string spicyName)
        {
            if (brandsList == null)
            {
                brandsList = new List<string>(new List<string>(["kotanyi", "avokádo", "nadir", "Orient", "Drago", "Vitana", "svět bylinek"]));
            }

            foreach (var item in brandsList)
                UriWebServices.OpenUri(GoogleSearch($"{item} koření {spicyName}"));
        }
    }

    /// <summary>
    /// Represents the cash back type.
    /// </summary>
    public static class CashBack
    {
        /// <summary>
        /// The vratnepenize constant.
        /// </summary>
        public const string Vratnepenize = "https://www.vratnepenize.cz/zbozi/hledej?g=%s";
        /// <summary>
        /// The tipli constant.
        /// </summary>
        public const string Tipli = "https://www.tipli.cz/hledat/%s";
        /// <summary>
        /// The plnapenezenka constant.
        /// </summary>
        public const string Plnapenezenka = "https://www.plnapenezenka.cz/hledej/%s";

        /// <summary>
        /// The all.
        /// </summary>
        public static readonly List<string> All = new List<string>([Vratnepenize, Tipli, Plnapenezenka]);
    }

    /// <summary>
    /// Represents the horticulture whole czech type.
    /// </summary>
    public static class HorticultureWholeCzech
    {
        /// <summary>
        /// The www zahradnictvi flos cz constant.
        /// </summary>
        public const string WwwZahradnictviFlosCz = "https://www.zahradnictvi-flos.cz/vyhledavani/%s?productFilter-s%5B13%5D=%s";
        /// <summary>
        /// The eshop starkl com constant.
        /// </summary>
        public const string EshopStarklCom = "https://eshop.starkl.com/search/?q=%s";
        /// <summary>
        /// The www hornbach cz constant.
        /// </summary>
        public const string WwwHornbachCz = "https://www.hornbach.cz/shop/vyhledavani/sortiment/%s";
        /// <summary>
        /// The www obi cz constant.
        /// </summary>
        public const string WwwObiCz = "https://www.obi.cz/search/%s/";

        /// <summary>
        /// The all.
        /// </summary>
        public static readonly List<string> All = new List<string>([WwwZahradnictviFlosCz, EshopStarklCom, WwwHornbachCz, WwwObiCz]);
    }

    /// <summary>
    /// Represents the horticulture havirov and surroundings type.
    /// </summary>
    public static class HorticultureHavirovAndSurroundings
    {
        /// <summary>
        /// The www zahradnictviporuba cz constant.
        /// </summary>
        public const string WwwZahradnictviporubaCz = "https://www.zahradnictviporuba.cz/";
        /// <summary>
        /// The www korner cz constant.
        /// </summary>
        public const string WwwKornerCz = "https://www.korner.cz";
        /// <summary>
        /// The www havlina cz constant.
        /// </summary>
        public const string WwwHavlinaCz = "https://www.havlina.cz/";
        /// <summary>
        /// The www zahradnictvi simkova cz constant.
        /// </summary>
        public const string WwwZahradnictviSimkovaCz = "https://www.zahradnictvi-simkova.cz";
        /// <summary>
        /// The zahradnictvi detmarovice webnode cz constant.
        /// </summary>
        public const string ZahradnictviDetmaroviceWebnodeCz = "https://zahradnictvi-detmarovice.webnode.cz/";
        /// <summary>
        /// The www fruto cz constant.
        /// </summary>
        public const string WwwFrutoCz = "https://www.fruto.cz/";
        /// <summary>
        /// The www zahradnictvikrhut cz constant.
        /// </summary>
        public const string WwwZahradnictvikrhutCz = "https://www.zahradnictvikrhut.cz";
        /// <summary>
        /// The www zupaz cz constant.
        /// </summary>
        public const string WwwZupazCz = "https://www.zupaz.cz/";
        /// <summary>
        /// The www vahamo cz constant.
        /// </summary>
        public const string WwwVahamoCz = "https://www.vahamo.cz";
        /// <summary>
        /// The eshop pasic cz constant.
        /// </summary>
        public const string EshopPasicCz = "https://eshop.pasic.cz";

        /// <summary>
        /// All.
        /// </summary>
        /// <typeparam name="string">The type string.</typeparam>
        /// <param name="WwwObiCz]">The www obi cz.</param>
        /// <returns>The all result.</returns>
        public static List<string> All()
        {
            return typeof(HorticultureHavirovAndSurroundings)
                .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                .Where(fieldInfo => fieldInfo.IsLiteral && !fieldInfo.IsInitOnly && fieldInfo.FieldType == typeof(string))
                .Select(fieldInfo => (string)fieldInfo.GetRawConstantValue()!)
                .ToList();
        }
    }

    /// <summary>
    /// Represents the english mobile parts type.
    /// </summary>
    public static class EnglishMobileParts
    {
        /// <summary>
        /// The ebay constant.
        /// </summary>
        public const string Ebay = "https://www.ebay.com/sch/i.html?_nkw=%";
        /// <summary>
        /// The witrigs constant.
        /// </summary>
        public const string Witrigs = "https://www.witrigs.com/searchautocomplete/autoresult?q=%";
        /// <summary>
        /// The aliexpress constant.
        /// </summary>
        public const string Aliexpress = "https://www.aliexpress.com/wholesale?SearchText=%s";

        /// <summary>
        /// The all.
        /// </summary>
        public static readonly List<string> All = new()
        {
            Ebay,
            Witrigs,
            Aliexpress
        };

        /// <summary>
        /// Search in all.
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        public static void SearchInAll(string searchQuery)
        {
            UriWebServices.SearchInAll(All, searchQuery);
        }
    }

    /// <summary>
    /// Represents the business type.
    /// </summary>
    public static class Business
    {
        /// <summary>
        /// The www firmo cz constant.
        /// </summary>
        public const string WwwFirmoCz = "www.firmo.cz";
        /// <summary>
        /// The rejstrik penize cz constant.
        /// </summary>
        public const string RejstrikPenizeCz = "rejstrik.penize.cz";
        /// <summary>
        /// The www firmy cz constant.
        /// </summary>
        public const string WwwFirmyCz = "www.firmy.cz";
        /// <summary>
        /// The rejstrik firem kurzy cz constant.
        /// </summary>
        public const string RejstrikFiremKurzyCz = "rejstrik-firem.kurzy.cz";
        /// <summary>
        /// The www podnikatel cz constant.
        /// </summary>
        public const string WwwPodnikatelCz = "www.podnikatel.cz";
        /// <summary>
        /// The rejstriky finance cz constant.
        /// </summary>
        public const string RejstrikyFinanceCz = "rejstriky.finance.cz";

        /// <summary>
        /// Gets or sets the all.
        /// </summary>
        public static List<string> All { get; set; } = new List<string>([WwwFirmoCz, RejstrikPenizeCz, WwwFirmyCz, RejstrikFiremKurzyCz, WwwPodnikatelCz, RejstrikyFinanceCz]);
    }

    /// <summary>
    /// Represents the my blogs type.
    /// </summary>
    public static class MyBlogs
    {
        /// <summary>
        /// The jpn admin all posts constant.
        /// </summary>
        public const string JpnAdminAllPosts = @"https://jepsano.net/wp-admin/edit.php?s=%s&post_status=all&post_type=post&action=-1&m=0&cat=0&seo_filter&readability_filter&paged=1&action2=-1";
    }

    /// <summary>
    /// Represents the automotive spare parts type.
    /// </summary>
    public static class AutomotiveSpareParts
    {
        /// <summary>
        /// The www autokseft cz constant.
        /// </summary>
        public const string WwwAutokseftCz = "https://www.autokseft.cz/index.php?main_page=shop_search&keyword=%s";
        /// <summary>
        /// The www autodoc cz constant.
        /// </summary>
        public const string WwwAutodocCz = "https://www.autodoc.cz/search?keyword=%";
        /// <summary>
        /// The www nahradni dily zh cz constant.
        /// </summary>
        public const string WwwNahradniDilyZhCz = "https://www.nahradni-dily-zh.cz/search.asp?searchinput=%";
        /// <summary>
        /// The www automobilovedily cz constant.
        /// </summary>
        public const string WwwAutomobilovedilyCz = "https://www.automobilovedily24.cz/search?keyword=%";

        /// <summary>
        /// Gets or sets the all.
        /// </summary>
        public static List<string> All { get; set; } = new List<string>([WwwAutokseftCz, WwwAutodocCz, WwwNahradniDilyZhCz, WwwAutomobilovedilyCz]);
    }

    /// <summary>
    /// Represents the uri share service type.
    /// </summary>
    public static class UriShareService
    {
        /// <summary>
        /// Gets or sets the domains.
        /// </summary>
        public static List<string> Domains { get; set; }

        static UriShareService()
        {
            Domains = new List<string>(["mega.co", "uploading.com", "zippyshare.com", "box.com", "rapidshare.com", "dfiles.eu", "4shared.com", "mediafire.com", "dropbox.com", "bayfiles.com", "divxstage.eu", "hulkshare.com", "megashares", "files.fm", "wetransfer.com", "filehosting.org", "yourfilelink.com"]);
        }
    }

    /// <summary>
    /// Represents the cdn providers type.
    /// </summary>
    public static class CdnProviders
    {
        /// <summary>
        /// The cdnjs constant.
        /// </summary>
        public const string Cdnjs = "https://api.cdnjs.com/libraries?search=%";
        /// <summary>
        /// The npmjs constant.
        /// </summary>
        public const string Npmjs = "https://www.npmjs.com/search?q=%";
        /// <summary>
        /// The npmjsp constant.
        /// </summary>
        public const string Npmjsp = "https://www.npmjs.com/package/%s";

        /// <summary>
        /// The all.
        /// </summary>
        public static readonly List<string> All = new List<string>([Cdnjs, Npmjs]);
    }

    /// <summary>
    /// Represents the remote jobs type.
    /// </summary>
    public static class RemoteJobs
    {
        /// <summary>
        /// The www flexjobs com constant.
        /// </summary>
        public const string WwwFlexjobsCom = "https://www.flexjobs.com/search?search=%s&location=";
        /// <summary>
        /// The angel co constant.
        /// </summary>
        public const string AngelCo = "https://angel.co/jobs#find/f!%7B%22remote%22%3Atrue%2C%22keywords%22%3A%5B%22%s%22%5D%7D";
        /// <summary>
        /// The talent hubstaff com constant.
        /// </summary>
        public const string TalentHubstaffCom = "https://talent.hubstaff.com/search/jobs?search%5Bkeywords%5D=%s&page=1&search%5Btype%5D=&search%5Blast_slider%5D=&search%5Bnewer_than%5D=&search%5Bnewer_than%5D=&search%5Bpayrate_start%5D=1&search%5Bpayrate_end%5D=100%2B&search%5Bpayrate_null%5D=0&search%5Bpayrate_null%5D=1&search%5Bbudget_start%5D=1&search%5Bbudget_end%5D=100000%2B&search%5Bbudget_null%5D=0&search%5Bbudget_null%5D=1&search%5Bexperience_level%5D=-1&search%5Bcountries%5D%5B%5D=&search%5Blanguages%5D%5B%5D=&search%5Bsort_by%5D=relevance";
        /// <summary>
        /// The remote com constant.
        /// </summary>
        public const string RemoteCom = "https://remote.com/jobs/browse?keyword=%";
        /// <summary>
        /// The remote co constant.
        /// </summary>
        public const string RemoteCo = "https://remote.co/remote-jobs/search/?search_keywords=%";
        /// <summary>
        /// The weworkremotely com constant.
        /// </summary>
        public const string WeworkremotelyCom = "https://weworkremotely.com/remote-jobs/search?utf8=%E2%9C%93&term=%s";
        /// <summary>
        /// The jobspresso co constant.
        /// </summary>
        public const string JobspressoCo = "https://jobspresso.co/remote-work/#%s=1";
        /// <summary>
        /// The remoteok io constant.
        /// </summary>
        public const string RemoteokIo = "https://remoteok.io/";
        /// <summary>
        /// The www workingnomads co constant.
        /// </summary>
        public const string WwwWorkingnomadsCo = "https://www.workingnomads.co";
        /// <summary>
        /// The stackoverflow com constant.
        /// </summary>
        public const string StackoverflowCom = "https://stackoverflow.com/jobs?q=%";

        /// <summary>
        /// Gets or sets the all.
        /// </summary>
        public static List<string> All { get; set; } = new List<string>([WwwFlexjobsCom, AngelCo, TalentHubstaffCom, RemoteCo, WeworkremotelyCom, JobspressoCo, StackoverflowCom]);
    }

    /// <summary>
    /// Represents the libraries type.
    /// </summary>
    public static class Libraries
    {
        /// <summary>
        /// The nkp constant.
        /// </summary>
        public const string Nkp = @"https://aleph.nkp.cz/F/K1AF26NFNIRG8S216J2Q7YBV19F2F8LF11VEA4AY4I2L2Y42M3-55374?func=find-b&find_code=WRD&x=0&y=0&request=%s&filter_code_1=WTP&filter_request_1=&filter_code_2=WLN&adjacent=N";
        /// <summary>
        /// The vsb constant.
        /// </summary>
        public const string Vsb = "https://katalog.vsb.cz/search?type=global&q=%s";
        /// <summary>
        /// The cas constant.
        /// </summary>
        public const string Cas = @"https://vufind.lib.cas.cz/ustav/KNAV/Search/Results?type=AllFields&institution=KNAV&filter%5B%5D=institution%3AKNAV&lookfor=%s&rQhtuXCSid=04u.IQRKfg&swLoQZTxFJEVbrgB=_oD3lR7wWZ6Sx0yt&umXNFi=c5lOmp&rQhtuXCSid=04u.IQRKfg&swLoQZTxFJEVbrgB=_oD3lR7wWZ6Sx0yt&umXNFi=c5lOmp";
        /// <summary>
        /// The mlp constant.
        /// </summary>
        public const string Mlp = "https://search.mlp.cz/en/?query=%s&kde=all#/c_s_ol=query-eq:%s";
        /// <summary>
        /// The kmo all constant.
        /// </summary>
        public const string KmoAll = "https://tritius.kmo.cz/Katalog/search?q=%s&area=247&field=0";
        /// <summary>
        /// The kmo AV constant.
        /// </summary>
        public const string KmoAV = "https://tritius.kmo.cz/Katalog/search?q=%s&area=238&field=0";
        /// <summary>
        /// The kmo MP constant.
        /// </summary>
        public const string KmoMP = "https://tritius.kmo.cz/Katalog/search?q=%s&area=242&field=0";
        /// <summary>
        /// The svkos constant.
        /// </summary>
        public const string Svkos = "https://katalog.svkos.cz/F/JSAUCF45R2HDYLIMN5CFCRTY5LIRAYKG33QJR7IT42N8G4X53M-60701?func=find-b&request=%s&x=0&y=0&find_code=WRD&adjacent=N&local_base=KATALOG&filter_code_4=WFM&filter_request_4=&filter_code_1=WLN&filter_request_1=&filter_code_2=WYR&filter_request_2=&filter_code_3=WYR&filter_request_3=";
        /// <summary>
        /// The dk constant.
        /// </summary>
        public const string Dk = "https://www.databazeknih.cz/search?q=%s&hledat=";
    }

    /// <summary>
    /// Represents the geo caching com site type.
    /// </summary>
    public class GeoCachingComSite
    {
        /// <summary>
        /// Gets the cache details URL for the specified cache GUID.
        /// </summary>
        /// <param name="cacheGuid">The cache GUID.</param>
        /// <returns>The cache details URL.</returns>
        public static string CacheDetails(string cacheGuid) => "https://www.geocaching.com/seek/cache_details.aspx?guid=" + cacheGuid;

        /// <summary>
        /// Gets the gallery URL for the specified cache GUID.
        /// </summary>
        /// <param name="cacheGuid">The cache GUID.</param>
        /// <returns>The cache gallery URL.</returns>
        public static string Gallery(string cacheGuid) => "https://www.geocaching.com/seek/gallery.aspx?guid=" + cacheGuid;

        /// <summary>
        /// Gets the log URL for the specified cache GUID.
        /// </summary>
        /// <param name="cacheGuid">The cache GUID.</param>
        /// <returns>The cache log URL.</returns>
        public static string Log(string cacheGuid) => "https://www.geocaching.com/seek/log.aspx?guid=" + cacheGuid;

        /// <summary>
        /// Gets the coords.info URL for the specified cache code.
        /// </summary>
        /// <param name="cacheCode">The cache code.</param>
        /// <returns>The coords.info URL.</returns>
        public static string CoordsInfo(string cacheCode) => "https://coords.info/" + cacheCode;

        /// <summary>
        /// Gets the coords.info URL for the specified GC code suffix.
        /// </summary>
        /// <param name="cacheCode">The GC code suffix.</param>
        /// <returns>The coords.info GC URL.</returns>
        public static string GC(string cacheCode) => "https://coords.info/GC" + cacheCode;
    }

    public partial class Facebook
    {
        /// <summary>
        /// Gets the Facebook top search URL for the specified search query.
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>The Facebook top search URL.</returns>
        public static string FbTopSearch(string searchQuery) => FromChromeReplacement("https://www.facebook.com/search/top/?q=%s&epa=SEARCH_BOX", searchQuery);
    }
}
