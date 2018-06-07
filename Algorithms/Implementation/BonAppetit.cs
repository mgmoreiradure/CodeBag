using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
class Solution {
    static void Main(string[] args) {
      int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));
            
            int anna = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            int aCobrar =0;
            
            foreach (var item in b)
            {
                total += item;    
            }
            total-= b[ a[1]];
            aCobrar = total / 2;
            if (aCobrar == anna)
            {
                Console.WriteLine("Bon Appetit");
            }
            else {
                Console.WriteLine("{0}", anna - aCobrar);
            }
    }
}
}
