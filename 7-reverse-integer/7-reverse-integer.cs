public class Solution
{
    public int Reverse(int x)
    {
        if (x == 0 || x > int.MaxValue)
            return 0;   

        string s = x.ToString();
        string result = string.Empty;

        if (s[0] == '-')
            result += '-';

        if (s[s.Length - 1] != '0')
            result += s[s.Length - 1];

        for (int i = s.Length - 2; i >= 0; i--)
            if (s[i] != '-')
                result += s[i];

        var endResult = long.Parse(result);

        if (endResult > int.MaxValue || endResult < int.MinValue)
            return 0;

        return int.Parse(endResult.ToString());
    }
}