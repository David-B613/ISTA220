using System;

namespace Quiz03
{
    class Program
    {
        static void Main(string[] args)
        
              {
            try
            {
                int num2 = 1;
                Console.Write("To calculate the reciprocal of an integer, enter a positive integer:\n");
                int num1 = Convert.ToInt32(Console.ReadLine());
                {
                    if (num1 < 0)
                        Console.WriteLine("Your number must be a positive number.");
                        Console.WriteLine(num2 / num1);
                }
                  
          

            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
