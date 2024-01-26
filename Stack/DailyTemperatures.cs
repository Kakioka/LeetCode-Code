public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var s = new Stack<int>();
        var result = new int[temperatures.Length];

        for(int i = temperatures.Length - 1; i >= 0; i--)
        {
            while(s.Count != 0 && temperatures[i] >= temperatures[s.Peek()]) {
                s.Pop();
            }

            if(s.Count == 0){
                result[i] = 0;
            }else{
                result[i] = s.Peek() - i;
            }
            s.Push(i);
        }

        return result;
    }
}
