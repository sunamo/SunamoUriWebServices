namespace SunamoUriWebServices.Ads;

public class AdsRegionBase
{
    public List<string> All { get; set; }

    public string AukroCz { get; set; }

    public string AvizoCz { get; set; }

    public string BazarCz { get; set; }

    public string BazosCz { get; set; }

    public string HyperinzerceCz { get; set; }

    public string SBazarCz { get; set; }

    private List<string> Other { get; set; }

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

    public void SearchInAll(string searchQuery)
    {
        UriWebServices.SearchInAll(All, searchQuery);
    }
}
