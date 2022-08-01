public class Solution {
    public int SingleNumber(int[] nums) {
        List<int> result = new List<int>();
        
        foreach(var number in nums)
        {
            if (result.Contains(number))
                result.Remove(number);
            else
                result.Add(number);
        }
        
        return result[0];
    }
}