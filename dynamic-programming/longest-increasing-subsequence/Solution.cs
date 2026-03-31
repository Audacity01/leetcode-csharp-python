using System;

public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        var dp = new int[nums.Length];
        Array.Fill(dp, 1);
        int maxLen = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[j] < nums[i])
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
            }
            maxLen = Math.Max(maxLen, dp[i]);
        }
        return maxLen;
    }
}
