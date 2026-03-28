namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

/// <summary>
/// Contains web service URL definitions for various categories (batteries, furniture, ads, etc.).
/// </summary>
public partial class UriWebServices
{
    /// <summary>
    /// Provides battery e-shop URLs.
    /// </summary>
    public static class BatteryEshops
    {
#region Specialize on batteries
        /// <summary> Battery shop URL. </summary>
        public static readonly string WwwBatteryshopCz = "www.batteryshop.cz";
        /// <summary> Avacom URL. </summary>
        public static readonly string WwwAvacomCz = "www.avacom.cz";
        /// <summary> Aku-shop URL. </summary>
        public static readonly string WwwAkuShopCz = "www.aku-shop.cz";
        /// <summary> Powerguy URL. </summary>
        public static readonly string WwwPowerguyCz = "www.powerguy.cz";
#endregion
#region Have category for it
        /// <summary> Cesky-mobil URL. </summary>
        public static readonly string WwwCeskyMobilCz = "www.cesky-mobil.cz";
        /// <summary> Datart URL. </summary>
        public static readonly string WwwDatartCz = "www.datart.cz";
        /// <summary> Smarty URL. </summary>
        public static readonly string WwwSmartyCz = "www.smarty.cz";
        /// <summary> Mobilprislusenstvi URL. </summary>
        public static readonly string WwwMobilprislusenstviCz = "www.mobilprislusenstvi.cz";
        /// <summary> Huramobil URL. </summary>
        public static readonly string WwwHuramobilCz = "www.huramobil.cz";
#endregion
    }

    /// <summary>
    /// Provides furniture e-shop URLs for Ostrava region with best rating.
    /// </summary>
    public static class FurnitureInOvaWithBestRating
    {
        /// <summary> Intena.cz search URL template. </summary>
        public const string WwwIntenaCz = "https://www.intena.cz/vyhledavani?search_query=%s&submit_search=&orderby=price&orderway=asc";
        /// <summary> IKEA search URL template. </summary>
        public const string WwwIkeaCom = "https://www.ikea.com/cz/cs/search/products/?q=%s&sort=PRICE_LOW_TO_HIGH";
        /// <summary> Type reference for reflection. </summary>
        public static Type ReflectionType = typeof(FurnitureInOvaWithBestRating);
    }

    /// <summary>
    /// Provides preferred furniture e-shop URLs for Ostrava region.
    /// </summary>
    public static class FurnitureInOvaPreffered
    {
        /// <summary> Orfa-nabytek.cz search URL template. </summary>
        public const string WwwOrfaNabytekCz = "https://www.orfa-nabytek.cz/produkty/hledani?sor=pra&pfr=&pto=&send=Zobrazit&m=&q=%s&do=formProductsFilter-submit";
        /// <summary> Sconto.cz search URL template. </summary>
        public const string WwwScontoCz = "https://www.sconto.cz/hledani?q=%s";
        /// <summary> Moebelix.cz search URL template. </summary>
        public const string WwwMoebelixCz = "https://www.moebelix.cz/s/?sort=priceAsc&s=%s";
        /// <summary> Type reference for reflection. </summary>
        public static Type ReflectionType = typeof(FurnitureInOvaPreffered);
    }

    /// <summary>
    /// Provides furniture e-shop URLs for Ostrava region.
    /// </summary>
    public static class FurnitureInOva
    {
        /// <summary> Sconto.cz search URL template. </summary>
        public const string WwwScontoCz = "https://www.sconto.cz/hledani?q=%s";
        /// <summary> Moebelix.cz search URL template. </summary>
        public const string WwwMoebelixCz = "https://www.moebelix.cz/s/?sort=priceAsc&s=%s";
        /// <summary> JYSK search URL template. </summary>
        public const string JyskCz = "https://jysk.cz/search?query=%s&search_category=typed_query&op=Hledat#meta=solr&start=0&sort=fts_field_minsingleprice%2Basc";
        /// <summary> Okay.cz search URL template. </summary>
        public const string WwwOkayCz = "https://www.okay.cz/hledani/?query=%s";
        /// <summary> XXXLutz.cz search URL template. </summary>
        public const string WwwXxxlutzCz = "https://www.xxxlutz.cz/s/?s=%s";
        /// <summary> Type reference for reflection. </summary>
        public static Type ReflectionType = typeof(FurnitureInOva);
    }

    /// <summary>
    /// Provides mobile repair search functionality.
    /// </summary>
    public static class RepairMobile
    {
        /// <summary>
        /// Searches all repair kit shops for the specified query.
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

