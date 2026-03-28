namespace SunamoUriWebServices._public.SunamoData.Data;

/// <summary>
/// Arguments for building Azure DevOps URI.
/// </summary>
public class AzureBuildUriArgs
{
    /// <summary>
    /// Gets or sets the personal access token for authentication.
    /// </summary>
    public string? PersonalAccessToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to include login in the URI.
    /// </summary>
    public bool IsWithLogin { get; set; }
}
