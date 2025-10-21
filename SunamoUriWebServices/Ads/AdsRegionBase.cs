// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
// Instance variables refactored according to C# conventions
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

    List<string> Other { get; set; }

    public AdsRegionBase(string psc, string hyperinzerceCz, string bazarCz, string sBazarCz, string avizoCz, params string[] other)
    {
        bazosCz = AdsByPsc.bazosCz.Replace("%psc", psc);
        aukroCz = AdsByPsc.aukroCz.Replace("%psc", psc);

        All = new List<string>
        {
            hyperinzerceCz,
            bazarCz, sBazarCz, avizoCz, bazosCz, aukroCz,

        };
        All.AddRange(other);

        this.hyperinzerceCz = hyperinzerceCz;
        this.bazarCz = bazarCz;
        this.sBazarCz = sBazarCz;
        this.avizoCz = avizoCz;

        Other = other.ToList();
    }

    public void SearchInAll(string what)
    {
        UriWebServices.SearchInAll(All, what);
    }


}