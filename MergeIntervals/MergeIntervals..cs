public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals == null || intervals.Length <= 1) return intervals;

        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));
        List<int[]> mergedIntervals = new List<int[]>();
        int[] currentInterval = intervals[0];
        mergedIntervals.Add(currentInterval);

        for (int i = 1; i < intervals.Length; i++)
        {
            int[] nextInterval = intervals[i];

            if (nextInterval[0] <= currentInterval[1])
            {
                currentInterval[1] = Math.Max(currentInterval[1], nextInterval[1]);
            }
            else 
            {
                mergedIntervals.Add(nextInterval);
                currentInterval = nextInterval;
            }
        }
        return mergedIntervals.ToArray();
    }
}