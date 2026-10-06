namespace SunamoUriWebServices._sunamo.SunamoExceptions;

internal sealed partial class Exceptions
{
    private static readonly StringBuilder additionalInfoInnerBuilder = new();
    private static readonly StringBuilder additionalInfoBuilder = new();

    #region Other
    internal static string CheckBefore(string prefix)
    {
        return string.IsNullOrWhiteSpace(prefix) ? string.Empty : prefix + ": ";
    }

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

    internal static void TypeAndMethodName(string stackTraceLine, out string type, out string methodName)
    {
        var afterAtText = stackTraceLine.Split(new[] { "at " }, StringSplitOptions.None)[1].Trim();
        var fullMethodPath = afterAtText.Split(new[] { "(" }, StringSplitOptions.None)[0];
        var parts = fullMethodPath.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        methodName = parts[^1];
        parts.RemoveAt(parts.Count - 1);
        type = string.Join(".", parts);
    }

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
