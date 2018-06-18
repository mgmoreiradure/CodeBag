using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int migratoryBirds(int n, int[] ar) {
        // Complete this function
 int [] type =new int[5] {0,0,0,0,0};
            int idType = 0;
            // Complete this function
            for (int i = 0; i < n; i++)
            {
                int index=ar[i] - 1;
                type[index]++;             
            }
            
            for (int i = 0; i < 5; i++)
            {
                if (type[i]> type[idType])
                {
                    idType = i;
                }    
            }
            return idType +1;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
    }
}
