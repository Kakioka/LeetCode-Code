public class ProductExceptSelfSolution {
    public int[] ProductExceptSelf(int[] nums) {
        //store to reduce calls to Length which takes time and resources
        int n = nums.Length;
        int[] answer = new int[n];

        //multiply numbers left 
        //keeps track of the 
        int leftProduct = 1;
        //iterates through the answer array setting the jth index to the current leftProduct
        for (int j = 0; j < n; j++){
            answer[j] = leftProduct;

            //multiplies the current leftProduct by the jth index of nums which is then used for the j+1th index of answer
            leftProduct *= nums[j];
        }

        //multiply numbers right
        int rightProduct = 1;
        //iterate backwards through answer
        for (int i = n - 1; i >= 0; i--){
            //multiplies the ith index of answer by the current rightProduct
            //because iterating backwards, completes the multiplication necessary for a correct answer.
            answer[i] *= rightProduct;

            //multiplies the current rightProduct by the ith index of nums
            rightProduct *= nums[i];
        }

        return answer;
        
    }
}
