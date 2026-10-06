namespace SunamoUriWebServices.Ads;

// For phones, etc. repas sites like mp.cz are better.
public static class AdsMsRegion
{
    public const string HyperinzerceCz =
        "https://hyperinzerce.cz/inzeraty/Index?query=%s&priceFrom=0&priceTo=99000000&distanceSearch=False&regionIds=HKK";

    public const string BazarCz = "https://www.bazar.cz/ostrava/hledat/%s/?a=25&p=%psc&pid=6934";

    public const string SBazarCz = "https://www.sbazar.cz/hledej/%s/0-vsechny-kategorie/moravskoslezsky";

    public const string AvizoCz = "https://www.avizo.cz/fulltext/?beng=1&searchfor=ads&keywords=%s";

    public static Type ReflectionType = typeof(AdsMsRegion);

    public static AdsRegionBase Instance = new("70800", HyperinzerceCz, BazarCz, SBazarCz, AvizoCz);

    #region Methods

    /// <summary>
    /// Gets Bazos.cz search URL for the specified query (70800, 25km radius).
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted search URL.</returns>
    public static string SearchBazosCz(string searchQuery) => FromChromeReplacement(Instance.BazosCz, searchQuery);

    /// <summary>
    /// Replaces Chrome search placeholder with the specified term.
    /// </summary>
    /// <param name="uri">The URI template with placeholder.</param>
    /// <param name="term">The search term to insert.</param>
    /// <returns>The formatted URI.</returns>
    public static string FromChromeReplacement(string uri, string term) => UriWebServices.FromChromeReplacement(uri, term);

    /// <summary>
    /// Gets Hyperinzerce.cz search URL for the specified query (Moravian-Silesian region).
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted search URL.</returns>
    public static string SearchHyperinzerceCz(string searchQuery) => FromChromeReplacement(HyperinzerceCz, searchQuery);

    /// <summary>
    /// Gets Bazar.cz search URL for the specified query (70800, 25km radius).
    /// </summary>
    /// <param name="searchQuery">The search query.</param>
    /// <returns>The formatted search URL.</returns>
    public static string SearchBazarCz(string searchQuery) => FromChromeReplacement(BazarCz, searchQuery);

    #endregion
}
