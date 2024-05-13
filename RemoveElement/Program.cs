int RemoveElement(int[] nums, int val)
{

    int qtdNumerosValidos = 0;

    for (int x = 0; x < nums.Length; x++)
    {

        if (nums[x] != val)
        {

            qtdNumerosValidos++;           
            continue;

        }

        bool matarProcessamento = true;

        for (int y = x + 1; y < nums.Length; y++)
        {

            if (nums[y] != val)
            {

                int aux = nums[y];

                nums[y] = nums[x];
                nums[x] = aux;

                matarProcessamento = false;

                qtdNumerosValidos++;

                break;

            }

        }

        if (matarProcessamento)
        {
            break;
        }

    }

    return qtdNumerosValidos;

}

var inputs = new List<int[]>()
{
    new int[]{3,2,2,3},
    new int[]{ 0, 1, 2, 2, 3, 0, 4, 2 }
};

foreach (var input in inputs)
{
    Console.WriteLine(RemoveElement(input, 3));
}