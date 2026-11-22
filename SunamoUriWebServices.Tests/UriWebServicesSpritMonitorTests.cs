namespace SunamoUriWebServices.Tests;

/// <summary>
/// Tests of the spritmonitor.de search URL.
/// </summary>
public class UriWebServicesSpritMonitorTests
{
    /// <summary>
    /// The search URL points to spritmonitor.de and escapes the car model.
    /// </summary>
    [Fact]
    public void SpritMonitorSearch_EscapesCarModel()
    {
        var uri = UriWebServices.SpritMonitorSearch("Škoda Octavia 1.6 & CNG");

        Assert.Equal("https://www.spritmonitor.de/en/search.html?searchterm=%C5%A0koda%20Octavia%201.6%20%26%20CNG", uri);
    }
}
