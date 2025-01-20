using ClimbingStairs;


var testes = new int[]
{
   3
};

for (int x = 0; x < testes.Length; x++)
{

    Console.WriteLine();

    var resultado = ClimberManager.ClimbStairs(testes[x]);
    Console.WriteLine($"{testes[x]} = {resultado}");

    Console.WriteLine();

}