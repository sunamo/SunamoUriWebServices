
namespace SunamoUriWebServices;
using System.Runtime.InteropServices;

public partial class UriWebServices
{
    public const string githubCom = "https://github.com/";

    /// <summary>
    ///     alphabetically
    /// </summary>
    private static readonly List<string> githubRepos = SHGetLines.GetLines(@"GridControlsInWpf_Blog
MyCodeExample
sugo
sunamo
sunamo5
SunamoCssGenerator
SunamoEditorConfig
SunamoLaTeX
SunamoMathpix
SunamoRobotsTxt
SunamoRuleset
PlatformIndependentNuGetPackages
PlatformIndependentNuGetPackages5
PlatformIndependentNuGetPackages.Tests
sunamo.github.io
sunamo.notmine
sunamo.notmine5
sunamo.notmine.Tests
sunamo.performance
sunamo.Tests
sunamo.unsafe
sunamo.unsafe.Tests
sunpm
TranslateEngine");

    public static void OpenUri(string url)
    {
        try
        {
            Process.Start(url);
        }
        catch
        {
            // hack because of this: https://github.com/dotnet/corefx/issues/10361
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // Tohle nevím k čemu tu je, mrví to to akorát adresy
                //url = url.Replace("&", "^&");
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

    public static bool IsGithubRepo(string fn)
    {
        return githubRepos.Contains(fn);
    }

    public static string GitClone(string slnName)
    {
        return githubCom + "sunamo/" + slnName + ".git";
    }

    public static string AzureRepoWebUIFullOrGithub(string fn, AzureBuildUriArgs a = null)
    {
        if (IsGithubRepo(fn)) return GitClone(fn);
        return AzureRepoWebUIFull(fn, a);
    }

    public partial class Facebook
    {
        public static string FacebookProfile(string nick)
        {
            return "https://www.facebook.com/" + nick;
        }
    }
}