public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if (strs.Length == 0) return new List<IList<string>>();

        int[] count = new int[26];
        Dictionary<string, List<string>> ansMap = new Dictionary<string, List<string>>();

        foreach (var s in strs)
        {
            Array.Clear(count,0,count.Length);

            foreach (char c in s.ToCharArray()) {
                count[c - 'a']++;
            }
            
            // Build the unique hash key for this character configuration
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < 26; i++) {
                sb.Append("#");
                sb.Append(count[i]);
            }
            
            string key = sb.ToString();
            
            if (!ansMap.ContainsKey(key)) {
                ansMap[key] = new List<string>();
            }
            
            ansMap[key].Add(s);
        }
        
        // Convert the dictionary values into a generic nested List format
        return new List<IList<string>>(ansMap.Values);
        }        
    }