
/*
My solution works passes the testcases when rubn but fails the  EXACT SAME testcases when submitted. Because of course it does. 
*/
public class MYSolution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        List<int> numsList = nums.ToList();
        int count = 1;
        int bigCount = 1;
        int currMax = nums.Max();
        numsList.Remove(currMax);
        
        while(numsList.Count > 0){
            if(numsList.Max() == (currMax-1)){
                count++;
                currMax = numsList.Max();
                numsList.Remove(currMax);
                if (count > bigCount){
                    bigCount = count;
                }
            }else{
                if (numsList.Max() != currMax){
                    count = 1;
                }
                currMax = numsList.Max();
                numsList.Remove(currMax);
            }
        }
        return bigCount;
    }
}

/*
  Solution I liked the best using hashsets to ensure unique number then iterating through set however, I think it's O(n^2) time
*/
public class HashSolution 
{
    public int LongestConsecutive(int[] nums) 
    {
        if(nums.Length < 1) { return 0; }

        HashSet<int> set = new();
        int maxConsecutiveSequence = 1;

        foreach(var num in nums) { set.Add(num); }

        foreach(var num in set)
        {
            int currConsecutiveSequence = 1;
            int currNum = num;

            if(!set.Contains(currNum-1))
            {
                while(set.Contains(currNum+1))
                {
                    currConsecutiveSequence++;
                    currNum++;
                }
            }
            maxConsecutiveSequence = Math.Max(currConsecutiveSequence, maxConsecutiveSequence);
        }
        return maxConsecutiveSequence;
    }
}
/*
Solution that I used, my inital thought was the same but I dismissed it because I thought that sorting was too slow and most definitely not O(n) time. Also I didn't want to code either Count, Radix, or Bucket sort myself
*/
public class SortSolution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        Array.Sort(nums);
        int count = 0;
        int answer = 0;
        for (int i = 0; i<nums.Count(); i++){
            if (i > 0){
                if(nums[i] == nums[i-1] + 1) count++;
                else if (nums[i] == nums[i-1]) continue;
                else count = 0;
            }
            

            if(count + 1 > answer) answer = count+1;
        }

        return answer;

    }
}

