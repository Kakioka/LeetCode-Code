public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxSubLength = int.MinValue; //maximum length of substring w/ at most k replacements
        int maxFreq = 0; //max frequency of any char in current window
        Dictionary<char, int> map = new Dictionary<char, int>(); //Dictionary to track frequency of each char
        int j = -1, i = 0; //pointers for sliding window

        //iterate through string
        while(i < s.Length){
            //add current char to window
            if(!map.ContainsKey(s[i])) map[s[i]] = 0;

            map[s[i]]++;

            //update max frequency in current window
            maxFreq = Math.Max(maxFreq, map[s[i]]);

            //check if the number of replacements needed is more than k
            if((i-j) - maxFreq > k){
                //move left pointer right
                j++;
                //update frequency of char going out of window
                map[s[j]]--;
            }
            //update max length of substring
            maxSubLength = Math.Max(maxSubLength, i-j);

            //move right pointer to next char
            i++;
        }

        //return max length of substring
        return maxSubLength;
    }
}
