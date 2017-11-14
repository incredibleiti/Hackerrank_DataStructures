using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        int[][] arr = new int[6][];
        int R = 6;
        int C = 0;
        for (int arr_i = 0; arr_i < 6; arr_i++)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            C = arr.Length;
        }

        int Summax = 0;
        int max = 0;
        for (int i = 0; i < R-2; i++)
        {
            for (int j = 0; j  < C-2; j ++)
            {
                max = (arr[i][j] + arr[i][j + 1] + arr[i][j + 2])
                    + (arr[i + 1][j + 1])
                    + (arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);

                if (max > Summax)
                {
                    Summax = max;
                }
            }
        }

        Console.WriteLine(Summax);
        Console.ReadKey();
    }
}

