public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        
        return ConcatenateArray(word1) == ConcatenateArray(word2);

        // var str1 = string.Join("", word1);
        // var str2 = string.Join("", word2);

        // return str1 == str2;
    }
    private string ConcatenateArray(string[] arr)
    {
        StringBuilder sb = new StringBuilder();
        foreach (string str in arr)
        {
            sb.Append(str);
        }
        return sb.ToString();
    }
}