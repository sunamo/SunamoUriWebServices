namespace SunamoUriWebServices.Ads;

/// <summary>
/// Advertisement search URLs for the Hradec Kralove region.
/// </summary>
public class AdsHkRegion
{
    /// <summary>
    /// Hyperinzerce.cz search URL for Hradec Kralove region.
    /// </summary>
    public const string HyperinzerceCz =
        "https://hyperinzerce.cz/inzeraty/Index?query=%s&priceFrom=0&priceTo=99000000&distanceSearch=False&regionIds=HKK";

    /// <summary>
    /// Bazar.cz search URL for Hradec Kralove region.
    /// </summary>
    public const string BazarCz = "https://www.bazar.cz/hradec-kralove/hledat/%s/?a=25";

    /// <summary>
    /// SBazar.cz search URL for Hradec Kralove region.
    /// </summary>
    public const string SBazarCz = "https://www.sbazar.cz/hledej/%s/0-vsechny-kategorie/kralovehradecky";

    /// <summary>
    /// Avizo.cz search URL for Hradec Kralove region.
    /// </summary>
    public const string AvizoCz = "https://www.avizo.cz/inzerce/%s/?lokalita%5B%5D=0012";

    /// <summary>
    /// Preconfigured region search instance for Hradec Kralove.
    /// </summary>
    public static AdsRegionBase Instance = new("50002", HyperinzerceCz, BazarCz, SBazarCz, AvizoCz);
}
