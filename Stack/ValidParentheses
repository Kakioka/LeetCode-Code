public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new ();

        Dictionary<char, char> dict = new(){
            {'(', ')'}, 
            {'{', '}'}, 
            {'[', ']'}
        };

        for (int i = 0; i < s.Length; i++){
            if (dict.Keys.Contains(s[i])) stack.Push(s[i]);
            else if (stack.Count > 0 && s[i] == dict[stack.Peek()]) stack.Pop();
            else return false;
        }
        return stack.Count == 0;
    }
}
