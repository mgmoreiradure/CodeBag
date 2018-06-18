using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        int d1 = 0;
            int d2 = n - 1;
            int sumD1=0;
            int SumD2=0;
            for (int i = 0; i < n; i++)
            {
                sumD1 += a[i][d1];
                SumD2 += a[i][d2];
                d1++;
                d2--;
            }
           int rest =Math.Abs(sumD1-SumD2);
            Console.WriteLine(rest);
    }
}
