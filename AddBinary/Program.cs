string AddBinary(string a, string b)
{

    if (a == "" || b == "")
    {
        return a == "" ? b : a;
    }

    int rangeMaximo = a.Length > b.Length ? a.Length : b.Length;


    for (int x = rangeMaximo; x >= 0; x--)
    {



    }

}

Dictionary<string, string> inputs = new Dictionary<string, string>()
{
    { "11", "1" },
    { "1010", "1011" }
};

foreach (var input in inputs)
{
    Console.WriteLine(AddBinary(input.Key, input.Value));
}