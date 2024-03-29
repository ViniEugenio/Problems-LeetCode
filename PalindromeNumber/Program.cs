// https://leetcode.com/problems/palindrome-number/description/

bool IsPalindrome(int x)
{

    if (x < 0)
    {
        return false;
    }

    var numeroConvertido = x.ToString();

    for (var y = x.ToString().Length - 1; y >= 0; y--)
    {

        if (numeroConvertido[y] != numeroConvertido[numeroConvertido.Length - 1 - y])
        {
            return false;
        }

    }

    return true;

}

var inputs = new int[]
{
    121,
    -121,
    222,
    234,
    111,
    10
};

foreach (var input in inputs)
{
    Console.WriteLine(IsPalindrome(input) ? $"O número {input} é um palindromo" : $"O número {input} não é um palindromo");
}

