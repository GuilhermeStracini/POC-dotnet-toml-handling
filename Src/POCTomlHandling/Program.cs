using System.Diagnostics.CodeAnalysis;
using POCTomlHandling.Libraries;

namespace POCTomlHandling;

[ExcludeFromCodeCoverage]
internal static class Program
{
    public static void Main()
    {
        const string content =
            @"
        [example]
        key = ""value""
        ";
        const string root = "example";
        const string key = "key";

        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("Tomlyn");
        Console.WriteLine("---------------------------------------------------------------");
        var tomlyn = new TomlynParser();
        var tomlynResult = tomlyn.ParseTomlString(content, root, key);
        Console.WriteLine($"Key: {tomlynResult}");

        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("Tommy");
        Console.WriteLine("---------------------------------------------------------------");
        var tommy = new TommyParser();
        var tommyResult = tommy.ParseTomlString(content, root, key);
        Console.WriteLine($"Key: {tommyResult}");

        Console.ReadKey();
    }
}
