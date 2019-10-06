/*
Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21
Note:
Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.

*/
/*
Runtime: 44 ms, faster than 59.85% of C# online submissions for Reverse Integer.
Memory Usage: 13.8 MB, less than 8.33% of C# online submissions for Reverse Integer.
*/

public class Solution
    {
        public int Reverse(int x)
        {
            long reverse = 0;

            while (x != 0)
            {
                reverse = reverse * 10 + x % 10;
                x = x / 10;
            }

            if (reverse > int.MaxValue || reverse < int.MinValue)
            {
                return 0;
            }

            return (int)reverse;
        }
    }
