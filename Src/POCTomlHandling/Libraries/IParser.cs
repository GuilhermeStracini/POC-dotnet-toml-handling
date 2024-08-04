namespace POCTomlHandling.Libraries;

internal interface IParser
{
    object ParseTomlString(string content, string root, string key);
}
