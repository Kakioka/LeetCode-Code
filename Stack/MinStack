public class MinStack {

    Stack<int> minTracker = null;
    Stack<int> stack = null;

    public MinStack() {
        stack = new Stack<int>();
        minTracker = new Stack<int>();
    }
    
    public void Push(int val) {
        if(minTracker.Count > 0){
            int minVal = minTracker.Peek();
            if(minVal >= val){
                minTracker.Push(val);
            }
        }else{
            minTracker.Push(val);
        }
        stack.Push(val);
    }
    
    public void Pop() {
        int val = 0;
        val = stack.Pop();
        if(minTracker.Count > 0 && val == minTracker.Peek()){
            minTracker.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minTracker.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
