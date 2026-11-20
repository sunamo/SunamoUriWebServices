namespace SunamoUriWebServices;

/// <summary>
/// Represents the uri web services type.
/// </summary>
public partial class UriWebServices
{
    /// <summary>
    /// The github com constant.
    /// </summary>
    public const string GithubCom = "https://github.com/";

    private static readonly List<string> myGithubReposNames = new();

    /// <summary>
    /// Open uri.
    /// </summary>
    /// <returns>The open uri result.</returns>
    public static void OpenUri(string url)
    {
        try
        {
            Process.Start(url);
        }
        catch
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url);
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// Is github repo.
    /// </summary>
    /// <param name="repositoryName">The repository name.</param>
    /// <returns>The is github repo result.</returns>
    public static bool IsGithubRepo(string repositoryName)
    {
        return myGithubReposNames.Contains(repositoryName);
    }

    /// <summary>
    /// Git clone.
    /// </summary>
    /// <param name="repositoryName">The repository name.</param>
    /// <returns>The git clone result.</returns>
    public static string GitClone(string solutionName)
    {
        return GithubCom + "sunamo/" + solutionName + ".git";
    }

    /// <summary>
    /// Azure repo web UI full or github.
    /// </summary>
    /// <param name="repositoryName">The repository name.</param>
    /// <param name="args">The args.</param>
    /// <returns>The azure repo web UI full or github result.</returns>
    public static string AzureRepoWebUIFullOrGithub(string repositoryName, AzureBuildUriArgs? args = null)
    {
        if (IsGithubRepo(repositoryName)) return GitClone(repositoryName);
        return AzureRepoWebUIFull(repositoryName, args);
    }

    /// <summary>
    /// Represents the facebook type.
    /// </summary>
    public partial class Facebook
    {
        /// <summary>
        /// Facebook profile.
        /// </summary>
        /// <param name="nickname">The nickname.</param>
        /// <returns>The facebook profile result.</returns>
        public static string FacebookProfile(string nickname)
        {
            return "https://www.facebook.com/" + nickname;
        }
    }
}
