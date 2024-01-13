public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //dictionary to hold values and their frequency
        Dictionary<int, int> dict = new Dictionary<int, int>();
        //list that will be returned with k most frequent values
        List<int> ansList = new List<int>();

        //add all nums to dict
        foreach(int num in nums){
            try{
                dict.Add(num, 1);
            }catch(ArgumentException){
                dict[num] += 1;
            }
        }

        //repeat k times
        for(int i = 0; i < k; i++){
            int currMaxValue = 0;
            int currMaxKey = 0;
            foreach(KeyValuePair<int, int> kvp in dict){
                if(currMaxValue != 0){
                    if (kvp.Value > currMaxValue){
                        currMaxValue = kvp.Value;
                        currMaxKey = kvp.Key;
                    }
                }else{
                    currMaxValue = kvp.Value;
                    currMaxKey = kvp.Key;
                }
            }
            ansList.Add(currMaxKey);
            dict.Remove(currMaxKey);
        }
        //return the ansList as an array
        return ansList.ToArray();

    }
}
