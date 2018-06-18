using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        int positive = 0;
            int negative = 0;
            int zero = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] >0)
                {
                    positive++;
                }
                else if (arr[i]<0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }  
            }
           Console.WriteLine(String.Format("{0:0.000000}", Convert.ToDouble((double)positive / (double)n)));                         
           Console.WriteLine(String.Format("{0:0.000000}", Convert.ToDouble((double)negative / (double)n)));                         
           Console.WriteLine(String.Format("{0:0.000000}", Convert.ToDouble((double)zero / (double)n)));                         
    }
}
