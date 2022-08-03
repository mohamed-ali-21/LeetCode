public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
        {
            List<int> list = nums.ToList();
            list.Remove(nums[i]);
            
            if (list.Contains(nums[i]))
                return true;
        }
        
        return false;
    }
}