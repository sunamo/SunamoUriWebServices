namespace SunamoUriWebServices.Ads;

/// <summary>
/// Represents the ads region base type.
/// </summary>
public class AdsRegionBase
{
    /// <summary>
    /// Gets or sets the all.
    /// </summary>
    public List<string> All { get; set; }

    /// <summary>
    /// Gets or sets the aukro cz.
    /// </summary>
    public string AukroCz { get; set; }

    /// <summary>
    /// Gets or sets the avizo cz.
    /// </summary>
    public string AvizoCz { get; set; }

    /// <summary>
    /// Gets or sets the bazar cz.
    /// </summary>
    public string BazarCz { get; set; }

    /// <summary>
    /// Gets or sets the bazos cz.
    /// </summary>
    public string BazosCz { get; set; }

    /// <summary>
    /// Gets or sets the hyperinzerce cz.
    /// </summary>
    public string HyperinzerceCz { get; set; }

    /// <summary>
    /// Gets or sets the s bazar cz.
    /// </summary>
    public string SBazarCz { get; set; }

    private List<string> Other { get; set; }

    /// <summary>
    /// Initializes a new instance of the ads region base class.
    /// </summary>
    /// <param name="postalCode">The postal code.</param>
    /// <param name="hyperinzerceCz">The hyperinzerce cz.</param>
    /// <param name="bazarCz">The bazar cz.</param>
    /// <param name="sBazarCz">The s bazar cz.</param>
    /// <param name="avizoCz">The avizo cz.</param>
    /// <param name="other">The other.</param>
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
    /// Initializes a new instance of the search in all class.
    /// </summary>
    /// <param name="postalCode">The postal code.</param>
    /// <param name="hyperinzerceCz">The hyperinzerce cz.</param>
    /// <param name="bazarCz">The bazar cz.</param>
    /// <param name="sBazarCz">The s bazar cz.</param>
    /// <param name="avizoCz">The avizo cz.</param>
    /// <param name="other">The other.</param>
    public void SearchInAll(string searchQuery)
    {
        UriWebServices.SearchInAll(All, searchQuery);
    }
}
