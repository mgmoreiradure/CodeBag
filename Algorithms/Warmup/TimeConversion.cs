using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string timeConversion(string s) {
        // Complete this function
      string[] arr_temp = s.Split(':');
            string m = arr_temp[2].Substring(2);
            arr_temp[2]=arr_temp[2].Remove(2);
            string military = "";


            if (m.ToUpper() == "PM") {
                if (arr_temp[0]=="12")
                {
                    military = "12";
                }
                else
                {
                    military = (Convert.ToInt32(arr_temp[0]) + 12).ToString();
                }
                 
            }
            else
            {
                if (arr_temp[0] == "12")
                {
                    military = "00";
                }
                else
                {
                    military = arr_temp[0];
                }
            }
            military += ":" + arr_temp[1] + ":" + arr_temp[2];
            return military;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
