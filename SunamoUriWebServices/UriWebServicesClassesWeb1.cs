namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

public partial class UriWebServices
{
    /// <summary>
    /// Represents the battery eshops type.
    /// </summary>
    public static class BatteryEshops
    {
#region Specialize on batteries
        /// <summary>
        /// The www batteryshop cz.
        /// </summary>
        public static readonly string WwwBatteryshopCz = "www.batteryshop.cz";
        /// <summary>
        /// The www avacom cz.
        /// </summary>
        public static readonly string WwwAvacomCz = "www.avacom.cz";
        /// <summary>
        /// The www aku shop cz.
        /// </summary>
        public static readonly string WwwAkuShopCz = "www.aku-shop.cz";
        /// <summary>
        /// The www powerguy cz.
        /// </summary>
        public static readonly string WwwPowerguyCz = "www.powerguy.cz";
#endregion
#region Have category for it
        /// <summary>
        /// The www cesky mobil cz.
        /// </summary>
        public static readonly string WwwCeskyMobilCz = "www.cesky-mobil.cz";
        /// <summary>
        /// The www datart cz.
        /// </summary>
        public static readonly string WwwDatartCz = "www.datart.cz";
        /// <summary>
        /// The www smarty cz.
        /// </summary>
        public static readonly string WwwSmartyCz = "www.smarty.cz";
        /// <summary>
        /// The www mobilprislusenstvi cz.
        /// </summary>
        public static readonly string WwwMobilprislusenstviCz = "www.mobilprislusenstvi.cz";
        /// <summary>
        /// The www huramobil cz.
        /// </summary>
        public static readonly string WwwHuramobilCz = "www.huramobil.cz";
#endregion
    }

    /// <summary>
    /// Represents the furniture in ova with best rating type.
    /// </summary>
    public static class FurnitureInOvaWithBestRating
    {
        /// <summary>
        /// The www intena cz constant.
        /// </summary>
        public const string WwwIntenaCz = "https://www.intena.cz/vyhledavani?search_query=%s&submit_search=&orderby=price&orderway=asc";
        /// <summary>
        /// The www ikea com constant.
        /// </summary>
        public const string WwwIkeaCom = "https://www.ikea.com/cz/cs/search/products/?q=%s&sort=PRICE_LOW_TO_HIGH";
        /// <summary>
        /// The reflection type.
        /// </summary>
        public static Type ReflectionType = typeof(FurnitureInOvaWithBestRating);
    }

    /// <summary>
    /// Represents the furniture in ova preffered type.
    /// </summary>
    public static class FurnitureInOvaPreffered
    {
        /// <summary>
        /// The www orfa nabytek cz constant.
        /// </summary>
        public const string WwwOrfaNabytekCz = "https://www.orfa-nabytek.cz/produkty/hledani?sor=pra&pfr=&pto=&send=Zobrazit&m=&q=%s&do=formProductsFilter-submit";
        /// <summary>
        /// The www sconto cz constant.
        /// </summary>
        public const string WwwScontoCz = "https://www.sconto.cz/hledani?q=%s";
        /// <summary>
        /// The www moebelix cz constant.
        /// </summary>
        public const string WwwMoebelixCz = "https://www.moebelix.cz/s/?sort=priceAsc&s=%s";
        /// <summary>
        /// The reflection type.
        /// </summary>
        public static Type ReflectionType = typeof(FurnitureInOvaPreffered);
    }

