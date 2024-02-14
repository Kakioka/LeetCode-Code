public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length < 2) return s.Length;

        var start = 0; // Left boundary of the window.
        var maxLength = 0; // To keep track of the maximum length found.

        var lastIndexMap = new Dictionary<char, int>();

        for (var end = 0; end < s.Length; end++)
        {
            var currentChar = s[end];

            // adjust the start pointer to exclude the previous occurrence of the character.
            if (lastIndexMap.ContainsKey(currentChar))
            {
                start = Math.Max(start, lastIndexMap[currentChar] + 1);
            }

            lastIndexMap[currentChar] = end;

            maxLength = Math.Max(maxLength, end - start + 1);
        }
        return maxLength;
    }
}
