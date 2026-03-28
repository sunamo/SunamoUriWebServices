namespace SunamoUriWebServices.Ads;

/// <summary>
/// Advertisement search URLs for the Prague region.
/// </summary>
public class AdsPhaRegion
{
    /// <summary>
    /// Creates a preconfigured region search instance for Prague.
    /// </summary>
    /// <returns>An <see cref="AdsRegionBase"/> instance configured for Prague.</returns>
    public static AdsRegionBase Pha()
    {
        var hyperinzerceCz = "https://hyperinzerce.cz/inzeraty/Index?query=%s&distanceSearch=False&regionIds=PHA&sortBy=Default";
        var bazarCz = "https://www.bazar.cz/praha/hledat/%s/?a=25";
        var sBazarCz = "https://www.sbazar.cz/hledej/%s/0-vsechny-kategorie/praha?p=11000&pid=4000";
        var avizoCz = "https://www.avizo.cz/inzerce/%s/?lokalita_search=11000%20-%20Praha%209&lokalita_id=3297";
        var marketplace = "https://www.facebook.com/marketplace/prague/search?sortBy=price_ascend&query=%s&exact=false";

        return new AdsRegionBase("11000", hyperinzerceCz, bazarCz, sBazarCz, avizoCz, marketplace);
    }
}
