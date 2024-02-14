/*
Pretty sure I finally understand the sliding window thing. But this time it was innefeciency that did me in
my code:
public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        //edge cases
        if(s1.Length > s2.Length) return false;
        if(s1.Length == 1) return s2.Contains(s1);

        //length of s1
        int len = s1.Length;
        //pointers for window
        int start = 0;
        //hashset of permutations
        HashSet<string> permutations = GeneratePermutations(s1);

        while((s2.Length - start) >= len){
            Console.WriteLine(s2.Substring(start, len));
            if(permutations.Contains(s2.Substring(start, len))) return true;
            start++;
        }
        return false;
    }

    public bool NextPermutation(Span<char> input){
        int i = input.Length - 2;
        while (i >= 0 && input[i] >= input[i + 1])
        {
            i--;
        }
        if (i < 0)
            return false;

        int j = input.Length - 1;
        while (input[j] <= input[i])
        {
            j--;
        }
        (input[i], input[j]) = (input[j], input[i]);

        Reverse(input, i + 1);

        return true;
    }

    private void Reverse(Span<char> input, int start){
        int i = start;
        int j = input.Length - 1;
        while (i < j)
        {
            (input[i], input[j]) = (input[j], input[i]);
            i++;
            j--;
        }              
    }

    public HashSet<string> GeneratePermutations(string input){
        var array = input.ToCharArray().OrderBy(c => c).ToArray();
        Span<char> spanInput = array.AsSpan();

        var result = new HashSet<string>() { new string(spanInput) };
        while (NextPermutation(spanInput))
            result.Add(new string(spanInput));

        return result;
    }
}
*/

//Best
public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        if(s1.Length > s2.Length)
        {
            return false;
        }
        
        int[] cnt1 = new int[26];
        foreach(var c in s1)
        {  
            cnt1[c-'a']++;
        }
        
        int l=0,r=0;
        int[] cnt2 = new int[26];
        while(r < s2.Length)
        {
            cnt2[s2[r] - 'a']++;
            
            if(cnt2[s2[r] - 'a'] > cnt1[s2[r] - 'a'])
            {
                while(l<=r && cnt2[s2[r] - 'a'] > cnt1[s2[r] - 'a'])
                {   
                    cnt2[s2[l] - 'a']--;
                    l++;
                }
            }

            if(r - l + 1 == s1.Length)
            {
                return true;
            }
            
            r++;
        }
        
        return false;
    }
}
