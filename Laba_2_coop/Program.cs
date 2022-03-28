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
            Console.BackgroundColor = ConsoleColor.White;
            int choise;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
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
                            Console.Write("Dear user, choose the option from the following\n\t\t Option 3: enter number 3 (your curator will be Yanenko Yuriy)\n\t\t Option 5: enter number 5 (your curator will Tsaryova Alyona)\n\t\t Option 6: enter number 6 (your curator will be Bezpalko Maria)\n\t\t ");
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
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("We are performing option 6!");
                            //Console.ForegroundColor = ConsoleColor.;
                            Var6b1();
                            break;
                        }
                }
            } while (choise != 0);
        }
        //Методи введеня одновимірного масиву
        static void ReabLineOneMass(ref int[] myArray, int n)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Choose how to fill the array: \n\t 1: - Fill in manually (in a row)! \n\t 2: - Fill in manually (in a column)! \n\t 3: - Fill in randomly (entering color)! \n\t 4: - Fill in randomly (trust the god of randomness)!");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    InputTape(ref myArray, n);
                    break;
                case 2:
                    InputColumn(ref myArray, n);
                    break;
                case 3:
                    ParRandom(ref myArray, n);
                    Print(myArray);
                    break;
                case 4:
                    GodRandom(ref myArray, n);
                    Print(myArray);
                    break;
            }
        }
        static void ParRandom(ref int[] myArray, int elemetCount)
        {
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
        static void GodRandom(ref int[] myArray, int elemetCount)
        {
            myArray = new int[elemetCount];
            Random gacha = new Random();
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = gacha.Next(-666, 666);
        }
        static void InputColumn(ref int[] myArray, int elemetCount)
        {            
            myArray = new int[elemetCount];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Enter array element number {i + 1}: \t");
                myArray[i] = Int32.Parse(Console.ReadLine());
            }
        }
        static void InputTape(ref int[] myArray, int elemetCount)
        {
            Console.Write("Enter the array:");
            string[] row = Console.ReadLine().Trim().Split();
            myArray = new int[elemetCount];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(row[i]);
            }
        }
        static void Print(int[] myArray)
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();
        }
        //Блок 1: Варіант 3.
        static void Var3b1()
        {
            Console.Write("Enter the length of array: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            ReabLineOneMass(ref arr, num);
            Print(Block1v3(arr));
        }
        static int[] Block1v3(int[] arr)
        {
            Console.Write("Enter the number what are you want to destroy: ");
            int key = int.Parse(Console.ReadLine());
            int keyInd = Array.IndexOf(arr, key);
            if (arr == null || keyInd < -1 || keyInd >= arr.Length)
            {
                Console.WriteLine("Oh, we can't do smth whith that");
            }
            else if (keyInd == -1)
                Console.WriteLine("No, this num das not exist");
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
            Console.WriteLine("Enter the length of the array");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            ReabLineOneMass(ref arr, num);
            Console.WriteLine("Your new array");
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
            ReabLineOneMass(ref arr, num);
            Console.WriteLine("Your new array:");
            Block1v6(arr);
        }
        static int[] Block1v6(int[] arr)
        {
            int[] b = new int[arr.Length];
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((Math.Abs(arr[i]%2)==0) || arr[i] == 0)
                {
                    b[cnt] = arr[i];
                    cnt++;
                }
            }
            if (cnt == arr.Length)
            {
                Console.WriteLine("There were no odd numbers in the array");
                Print(arr);
            }
            if(cnt ==0)
            {
                Console.WriteLine("There is no array");
            }
            else
            {
                Array.Resize(ref b, cnt);
                Print(b);
            }
            return b;
        }
        //Блок 2
        static void Block2()
        {
            int choise;
            do
            {
                Console.Clear();
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
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("We are performing option 6!");
                            Var6Block2();
                            break;
                        }
                }
            } while (choise != 0);
        }
        static void TypeOfJaggArr(ref int[][] arr, int n, int m)
        {
            Console.WriteLine("How are you want to input the array?\n1 - arbaiten your hand, 2 - random!");
            int choise = int.Parse(Console.ReadLine());
            switch(choise)
            {
                case 1:
                    {
                        ZubMas(arr, n, m);
                        break;
                    }
                case 2:
                    {
                        RandJagg(ref arr, n, m);
                        PrintZub(arr);
                        break;
                    }
            }
        }
        static int[][] ZubMas(int[][] mass, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                mass[i] = new int[m];
                Console.WriteLine("Enter elements of the {0} raw" + "(all throught spaces)", i);
                string[] arrinput = Console.ReadLine().Trim().Split();
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
            Console.WriteLine("Write the min number of diapasone");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the max number of diapasone");
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
        //Блок 2. Варіант 3
        static void Var3Block2()
        {
            Console.WriteLine("Enter amount of rows");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of laws");
            int m = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            TypeOfJaggArr(ref matrix, n, m);
            PrintZub(InsertRows(n, matrix));
            Console.ReadKey();
        }
        static int[][] InsertRows(int n, int[][] arr)
        {
            Console.WriteLine("How many rows you are want add?");
            int k = int.Parse(Console.ReadLine());
            if (k < 0)
            {
                Console.WriteLine("Why are you doing this? I can't work with this\ntake your array back");
                return arr;
            }
            else
            {
                Array.Resize(ref arr, arr.Length + k);

                for (int i = n - 1; i >= 0; i--)
                {
                    arr[i + k] = arr[i];
                }
                return arr;
            }
        }
        //Блок 2. Варіант 5
        static void Var5Block2()
        {
            Console.WriteLine("Enter the amount of rows");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of laws");
            int m = int.Parse(Console.ReadLine());
            int[][] mass = new int[n][];
            TypeOfJaggArr(ref mass, n, m);
            PrintZub(Deleter(mass, n));
            Console.ReadKey();
        }
        static int[][] Deleter(int[][] mass, int n)
        {
            Console.WriteLine("Enter the index of raw, what are you want to destroy first");
            int k1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the index of raw, what are you want to destriy last");
            int k2 = int.Parse(Console.ReadLine());
            if (k1 > k2 || k1 < 0 || k2 > mass.Length)
            {
                Console.WriteLine("What are you doing?");
                return mass;
            }
            else
            {
                int v = k2 - k1;
                int[][] b = new int[n - v][];
                for (int i = 0; i < k1; i++)
                {
                    b[i] = mass[i];

                }
                for (int i = k2; i < mass.Length; i++)
                {
                    b[i - v] = mass[i];
                }
                return b;
            }
           
        }
        //Блок 2. Варіант 6
        static void Var6Block2()
        {
            Console.WriteLine("Enter the amount of rows");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of laws");
            int m = int.Parse(Console.ReadLine());
            int[][] mass = new int[n][];
            TypeOfJaggArr(ref mass, n, m);
            Block2v6(mass, n);
            Console.ReadKey();
        }
        static int[][] Block2v6(int[][] mass, int n)
        {
            int count  = 0;
            int[][] b = new int[n][];
            for(int i = 0; i<mass.Length; i++ )
            {
                if((i%2)!= 0)
                {
                    b[count]= mass[i];
                    count++;
                }
            }
            Array.Resize(ref b, count);
            Console.WriteLine("Result:");
            PrintZub(b);
            return b;
        }
    } 
}
