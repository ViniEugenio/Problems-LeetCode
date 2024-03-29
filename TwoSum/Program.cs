// https://leetcode.com/problems/two-sum/description

int[] TwoSum(int[] nums, int target)
{    

    for (var x = 0; x < nums.Length; x++)
    {

        for (var y = x + 1; y < nums.Length; y++)
        {

            if (nums[x] + nums[y] == target)
            {
                return [x, y];
            }

        }

    }

    return [0];

}

var input = new int[] { 2, 7, 11, 15 };
var target = 9;

Console.WriteLine(TwoSum(input, target));
