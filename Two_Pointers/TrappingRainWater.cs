public class Solution {
    public int Trap(int[] height) {
        int left = 0, right = height.Length - 1;   
        int maxL = height[left], maxR = height[right];
        int result = 0;

        while(left < right){
            if (maxL <= maxR){
                ++left;
                result = ((maxL - height[left]) > 0) ? (result + maxL-height[left]) : result;
                if(height[left] > maxL){
                    maxL = height[left];
                }
            }else{
                --right;
                result = ((maxR - height[right]) > 0) ? (result + maxR-height[right]) : result;
                if(height[right] > maxR){
                    maxR = height[right];
                }
            }
        }
        return result;
    }
}
