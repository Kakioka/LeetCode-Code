public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int max = 0;
        Stack<int> stack = new();

        for (int i = 0; i <= heights.Length; i++) {
            int height = i == heights.Length ? 0 : heights[i];
            while (stack.Count > 0 && heights[stack.Peek()] > height) {
                int calcHeight = heights[stack.Pop()];
                int leftWall = stack.Count == 0 ? -1 : stack.Peek();
                max = Math.Max(max, calcHeight * (i - leftWall - 1));
            }

            stack.Push(i);
        }

        return max;
    }
}
