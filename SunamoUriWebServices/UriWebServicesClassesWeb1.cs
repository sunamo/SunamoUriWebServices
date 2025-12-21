namespace SunamoUriWebServices;

using SunamoUriWebServices.Values;

public partial class UriWebServices
{
    public static class BatteryEshops
    {
#region Specialize on batteries
        public static readonly string wwwBatteryshopCz = "www.batteryshop.cz";
        public static readonly string wwwAvacomCz = "www.avacom.cz";
        public static readonly string wwwAkuShopCz = "www.aku-shop.cz";
        public static readonly string wwwPowerguyCz = "www.powerguy.cz";
#endregion
#region Have category for it
        public static readonly string wwwCeskyMobilCz = "www.cesky-mobil.cz";
        public static readonly string wwwDatartCz = "www.datart.cz";
        public static readonly string wwwSmartyCz = "www.smarty.cz";
        public static readonly string wwwMobilprislusenstviCz = "www.mobilprislusenstvi.cz";
        public static readonly string wwwHuramobilCz = "www.huramobil.cz";
#endregion
    }

    public static class FurnitureInOvaWithBestRating
    {
        //public const string wwwNabytekmodenCz = "https://www.nabytekmoden.cz/";
        //public const string wwwJitonaCz = "http://www.jitona.cz/";
        public const string wwwIntenaCz = "https://www.intena.cz/vyhledavani?search_query=%s&submit_search=&orderby=price&orderway=asc";
        //public const string wwwJechCz = "https://www.jech.cz/hledat?query=%s";
        public const string wwwIkeaCom = "https://www.ikea.com/cz/cs/search/products/?q=%s&sort=PRICE_LOW_TO_HIGH";
        public static Type type = typeof(FurnitureInOvaWithBestRating);
    }

    public static class FurnitureInOvaPreffered
    {
        public const string wwwOrfaNabytekCz = "https://www.orfa-nabytek.cz/produkty/hledani?sor=pra&pfr=&pto=&send=Zobrazit&m=&q=%s&do=formProductsFilter-submit";
        public const string wwwScontoCz = "https://www.sconto.cz/hledani?q=%s";
        public const string wwwMoebelixCz = "https://www.moebelix.cz/s/?sort=priceAsc&s=%s";
        public static Type type = typeof(FurnitureInOvaPreffered);
    }

    public static class FurnitureInOva
    {
        // only in ova
        //public const string wwwOrfaNabytekCz = "https://www.orfa-nabytek.cz/produkty/hledani?sor=pra&pfr=&pto=&send=Zobrazit&m=&q=%s&do=formProductsFilter-submit";
        public const string wwwScontoCz = "https://www.sconto.cz/hledani?q=%s";
        public const string wwwMoebelixCz = "https://www.moebelix.cz/s/?sort=priceAsc&s=%s";
        public const string jyskCz = "https://jysk.cz/search?query=%s&search_category=typed_query&op=Hledat#meta=solr&start=0&sort=fts_field_minsingleprice%2Basc";
        public const string wwwOkayCz = "https://www.okay.cz/hledani/?query=%s";
        public const string wwwXxxlutzCz = "https://www.xxxlutz.cz/s/?s=%s";
        public static Type type = typeof(FurnitureInOva);
    //public const string wwwIdeaNabytekCz = "https://www.idea-nabytek.cz/ulozne-prostory/%se/?ordertype=asc&Ordering=ProductPriceWithVat";
    }

    public static class RepairMobile
    {
        public static void SearchInAll(string what)
        {
            opened++;
            UriWebServices.SearchInAll(RepairMobileValues.allRepairKitShops, what);
            if (opened % 10 == 0)
                Debugger.Break();
        }
    }

    /// <summary>
    ///     For phones, etc. is better repas sites as mp.cz
    /// </summary>
    public static class AdsWholeCR
    {
        /*
Template for which I will find, have to be in derivates the same:

1) bazos.cz
2) hyperinzerce.cz
3) bazar.cz
4) sbazar.cz
5) avizo.cz
6) letgo.cz
7) aukro.cz
 */
        public const string bazosCz = "https://www.bazos.cz/search.php?hledat=%s&rubriky=www&cenaod=&cenado=&Submit=Hledat&kitx=ano";
        public const string hyperinzerceCz = "https://inzeraty.hyperinzerce.cz/%s/";
        public const string bazarCz = "https://www.bazar.cz/hledat/%s/";
        public const string sBazarCz = "https://www.sbazar.cz/hledej/%s";
        public const string avizoCz = "https://www.avizo.cz/fulltext/?beng=1&searchfor=ads&keywords=%s";
        //public const string letGoCz = "https://www.letgo.cz/items/q-%s";
        public const string aukroCz = "https://aukro.cz/vysledky-vyhledavani?text=%s";
        public static readonly List<string> All = new()
        {
            bazosCz,
            hyperinzerceCz,
            bazarCz,
            sBazarCz,
            avizoCz,
            aukroCz
        };
        public static void SearchInAll(string what)
        {
            UriWebServices.SearchInAll(All, what);
        }

        /// <summary>
        ///     70800 v okoli 25km
        /// </summary>
        /// <param name = "what"></param>
        public static string BazosCz(string what)
        {
            return FromChromeReplacement(bazosCz, what);
        }

        /// <summary>
        ///     MS kraj
        /// </summary>
        /// <param name = "what"></param>
        public static string HyperInzerceCz(string what)
        {
            return FromChromeReplacement(hyperinzerceCz, what);
        }

