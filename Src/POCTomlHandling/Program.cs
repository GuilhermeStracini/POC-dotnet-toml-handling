using Tommy;

namespace POCTomlHandling;

internal static class Program
{
    public static void Main()
    {
        var toml =
            @"
        [example]
        key = ""value""
        ";
        using var reader = new StringReader(toml);
        var table = TOML.Parse(reader);
        Console.WriteLine($"Key: {table["example"]["key"].AsString.Value}");
    }
}