    /// <summary>
    /// Provides advertisement search URLs for the whole Czech Republic.
    /// For phones, etc. repas sites like mp.cz are better.
    /// </summary>
    public static class AdsWholeCR
    {
        /// <summary> Bazos.cz search URL template. </summary>
        public const string BazosCz = "https://www.bazos.cz/search.php?hledat=%s&rubriky=www&cenaod=&cenado=&Submit=Hledat&kitx=ano";
        /// <summary> Hyperinzerce.cz search URL template. </summary>
        public const string HyperinzerceCz = "https://inzeraty.hyperinzerce.cz/%s/";
        /// <summary> Bazar.cz search URL template. </summary>
        public const string BazarCz = "https://www.bazar.cz/hledat/%s/";
        /// <summary> SBazar.cz search URL template. </summary>
        public const string SBazarCz = "https://www.sbazar.cz/hledej/%s";
        /// <summary> Avizo.cz search URL template. </summary>
        public const string AvizoCz = "https://www.avizo.cz/fulltext/?beng=1&searchfor=ads&keywords=%s";
        /// <summary> Aukro.cz search URL template. </summary>
        public const string AukroCz = "https://aukro.cz/vysledky-vyhledavani?text=%s";

        /// <summary>
        /// All whole-CR advertisement search URL templates.
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
        /// Searches all whole-CR advertisement sites for the specified query.
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        public static void SearchInAll(string searchQuery)
        {
            UriWebServices.SearchInAll(All, searchQuery);
        }

        /// <summary>
        /// Gets Bazos.cz search URL for the specified query (70800, 25km radius).
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>The formatted Bazos.cz search URL.</returns>
        public static string SearchBazosCz(string searchQuery)
        {
            return FromChromeReplacement(BazosCz, searchQuery);
        }

        /// <summary>
        /// Gets Hyperinzerce.cz search URL for the specified query (Moravian-Silesian region).
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>The formatted Hyperinzerce.cz search URL.</returns>
        public static string SearchHyperinzerceCz(string searchQuery)
        {
            return FromChromeReplacement(HyperinzerceCz, searchQuery);
        }

        /// <summary>
        /// Gets Bazar.cz search URL for the specified query (70800, 25km radius).
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>The formatted Bazar.cz search URL.</returns>
        public static string SearchBazarCz(string searchQuery)
        {
            return FromChromeReplacement(BazarCz, searchQuery);
        }

        /// <summary>
        /// Replaces Chrome search placeholder with the specified term.
        /// </summary>
        /// <param name="uri">The URI template.</param>
        /// <param name="term">The search term.</param>
        /// <returns>The formatted URI.</returns>
        public static string FromChromeReplacement(string uri, string term)
        {
            return UriWebServices.FromChromeReplacement(uri, term);
        }

        /// <summary>
        /// Gets SBazar.cz search URL for the specified query.
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>The formatted SBazar.cz search URL.</returns>
        public static string SearchSBazarCz(string searchQuery)
        {
            return FromChromeReplacement(SBazarCz, searchQuery);
        }

        /// <summary>
        /// Gets Avizo.cz search URL for the specified query.
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>The formatted Avizo.cz search URL.</returns>
        public static string SearchAvizoCz(string searchQuery)
        {
            return FromChromeReplacement(AvizoCz, searchQuery);
        }
    }

    /// <summary>
    /// Provides solar equipment e-shop URLs.
    /// </summary>
    public static class SolarShops
    {
        /// <summary> Mulac.cz search URL template. </summary>
        public const string MulacCz = @"https://www.mulac.cz/hledani/?q=%";
        /// <summary> Solar-eshop.cz search URL template. </summary>
        public const string SolarEshop = @"https://www.solar-eshop.cz/vyhledavani/?w=%s&submit=";
        /// <summary> Karavan3nec.cz search URL template. </summary>
        public const string Karavan3nec = @"https://www.karavan3nec.cz/?page=search&sortmode=7&search=%s";
        /// <summary> Campi-shop.cz search URL template. </summary>
        public const string CampiShopCz = @"https://www.campi-shop.cz/obchod/vyhledavani/_q=%";
        /// <summary> GES.cz search URL template. </summary>
        public const string GesCz = @"https://www.ges.cz/cz/hledat/?search=%";
        /// <summary> DSTechnik.cz search URL template. </summary>
        public const string DstechnikCz = @"https://www.dstechnik.cz/vyhledavani/?qkk=333af8f0cfef3cbbe82db1e238b1ba2d&hledej=%s&x=0&y=0";
        /// <summary> Emerx.cz search URL template. </summary>
        public const string EmerxCz = @"https://www.emerx.cz/hledani?s=%s&submit_=HLEDAT&do=searchForm-submit";

        private static List<string> shops = new List<string>(["mulac.cz", "solar-eshop.cz", "karavan3nec.cz", "campi-shop.cz", "ges.cz", "dstechnik.cz", "emerx.cz", "vpcentrum.eu", "dexhal.cz"]);

        /// <summary>
        /// All solar shop search URL templates.
        /// </summary>
        public static readonly List<string> All = new List<string>([MulacCz, SolarEshop, Karavan3nec, CampiShopCz, GesCz, DstechnikCz, EmerxCz]);
    }