    /// <summary>
    /// Represents the furniture in ova type.
    /// </summary>
    public static class FurnitureInOva
    {
        /// <summary>
        /// The www sconto cz constant.
        /// </summary>
        public const string WwwScontoCz = "https://www.sconto.cz/hledani?q=%s";
        /// <summary>
        /// The www moebelix cz constant.
        /// </summary>
        public const string WwwMoebelixCz = "https://www.moebelix.cz/s/?sort=priceAsc&s=%s";
        /// <summary>
        /// The jysk cz constant.
        /// </summary>
        public const string JyskCz = "https://jysk.cz/search?query=%s&search_category=typed_query&op=Hledat#meta=solr&start=0&sort=fts_field_minsingleprice%2Basc";
        /// <summary>
        /// The www okay cz constant.
        /// </summary>
        public const string WwwOkayCz = "https://www.okay.cz/hledani/?query=%s";
        /// <summary>
        /// The www xxxlutz cz constant.
        /// </summary>
        public const string WwwXxxlutzCz = "https://www.xxxlutz.cz/s/?s=%s";
        /// <summary>
        /// The reflection type.
        /// </summary>
        public static Type ReflectionType = typeof(FurnitureInOva);
    }

    /// <summary>
    /// Represents the repair mobile type.
    /// </summary>
    public static class RepairMobile
    {
        /// <summary>
        /// Search in all.
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        public static void SearchInAll(string searchQuery)
        {
            opened++;
            UriWebServices.SearchInAll(RepairMobileValues.AllRepairKitShops!, searchQuery);
            if (opened % 10 == 0)
                Debugger.Break();
        }
    }

    // For phones, etc. repas sites like mp.cz are better.
    /// <summary>
    /// Represents the ads whole CR type.
    /// </summary>
    public static class AdsWholeCR
    {
        /// <summary>
        /// The bazos cz constant.
        /// </summary>
        public const string BazosCz = "https://www.bazos.cz/search.php?hledat=%s&rubriky=www&cenaod=&cenado=&Submit=Hledat&kitx=ano";
        /// <summary>
        /// The hyperinzerce cz constant.
        /// </summary>
        public const string HyperinzerceCz = "https://inzeraty.hyperinzerce.cz/%s/";
        /// <summary>
        /// The bazar cz constant.
        /// </summary>
        public const string BazarCz = "https://www.bazar.cz/hledat/%s/";
        /// <summary>
        /// The s bazar cz constant.
        /// </summary>
        public const string SBazarCz = "https://www.sbazar.cz/hledej/%s";
        /// <summary>
        /// The avizo cz constant.
        /// </summary>
        public const string AvizoCz = "https://www.avizo.cz/fulltext/?beng=1&searchfor=ads&keywords=%s";
        /// <summary>
        /// The aukro cz constant.
        /// </summary>
        public const string AukroCz = "https://aukro.cz/vysledky-vyhledavani?text=%s";

        /// <summary>
        /// The all.
        /// </summary>
        public static readonly List<string> All = new()
        {
            BazosCz,
            HyperinzerceCz,
            BazarCz,
            SBazarCz,
            AvizoCz,
            AukroCz
        };

        /// <summary>
        /// Search in all.
        /// </summary>
        /// <param name="FurnitureInOvaPreffered">The furniture in ova preffered.</param>
        /// <returns>The search in all result.</returns>
        public static void SearchInAll(string searchQuery)
        {
            UriWebServices.SearchInAll(All, searchQuery);
        }

        /// <summary>
        /// Gets Bazos.cz search URL for the specified query (70800, 25km radius).
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>The formatted Bazos.cz search URL.</returns>
        public static string SearchBazosCz(string searchQuery) => FromChromeReplacement(BazosCz, searchQuery);

        /// <summary>
        /// Gets Hyperinzerce.cz search URL for the specified query (Moravian-Silesian region).
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>The formatted Hyperinzerce.cz search URL.</returns>
        public static string SearchHyperinzerceCz(string searchQuery) => FromChromeReplacement(HyperinzerceCz, searchQuery);

        /// <summary>
        /// Gets Bazar.cz search URL for the specified query (70800, 25km radius).
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>The formatted Bazar.cz search URL.</returns>
        public static string SearchBazarCz(string searchQuery) => FromChromeReplacement(BazarCz, searchQuery);

