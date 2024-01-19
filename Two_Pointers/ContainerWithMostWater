public class Solution {
    public int MaxArea(int[] height) {
        int left = 0, right = height.Length-1, currentHigh = 0, answer = 0;

        while(left != right){

            if(height[left] < height[right]){
                if(currentHigh < Area(height[left], (right-left))) currentHigh = Area(height[left], (right-left));
                ++left;
            }else{
                if(currentHigh < Area(height[right], (right-left))) currentHigh = Area(height[right], (right-left));
                --right;
            }
        }

        return currentHigh;
    }

    public int Area(int h, int w){
        return h*w;
    }
}
