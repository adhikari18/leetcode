/*
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
*/

/*
Runtime: 80 ms, faster than 98.07% of C# online submissions for Roman to Integer.
Memory Usage: 24.9 MB, less than 8.70% of C# online submissions for Roman to Integer.
*/

public class Solution
    {
        public int RomanToInt(string s)
        {
            var result = 0;

            for (var index = 0; index < s.Length; index++)
            {
                var character = s[index];
                if (index < s.Length - 1)
                {
                    var value = GetValue(character);
                    var value2 = GetValue(s[index + 1]);
                    if (value2 > value)
                    {
                        result += value2 - value;
                        index++;
                    }
                    else
                    {
                        result += value;
                    }
                }
                else
                {
                    result += GetValue(character);
                }
            }

            return result;
        }
        private int GetValue(char s)
        {
            switch (s)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
    }
