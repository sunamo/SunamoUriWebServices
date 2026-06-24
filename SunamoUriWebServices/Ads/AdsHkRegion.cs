namespace SunamoUriWebServices.Ads;

public class AdsHkRegion
{
    public const string HyperinzerceCz =
        "https://hyperinzerce.cz/inzeraty/Index?query=%s&priceFrom=0&priceTo=99000000&distanceSearch=False&regionIds=HKK";

    public const string BazarCz = "https://www.bazar.cz/hradec-kralove/hledat/%s/?a=25";

    public const string SBazarCz = "https://www.sbazar.cz/hledej/%s/0-vsechny-kategorie/kralovehradecky";

    public const string AvizoCz = "https://www.avizo.cz/inzerce/%s/?lokalita%5B%5D=0012";

    public static AdsRegionBase Instance = new("50002", HyperinzerceCz, BazarCz, SBazarCz, AvizoCz);
}
