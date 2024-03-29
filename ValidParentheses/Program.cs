
var valoresTeste = new Dictionary<string, bool>
{
    {"(){}}{", false }
};

bool IsValid(string s)
{

    if (s.Length % 2 != 0 || new char[] { ')', ']', '}' }.Contains(s[0]))
    {
        return false;
    }

    var dicionarioCondicoesFechamento = new Dictionary<char, char>()
    {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' }
    };

    Stack<char> pilhaCaracteresAbertura = new Stack<char>();

    for (var x = 0; x < s.Length; x++)
    {

        var caracter = s[x];

        if (new char[] { '(', '[', '{' }.Contains(caracter))
        {

            pilhaCaracteresAbertura.Push(caracter);
            continue;

        }

        if (!pilhaCaracteresAbertura.Any())
        {
            return false;
        }

        var caracterTopoPilha = pilhaCaracteresAbertura.Peek();
        bool fechou = dicionarioCondicoesFechamento[caracterTopoPilha] == caracter;

        if (fechou)         
        {

            pilhaCaracteresAbertura.Pop();
            continue;

        }

        return false;

    }

    return !pilhaCaracteresAbertura.Any();

}

bool funcionou = true;

foreach (var teste in valoresTeste)
{

    bool resultado = IsValid(teste.Key);
    if (resultado != teste.Value)
    {

        funcionou = false;
        break;

    }

}

Console.WriteLine(funcionou ? "código funcionou" : "código não funcionou");
