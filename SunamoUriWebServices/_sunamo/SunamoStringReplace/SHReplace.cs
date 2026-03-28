namespace SunamoUriWebServices._sunamo.SunamoStringReplace;

/// <summary>
/// Provides string replacement utility methods.
/// </summary>
internal class SHReplace
{
    /// <summary>
    /// Replaces all occurrences of specified patterns with a replacement string.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <param name="replacement">The replacement string.</param>
    /// <param name="patterns">The patterns to replace.</param>
    /// <returns>The text with all patterns replaced.</returns>
    internal static string ReplaceAll(string text, string replacement, params string[] patterns)
    {
        foreach (var item in patterns)
            if (string.IsNullOrEmpty(item))
                return text;

        foreach (var item in patterns) text = text.Replace(item, replacement);
        return text;
    }
}
