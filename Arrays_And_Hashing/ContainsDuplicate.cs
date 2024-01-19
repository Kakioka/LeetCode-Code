
public class ContainsDuplicate {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach(int num in nums){
            try{
                dict.Add(num, 1);
            }catch(ArgumentException){
                return true;
            }
        }
        return false;
    }
}
