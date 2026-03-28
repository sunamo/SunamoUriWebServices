namespace SunamoUriWebServices;

/// <summary>
/// Provides URI building methods for various web services.
/// </summary>
public partial class UriWebServices
{
    /// <summary>
    /// GitHub base URL.
    /// </summary>
    public const string GithubCom = "https://github.com/";

    private static readonly List<string> myGithubReposNames = new();

    /// <summary>
    /// Opens a URI in the default browser, handling cross-platform differences.
    /// </summary>
    /// <param name="url">The URL to open.</param>
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
    /// Checks if the specified repository name is a known GitHub repository.
    /// </summary>
    /// <param name="repositoryName">The repository name to check.</param>
    /// <returns>True if the repository is a known GitHub repository.</returns>
    public static bool IsGithubRepo(string repositoryName)
    {
        return myGithubReposNames.Contains(repositoryName);
    }

    /// <summary>
    /// Gets the Git clone URL for the specified solution name.
    /// </summary>
    /// <param name="solutionName">The solution name.</param>
    /// <returns>The Git clone URL.</returns>
    public static string GitClone(string solutionName)
    {
        return GithubCom + "sunamo/" + solutionName + ".git";
    }

    /// <summary>
    /// Gets the Azure Repo Web UI URL or GitHub clone URL based on repository type.
    /// </summary>
    /// <param name="repositoryName">The repository name.</param>
    /// <param name="args">Optional Azure build URI arguments.</param>
    /// <returns>The repository URL.</returns>
    public static string AzureRepoWebUIFullOrGithub(string repositoryName, AzureBuildUriArgs? args = null)
    {
        if (IsGithubRepo(repositoryName)) return GitClone(repositoryName);
        return AzureRepoWebUIFull(repositoryName, args);
    }

    /// <summary>
    /// Provides Facebook-related URL building methods.
    /// </summary>
    public partial class Facebook
    {
        /// <summary>
        /// Gets the Facebook profile URL for the specified nickname.
        /// </summary>
        /// <param name="nickname">The Facebook username or nickname.</param>
        /// <returns>The Facebook profile URL.</returns>
        public static string FacebookProfile(string nickname)
        {
            return "https://www.facebook.com/" + nickname;
        }
    }
}
