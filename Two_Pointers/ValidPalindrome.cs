public class Solution {
    public bool IsPalindrome(string s) {
        if(s == " ") return true;
        string[] separators = { ",", ".", "!", "?", ";", ":", " ", "@", "#", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "|", "]", "}", "[", "{", "/", ">", "<", "`", "~", "\\", "\"", "\'"};
        string[] splitString = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        s = string.Concat(splitString);
        s = s.ToLower();
        char[] r = s.ToCharArray();
        Array.Reverse(r);
        string reversed = new string(r);
        if(s == reversed){
            return true;
        }
        return false;
    }
}
