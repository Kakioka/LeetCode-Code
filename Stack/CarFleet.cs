public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        //sorts based on position
        Array.Sort(position, speed);
        //stack of floats to account for division
        Stack<float> st = new();

        //iterate backwards through arrays
        for(int i = position.Length-1; i >= 0; i--){
            //calculate distance and time
            float dist = target - position[i];
            float time = dist/speed[i];
            //if the stack is empty push to it
            //or
            //if the current time is greater than the stacked time
            if(st.Count == 0 || time>st.Peek()){
                st.Push(time);
            }


        }
        //whatever is left in stack should be the number of fleets
        return st.Count;


    }
}
