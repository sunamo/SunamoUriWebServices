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

    public static string SearchBazosCz(string searchQuery) => FromChromeReplacement(Instance.BazosCz, searchQuery);

    public static string FromChromeReplacement(string uri, string term) => UriWebServices.FromChromeReplacement(uri, term);

    public static string SearchHyperinzerceCz(string searchQuery) => FromChromeReplacement(HyperinzerceCz, searchQuery);

    public static string SearchBazarCz(string searchQuery) => FromChromeReplacement(BazarCz, searchQuery);

    #endregion
}
