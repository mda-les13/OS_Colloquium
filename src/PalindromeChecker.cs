public class PalindromeChecker
{
    public bool IsPalindrome(int number)
    {
        string strNumber = number.ToString();
        int length = strNumber.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (strNumber[i] != strNumber[length - i - 1])
                return false;
        }

        return true;
    }
}
