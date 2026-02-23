// variables names: ok
namespace SunamoUriWebServices.Tests;

/// <summary>
/// EN: Unit tests for UriWebServicesIdos class
/// CZ: Unit testy pro třídu UriWebServicesIdos
/// </summary>
public class UriWebServicesIdosTests
{
    /// <summary>
    /// EN: Test CalculateTargetDate with date 29.10.2025 (October 29, 2025)
    /// CZ: Test metody CalculateTargetDate s datem 29.10.2025 (29. října 2025)
    /// </summary>
    [Fact]
    public void CalculateTargetDate_WithDate20251029_ReturnsCorrectDate()
    {
        // Arrange
        DateTime testDate = new DateTime(2025, 10, 29);

        // Act
        DateTime result = UriWebServicesIdos.CalculateTargetDate(testDate);

        // Assert
        // EN: 13.12.2025 is Saturday, so should return Friday 12.12.2025
        // CZ: 13.12.2025 je sobota, takže by měl vrátit pátek 12.12.2025
        Assert.Equal(new DateTime(2025, 12, 12), result);
    }

    /// <summary>
    /// EN: Test CalculateTargetDate with date 16.12.2025 (December 16, 2025)
    /// CZ: Test metody CalculateTargetDate s datem 16.12.2025 (16. prosince 2025)
    /// </summary>
    [Fact]
    public void CalculateTargetDate_WithDate20251216_ReturnsCorrectDate()
    {
        // Arrange
        DateTime testDate = new DateTime(2025, 12, 16);

        // Act
        DateTime result = UriWebServicesIdos.CalculateTargetDate(testDate);

        // Assert
        Assert.Equal(new DateTime(2026, 6, 12), result);
    }
}
