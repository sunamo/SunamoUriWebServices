// variables names: ok
// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy

using SunamoUriWebServices;
using SunamoUriWebServices.Ads;

namespace RunnerUriWebServices;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        var parameter = AdsPhaRegion.Pha();
        string whatToSearch = null;

        //for (int index = 55; index < 61; index++)
        //{
        //    whatToSearch = "televize " + index + "\"";
        //    //UriWebServices.SearchInAll(parameter.All, whatToSearch);
        //    UriWebServices.OpenUri(UriWebServices.FromChromeReplacement(parameter.bazosCz, whatToSearch));
        //}

        whatToSearch = "TV stolek";
        UriWebServices.SearchInAll(parameter.All, whatToSearch);
        //UriWebServices.OpenUri(UriWebServices.FromChromeReplacement(parameter.hyperinzerceCz, whatToSearch));
    }
}
