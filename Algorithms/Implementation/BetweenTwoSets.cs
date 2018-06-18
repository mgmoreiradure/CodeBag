using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int getTotalX(int[] a, int[] b, int aLength,int bLength) {
        // Complete this function
       
            int init = a[ aLength - 1];
            int end = b[0];
            int count = 0;
            // Complete this function
            for (int i = init; i <= end; i++)
            {
                bool flag = true;
                foreach (int item in a)
                {
                    if (i % item !=0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    foreach (var item2 in b)
                    {
                        if (item2 % i != 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                if (flag)
                    count++;
                
                flag=false;
            }
            return count;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp,Int32.Parse);
        int total = getTotalX(a, b,n,m);
        Console.WriteLine(total);
    }
}
