using System;

public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];

        int prev2 = 0, prev1 = 0;
        foreach (var num in nums)
        {
            int temp = prev1;
            prev1 = Math.Max(prev1, prev2 + num);
            prev2 = temp;
        }
        return prev1;
    }
}
