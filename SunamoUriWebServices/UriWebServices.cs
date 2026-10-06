namespace SunamoUriWebServices;

public partial class UriWebServices
{
    public const string GithubCom = "https://github.com/";

    private static readonly List<string> myGithubReposNames = new();

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

    public static bool IsGithubRepo(string repositoryName)
    {
        return myGithubReposNames.Contains(repositoryName);
    }

    public static string GitClone(string solutionName)
    {
        return GithubCom + "sunamo/" + solutionName + ".git";
    }

    public static string AzureRepoWebUIFullOrGithub(string repositoryName, AzureBuildUriArgs? args = null)
    {
        if (IsGithubRepo(repositoryName)) return GitClone(repositoryName);
        return AzureRepoWebUIFull(repositoryName, args);
    }

    public partial class Facebook
    {
        public static string FacebookProfile(string nickname)
        {
            return "https://www.facebook.com/" + nickname;
        }
    }
}
