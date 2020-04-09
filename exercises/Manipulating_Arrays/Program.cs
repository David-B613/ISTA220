using System;

namespace Manipulating_Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 }; //Array A 
            Console.WriteLine("Array A: {0}", string.Join(", ", ArrayA));
            Console.WriteLine("\n");

            int[] ArrayB = { 1, 3, 5, 7, 9 };  // Array B 
            Console.WriteLine("Array B: {0}", string.Join(", ", ArrayB));
            Console.WriteLine("\n");

            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 }; // Array C 
            Console.WriteLine("Array C: {0}", string.Join(", ", ArrayC));
            Console.WriteLine("\n");

            SumAvg(ArrayA);
            SumAvgB(ArrayB);
            SumAvgC(ArrayC);

            ReverseArray(ArrayA);
            ReverseArrayB(ArrayB);
            ReverseArray(ArrayC);



        }

        public static void SumAvg(int[] ArrayA)
        {
            int sum = 0;
            int avg = 0;

            for (int i = 0; i < ArrayA.Length; i++)
            {
                sum += ArrayA[i];
            }
            avg = sum / ArrayA.Length;

            Console.WriteLine("The Sum of Array A is : " + sum);

            Console.WriteLine("The Average of Array A is : " + avg);
            Console.WriteLine("\n");


        }
        public static void SumAvgB(int[] ArrayB)
        {
            int sum = 0;
            int avg = 0;

            for (int i = 0; i < ArrayB.Length; i++)
            {
                sum += ArrayB[i];
            }
            avg = sum / ArrayB.Length;

            Console.WriteLine("The Sum of Array B is : " + sum);

            Console.WriteLine("The Average of Array B is : " + avg);
            Console.WriteLine("\n");


        }
        public static void SumAvgC(int[] ArrayC)
        {
            int sum = 0;
            int avg = 0;

            for (int i = 0; i < ArrayC.Length; i++)
            {
                sum += ArrayC[i];
            }
            avg = sum / ArrayC.Length;

            Console.WriteLine("The Sum of Array C is : " + sum);

            Console.WriteLine("The Average of Array C is : " + avg);
            Console.WriteLine("\n");



        }
        public static void ReverseArray(int[] ArrayA)
        {
            {
                int[] list = ArrayA;
                int[] temp = list;
                Console.Write("Original Array A: ");
                foreach (int i in list)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                // reverse the array
                Array.Reverse(temp);
                Console.Write("Reversed Array A: ");
                foreach (int i in temp)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\n");


            }


        }
        public static void ReverseArrayB(int[] ArrayB)
        {
            {
                
                int[] list = ArrayB;
                int[] temp = list;
                Console.Write("Original Array B: ");
                foreach (int i in list)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                // reverse the array
                Array.Reverse(temp);
                Console.Write("Reversed Array B: ");
                foreach (int i in temp)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\n");


            }
        }
        public static void ReverseArrayC(int[] ArrayC)
        {
            int[] list = ArrayC;
            int[] temp = list;
            Console.Write("Original Array C: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // reverse the array
            Array.Reverse(temp);
            Console.Write("Reversed Array C: ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            //Console.ReadKey();


        }
    }

}


