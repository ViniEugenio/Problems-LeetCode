using System.Numerics;

int[] PlusOne(int[] digits)
{

    string valorFormatado = "";
    int resto = 1;

    for (var x = digits.Length - 1; x >= 0; x--)
    {

        int result = digits[x] + resto;

        resto = result > 9 ? 1 : 0;

        if (resto == 1 && x > 0)
        {
            result = 0;
        }

        valorFormatado = $"{result}{valorFormatado ?? ""}";

    }

    int[] retorno = new int[valorFormatado.Length];

    for (var x = 0; x < retorno.Length; x++)
    {
        retorno[x] = Convert.ToInt32(valorFormatado[x].ToString());
    }

    return retorno;

}

var inputs = new List<int[]>()
{
    new int [] { 9,9 },
};

foreach (var input in inputs)
{

    string resultado = string.Join(", ", PlusOne(input));
    Console.WriteLine(resultado);

}