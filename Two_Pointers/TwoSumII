public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        HashSet<int> hs = new HashSet<int>(numbers);

        int idx1 = 0, idx2 = 0;

        foreach(int num in hs){
            if(hs.Contains(target-num)){
                idx2 = num;
                idx1 = target-num;
            }
        }
        int[] answer = {(FindIndex(numbers, idx1) + 1), (FindIndex(numbers, idx2) + 1)};

        //in event of the same number twice being the answer
        if(answer[0] == answer[1]){
            for(int i = 0; i<numbers.Length; i++){
                if(numbers[i] == numbers[answer[0]-1] && i != answer[0]-1){
                    if(i < answer[1]-1){
                        answer[0] = i+1;
                        return answer;
                    }else{
                        answer[1] = i+1;
                        return answer;
                    }
                }
            }
        }
        
        return answer;
    }

    public int FindIndex(int[] sortedData, int item)
    {
        var leftIndex = 0;
        var rightIndex = sortedData.Length - 1;

        while (leftIndex <= rightIndex)
        {
            var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

            if (item.CompareTo(sortedData[middleIndex]) > 0)
            {
                leftIndex = middleIndex + 1;
                continue;
            }

            if (item.CompareTo(sortedData[middleIndex]) < 0)
            {
                rightIndex = middleIndex - 1;
                continue;
            }

            return middleIndex;
        }

        return -1;
    }
}
