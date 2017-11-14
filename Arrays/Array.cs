using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        string result = string.Empty;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            result += arr[i].ToString();
            if (i != 0)
            {
                result += " ";
            }
        }

        Console.WriteLine(result);
    }
}