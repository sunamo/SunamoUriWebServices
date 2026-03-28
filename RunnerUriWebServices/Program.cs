// variables names: ok

using SunamoUriWebServices;
using SunamoUriWebServices.Ads;

namespace RunnerUriWebServices;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        var parameter = AdsPhaRegion.Pha();
        string? whatToSearch = null;

        whatToSearch = "TV stolek";
        UriWebServices.SearchInAll(parameter.All, whatToSearch);
    }
}
