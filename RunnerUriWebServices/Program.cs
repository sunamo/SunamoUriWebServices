using SunamoUriWebServices;
using SunamoUriWebServices.Ads;

namespace RunnerUriWebServices;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        var p = AdsPhaRegion.Pha();
        string whatToSearch = null;

        //for (int i = 55; i < 61; i++)
        //{
        //    whatToSearch = "televize " + i + "\"";
        //    //UriWebServices.SearchInAll(p.All, whatToSearch);
        //    UriWebServices.OpenUri(UriWebServices.FromChromeReplacement(p.bazosCz, whatToSearch));
        //}

        whatToSearch = "TV stolek";
        UriWebServices.SearchInAll(p.All, whatToSearch);
        //UriWebServices.OpenUri(UriWebServices.FromChromeReplacement(p.hyperinzerceCz, whatToSearch));
    }
}
