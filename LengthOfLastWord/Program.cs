int LengthOfLastWord(string s)
{

    if (s.Length == 0)
    {
        return 0;
    }

    int quantidade = 0;

    for (int x = s.Length - 1; x >= 0; x--)
    {

        if (s[x] == ' ' && quantidade == 0)
        {
            continue;
        }

        if (s[x] == ' ' && quantidade > 0)
        {
            return quantidade;
        }

        quantidade++;

    }

    return quantidade;

}

var inputs = new string[]
{
    "Hello World",
    "   fly me   to   the moon  ",
    "luffy is still joyboy"
};

foreach (var input in inputs)
{
    Console.WriteLine(LengthOfLastWord(input));
}