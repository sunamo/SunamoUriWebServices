namespace SunamoUriWebServices.Ads;
public class AdsPhaRegion
{
    /// <summary>
    /// Result.All insert into UriWebServices.SearchInAll(result, what);
    /// </summary>
    /// <returns></returns>
    public static AdsRegionBase Pha()
    {
        var hyperinzerceCz = "https://hyperinzerce.cz/inzeraty/Index?query=%s&distanceSearch=False&regionIds=PHA&sortBy=Default";
        var bazarCz = "https://www.bazar.cz/praha/hledat/%s/?a=25";
        var sBazarCz = "https://www.sbazar.cz/hledej/%s/0-vsechny-kategorie/praha?p=11000&pid=4000";
        var avizoCz = "https://www.avizo.cz/inzerce/%s/?lokalita_search=19000%20-%20Praha%209&lokalita_id=3297";
        var marketplace = "https://www.facebook.com/marketplace/prague/search?sortBy=price_ascend&query=%s&exact=false";
        // nebudu otevírat, zbytečně to komplikuji
        var announce = "https://www.annonce.cz/inzerce-zdarma-a-do-100-Kc$18-filter.html?location_country=&location_zip=180&location_zip=181&location_zip=182&location_zip=183&location_zip=184&location_zip=185&location_zip=186&location_zip=187&location_zip=188&location_zip=189&q=%s&maxAge=&nabidkovy=2&action=Hledej";

        return new AdsRegionBase("19000", hyperinzerceCz, bazarCz, sBazarCz, avizoCz, marketplace);
    }
}