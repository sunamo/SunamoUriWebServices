namespace SunamoUriWebServices;

public partial class UriWebServices
{
    /// <summary>
    /// Is to open.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The is to open result.</returns>
    public static bool IsToOpen(string text)
    {
        return new List<string>(["N/A", "n/a"]).Contains(text);
    }

    /// <summary>
    /// Represents the uri web services dont translate type.
    /// </summary>
    public static class UriWebServicesDontTranslate
    {
        private static List<string>? brandsList;

        /// <summary>
        /// Search in all.
        /// </summary>
        /// <param name="spicyName">The spicy name.</param>
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
