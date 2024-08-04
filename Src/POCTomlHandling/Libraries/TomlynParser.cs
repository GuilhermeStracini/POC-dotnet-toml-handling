using Tomlyn;
using Tomlyn.Model;

namespace POCTomlHandling.Libraries;

public class TomlynParser : IParser
{
    public object ParseTomlString(string content, string root, string key)
    {
        var model = Toml.ToModel(content);
        return ((TomlTable)model[root]!)[key];
    }
}
