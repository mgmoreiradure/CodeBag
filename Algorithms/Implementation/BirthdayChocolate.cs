using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int solve(int n, int[] s, int d, int m){
         // Complete this function
            int contador = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                if (i + m <= n)
                {
                    
                    for (int b = i; b < i+ m; b++)
                    {
                        sum += s[b];
                    }
                }
                else if (n==1)
                {
                    for (int b = i; b < i+ m; b++)
                    {
                        sum += s[b];
                    }
                }
                else
                {
                    break;
                }
                if (sum == d)
                    contador++;
                
            }

            return contador;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        string[] tokens_d = Console.ReadLine().Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int result = solve(n, s, d, m);
        Console.WriteLine(result);
    }
}
