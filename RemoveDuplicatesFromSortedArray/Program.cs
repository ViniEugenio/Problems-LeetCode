
int RemoveDuplicates(int[] nums)
{

    if (nums.Length == 1)
    {
        return 1;
    }

    int qtd = 0;

    for (var x = 0; x < nums.Length; x++)
    {

        qtd++;

        if (x == nums.Length - 1)
        {
            break;
        }

        if (nums[x] < nums[x + 1])
        {
            continue;
        }

        else
        {
            nums[x + 1] = nums[x];
        }

        bool matarProcessamento = true;

        for (var y = x + 2; y < nums.Length; y++)
        {

            if (nums[y] > nums[x + 1])
            {

                matarProcessamento = false;
                nums[x + 1] = nums[y];

                break;

            }

        }

        if (matarProcessamento)
        {
            break;
        }

    }

    string numsFimProcessamento = "[";

    foreach (var x in nums)
    {
        numsFimProcessamento += x + ",";
    }

    numsFimProcessamento += "]";

    Console.WriteLine(numsFimProcessamento);
    return qtd;

}

var cases = new List<int[]>
{
    new int[]{1,2},
    new int[]{ 1,2,2 },
    new int[]{0,0,1,1,1,2,2,3,3,4},
    new int[]{1,1,1},
    new int[]{1}
};

foreach (var x in cases)
{
    Console.WriteLine(RemoveDuplicates(x));
}

