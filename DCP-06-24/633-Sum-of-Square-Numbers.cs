public class Solution {
    public bool JudgeSquareSum(int c) {
        
        int sqrt(int x) 
        {
            return (int)Math.Sqrt(x);
        }

        long left = 0;
        long right = sqrt(c);

        while (left <= right) 
        {
            long sumOfSquares = left * left + right * right;

            if (sumOfSquares == c) 
            {
                return true;
            } 
            else if (sumOfSquares < c) 
            {
                left++;
            } 
            else 
            {
                right--;
            }
        }
        return false;
    }
}