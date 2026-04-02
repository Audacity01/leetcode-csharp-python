using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();
        foreach (var s in strs)
        {
            var key = new string(s.OrderBy(c => c).ToArray());
            if (!groups.ContainsKey(key))
                groups[key] = new List<string>();
            groups[key].Add(s);
        }
        return groups.Values.ToList<IList<string>>();
    }
}
