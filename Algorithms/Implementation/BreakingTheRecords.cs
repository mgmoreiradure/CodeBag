using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] getRecord(int[] s, int n)
        {
            int[] i = new int[2];
            int highCount = 0;
            int lowCount = 0;
            int high = s[0];
            int low = s[0];
            // Complete this function
            for (int item = 0; item < n; item++)
            {
                if (s[item] > high)
                {
                    highCount++;
                    high = s[item];
                }
                if (s[item] < low)
                {
                    lowCount++;
                    low = s[item];
                }
            }
            
            i[0] = highCount;
            i[1] = lowCount;
            return i;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        int[] result = getRecord(s,n);
        Console.WriteLine(String.Join(" ", result));
    }
}
