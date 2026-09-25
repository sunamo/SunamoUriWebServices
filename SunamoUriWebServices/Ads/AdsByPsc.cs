// variables names: ok
namespace SunamoUriWebServices.Ads;

/// <summary>
/// Provides classified ad search URL templates with postal code parameter.
/// </summary>
public class AdsByPsc
{
    /// <summary>
    /// Bazos.cz search URL template with postal code and radius parameters.
    /// </summary>
    public const string bazosCz =
        "https://www.bazos.cz/search.php?hledat=%s&rubriky=www&hlokalita=%psc&humkreis=25&cenaod=&cenado=&Submit=Hledat&kitx=ano";

    /// <summary>
    /// Aukro.cz search URL template with postal code and distance parameters.
    /// </summary>
    public const string aukroCz =
        "https://aukro.cz/vysledky-vyhledavani?text=%s&postCode=%psc&distance=40";
}