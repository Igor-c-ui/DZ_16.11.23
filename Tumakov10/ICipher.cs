namespace Tumakov10
{
    internal interface ICipher
    {
        string encode(string text);
        string decode(string text);
    }
}