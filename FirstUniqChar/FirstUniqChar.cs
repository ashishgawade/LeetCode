public class FirstUniqChar
{

    public int FirstUniqCharMethod(string s)
    {
        if (string.IsNullOrEmpty(s))
            return -1;

        int[] charCounts = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            charCounts[s[i] - 'a']++;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (charCounts[s[i] - 'a'] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}