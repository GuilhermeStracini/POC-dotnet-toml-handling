using FluentAssertions;
using Tommy;

namespace POCTemplate.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        const bool expected = true;
    [Fact]
    public void ParseTomlString()
    {
        // Arrange
        var toml = @"
        [example]
        key = ""value""
        ";
        using var reader = new StringReader(toml);
        
        // Act
        var table = TOML.Parse(reader);
        
        // Assert
        table[""example""][""key""].AsString.Should().Be("value");
    }

        // Act

        // Assert
        expected.Should().BeTrue();
    }
}
