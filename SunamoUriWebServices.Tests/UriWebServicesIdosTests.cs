// variables names: ok
namespace SunamoUriWebServices.Tests;

/// <summary>
/// Unit tests for UriWebServicesIdos class
/// </summary>
public class UriWebServicesIdosTests
{
    /// <summary>
    /// Test CalculateTargetDate with date 29.10.2025 (October 29, 2025)
    /// </summary>
    [Fact]
    public void CalculateTargetDate_WithDate20251029_ReturnsCorrectDate()
    {
        // Arrange
        DateTime testDate = new DateTime(2025, 10, 29);

        // Act
        DateTime result = UriWebServicesIdos.CalculateTargetDate(testDate);

        // Assert
        // 13.12.2025 is Saturday, so should return Friday 12.12.2025
        Assert.Equal(new DateTime(2025, 12, 12), result);
    }

    /// <summary>
    /// Test CalculateTargetDate with date 16.12.2025 (December 16, 2025)
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
