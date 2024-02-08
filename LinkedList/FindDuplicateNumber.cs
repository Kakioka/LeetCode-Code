/*
nah but genuinely at this point, I'm kinda thinking Floyd was a genius. Once again utilizing Floyd's cycle finding alg
instead of pointers, we use the indexes
slow becomes nums[slow] acting as the pointer itself, fast becomes a double pointer initially being the index nums[fast]
then once a possibility is found, gotta double check by resetting slow then doing it again
*/

public class Solution {
    public int FindDuplicate(int[] nums) {
        
        int fast = nums[0];
        int slow = nums[0];

        do{
            slow = nums[slow];
            fast = nums[nums[fast]];
        }while(slow != fast);

        slow = nums[0];
        while(slow != fast){
            slow = nums[slow];
            fast = nums[fast];
        }

        return slow;
    }
}
