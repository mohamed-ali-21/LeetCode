public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        List<int> result = new List<int>();
        
        for(int i = 0; i < nums.Length; i++)
            if (nums[i] == target)
                result.Add(i);
        
        if (result.Count() == 0)
            return new [] {-1, -1};
        
        return new [] {result[0], result[result.Count() - 1]};
    }
}