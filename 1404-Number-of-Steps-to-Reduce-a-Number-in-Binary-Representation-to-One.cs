public class Solution {
    public int NumSteps(string s) {
       //var numRepresentation = Convert.ToInt32(s, 2);
        var numRepresentation = ConvertBinaryStringToBigInteger(s);
        var counter = 0;

        while (numRepresentation > 1) 
        {
            if (numRepresentation % 2 == 0) 
            {
                numRepresentation = numRepresentation / 2;
            } else 
            {
                numRepresentation = numRepresentation + 1;
            }
            counter++;
        }
        return counter;
    }
    private BigInteger ConvertBinaryStringToBigInteger(string binary) 
    {
        BigInteger result = 0;
        foreach (char c in binary) 
        {
            result = result * 2 + (c - '0');
        }
        return result;
    }
}