/*Original Solution: INNEFFICIENT*/

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        //edge case
        if(nums.Length < 1 || k < 1) return [];

        int start = 0, end = k;
        List<int> holder = new();
        List<int> output = new();

        while(start <= (nums.Length - k)){
            for(int i = start; i<end; i++){
                holder.Add(nums[i]);
            }
            Console.WriteLine("this is iteration: {0}", start);
            foreach(int i in holder){
                Console.WriteLine(i);
            }
            output.Add(holder.Max());
            start++;
            end++;
            holder.Clear();
        }

        return output.ToArray();
    }
}

/*OPTIMAL*/
//More DP than sliding window solution
// public class Solution {
//     public int[] MaxSlidingWindow(int[] nums, int k) {
//         int n = nums.Length;
//         if (n * k == 0) return new int[0];
//         if (k == 1) return nums;

//         int[] leftMax = new int[n];
//         leftMax[0] = nums[0];
//         int[] rightMax = new int[n];
//         rightMax[n - 1] = nums[n - 1];
//         for (int i = 1; i < n; i++) {
//             leftMax[i] = (i % k == 0) ? nums[i] : Math.Max(leftMax[i - 1], nums[i]);

//             int j = n - i - 1;
//             rightMax[j] = (j % k == k - 1) ? nums[j] : Math.Max(rightMax[j + 1], nums[j]);
//         }

//         int[] output = new int[n - k + 1];
//         for (int i = 0; i < n - k + 1; i++)
//             output[i] = Math.Max(leftMax[i + k - 1], rightMax[i]);

//         return output;
//     }
// }

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums.Length == 0 || k == 0) {
        return new int[0];
        }
    
        int n = nums.Length;
        int[] result = new int[n - k + 1];
        int ri = 0; // Index for the result array
        
        // Create a Deque (Double-ended queue) to store indices of elements
        // The front of the Deque will always have the index of the maximum element in the current window
        LinkedList<int> deque = new LinkedList<int>();
        
        for (int i = 0; i < n; i++) {
            // Remove indices of elements that are out of the current window from the front of the Deque
            while (deque.Count > 0 && deque.First.Value < i - k + 1) {
                deque.RemoveFirst();
            }
            
            // Remove indices of elements that are smaller than the current element from the back of the Deque
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i]) {
                deque.RemoveLast();
            }
            
            // Add the current index to the back of the Deque
            deque.AddLast(i);
            
            // If the window has moved to the point where it contains 'k' elements, start storing the maximum for each window
            if (i >= k - 1) {
                result[ri++] = nums[deque.First.Value];
            }
        }
        
        return result;
    }
}
