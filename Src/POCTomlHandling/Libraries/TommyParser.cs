using Tommy;

namespace POCTomlHandling.Libraries;

public class TommyParser : IParser
{
    public object ParseTomlString(string content, string root, string key)
    {
        using var reader = new StringReader(content);
        var table = TOML.Parse(reader);
        return table[root][key].AsString.Value;
    }
}
