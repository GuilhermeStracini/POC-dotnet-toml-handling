using FluentAssertions;
using Tommy;
using Tomlyn;

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

    [Fact]
    public void ParseTomlStringWithTomlyn()
    {
        // Arrange
        var toml = @"
        [example]
        key = ""value""
        ";
        var model = Toml.Parse(toml);

        // Act
        var table = model.ToModel();

        // Assert
        table["example"].AsTable()["key"].Should().Be("value");
    }
        key = ""value""
        ";
        using var reader = new StringReader(toml);

        // Act
        var table = TOML.Parse(reader);

        // Assert
        table["example"]["key"].AsString.Value.Should().Be("value");
    }
}
