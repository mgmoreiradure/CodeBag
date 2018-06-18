using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
            {
                string text = "";
                for (int a = 0; a < n; a++)
                {
                    
                    if (n-1-i <= a)
                    {
                        text += "#";
                    }
                    else
                    {
                        text += " ";
                    }
                   

                }
                 Console.WriteLine(text);
            }
    }
}
