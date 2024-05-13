
int SearchPosition(int[] nums, int target)
{

    if (nums[nums.Length - 1] < target)
    {
        return nums.Length;
    }

    for (var x = 0; x < nums.Length; x++)
    {

        if (nums[x] >= target)
        {
            return x;
        }

    }

    return 0;

}

Dictionary<int[], int> inputs = new Dictionary<int[], int>()
{
    { new int[] {1,3,5,6}, 5 },
    { new int[] { 1, 3, 5, 6 } , 2 }
};

foreach (var input in inputs)
{
    Console.WriteLine(SearchPosition(input.Key, input.Value));
}