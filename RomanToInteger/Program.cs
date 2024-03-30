// https://leetcode.com/problems/roman-to-integer/

int RomanToInt(string s)
{

    var dicionarioRomano = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    int contador = 0;

    for (var x = 0; x < s.Length; x++)
    {

        int valorAtual = dicionarioRomano[s[x]];

        if (x == s.Length - 1)
        {

            contador += valorAtual;
            continue;

        }

        int valorFrente = dicionarioRomano[s[x + 1]];

        if (valorAtual < valorFrente)
        {

            contador += valorFrente - valorAtual;
            x++;

            continue;

        }

        contador += valorAtual;

    }

    return contador;

}

var inputs = new string[]
{
    "MCMXCIV"
};

foreach (var input in inputs)
{
    Console.WriteLine($"O número romano '{input}' é igual a {(RomanToInt(input))}");
}