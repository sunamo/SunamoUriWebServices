namespace SunamoUriWebServices.Ads;

/// <summary>
/// Represents the ads by psc type.
/// </summary>
public class AdsByPsc
{
    /// <summary>
    /// The bazos cz constant.
    /// </summary>
    public const string bazosCz =
        "https://www.bazos.cz/search.php?hledat=%s&rubriky=www&hlokalita=%psc&humkreis=25&cenaod=&cenado=&Submit=Hledat&kitx=ano";

    /// <summary>
    /// The aukro cz constant.
    /// </summary>
    public const string aukroCz =
        "https://aukro.cz/vysledky-vyhledavani?text=%s&postCode=%psc&distance=40";
}
