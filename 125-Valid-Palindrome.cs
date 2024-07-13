public class Solution {
    public bool IsPalindrome(string s) {
        // Convert the string to lowercase and remove non-alphanumeric characters
        StringBuilder sb = new StringBuilder();
        foreach (char c in s.ToLower()) {
            if (char.IsLetterOrDigit(c)) {
                sb.Append(c);
            }
        }
        
        string normalizedString = sb.ToString();
        
        // Check if the normalized string is a palindrome
        int left = 0, right = normalizedString.Length - 1;
        while (left < right) {
            if (normalizedString[left] != normalizedString[right]) {
                return false;
            }
            left++;
            right--;
        }
        
        return true;

        /*var cleanString = new string(s.ToLower()
                                      .Where(char.IsLetterOrDigit)
                                      .ToArray());

        for (int i = 0; i < cleanString.Length / 2; i++)
            {
                if (cleanString[i] != cleanString[cleanString.Length - i - 1])
                {
                    return false;
                }
            }
            return true;*/
    }
}