using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = Console.ReadLine();
        }

        int Q = Convert.ToInt32(Console.ReadLine());
        string[] qr = new string[Q];
        for (int i = 0; i < Q; i++)
        {
            qr[i] = Console.ReadLine();
        }

        // soltuon

        for (int i = 0; i < Q; i++)
        {
            int cnt = Array.FindAll(arr, s => s.Equals(qr[i])).Count();
            Console.WriteLine(cnt);
        }
        Console.ReadKey();
    }
}
