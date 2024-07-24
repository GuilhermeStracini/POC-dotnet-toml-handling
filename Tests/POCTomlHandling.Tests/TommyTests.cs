using FluentAssertions;
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
        using var reader = new StringReader(toml);

        // Act
        var table = TOML.Parse(reader);

        // Assert
        table["example"]["key"].AsString.Value.Should().Be("value");
    }
}
