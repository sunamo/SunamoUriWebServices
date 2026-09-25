namespace SunamoUriWebServices;

public partial class UriWebServices
{
    public static bool IsToOpen(string text)
    {
        return new List<string>(["N/A", "n/a"]).Contains(text);
    }

    public static class UriWebServicesDontTranslate
    {
        private static List<string>? brandsList;

        public static void SearchInAll(string spicyName)
        {
            if (brandsList == null)
            {
                brandsList = new List<string>(new List<string>(["kotanyi", "avokádo", "nadir", "Orient", "Drago",
                    "vítana", "svět bylinek"]));
            }

            foreach (var item in brandsList) UriWebServices.OpenUri(GoogleSearch($"{item} koření {spicyName}"));
        }
    }
}