    /// <summary>
    /// Provides lyrics search URL templates.
    /// </summary>
    public static class Lyrics
    {
        /// <summary>
        /// All lyrics search URL templates.
        /// </summary>
        public static List<string> All { get; set; } = new List<string>([WwwMusixmatchCom, GeniusCom, WwwMetrolyricsCom, WwwLyricsCom, AzlyricsCom]);

#region Space for %20, uri encoded
        /// <summary> Musixmatch search URL template. </summary>
        public const string WwwMusixmatchCom = "https://www.musixmatch.com/search/%s";
        /// <summary> Genius search URL template. </summary>
        public const string GeniusCom = "https://genius.com/search?q=%s";
        /// <summary> Lyrics.com search URL template. </summary>
        public const string WwwLyricsCom = "https://www.lyrics.com/lyrics/%s";
#endregion
#region Space for plus
        /// <summary> MetroLyrics search URL template. </summary>
        public const string WwwMetrolyricsCom = "https://www.metrolyrics.com/search.html?search=%s";
        /// <summary> AZLyrics search URL template. </summary>
        public const string AzlyricsCom = "https://search.azlyrics.com/search.php?q=%s";
#endregion
    }

    /// <summary>
    /// Provides Sunamo.cz service URLs.
    /// </summary>
    public static class SunamoCz
    {
        /// <summary> Lyrics search URL template. </summary>
        public const string LyricsScz = "https://lyr.sunamo.net/search/%s";
        /// <summary> Apps help URL template. </summary>
        public const string AppsHelp = "https://app.sunamo.net/help/%s";
        /// <summary> Apps feedback URL template. </summary>
        public const string AppsFeedBack = "https://app.sunamo.net/feedback/%s";
        /// <summary> Apps application URL template. </summary>
        public const string AppsApp = "https://app.sunamo.net/app/%s";
    }

    /// <summary>
    /// Provides sex shop search URL templates.
    /// </summary>
    public static class SexShops
    {
        /// <summary> RuzovySlon.cz search URL template. </summary>
        public const string WwwRuzovyslonCz = "https://www.ruzovyslon.cz/hledani?_submit=Hledat&s=%s&do=searchForm-submit";
        /// <summary> EroticCity.cz search URL template. </summary>
        public const string WwwEroticcityCz = "https://www.eroticcity.cz/vyhledavani.html?q=%";
        /// <summary> Sexshopik.cz search URL template. </summary>
        public const string WwwSexshopikCz = "https://www.sexshopik.cz/vyhledavani/?search%5Bquery%5D=%s";
        /// <summary> SexShop69.cz search URL template. </summary>
        public const string WwwSexShopCz = "https://www.sex-shop69.cz/search/search?st_search%5Bsearch%5D=%s&st_search%5Band_search%5D=1&st_search%5Bdetail%5D=";
        /// <summary> IntimmShop.cz search URL template. </summary>
        public const string IntimmShopCz = "https://intimm-shop.cz/vyhledavani?controller=search&orderby=position&orderway=desc&search_query=%s&submit_search=";
        /// <summary> EroticStore.cz search URL template. </summary>
        public const string WwwEroticstoreCz = "https://www.eroticstore.cz/vysledky-hledani/?search=%";
        /// <summary> NejlevnejsiErotickePomucky.cz search URL template. </summary>
        public const string WwwNejlevnejsierotickepomuckyCz = "https://www.nejlevnejsierotickepomucky.cz/vyhledavani/?string=%";
        /// <summary> WilliStore.cz search URL template. </summary>
        public const string WwwWillistoreCz = "https://www.willistore.cz/?controller=search&orderby=position&orderway=desc&q=%s&submit_search=";
        /// <summary> VibrátoryOnline.cz search URL template. </summary>
        public const string WwwVibratoryOnlineCz = "https://www.vibratory-online.cz/hledat/?search=%s&searchButton.x=0&searchButton.y=0";
        /// <summary> LuxusniPradlo.cz search URL template. </summary>
        public const string WwwLuxusnipradloCz = "https://www.luxusnipradlo.cz/hledani/?q=%";
        /// <summary> E-Kondomy.cz search URL template. </summary>
        public const string EKondomyCz = "https://e-kondomy.cz/catalogsearch/result/?q=%";

        /// <summary>
        /// All sex shop search URL templates.
        /// </summary>
        public static List<string> All { get; set; } = new List<string>([WwwRuzovyslonCz, WwwEroticcityCz, WwwSexshopikCz, WwwSexShopCz, IntimmShopCz, WwwEroticstoreCz, WwwNejlevnejsierotickepomuckyCz, WwwWillistoreCz, WwwVibratoryOnlineCz, WwwLuxusnipradloCz, EKondomyCz]);
    }
}
