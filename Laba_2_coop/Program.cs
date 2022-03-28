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
                Console.Write("Welcome, dear user! If you want to leave us, input 0\nWe have blocks 1 and 2 to choose from:   ");
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
                    default:
                        {
                            Console.WriteLine("Dear user, you input smth wrong");
                            break;
                        }
                }
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
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Var6b1();
                            break;
                        }
                }
            } while (choise != 0);
        }
        //Методи введеня одновимірного масиву
        static void ReabLineOneMass(ref int[] myArray)
        {
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.WriteLine("Choose how to fill the array: \n\t 1: - Fill in manually (in a row)! \n\t 2: - Fill in manually (in a column)! \n\t 3: - Fill in randomly (entering color)! \n\t 4: - Fill in randomly (trust the god of randomness)!");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    InputTape(ref myArray);
                    break;
                case 2:
                    InputColumn(ref myArray);
                    break;
                case 3:
                    ParRandom(ref myArray);
                    Print(myArray);
                    break;
                case 4:
                    GodRandom(ref myArray);
                    Print(myArray);
                    break;
            }
            //Console.ReadKey();
        }
        static void ParRandom(ref int[] myArray)
        {
            Console.Write("Please enter the number of elements in the array: \t");
            int elemetCount = Int32.Parse(Console.ReadLine());
            myArray = new int[elemetCount];
            Random gacha = new Random();
            Console.Write("Enter the minimum parameter:");
            int par = int.Parse(Console.ReadLine());
            Console.Write("Enter the maximum parameter:");
            int par2 = int.Parse(Console.ReadLine());
            while (par > par2)
            {
                Console.WriteLine("Dear user, please do not break the program!");
                Console.WriteLine("Enter the maximum parameter:");
                par2 = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = gacha.Next(par, par2);
        }
        static void GodRandom(ref int[] myArray)
        {
            Console.Write("Please enter the number of elements in the array: \t");
            int elemetCount = Int32.Parse(Console.ReadLine());
            myArray = new int[elemetCount];
            Random gacha = new Random();
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = gacha.Next(-666, 666);
        }
        static void InputColumn(ref int[] myArray)
        {
            Console.Write("Please enter the number of elements in the array: \t");
            int elemetCount = Int32.Parse(Console.ReadLine());
            myArray = new int[elemetCount];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Enter array element number {i + 1}: \t");
                myArray[i] = Int32.Parse(Console.ReadLine());
            }
        }
        static void InputTape(ref int[] myArray)
        {
            Console.Write("Введіть елементи масиву:");
            string[] row = Console.ReadLine().Split(' ');
            myArray = new int[row.Length];
            for (int i = 0; i < row.Length; i++)
            {
                myArray[i] = int.Parse(row[i]);
            }
        }
        //Кінець
        //Блок 1: Варіант 3.
        static void Var3b1()
        {
            Console.Write("Введiть кiлькiсть елементiв: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            ReabLineOneMass(ref arr);
            Print(Block1v3(num, arr));
        }
        static void Print(int[] myArray)
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.Write(myArray[i] + " ");
            }
        }
        static int[] Block1v3(int num, int[] arr)
        {
            Console.Write("Введiть число, яке потрiбно знищити: ");
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
        //Блок 1: Варіант 5.
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
            int[] arr = new int[num];
            ReabLineOneMass(ref arr);
            Print(Block1v5(arr));
        }
        static int[] Block1v5(int[] array)
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
        //Блок 1: Варіант 6.
        static void Var6b1()
        {
            Console.Write("Enter the length of array: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            ReabLineOneMass(ref arr);
            Print(Block1v6(arr));
        }
        static int[] Block1v6(int[] arr)
        {
            int[] b = new int[arr.Length];

            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0 || arr[i] == 0)
                {
                    b[cnt] = arr[i];
                    cnt++;
                }
            }
            Array.Resize(ref b, cnt);
            return b;
        }
        static void Block2()
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
                            Var3Block2();
                            break;
                        }
                    case 5:
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("We are performing option 5!");
                            Var5Block2();
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
        static void Var3Block2()
        {
            Console.WriteLine("Input amount of rows");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input amount of laws");
            int m = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            ZubMas(matrix, n, m);
            PrintZub(InsertRows(n, matrix));
            Console.ReadKey();   
        }
        static int[][] InsertRows(int n, int[][] arr)
        {
            int k = int.Parse(Console.ReadLine());
            int[][] bArr = new int[n + k][];
            
                for (int i = n - 1; i >= 0; i--)
                {
                    bArr[i + k] = arr[i];   
                }
                for (int i = 0; i < k; i++)
                {
                    bArr[i] = arr[i];
                }
            
            return bArr;
        }
        static void Var5Block2()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[][] mass = new int[n][];
            ZubMas(mass, n, m);
            PrintZub(Deleter(mass, n));
            Console.ReadKey();
        }
        static int[][] ZubMas(int[][] mass, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                mass[i] = new int[m];
                Console.WriteLine("Вводьте елементи {0}-го рядка" + "(всi в один рядок через пробiли)", i);
                string[] arrinput = Console.ReadLine().Trim().Split();
               
                //mass[i] = Array.ConvertAll(Console.ReadLine().Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries),int.Parse);
                for (int j = 0; j < m; j++)
                {
                    mass[i][j] = int.Parse(arrinput[j]);
                }
            }
            return mass;
        }
        static void RandJagg(ref int[][] arr, int n, int m)
        {
            Random rnd = new Random();
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[m];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(min, max);
                }
            }
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
