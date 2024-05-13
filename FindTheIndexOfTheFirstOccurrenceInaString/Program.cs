int StrStr(string haystack, string needle)
{

    if (
        string.IsNullOrEmpty(haystack)
        || string.IsNullOrEmpty(needle)
        || needle.Length > haystack.Length
    )
    {
        return -1;
    }

    for (int indiceHaystack = 0; indiceHaystack < haystack.Length; indiceHaystack++)
    {

        int quantidadeLetrasRestantes = haystack.Length - indiceHaystack;
        if (quantidadeLetrasRestantes < needle.Length)
        {
            return -1;
        }

        if (haystack[indiceHaystack] != needle[0])
        {
            continue;
        }

        bool palavraEncontrada = true;
        for (int indiceNeedle = 1; indiceNeedle < needle.Length; indiceNeedle++)
        {

            if (needle[indiceNeedle] != haystack[indiceHaystack + indiceNeedle])
            {
                palavraEncontrada = false;
                break;
            }

        }

        if (palavraEncontrada)
        {
            return indiceHaystack;
        }

    }

    return -1;

}

Dictionary<string, string> values = new Dictionary<string, string>()
{
    { "bbaa", "aab" }
};

foreach (var value in values)
{
    Console.WriteLine(StrStr(value.Key, value.Value));
}