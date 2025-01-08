namespace Tumakov9
{
    internal interface ICipher
    {
        string Encode(string s);
        string Decode(string s);
    }
}
