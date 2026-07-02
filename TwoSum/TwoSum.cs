public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>();

        for (int i=0; i < nums.Length; i++)
        {
            var remainder = target - nums[i];

            if (map.ContainsKey(nums[i]))
            return new int[] {nums[i], map[remainder]};
            else
            map.Add(nums[i], i);
        }
        return new int[0];        
    }
}