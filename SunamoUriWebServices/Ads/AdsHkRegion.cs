namespace SunamoUriWebServices.Ads;

/// <summary>
/// Represents the ads hk region type.
/// </summary>
public class AdsHkRegion
{
    /// <summary>
    /// The hyperinzerce cz constant.
    /// </summary>
    public const string HyperinzerceCz =
        "https://hyperinzerce.cz/inzeraty/Index?query=%s&priceFrom=0&priceTo=99000000&distanceSearch=False&regionIds=HKK";

    /// <summary>
    /// The bazar cz constant.
    /// </summary>
    public const string BazarCz = "https://www.bazar.cz/hradec-kralove/hledat/%s/?a=25";

    /// <summary>
    /// The s bazar cz constant.
    /// </summary>
    public const string SBazarCz = "https://www.sbazar.cz/hledej/%s/0-vsechny-kategorie/kralovehradecky";

    /// <summary>
    /// The avizo cz constant.
    /// </summary>
    public const string AvizoCz = "https://www.avizo.cz/inzerce/%s/?lokalita%5B%5D=0012";

    /// <summary>
    /// The instance.
    /// </summary>
    public static AdsRegionBase Instance = new("50002", HyperinzerceCz, BazarCz, SBazarCz, AvizoCz);
}
