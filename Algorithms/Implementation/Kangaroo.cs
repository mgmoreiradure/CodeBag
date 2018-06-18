using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static bool Colection(int x1,int x2,int v1, int v2)
        {
            bool flag = true;
            bool r = false;
            
            do
            {
                if (x1 == x2)
                {
                    flag = false;
                    r = true;
                }else if (x2 > x1)
                {
                    flag = false;
                }
                x1 += v1;
                x2 += v2;
            } while (flag);
            return r;
        }
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            bool c = false;
            if (x1>=x2)
            {
                if (v1 < v2)
                {
                    c = Colection(x1, x2, v1, v2);
                }

            }
            else
            {
                if (v1 > v2)
                {
                    c = Colection(x2, x1, v2, v1);
                }
            }

            return (c) ? "YES" : "NO";


        }

    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        string result = kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }
}
