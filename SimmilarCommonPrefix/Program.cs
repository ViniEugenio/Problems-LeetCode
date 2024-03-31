// https://leetcode.com/problems/longest-common-prefix/description/

string LongestCommonPrefix(string[] strs)
{

    if (strs.Length == 0)
    {
        return string.Empty;
    }

    if (strs.Length == 1)
    {
        return strs[0];
    }

    string prefix = "";

    for (var x = 0; x < strs[0].Length; x++)
    {

        string auxiliar = "";

        for (var y = 0; y < strs.Length; y++)
        {

            if (x > strs[y].Length - 1)
            {
                auxiliar = "";
                break;
            }

            var caracter = strs[y][x].ToString();

            if (auxiliar == "")
            {

                auxiliar = caracter;
                continue;

            }

            else if (auxiliar != caracter)
            {
                auxiliar = string.Empty;
                break;
            }

        }

        if (auxiliar == string.Empty)
        {
            break;
        }

        prefix += auxiliar;

    }

    return prefix;

}

var strs = new string[] { "flower", "flow", "flight" };
Console.WriteLine(LongestCommonPrefix(strs));