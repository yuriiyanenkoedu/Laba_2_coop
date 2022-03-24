using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_coop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Який блок? (1 або 2)");
            int choise = int.Parse(Console.ReadLine());
            switch(choise)
            {
                case 1:
                    {
                        Block1();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
            }
        }
        static void Block1()
        {
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 3:
                    {
                        Var3b1();
                        break;
                    }
                case 5:
                    {
                        Var5b1();
                        break;
                    }
                case 6:
                    {
                        break;
                    }
            }
        }
        static void Var3b1()
        {
            int num = int.Parse(Console.ReadLine());
            Print(Block1v3(num, HandmadeArray(num)));
            Console.ReadKey();
        }
        static int[,] CreateArrayHand(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                string[] law = Console.ReadLine().Trim().Split();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(law[j]);
                }
            }
            return arr;
        }
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static int[] Block1v3(int num, int[] arr)
        {
            int key = int.Parse(Console.ReadLine());
            int keyInd = Array.IndexOf(arr, key);
            if (arr == null || keyInd < -1 || keyInd >= arr.Length)
            {
                Console.WriteLine("Видалити неможливо, " +
                "iндекс поза допустимими межами");
            }
            else if (keyInd == -1)
                Console.WriteLine("No this num");
            else
                Erase(ref arr, keyInd);
            return arr;
        }
        static int[] HandmadeArray(int n)
        {
            string[] spArr = Console.ReadLine().Trim().Split();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(spArr[i]);
            }
            return arr;
        }
        static int[] Erase(ref int[] arr, int keyInd)
        {
            for (int i = keyInd + 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            Array.Resize(ref arr, arr.Length - 1);
            return arr;
        }
        static void Var5b1()
        {
            int num = int.Parse(Console.ReadLine());
            Print(Block1v5(num, HandmadeArray(num)));
            Console.ReadKey();
        }
        static int[] Block1v5(int num, int[] array)
        {
            for (int i = array.Length-1; i>=0; i--)
            {
                if (i%2==0)
                {
                    Erase1(ref array, i);
                }
                
            }
            return array;
        }
        static int[] Erase1(ref int[] arr, int keyInd)
        {
            for (int i = keyInd + 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            Array.Resize(ref arr, arr.Length - 1);
            return arr;
        }
        
    }
    
}
