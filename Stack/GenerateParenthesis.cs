//credit to aakashraj416
/*
I had no idea where to start but this is just genius. 
  */
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> result = new List<string>();
        GenerateValidParenthesis(n, n, "", result);
        return result;
    }
    public void GenerateValidParenthesis(int closed, int open, string str, IList<string> result){
        if(closed == 0 && open == 0){
            result.Add(str);
            return;
        }
        if (open > 0){
            GenerateValidParenthesis(closed, open-1, str+'(',result);
        }

        if(closed> opencount){
            GenerateValidParenthesis(closed-1, open, str+')',result);
        }
    }
}
