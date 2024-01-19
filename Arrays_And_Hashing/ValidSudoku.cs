public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        //checks each row
        for(int i = 0; i < 9; i++){
            if (ContainsDuplicate(board[i])){
                return false;
            }
        }

        //columns...
        for(int c = 0; c<9; c++){
            //storing column
            char[] temp = new char[9];
            for (int r = 0; r<9; r++){
                temp[r] = board[r][c];
            }
            if (ContainsDuplicate(temp)) return false;
        }
        
        //box...
        int rStart = 0,cStart = 0, rEnd = 3, cEnd = 3;
        while(rStart < 9 && cStart < 9){
            int count = 0;
            char[] box = new char[9];
            for (int row = rStart; row<rEnd; row++){
                for (int column = cStart; column<cEnd; column++){
                    box[count] = board[row][column];
                    count++;
                }
            }
            for (int i = 0; i<box.Length; i++){
                if (box[i] != '.')
                    if (Array.FindAll(box, el => el == box[i]).Length > 1) return false;
                
            }
            if (rEnd==9){
                cStart += 3;
                cEnd += 3;
                rStart = 0;
                rEnd = 3;
            }else if (cEnd > 9) break;
            else{
                rStart += 3;
                rEnd += 3;
            }
        }
        return true;
    }

       public bool ContainsDuplicate(char[] chars) {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach(char cha in chars){
            try{
                if (!cha.Equals('.')){
                    dict.Add(cha, 1);
                }
            }catch(ArgumentException){
                return true;
            }
        }
        return false;
    }
}
