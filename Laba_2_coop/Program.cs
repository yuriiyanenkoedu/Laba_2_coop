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
            switch (choise)
            {
                case 1:
                    {
                        Block1();
                        break;
                    }
                case 2:
                    {
                        Block2();
                        break;
                    }
            }
        }
        static void Block1()
        {
            Console.WriteLine("Оберiть варiант: 3, 5 або 6");
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
            Print(Block1v3(num, HandmadeArraySpaces(num)));
            Console.ReadKey();
        }
        //Block1
        static void Randomfill(int n, int[] myArray)
        {

            Console.WriteLine("Enter the min value of the array:\t");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the max value of the array:\t");
            int maxValue = int.Parse(Console.ReadLine());
            Random ran = new Random();

            Console.WriteLine("Your array:");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = ran.Next(minValue, maxValue);
                Console.Write(myArray[i] + " ");
            }

        }
        static void HandmadeEnter(int[] myArray)
                {

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Enter the number on {i} index:\t");
                myArray[i] = int.Parse(Console.ReadLine());
                }
            }
        static int[] HandmadeArraySpaces(int n)
        {
            string[] spArr = Console.ReadLine().Trim().Split();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(spArr[i]);
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

        static int[] Erase(ref int[] arr, int keyInd)
        {
            for (int i = keyInd + 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            Array.Resize(ref arr, arr.Length - 1);
            return arr;
        }
        static int[][] JaggInput(int n, int m, int[][] arr)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Вводьте елементи {0}-го рядка" + "(всi в один рядок через пробiли)", i);
            arr[i] = Array.ConvertAll(
            Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries), int.Parse);
            }
            return arr;
        }
        static void Var5b1()
        {
            int num = int.Parse(Console.ReadLine());
            Print(Block1v5(num, HandmadeArraySpaces(num)));
            Console.ReadKey();
        }
        static int[] Block1v5(int num, int[] array) 
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Erase(ref array, i);
                }
            }
            return array;
        }
        static void Block2()
        {
            Console.WriteLine("Оберiть варiант: 3, 5 або 6");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 3:
                    {
                        Var3Block2();
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                case 6:
                    {
                        break;
                    }
            } 
         }
        static void PrintJagg(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write("{0} ", arr[i][j]);
                Console.WriteLine();
            }
        }
        static void Var3Block2()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            JaggInput(n, m, matrix);
            PrintJagg(InsertRows(n, m, matrix));
            Console.ReadKey();
                
        }
        static int[][] InsertRows(int n, int m, int[][] arr)
        {
            int k = int.Parse(Console.ReadLine());
            int[][] bArr = new int[n + k][];
            for (int j = 0; j < m; j++)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    bArr[i + k] = arr[i];   
                }
                for (int i = 0; i < k; i++)
                {
                    bArr[i] = arr[i];
                }
            }
            return bArr;
        }
    }
}
