namespace SunamoUriWebServices._sunamo.SunamoExceptions;

/// <summary>
/// Provides utility methods for exception handling and diagnostics.
/// </summary>
internal sealed partial class Exceptions
{
    private static readonly StringBuilder additionalInfoInnerBuilder = new();
    private static readonly StringBuilder additionalInfoBuilder = new();

    #region Other
    /// <summary>
    /// Checks and formats the prefix for exception messages.
    /// </summary>
    /// <param name="prefix">The prefix to check.</param>
    /// <returns>Formatted prefix string or empty string.</returns>
    internal static string CheckBefore(string prefix)
    {
        return string.IsNullOrWhiteSpace(prefix) ? string.Empty : prefix + ": ";
    }

    /// <summary>
    /// Gets the place of exception from the current stack trace.
    /// </summary>
    /// <param name="isFillingFirstTwo">Whether to fill type and method name from the first non-ThrowEx frame.</param>
    /// <returns>Tuple containing type name, method name, and full stack trace.</returns>
    internal static Tuple<string, string, string> PlaceOfException(bool isFillingFirstTwo = true)
    {
        StackTrace stackTrace = new();
        var stackTraceText = stackTrace.ToString();
        var stackTraceLines = stackTraceText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
        stackTraceLines.RemoveAt(0);
        var i = 0;
        string type = string.Empty;
        string methodName = string.Empty;
        for (; i < stackTraceLines.Count; i++)
        {
            var item = stackTraceLines[i];
            if (isFillingFirstTwo)
                if (!item.StartsWith("   at ThrowEx"))
                {
                    TypeAndMethodName(item, out type, out methodName);
                    isFillingFirstTwo = false;
                }
            if (item.StartsWith("at System."))
            {
                stackTraceLines.Add(string.Empty);
                stackTraceLines.Add(string.Empty);
                break;
            }
        }
        return new Tuple<string, string, string>(type, methodName, string.Join(Environment.NewLine, stackTraceLines));
    }

    /// <summary>
    /// Extracts type and method name from a stack trace line.
    /// </summary>
    /// <param name="stackTraceLine">The stack trace line to parse.</param>
    /// <param name="type">The extracted type name.</param>
    /// <param name="methodName">The extracted method name.</param>
    internal static void TypeAndMethodName(string stackTraceLine, out string type, out string methodName)
    {
        var afterAtText = stackTraceLine.Split(new[] { "at " }, StringSplitOptions.None)[1].Trim();
        var fullMethodPath = afterAtText.Split(new[] { "(" }, StringSplitOptions.None)[0];
        var parts = fullMethodPath.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        methodName = parts[^1];
        parts.RemoveAt(parts.Count - 1);
        type = string.Join(".", parts);
    }

    /// <summary>
    /// Gets the name of the calling method.
    /// </summary>
    /// <param name="depth">The stack frame depth to retrieve.</param>
    /// <returns>The name of the calling method.</returns>
    internal static string CallingMethod(int depth = 1)
    {
        StackTrace stackTrace = new();
        var methodBase = stackTrace.GetFrame(depth)?.GetMethod();
        if (methodBase == null)
        {
            return "Method name cannot be get";
        }
        var methodName = methodBase.Name;
        return methodName;
    }
    #endregion

    #region IsNullOrWhitespace
    /// <summary>
    /// Checks if a string argument is null, empty, or whitespace.
    /// </summary>
    /// <param name="prefix">The prefix for the error message.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="isNotAllowingOnlyWhitespace">Whether to disallow whitespace-only values.</param>
    /// <returns>Error message if validation fails, null otherwise.</returns>
    internal static string? IsNullOrWhitespace(string prefix, string argName, string argValue, bool isNotAllowingOnlyWhitespace)
    {
        string additionalParams;
        if (argValue == null)
        {
            additionalParams = AddParams();
            return CheckBefore(prefix) + argName + " is null" + additionalParams;
        }
        if (argValue == string.Empty)
        {
            additionalParams = AddParams();
            return CheckBefore(prefix) + argName + " is empty (without trim)" + additionalParams;
        }
        if (isNotAllowingOnlyWhitespace && argValue.Trim() == string.Empty)
        {
            additionalParams = AddParams();
            return CheckBefore(prefix) + argName + " is empty (with trim)" + additionalParams;
        }
        return null;
    }

    /// <summary>
    /// Builds additional parameters string from the string builders.
    /// </summary>
    /// <returns>Formatted additional parameters string.</returns>
    internal static string AddParams()
    {
        additionalInfoBuilder.Insert(0, Environment.NewLine);
        additionalInfoBuilder.Insert(0, "Outer:");
        additionalInfoBuilder.Insert(0, Environment.NewLine);
        additionalInfoInnerBuilder.Insert(0, Environment.NewLine);
        additionalInfoInnerBuilder.Insert(0, "Inner:");
        additionalInfoInnerBuilder.Insert(0, Environment.NewLine);
        var additionalParams = additionalInfoBuilder.ToString();
        var additionalParamsInner = additionalInfoInnerBuilder.ToString();
        return additionalParams + additionalParamsInner;
    }
    #endregion
}
