using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int divisibleSumPairs(int n, int k, int[] ar) {
        // Complete this function
        int contador = 0;
            for (int i = 0; i < n; i++)
            {
                for (int b = i+1; b < n; b++)
                {
                    if ((ar[i] + ar[b]) % k ==0)
                    {
                        contador++;
                    }
                }
            }
            return contador;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = divisibleSumPairs(n, k, ar);
        Console.WriteLine(result);
    }
}
