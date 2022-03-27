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
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            int choise;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Welcome, dear user!\nWe have blocks 1 and 2 to choose from:   ");
                choise = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choise)
                {
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Block - 1 is in progress!");
                            Console.Write("Dear user, choose the option from the following\n\t\t Option 3: enter number 3 (your curator will be Yanenko Yuriy)\n\t\t Option 5: enter number 5 (your curator will be Tsaryova Alyona)\n\t\t Option 6: enter number 6 (your curator will be Bezpalko Maria)\n\t\t ");
                            Block1();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Block - 2 is in progress!");
                            Console.Write("Dear user, choose the option from the following\n\t\t Option 3: enter number 3 (your curator will be Yanenko Yuriy)\n\t\t Option 5: enter number 5 (your curator will Tsaryova Alyona)\n\t\t Option 6: enter the number 6 (your curator will be Bezpalko Maria)\n\t\t ");
                            Block2();
                            Console.Clear();
                            break;
                        }
                }
                Console.ReadKey();
            } while (choise != 0);
            Console.WriteLine("Dear user, you have logged out of the program. See you! :) ");
            Console.ReadKey();
        }
        static void Block1()
        {
            int choise;
            do
            {
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 3:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("We are performing option 3!");
                            Var3b1();
                            break;
                        }
                    case 5:
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("We are performing option 5!");
                            Var5b1();
                            break;
                        }
                    case 6:
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("We are performing option 6!");
                            break;
                        }
                }
            } while (choise != 0);
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
        static int[,] MatrixInput(int n, int m, int[,] arr)
        {
            for (int i = 0; i < n; i++)
            {
                string[] arrElem = Console.ReadLine().Trim().Split();

                for (int j = 0; j < m; j++)
            {
                    arr[i,j] = int.Parse(arrElem[j]);
                }
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
                        Var5Block2();
                        break;
                    }
                case 6:
                    {
                        break;
                    }
            } 
        }
        static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0} ", arr[i, j]);
                Console.WriteLine();
            }
        }
        static void Var3Block2()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            MatrixInput(n, m, matrix);
            PrintMatrix(InsertRows(n, m, matrix));
                
        }
        static int[,] InsertRows(int n, int m, int[,] arr)
        {
            int k = int.Parse(Console.ReadLine());
            int[,] bArr = new int[n, m + k];
            for (int i = 0; i < n; i++)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    bArr[i, j + k] = arr[i, j];   
                }
                for (int j = 0; j < k; j++)
                {
                    bArr[i, j] = arr[i, j];
                }
            }
            return bArr;
        }
    
       
        static void Var5Block2()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] mass = new int[n][];
            ZubMas(mass,n);
            PrintZub(Deleter(mass, n));
            Console.ReadKey();
        }
        static int[][] ZubMas(int[][] mass, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Вводьте елементи {0}-го рядка" + "(всi в один рядок через пробiли)", i);
                mass[i] = Array.ConvertAll(Console.ReadLine().Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries),int.Parse);
            }
            return mass;
        }
        static void PrintZub(int[][] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    Console.Write("{0} ", mass[i][j]);
                }
                Console.WriteLine();
            }
        }
        static int[][] Deleter(int[][] mass, int n)
        {
            int k1 = int.Parse(Console.ReadLine());
            int k2 = int.Parse(Console.ReadLine());
            int v = k2 - k1;
            int[][] b = new int[n-v][];
            for (int i = 0; i < k1; i++)
            {
                b[i]=mass[i];

            }
            for (int i = k2; i < mass.Length; i++)
            {
                b[i-v] = mass[i];
            }
            return b;
        }
    }
    
}
