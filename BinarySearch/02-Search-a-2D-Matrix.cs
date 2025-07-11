// 74. Search a 2D Matrix
// Medium
// Topics : Binary search
// You are given an m x n integer matrix matrix with the following two properties:

// Each row is sorted in non-decreasing order.
// The first integer of each row is greater than the last integer of the previous row.
// Given an integer target, return true if target is in matrix or false otherwise.
// You must write a solution in O(log(m * n)) time complexity.

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int Left =0;
     int Right = matrix.Count() * matrix[0].Length - 1;

        while(Right>=Left)
        {
            int mid = (Right + Left)/2;
            int Val = matrix[mid / matrix[0].Length][mid % matrix[0].Length];
            if(Val == target) return true;
            else if(Val < target ) Left = mid +1;
            else Right = mid -1;
        }
        return false;
        
    }
}
