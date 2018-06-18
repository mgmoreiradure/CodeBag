using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] solve(int[] grades){
        // Complete this function
        for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 38)
                {
                    int value = grades[i];
                    int rest = value % 10;
                    int next = 0;
                    if (rest >=5)
                    {
                        next = 10 - rest;
                    }
                    else
                    {
                        next = 5 - rest;
                    }

                    if (next <3)
                    {
                        grades[i] = value + next;
                    }
                }
            }
            return grades;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for(int grades_i = 0; grades_i < n; grades_i++){
           grades[grades_i] = Convert.ToInt32(Console.ReadLine());   
        }
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
        

    }
}
