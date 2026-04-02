using System;
using System.Collections.Generic;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var seen = new Dictionary<char, int>();
        int maxLen = 0, start = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (seen.ContainsKey(s[i]) && seen[s[i]] >= start)
                start = seen[s[i]] + 1;
            seen[s[i]] = i;
            maxLen = Math.Max(maxLen, i - start + 1);
        }
        return maxLen;
    }
}
