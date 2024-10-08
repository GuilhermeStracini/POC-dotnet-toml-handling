using FluentAssertions;
using POCTomlHandling.Libraries;
using Tommy;

namespace POCTomlHandling.Tests;

public class TommyTests
{
    [Fact]
    public void ParseTomlString()
    {
        // Arrange
        var toml =
            @"
        [example]
        key = ""value""
        ";
        var parser = new TommyParser();

        // Act
        var result = parser.ParseTomlString(toml, "example", "key");

        // Assert
        result.Should().Be("value");
    }
}
