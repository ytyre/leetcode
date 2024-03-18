using System;

public class Solution {
    public int FindMinArrowShots(int[][] points) {
        int choice = 0;                
        Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));                
        for (int i = 0; i < points.Length; i++) {
            int x = points[i][0];
            int xx = points[i][1];         
            while (i + 1 < points.Length && xx >= points[i + 1][0]) {        
                i++;           
                xx = Math.Min(xx, points[i][1]);
            }       
            choice++;
        }    
        return choice;
    }
}
