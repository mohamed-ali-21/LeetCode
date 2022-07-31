public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        List<int> AllElements = nums1.ToList();
        AllElements.AddRange(nums2.ToList());
        AllElements = AllElements.OrderBy(x => x).ToList();   

        if (AllElements.Count() % 2 == 0)
        {
            int val1 = AllElements[(AllElements.Count / 2) - 1];
            int val2 = AllElements[(AllElements.Count / 2)];

            return Math.Round((((double)val1 + val2) / 2), 5);
        }

        return Math.Round(double.Parse(AllElements[int.Parse((AllElements.Count() / 2).ToString())].ToString()), 5);
    }
}