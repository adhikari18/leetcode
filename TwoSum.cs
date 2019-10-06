/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].

*/


/*
Runtime: 244 ms, faster than 98.55% of C# online submissions for Two Sum.
Memory Usage: 29.9 MB, less than 5.08% of C# online submissions for Two Sum.
*/

public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var hashSet = new HashSet<int>();
            var result = new int[2];
            for (var i = 0; i < nums.Length; ++i)
            {
                var temp = target - nums[i];
                if (hashSet.Contains(temp))
                {
                    return new[] { Array.IndexOf(nums, temp), i };
                }
                hashSet.Add(nums[i]);
            }
            return result;
        }
    }
