public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> nums = new Stack<int>();
        foreach(string s in tokens){
            if (Int32.TryParse(s, out int j)){
                nums.Push(j);
            }else{
                switch(s){
                    case "+":   int temp = nums.Pop() + nums.Pop();
                                nums.Push(temp);
                                break;
                    case "-":   int forSub = nums.Pop();
                                temp = nums.Pop() - forSub;
                                nums.Push(temp);
                                break;
                    case "*":   temp = nums.Pop() * nums.Pop();
                                nums.Push(temp);
                                break;
                    case "/":   int forDiv = nums.Pop();
                                temp = nums.Pop()/forDiv;
                                nums.Push(temp);
                                break;
                }
            }

        }
        if(nums.Count() > 0){
            return nums.Pop();
        }else{
            return 0;
        }
    }
}
