namespace SunamoUriWebServices._sunamo.SunamoExceptions;

/// <summary>
/// Provides methods for throwing exceptions with diagnostic information.
/// </summary>
internal partial class ThrowEx
{
    /// <summary>
    /// Checks if a string argument is null or empty and throws if so.
    /// </summary>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="argValue">The value of the argument.</param>
    /// <returns>True if the argument is null or empty.</returns>
    internal static bool IsNullOrEmpty(string argName, string argValue)
    { return ThrowIsNotNull(Exceptions.IsNullOrWhitespace(FullNameOfExecutedCode(), argName, argValue, true)); }

    #region Other
    /// <summary>
    /// Gets the full name of the currently executed code location.
    /// </summary>
    /// <returns>Full name including type and method.</returns>
    internal static string FullNameOfExecutedCode()
    {
        Tuple<string, string, string> placeOfException = Exceptions.PlaceOfException();
        string fullName = FullNameOfExecutedCode(placeOfException.Item1, placeOfException.Item2, true);
        return fullName;
    }

    private static string FullNameOfExecutedCode(object type, string methodName, bool isFromThrowEx = false)
    {
        if (methodName == null)
        {
            int depth = 2;
            if (isFromThrowEx)
            {
                depth++;
            }

            methodName = Exceptions.CallingMethod(depth);
        }
        string typeFullName;
        if (type is Type typeValue)
        {
            typeFullName = typeValue.FullName ?? "Type cannot be get via type is Type type2";
        }
        else if (type is MethodBase method)
        {
            typeFullName = method.ReflectedType?.FullName ?? "Type cannot be get via type is MethodBase method";
            methodName = method.Name;
        }
        else if (type is string)
        {
            typeFullName = type.ToString() ?? "Type cannot be get via type is string";
        }
        else
        {
            Type typeObject = type.GetType();
            typeFullName = typeObject.FullName ?? "Type cannot be get via type.GetType()";
        }
        return string.Concat(typeFullName, ".", methodName);
    }

    /// <summary>
    /// Throws an exception if the provided exception message is not null.
    /// </summary>
    /// <param name="exception">The exception message.</param>
    /// <param name="isReallyThrowing">Whether to actually throw or just return true.</param>
    /// <returns>True if exception was not null.</returns>
    internal static bool ThrowIsNotNull(string? exception, bool isReallyThrowing = true)
    {
        if (exception != null)
        {
            Debugger.Break();
            if (isReallyThrowing)
            {
                throw new Exception(exception);
            }
            return true;
        }
        return false;
    }
    #endregion
}
