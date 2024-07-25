using Tommy;
using Tomlyn;

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
        var model = Toml.Parse(toml);
        var table = model.ToModel();
        Console.WriteLine($""Key: {table["example"].AsTable()["key"]}"");

        // For writing
        var builder = new StringBuilder();
        Toml.FromModel(table, builder);
        Console.WriteLine(builder.ToString());
            @"
        [example]
        key = ""value""
        ";
        using var reader = new StringReader(toml);
        var table = TOML.Parse(reader);
        Console.WriteLine($"Key: {table["example"]["key"].AsString.Value}");
    }
}
