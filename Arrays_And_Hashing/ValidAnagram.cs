public class ValidAnagram {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }else{
            char[] sarr = s.ToArray();
            char[] tarr = t.ToArray();
            Array.Sort(sarr);
            Array.Sort(tarr);
            s = new string(sarr);
            t = new string(tarr);
            return s.Equals(t);
        }
    }
}
