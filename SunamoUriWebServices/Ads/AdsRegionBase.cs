namespace SunamoUriWebServices.Ads;

/// <summary>
/// Base class for regional advertisement search URLs.
/// </summary>
public class AdsRegionBase
{
    /// <summary>
    /// Gets or sets all advertisement search URLs.
    /// </summary>
    public List<string> All { get; set; }

    /// <summary>
    /// Gets or sets the Aukro.cz search URL.
    /// </summary>
    public string AukroCz { get; set; }

    /// <summary>
    /// Gets or sets the Avizo.cz search URL.
    /// </summary>
    public string AvizoCz { get; set; }

    /// <summary>
    /// Gets or sets the Bazar.cz search URL.
    /// </summary>
    public string BazarCz { get; set; }

    /// <summary>
    /// Gets or sets the Bazos.cz search URL (3rd largest).
    /// </summary>
    public string BazosCz { get; set; }

    /// <summary>
    /// Gets or sets the Hyperinzerce.cz search URL (1st largest).
    /// </summary>
    public string HyperinzerceCz { get; set; }

    /// <summary>
    /// Gets or sets the SBazar.cz search URL (2nd largest).
    /// </summary>
    public string SBazarCz { get; set; }

    private List<string> Other { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AdsRegionBase"/> class.
    /// </summary>
    /// <param name="postalCode">The postal code for location-based search.</param>
    /// <param name="hyperinzerceCz">The Hyperinzerce.cz search URL template.</param>
    /// <param name="bazarCz">The Bazar.cz search URL template.</param>
    /// <param name="sBazarCz">The SBazar.cz search URL template.</param>
    /// <param name="avizoCz">The Avizo.cz search URL template.</param>
    /// <param name="other">Additional search URL templates.</param>
    public AdsRegionBase(string postalCode, string hyperinzerceCz, string bazarCz, string sBazarCz, string avizoCz, params string[] other)
    {
        BazosCz = AdsByPsc.bazosCz.Replace("%psc", postalCode);
        AukroCz = AdsByPsc.aukroCz.Replace("%psc", postalCode);

        All = new List<string>
        {
            hyperinzerceCz,
            bazarCz, sBazarCz, avizoCz, BazosCz, AukroCz,
        };
        All.AddRange(other);

        HyperinzerceCz = hyperinzerceCz;
        BazarCz = bazarCz;
        SBazarCz = sBazarCz;
        AvizoCz = avizoCz;

        Other = other.ToList();
    }

    /// <summary>
    /// Searches in all advertisement sites for the specified query.
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    public void SearchInAll(string searchQuery)
    {
        UriWebServices.SearchInAll(All, searchQuery);
    }
}
