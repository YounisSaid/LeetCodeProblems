// Problem: Binary Search
// Link: https://leetcode.com/problems/binary-search/
// Difficulty: Easy
// Topic: Binary Search
// Language: C#

/*
Explanation:
- Standard binary search on a sorted array.
- Time: O(log n), Space: O(1)
*/
public class Solution {
    public int Search(int[] nums, int target) {
        int left =0;
        int right = (nums.Count()) -1;
        while(left<=right)
        {
            int mid = (left + right ) /2;
            if(nums[mid]<target) left = mid +1;
            else if(nums[mid]>target) right = mid -1;
            else return mid ;
        }
        return -1;
        
    }
}