        /// <summary>
        ///     70800 +25km
        /// </summary>
        /// <param name = "what"></param>
        public static string BazarCz(string what)
        {
            return FromChromeReplacement(bazarCz, what);
        }

        public static string FromChromeReplacement(string uri, string term)
        {
            return UriWebServices.FromChromeReplacement(uri, term);
        }

        public static string SBazarCz(string what)
        {
            return FromChromeReplacement(sBazarCz, what);
        }

        public static string AvizoCz(string what)
        {
            return FromChromeReplacement(avizoCz, what);
        }
    //public static string LetGoCz(string what)
    //{
    //    return FromChromeReplacement(letGoCz, what);
    //}
    }

    public static class SolarShops
    {
        public const string mulacCz = @"https://www.mulac.cz/hledani/?q=%";
        public const string solarEshop = @"https://www.solar-eshop.cz/vyhledavani/?w=%s&submit=";
        public const string karavan3nec = @"https://www.karavan3nec.cz/?page=search&sortmode=7&search=%s";
        public const string campiShopCz = @"https://www.campi-shop.cz/obchod/vyhledavani/_q=%";
        public const string gesCz = @"https://www.ges.cz/cz/hledat/?search=%";
        public const string dstechnikCz = @"https://www.dstechnik.cz/vyhledavani/?qkk=333af8f0cfef3cbbe82db1e238b1ba2d&hledej=%s&x=0&y=0";
        public const string emerxCz = @"https://www.emerx.cz/hledani?s=%s&submit_=HLEDAT&do=searchForm-submit";
        private static List<string> s_shops = new List<string>(["mulac.cz", "solar-eshop.cz", "karavan3nec.cz", "campi-shop.cz", "ges.cz", "dstechnik.cz", "emerx.cz", "vpcentrum.eu", "dexhal.cz"]);
        // not search term in uri
        //public const string vpCentrumCz = @"https://www.vpcentrum.eu/index.php?route=product/search&filter_name=Hledat";
        // not search term in uri
        //public const string dexhalCz = @"https://dexhal.cz/search?controller=search&orderby=position&orderway=desc&search_query=s&submit_search=Hledat";
        public static readonly List<string> All = new List<string>([mulacCz, solarEshop, karavan3nec, campiShopCz, gesCz, dstechnikCz, emerxCz]);
    }

    public static class Lyrics
    {
        public static List<string> All = new List<string>([wwwMusixmatchCom, geniusCom, wwwMetrolyricsCom, wwwLyricsCom, azlyricsCom]);
#region Space for %20, uri encoded
        public const string wwwMusixmatchCom = "https://www.musixmatch.com/search/%s";
        public const string geniusCom = "https://genius.com/search?q=%s";
        public const string wwwLyricsCom = "https://www.lyrics.com/lyrics/%s";
#endregion
#region Space for plus
        public const string wwwMetrolyricsCom = "https://www.metrolyrics.com/search.html?search=%s";
        public const string azlyricsCom = "https://search.azlyrics.com/search.php?q=%s";
#endregion
    }

    /// <summary>
    ///     Localhost due to easy convert with
    /// </summary>
    public static class SunamoCz
    {
        public const string lyricsScz = "https://lyr.sunamo.net/search/%s";
        public const string appsHelp = "https://app.sunamo.net/help/%s";
        public const string appsFeedBack = "https://app.sunamo.net/feedback/%s";
        public const string appsApp = "https://app.sunamo.net/app/%s";
    }

    public static class SexShops
    {
        public const string wwwRuzovyslonCz = "https://www.ruzovyslon.cz/hledani?_submit=Hledat&s=%s&do=searchForm-submit";
        public const string wwwEroticcityCz = "https://www.eroticcity.cz/vyhledavani.html?q=%";
        public const string wwwSexshopikCz = "https://www.sexshopik.cz/vyhledavani/?search%5Bquery%5D=%s";
        public const string wwwSexShopCz = "https://www.sex-shop69.cz/search/search?st_search%5Bsearch%5D=%s&st_search%5Band_search%5D=1&st_search%5Bdetail%5D=";
        public const string intimmShopCz = "https://intimm-shop.cz/vyhledavani?controller=search&orderby=position&orderway=desc&search_query=%s&submit_search=";
        public const string wwwEroticstoreCz = "https://www.eroticstore.cz/vysledky-hledani/?search=%";
        public const string wwwNejlevnejsierotickepomuckyCz = "https://www.nejlevnejsierotickepomucky.cz/vyhledavani/?string=%";
        public const string wwwWillistoreCz = "https://www.willistore.cz/?controller=search&orderby=position&orderway=desc&q=%s&submit_search=";
        public const string wwwVibratoryOnlineCz = "https://www.vibratory-online.cz/hledat/?search=%s&searchButton.x=0&searchButton.y=0";
        public const string wwwLuxusnipradloCz = "https://www.luxusnipradlo.cz/hledani/?q=%";
        public const string eKondomyCz = "https://e-kondomy.cz/catalogsearch/result/?q=%";
        public static List<string> All = new List<string>([wwwRuzovyslonCz, wwwEroticcityCz, wwwSexshopikCz, wwwSexShopCz, intimmShopCz, wwwEroticstoreCz, wwwNejlevnejsierotickepomuckyCz, wwwWillistoreCz, wwwVibratoryOnlineCz, wwwLuxusnipradloCz, eKondomyCz]);
    }
}