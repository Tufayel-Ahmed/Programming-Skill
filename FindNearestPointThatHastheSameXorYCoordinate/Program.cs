using System;

namespace FindNearestPointThatHastheSameXorYCoordinate
{
    class Program
    {
        public static void Main(String[] args)
        {
            int x = 4, y = 3;
            //int[][] nums = new int[5] [2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };

            Solution solution = new Solution();
            //solution.NearestValidPoint(x, y, nums);
        }
    }

    public class Solution
    {
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            int position = -1;
            int minDistance = int.MaxValue;

            for (int i = 0; i < points.Length; i++)
            {
                if ((points[i][0] == x) || (points[i][1] == y))
                {
                    int distance = Math.Abs(points[i][0] - x) + Math.Abs(points[i][1] - y);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        position = i;
                    }
                }
            }
            return position;
        }
    }
}
