namespace POCTemplate;
using Tommy;

internal static class Program
{
    public static void Main()
        var toml = @"
        [example]
        key = ""value""
        ";
        using var reader = new StringReader(toml);
        var table = TOML.Parse(reader);
        Console.WriteLine($""Key: {table[""example""][""key""].AsString}"");

    {
        // This is a placeholder for the main entry point of the application.
        Console.WriteLine("Hello, World!");
    }
}
