namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

public partial class UriWebServices
{
    public static class BatteryEshops
    {
#region Specialize on batteries
        public static readonly string WwwBatteryshopCz = "www.batteryshop.cz";
        public static readonly string WwwAvacomCz = "www.avacom.cz";
        public static readonly string WwwAkuShopCz = "www.aku-shop.cz";
        public static readonly string WwwPowerguyCz = "www.powerguy.cz";
#endregion
#region Have category for it
        public static readonly string WwwCeskyMobilCz = "www.cesky-mobil.cz";
        public static readonly string WwwDatartCz = "www.datart.cz";
        public static readonly string WwwSmartyCz = "www.smarty.cz";
        public static readonly string WwwMobilprislusenstviCz = "www.mobilprislusenstvi.cz";
        public static readonly string WwwHuramobilCz = "www.huramobil.cz";
#endregion
    }

    public static class FurnitureInOvaWithBestRating
    {
        public const string WwwIntenaCz = "https://www.intena.cz/vyhledavani?search_query=%s&submit_search=&orderby=price&orderway=asc";
        public const string WwwIkeaCom = "https://www.ikea.com/cz/cs/search/products/?q=%s&sort=PRICE_LOW_TO_HIGH";
        public static Type ReflectionType = typeof(FurnitureInOvaWithBestRating);
    }

    public static class FurnitureInOvaPreffered
    {
        public const string WwwOrfaNabytekCz = "https://www.orfa-nabytek.cz/produkty/hledani?sor=pra&pfr=&pto=&send=Zobrazit&m=&q=%s&do=formProductsFilter-submit";
        public const string WwwScontoCz = "https://www.sconto.cz/hledani?q=%s";
        public const string WwwMoebelixCz = "https://www.moebelix.cz/s/?sort=priceAsc&s=%s";
        public static Type ReflectionType = typeof(FurnitureInOvaPreffered);
    }

    public static class FurnitureInOva
    {
        public const string WwwScontoCz = "https://www.sconto.cz/hledani?q=%s";
        public const string WwwMoebelixCz = "https://www.moebelix.cz/s/?sort=priceAsc&s=%s";
        public const string JyskCz = "https://jysk.cz/search?query=%s&search_category=typed_query&op=Hledat#meta=solr&start=0&sort=fts_field_minsingleprice%2Basc";
        public const string WwwOkayCz = "https://www.okay.cz/hledani/?query=%s";
        public const string WwwXxxlutzCz = "https://www.xxxlutz.cz/s/?s=%s";
        public static Type ReflectionType = typeof(FurnitureInOva);
    }

    public static class RepairMobile
    {
        public static void SearchInAll(string searchQuery)
        {
            opened++;
            UriWebServices.SearchInAll(RepairMobileValues.AllRepairKitShops!, searchQuery);
            if (opened % 10 == 0)
                Debugger.Break();
        }
    }

    // For phones, etc. repas sites like mp.cz are better.
    public static class AdsWholeCR
    {
        public const string BazosCz = "https://www.bazos.cz/search.php?hledat=%s&rubriky=www&cenaod=&cenado=&Submit=Hledat&kitx=ano";
        public const string HyperinzerceCz = "https://inzeraty.hyperinzerce.cz/%s/";
        public const string BazarCz = "https://www.bazar.cz/hledat/%s/";
        public const string SBazarCz = "https://www.sbazar.cz/hledej/%s";
        public const string AvizoCz = "https://www.avizo.cz/fulltext/?beng=1&searchfor=ads&keywords=%s";
        public const string AukroCz = "https://aukro.cz/vysledky-vyhledavani?text=%s";

        public static readonly List<string> All = new()
        {
            BazosCz,
            HyperinzerceCz,
            BazarCz,
            SBazarCz,
            AvizoCz,
            AukroCz
        };

        public static void SearchInAll(string searchQuery)
        {
            UriWebServices.SearchInAll(All, searchQuery);
        }

        public static string SearchBazosCz(string searchQuery) => FromChromeReplacement(BazosCz, searchQuery);

        public static string SearchHyperinzerceCz(string searchQuery) => FromChromeReplacement(HyperinzerceCz, searchQuery);

        public static string SearchBazarCz(string searchQuery) => FromChromeReplacement(BazarCz, searchQuery);

        public static string FromChromeReplacement(string uri, string term) => UriWebServices.FromChromeReplacement(uri, term);

        public static string SearchSBazarCz(string searchQuery) => FromChromeReplacement(SBazarCz, searchQuery);

