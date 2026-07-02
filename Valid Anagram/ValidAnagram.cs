public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] arrayCount = new int[26];

        for (int i=0; i < s.Length; i++)
        {
            arrayCount[s[i] - 'a']++;
            arrayCount[t[i] - 'a']--;
        }

        for (int i=0; i< 26; i++)
        {
            if (arrayCount[i] !=0)
            return false;
        }
        return true;
        
    }
}