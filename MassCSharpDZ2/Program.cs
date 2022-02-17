using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassCSharpDZ2
{
    class Program
    {
        static Random rand = new Random();
        static void GenerateArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(0, 9);
        }
        static void ShowArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[13];
            GenerateArr(arr1);
            Console.Write($"\nArr1 ==> ");
            ShowArr(arr1);
            int[] arr2 = new int[7];
            GenerateArr(arr2);
            Console.Write($"\nArr2 ==> ");
            ShowArr(arr2);
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int[] arr4 = new int[arr1.Length + arr2.Length];
            int[] arr5 = new int[arr1.Length + arr2.Length];
            arr3 = arr1.Concat(arr2).Distinct().ToArray();
            Console.Write($"\nArr3 ==> ");
            ShowArr(arr3);
            arr4 = arr1.Concat(arr2).Where(i => arr2.Contains(i)).Distinct().ToArray();
            Console.Write($"\nArr4 ==> ");
            ShowArr(arr4);
            arr5 = arr1.Concat(arr2).Where(i => !arr2.Contains(i)).ToArray();
            Console.Write($"\nArr5 ==> ");
            ShowArr(arr5);
            Console.ReadKey();
        }
    }
}