        public static string SearchAvizoCz(string searchQuery) => FromChromeReplacement(AvizoCz, searchQuery);
    }

    public static class SolarShops
    {
        public const string MulacCz = @"https://www.mulac.cz/hledani/?q=%";
        public const string SolarEshop = @"https://www.solar-eshop.cz/vyhledavani/?w=%s&submit=";
        public const string Karavan3nec = @"https://www.karavan3nec.cz/?page=search&sortmode=7&search=%s";
        public const string CampiShopCz = @"https://www.campi-shop.cz/obchod/vyhledavani/_q=%";
        public const string GesCz = @"https://www.ges.cz/cz/hledat/?search=%";
        public const string DstechnikCz = @"https://www.dstechnik.cz/vyhledavani/?qkk=333af8f0cfef3cbbe82db1e238b1ba2d&hledej=%s&x=0&y=0";
        public const string EmerxCz = @"https://www.emerx.cz/hledani?s=%s&submit_=HLEDAT&do=searchForm-submit";

        private static List<string> shops = new List<string>(["mulac.cz", "solar-eshop.cz", "karavan3nec.cz", "campi-shop.cz", "ges.cz", "dstechnik.cz", "emerx.cz", "vpcentrum.eu", "dexhal.cz"]);

        public static readonly List<string> All = new List<string>([MulacCz, SolarEshop, Karavan3nec, CampiShopCz, GesCz, DstechnikCz, EmerxCz]);
    }

    public static class Lyrics
    {
        public static List<string> All { get; set; } = new List<string>([WwwMusixmatchCom, GeniusCom, WwwMetrolyricsCom, WwwLyricsCom, AzlyricsCom]);

#region Space for %20, uri encoded
        public const string WwwMusixmatchCom = "https://www.musixmatch.com/search/%s";
        public const string GeniusCom = "https://genius.com/search?q=%s";
        public const string WwwLyricsCom = "https://www.lyrics.com/lyrics/%s";
#endregion
#region Space for plus
        public const string WwwMetrolyricsCom = "https://www.metrolyrics.com/search.html?search=%s";
        public const string AzlyricsCom = "https://search.azlyrics.com/search.php?q=%s";
#endregion
    }

    public static class SunamoCz
    {
        public const string LyricsScz = "https://lyr.sunamo.net/search/%s";
        public const string AppsHelp = "https://app.sunamo.net/help/%s";
        public const string AppsFeedBack = "https://app.sunamo.net/feedback/%s";
        public const string AppsApp = "https://app.sunamo.net/app/%s";
    }

    public static class SexShops
    {
        public const string WwwRuzovyslonCz = "https://www.ruzovyslon.cz/hledani?_submit=Hledat&s=%s&do=searchForm-submit";
        public const string WwwEroticcityCz = "https://www.eroticcity.cz/vyhledavani.html?q=%";
        public const string WwwSexshopikCz = "https://www.sexshopik.cz/vyhledavani/?search%5Bquery%5D=%s";
        public const string WwwSexShopCz = "https://www.sex-shop69.cz/search/search?st_search%5Bsearch%5D=%s&st_search%5Band_search%5D=1&st_search%5Bdetail%5D=";
        public const string IntimmShopCz = "https://intimm-shop.cz/vyhledavani?controller=search&orderby=position&orderway=desc&search_query=%s&submit_search=";
        public const string WwwEroticstoreCz = "https://www.eroticstore.cz/vysledky-hledani/?search=%";
        public const string WwwNejlevnejsierotickepomuckyCz = "https://www.nejlevnejsierotickepomucky.cz/vyhledavani/?string=%";
        public const string WwwWillistoreCz = "https://www.willistore.cz/?controller=search&orderby=position&orderway=desc&q=%s&submit_search=";
        public const string WwwVibratoryOnlineCz = "https://www.vibratory-online.cz/hledat/?search=%s&searchButton.x=0&searchButton.y=0";
        public const string WwwLuxusnipradloCz = "https://www.luxusnipradlo.cz/hledani/?q=%";
        public const string EKondomyCz = "https://e-kondomy.cz/catalogsearch/result/?q=%";

        public static List<string> All { get; set; } = new List<string>([WwwRuzovyslonCz, WwwEroticcityCz, WwwSexshopikCz, WwwSexShopCz, IntimmShopCz, WwwEroticstoreCz, WwwNejlevnejsierotickepomuckyCz, WwwWillistoreCz, WwwVibratoryOnlineCz, WwwLuxusnipradloCz, EKondomyCz]);
    }
}
