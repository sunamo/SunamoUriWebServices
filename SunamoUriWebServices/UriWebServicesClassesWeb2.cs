namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

public partial class UriWebServices
{
    public static class SpiceMarks
    {
        private static List<string>? brandsList;

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

    public static class CashBack
    {
        public const string Vratnepenize = "https://www.vratnepenize.cz/zbozi/hledej?g=%s";
        public const string Tipli = "https://www.tipli.cz/hledat/%s";
        public const string Plnapenezenka = "https://www.plnapenezenka.cz/hledej/%s";

        public static readonly List<string> All = new List<string>([Vratnepenize, Tipli, Plnapenezenka]);
    }

    public static class HorticultureWholeCzech
    {
        public const string WwwZahradnictviFlosCz = "https://www.zahradnictvi-flos.cz/vyhledavani/%s?productFilter-s%5B13%5D=%s";
        public const string EshopStarklCom = "https://eshop.starkl.com/search/?q=%s";
        public const string WwwHornbachCz = "https://www.hornbach.cz/shop/vyhledavani/sortiment/%s";
        public const string WwwObiCz = "https://www.obi.cz/search/%s/";

        public static readonly List<string> All = new List<string>([WwwZahradnictviFlosCz, EshopStarklCom, WwwHornbachCz, WwwObiCz]);
    }

    public static class HorticultureHavirovAndSurroundings
    {
        public const string WwwZahradnictviporubaCz = "https://www.zahradnictviporuba.cz/";
        public const string WwwKornerCz = "https://www.korner.cz";
        public const string WwwHavlinaCz = "https://www.havlina.cz/";
        public const string WwwZahradnictviSimkovaCz = "https://www.zahradnictvi-simkova.cz";
        public const string ZahradnictviDetmaroviceWebnodeCz = "https://zahradnictvi-detmarovice.webnode.cz/";
        public const string WwwFrutoCz = "https://www.fruto.cz/";
        public const string WwwZahradnictvikrhutCz = "https://www.zahradnictvikrhut.cz";
        public const string WwwZupazCz = "https://www.zupaz.cz/";
        public const string WwwVahamoCz = "https://www.vahamo.cz";
        public const string EshopPasicCz = "https://eshop.pasic.cz";

        public static List<string> All()
        {
            return typeof(HorticultureHavirovAndSurroundings)
                .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                .Where(fieldInfo => fieldInfo.IsLiteral && !fieldInfo.IsInitOnly && fieldInfo.FieldType == typeof(string))
                .Select(fieldInfo => (string)fieldInfo.GetRawConstantValue()!)
                .ToList();
        }
    }

    public static class EnglishMobileParts
    {
        public const string Ebay = "https://www.ebay.com/sch/i.html?_nkw=%";
        public const string Witrigs = "https://www.witrigs.com/searchautocomplete/autoresult?q=%";
        public const string Aliexpress = "https://www.aliexpress.com/wholesale?SearchText=%s";

        public static readonly List<string> All = new()
        {
            Ebay,
            Witrigs,
            Aliexpress
        };

        public static void SearchInAll(string searchQuery)
        {
            UriWebServices.SearchInAll(All, searchQuery);
        }
    }

    public static class Business
    {
        public const string WwwFirmoCz = "www.firmo.cz";
        public const string RejstrikPenizeCz = "rejstrik.penize.cz";
        public const string WwwFirmyCz = "www.firmy.cz";
        public const string RejstrikFiremKurzyCz = "rejstrik-firem.kurzy.cz";
        public const string WwwPodnikatelCz = "www.podnikatel.cz";
        public const string RejstrikyFinanceCz = "rejstriky.finance.cz";

        public static List<string> All { get; set; } = new List<string>([WwwFirmoCz, RejstrikPenizeCz, WwwFirmyCz, RejstrikFiremKurzyCz, WwwPodnikatelCz, RejstrikyFinanceCz]);
    }

    public static class MyBlogs
    {
        public const string JpnAdminAllPosts = @"https://jepsano.net/wp-admin/edit.php?s=%s&post_status=all&post_type=post&action=-1&m=0&cat=0&seo_filter&readability_filter&paged=1&action2=-1";
    }

    public static class AutomotiveSpareParts
    {
        public const string WwwAutokseftCz = "https://www.autokseft.cz/index.php?main_page=shop_search&keyword=%s";
        public const string WwwAutodocCz = "https://www.autodoc.cz/search?keyword=%";
        public const string WwwNahradniDilyZhCz = "https://www.nahradni-dily-zh.cz/search.asp?searchinput=%";
        public const string WwwAutomobilovedilyCz = "https://www.automobilovedily24.cz/search?keyword=%";

        public static List<string> All { get; set; } = new List<string>([WwwAutokseftCz, WwwAutodocCz, WwwNahradniDilyZhCz, WwwAutomobilovedilyCz]);
    }

    public static class UriShareService
    {
        public static List<string> Domains { get; set; }

        static UriShareService()
        {
            Domains = new List<string>(["mega.co", "uploading.com", "zippyshare.com", "box.com", "rapidshare.com", "dfiles.eu", "4shared.com", "mediafire.com", "dropbox.com", "bayfiles.com", "divxstage.eu", "hulkshare.com", "megashares", "files.fm", "wetransfer.com", "filehosting.org", "yourfilelink.com"]);
        }
    }

