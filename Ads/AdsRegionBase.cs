namespace SunamoUriWebServices.Ads;

public class AdsRegionBase
{
    public List<string> All;
    public string aukroCz;
    public string avizoCz;
    public string bazarCz;

    /// <summary>
    ///     3. největší
    /// </summary>
    public string bazosCz;

    /// <summary>
    ///     1. největší
    /// </summary>
    public string hyperinzerceCz;

    /// <summary>
    ///     2. největší
    /// </summary>
    public string sBazarCz;

    public AdsRegionBase(string psc, string hyperinzerceCz, string bazarCz, string sBazarCz, string avizoCz)
    {
        bazosCz = AdsByPsc.bazosCz.Replace("%psc", "50002");
        aukroCz = AdsByPsc.aukroCz.Replace("%psc", "50002");

        All = new List<string>
        {
            hyperinzerceCz,
            bazarCz, sBazarCz, avizoCz, bazosCz, aukroCz
        };

        this.hyperinzerceCz = hyperinzerceCz;
        this.bazarCz = bazarCz;
        this.sBazarCz = sBazarCz;
        this.avizoCz = avizoCz;
    }

    public void SearchInAll(string what)
    {
        UriWebServices.SearchInAll(All, what);
    }
}