using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        int min = arr[0];
            int max = arr[1];
            Int64 total = 0;            
            for (int i = 0; i < arr.Length; i++)
            {
                total+= Convert.ToInt64( arr[i]);
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            Console.WriteLine((total - max)+ " " + (total - min) );
    }
}