        /// <summary>
        /// Replaces Chrome search placeholder with the specified term.
        /// </summary>
        /// <param name="uri">The URI template.</param>
        /// <param name="term">The search term.</param>
        /// <returns>The formatted URI.</returns>
        public static string FromChromeReplacement(string uri, string term) => UriWebServices.FromChromeReplacement(uri, term);

        /// <summary>
        /// Gets SBazar.cz search URL for the specified query.
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>The formatted SBazar.cz search URL.</returns>
        public static string SearchSBazarCz(string searchQuery) => FromChromeReplacement(SBazarCz, searchQuery);

        /// <summary>
        /// Gets Avizo.cz search URL for the specified query.
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>The formatted Avizo.cz search URL.</returns>
        public static string SearchAvizoCz(string searchQuery) => FromChromeReplacement(AvizoCz, searchQuery);
    }

    /// <summary>
    /// Represents the solar shops type.
    /// </summary>
    public static class SolarShops
    {
        /// <summary>
        /// The mulac cz constant.
        /// </summary>
        public const string MulacCz = @"https://www.mulac.cz/hledani/?q=%";
        /// <summary>
        /// The solar eshop constant.
        /// </summary>
        public const string SolarEshop = @"https://www.solar-eshop.cz/vyhledavani/?w=%s&submit=";
        /// <summary>
        /// The karavan 3 nec constant.
        /// </summary>
        public const string Karavan3nec = @"https://www.karavan3nec.cz/?page=search&sortmode=7&search=%s";
        /// <summary>
        /// The campi shop cz constant.
        /// </summary>
        public const string CampiShopCz = @"https://www.campi-shop.cz/obchod/vyhledavani/_q=%";
        /// <summary>
        /// The ges cz constant.
        /// </summary>
        public const string GesCz = @"https://www.ges.cz/cz/hledat/?search=%";
        /// <summary>
        /// The dstechnik cz constant.
        /// </summary>
        public const string DstechnikCz = @"https://www.dstechnik.cz/vyhledavani/?qkk=333af8f0cfef3cbbe82db1e238b1ba2d&hledej=%s&x=0&y=0";
        /// <summary>
        /// The emerx cz constant.
        /// </summary>
        public const string EmerxCz = @"https://www.emerx.cz/hledani?s=%s&submit_=HLEDAT&do=searchForm-submit";

        private static List<string> shops = new List<string>(["mulac.cz", "solar-eshop.cz", "karavan3nec.cz", "campi-shop.cz", "ges.cz", "dstechnik.cz", "emerx.cz", "vpcentrum.eu", "dexhal.cz"]);

        /// <summary>
        /// The all.
        /// </summary>
        public static readonly List<string> All = new List<string>([MulacCz, SolarEshop, Karavan3nec, CampiShopCz, GesCz, DstechnikCz, EmerxCz]);
    }

    /// <summary>
    /// Represents the lyrics type.
    /// </summary>
    public static class Lyrics
    {
        /// <summary>
        /// Gets or sets the all.
        /// </summary>
        public static List<string> All { get; set; } = new List<string>([WwwMusixmatchCom, GeniusCom, WwwMetrolyricsCom, WwwLyricsCom, AzlyricsCom]);

#region Space for %20, uri encoded
        /// <summary>
        /// The www musixmatch com constant.
        /// </summary>
        public const string WwwMusixmatchCom = "https://www.musixmatch.com/search/%s";
        /// <summary>
        /// The genius com constant.
        /// </summary>
        public const string GeniusCom = "https://genius.com/search?q=%s";
        /// <summary>
        /// The www lyrics com constant.
        /// </summary>
        public const string WwwLyricsCom = "https://www.lyrics.com/lyrics/%s";
#endregion
#region Space for plus
        /// <summary>
        /// The www metrolyrics com constant.
        /// </summary>
        public const string WwwMetrolyricsCom = "https://www.metrolyrics.com/search.html?search=%s";
        /// <summary>
        /// The azlyrics com constant.
        /// </summary>
        public const string AzlyricsCom = "https://search.azlyrics.com/search.php?q=%s";
#endregion
    }

