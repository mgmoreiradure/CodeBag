using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int birthdayCakeCandles(int n, int[] ar) {
        // Complete this function
        int max = ar[0];
            int total = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i]== max)
                {
                    total++;
                }
                else if (ar[i]> max)
                {
                    total = 1;
                    max = ar[i];
                }
                                
            }
            return total;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}
