namespace SunamoUriWebServices._public.SunamoData.Data;

/// <summary>
/// Represents the azure build uri args type.
/// </summary>
public class AzureBuildUriArgs
{
    /// <summary>
    /// Gets or sets the personal access token.
    /// </summary>
    public string? PersonalAccessToken { get; set; }

    /// <summary>
    /// Gets or sets the is with login.
    /// </summary>
    public bool IsWithLogin { get; set; }
}
