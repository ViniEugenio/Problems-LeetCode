﻿namespace ClimbingStairs
{
    public static class ClimberManager
    {

        private static Dictionary<int, int> resultadosAnteriores = new Dictionary<int, int>();

        public static int ClimbStairs(int n)
        {
            if (n <= 1)
            {
                resultadosAnteriores.Add(n - 1, 1);
                return 1;
            }

            int primeiroValor = ClimbStairs(n - 1);
            resultadosAnteriores.Add(n - 1, primeiroValor);

            return primeiroValor + resultadosAnteriores[n - 2];
        }

    }
}
