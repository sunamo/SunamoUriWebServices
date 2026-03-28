namespace SunamoUriWebServices;

/// <summary>
/// Contains methods and classes that should not be translated.
/// </summary>
public partial class UriWebServices
{
    /// <summary>
    /// Checks if the specified text represents a value that should not be opened.
    /// </summary>
    /// <param name="text">The text to check.</param>
    /// <returns>True if the text is "N/A" or "n/a".</returns>
    public static bool IsToOpen(string text)
    {
        return new List<string>(["N/A", "n/a"]).Contains(text);
    }

    /// <summary>
    /// Provides spice search functionality across multiple brands.
    /// </summary>
    public static class UriWebServicesDontTranslate
    {
        private static List<string>? brandsList;

        /// <summary>
        /// Searches for a spice across all known spice brands using Google.
        /// </summary>
        /// <param name="spicyName">The name of the spice to search for.</param>
        public static void SearchInAll(string spicyName)
        {
            if (brandsList == null)
            {
                brandsList = new List<string>(new List<string>(["kotanyi", "avok\u00E1do", "nadir", "Orient", "Drago",
                    "v\u00EDtana", "sv\u011Bt bylinek"]));
            }

            foreach (var item in brandsList) UriWebServices.OpenUri(GoogleSearch($"{item} koření {spicyName}"));
        }
    }
}