    public static class CdnProviders
    {
        public const string Cdnjs = "https://api.cdnjs.com/libraries?search=%";
        public const string Npmjs = "https://www.npmjs.com/search?q=%";
        public const string Npmjsp = "https://www.npmjs.com/package/%s";

        public static readonly List<string> All = new List<string>([Cdnjs, Npmjs]);
    }

    public static class RemoteJobs
    {
        public const string WwwFlexjobsCom = "https://www.flexjobs.com/search?search=%s&location=";
        public const string AngelCo = "https://angel.co/jobs#find/f!%7B%22remote%22%3Atrue%2C%22keywords%22%3A%5B%22%s%22%5D%7D";
        public const string TalentHubstaffCom = "https://talent.hubstaff.com/search/jobs?search%5Bkeywords%5D=%s&page=1&search%5Btype%5D=&search%5Blast_slider%5D=&search%5Bnewer_than%5D=&search%5Bnewer_than%5D=&search%5Bpayrate_start%5D=1&search%5Bpayrate_end%5D=100%2B&search%5Bpayrate_null%5D=0&search%5Bpayrate_null%5D=1&search%5Bbudget_start%5D=1&search%5Bbudget_end%5D=100000%2B&search%5Bbudget_null%5D=0&search%5Bbudget_null%5D=1&search%5Bexperience_level%5D=-1&search%5Bcountries%5D%5B%5D=&search%5Blanguages%5D%5B%5D=&search%5Bsort_by%5D=relevance";
        public const string RemoteCom = "https://remote.com/jobs/browse?keyword=%";
        public const string RemoteCo = "https://remote.co/remote-jobs/search/?search_keywords=%";
        public const string WeworkremotelyCom = "https://weworkremotely.com/remote-jobs/search?utf8=%E2%9C%93&term=%s";
        public const string JobspressoCo = "https://jobspresso.co/remote-work/#%s=1";
        public const string RemoteokIo = "https://remoteok.io/";
        public const string WwwWorkingnomadsCo = "https://www.workingnomads.co";
        public const string StackoverflowCom = "https://stackoverflow.com/jobs?q=%";

        public static List<string> All { get; set; } = new List<string>([WwwFlexjobsCom, AngelCo, TalentHubstaffCom, RemoteCo, WeworkremotelyCom, JobspressoCo, StackoverflowCom]);
    }

    public static class Libraries
    {
        public const string Nkp = @"https://aleph.nkp.cz/F/K1AF26NFNIRG8S216J2Q7YBV19F2F8LF11VEA4AY4I2L2Y42M3-55374?func=find-b&find_code=WRD&x=0&y=0&request=%s&filter_code_1=WTP&filter_request_1=&filter_code_2=WLN&adjacent=N";
        public const string Vsb = "https://katalog.vsb.cz/search?type=global&q=%s";
        public const string Cas = @"https://vufind.lib.cas.cz/ustav/KNAV/Search/Results?type=AllFields&institution=KNAV&filter%5B%5D=institution%3AKNAV&lookfor=%s&rQhtuXCSid=04u.IQRKfg&swLoQZTxFJEVbrgB=_oD3lR7wWZ6Sx0yt&umXNFi=c5lOmp&rQhtuXCSid=04u.IQRKfg&swLoQZTxFJEVbrgB=_oD3lR7wWZ6Sx0yt&umXNFi=c5lOmp";
        public const string Mlp = "https://search.mlp.cz/en/?query=%s&kde=all#/c_s_ol=query-eq:%s";
        public const string KmoAll = "https://tritius.kmo.cz/Katalog/search?q=%s&area=247&field=0";
        public const string KmoAV = "https://tritius.kmo.cz/Katalog/search?q=%s&area=238&field=0";
        public const string KmoMP = "https://tritius.kmo.cz/Katalog/search?q=%s&area=242&field=0";
        public const string Svkos = "https://katalog.svkos.cz/F/JSAUCF45R2HDYLIMN5CFCRTY5LIRAYKG33QJR7IT42N8G4X53M-60701?func=find-b&request=%s&x=0&y=0&find_code=WRD&adjacent=N&local_base=KATALOG&filter_code_4=WFM&filter_request_4=&filter_code_1=WLN&filter_request_1=&filter_code_2=WYR&filter_request_2=&filter_code_3=WYR&filter_request_3=";
        public const string Dk = "https://www.databazeknih.cz/search?q=%s&hledat=";
    }

    public class GeoCachingComSite
    {
        public static string CacheDetails(string cacheGuid) => "https://www.geocaching.com/seek/cache_details.aspx?guid=" + cacheGuid;

        public static string Gallery(string cacheGuid) => "https://www.geocaching.com/seek/gallery.aspx?guid=" + cacheGuid;

        public static string Log(string cacheGuid) => "https://www.geocaching.com/seek/log.aspx?guid=" + cacheGuid;

        public static string CoordsInfo(string cacheCode) => "https://coords.info/" + cacheCode;

        public static string GC(string cacheCode) => "https://coords.info/GC" + cacheCode;
    }

    public partial class Facebook
    {
        public static string FbTopSearch(string searchQuery) => FromChromeReplacement("https://www.facebook.com/search/top/?q=%s&epa=SEARCH_BOX", searchQuery);
    }
}
