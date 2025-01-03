using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Day_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use a List instead of an array for dynamic resizing
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inputs.txt");
            //Console.WriteLine(filePath);
            string[] lines = File.ReadAllLines(@"C:\Users\ivoxm\OneDrive\Ambiente de Trabalho\AOC++\Day_1\Day_1\Day_1\inputs.txt.txt");

            foreach (String s in lines)
            {
                string[] sn = s.Split("  ", StringSplitOptions.RemoveEmptyEntries);
                list1.Add(int.Parse(sn[0]));
                list2.Add(int.Parse(sn[1]));
            }

            //// Convert Lists to arrays
            int[] arr1 = list1.ToArray();
            int[] arr2 = list2.ToArray();


            Array.Sort(arr1);
            Array.Sort(arr2);



            int sum =0;
            for(int i = 0; i < arr1.Length; i++)
            {

                sum += (arr2.Contains(arr1[i]) ? arr1[i] * (arr2.Count(x => x == arr1[i])) : 0);
            }
            Console.WriteLine(sum);
        }
    }
}