    /// <summary>
    /// Represents the sunamo cz type.
    /// </summary>
    public static class SunamoCz
    {
        /// <summary>
        /// The lyrics scz constant.
        /// </summary>
        public const string LyricsScz = "https://lyr.sunamo.net/search/%s";
        /// <summary>
        /// The apps help constant.
        /// </summary>
        public const string AppsHelp = "https://app.sunamo.net/help/%s";
        /// <summary>
        /// The apps feed back constant.
        /// </summary>
        public const string AppsFeedBack = "https://app.sunamo.net/feedback/%s";
        /// <summary>
        /// The apps app constant.
        /// </summary>
        public const string AppsApp = "https://app.sunamo.net/app/%s";
    }

    /// <summary>
    /// Represents the sex shops type.
    /// </summary>
    public static class SexShops
    {
        /// <summary>
        /// The www ruzovyslon cz constant.
        /// </summary>
        public const string WwwRuzovyslonCz = "https://www.ruzovyslon.cz/hledani?_submit=Hledat&s=%s&do=searchForm-submit";
        /// <summary>
        /// The www eroticcity cz constant.
        /// </summary>
        public const string WwwEroticcityCz = "https://www.eroticcity.cz/vyhledavani.html?q=%";
        /// <summary>
        /// The www sexshopik cz constant.
        /// </summary>
        public const string WwwSexshopikCz = "https://www.sexshopik.cz/vyhledavani/?search%5Bquery%5D=%s";
        /// <summary>
        /// The www sex shop cz constant.
        /// </summary>
        public const string WwwSexShopCz = "https://www.sex-shop69.cz/search/search?st_search%5Bsearch%5D=%s&st_search%5Band_search%5D=1&st_search%5Bdetail%5D=";
        /// <summary>
        /// The intimm shop cz constant.
        /// </summary>
        public const string IntimmShopCz = "https://intimm-shop.cz/vyhledavani?controller=search&orderby=position&orderway=desc&search_query=%s&submit_search=";
        /// <summary>
        /// The www eroticstore cz constant.
        /// </summary>
        public const string WwwEroticstoreCz = "https://www.eroticstore.cz/vysledky-hledani/?search=%";
        /// <summary>
        /// The www nejlevnejsierotickepomucky cz constant.
        /// </summary>
        public const string WwwNejlevnejsierotickepomuckyCz = "https://www.nejlevnejsierotickepomucky.cz/vyhledavani/?string=%";
        /// <summary>
        /// The www willistore cz constant.
        /// </summary>
        public const string WwwWillistoreCz = "https://www.willistore.cz/?controller=search&orderby=position&orderway=desc&q=%s&submit_search=";
        /// <summary>
        /// The www vibratory online cz constant.
        /// </summary>
        public const string WwwVibratoryOnlineCz = "https://www.vibratory-online.cz/hledat/?search=%s&searchButton.x=0&searchButton.y=0";
        /// <summary>
        /// The www luxusnipradlo cz constant.
        /// </summary>
        public const string WwwLuxusnipradloCz = "https://www.luxusnipradlo.cz/hledani/?q=%";
        /// <summary>
        /// The e kondomy cz constant.
        /// </summary>
        public const string EKondomyCz = "https://e-kondomy.cz/catalogsearch/result/?q=%";

        /// <summary>
        /// Gets or sets the all.
        /// </summary>
        public static List<string> All { get; set; } = new List<string>([WwwRuzovyslonCz, WwwEroticcityCz, WwwSexshopikCz, WwwSexShopCz, IntimmShopCz, WwwEroticstoreCz, WwwNejlevnejsierotickepomuckyCz, WwwWillistoreCz, WwwVibratoryOnlineCz, WwwLuxusnipradloCz, EKondomyCz]);
    }
}
