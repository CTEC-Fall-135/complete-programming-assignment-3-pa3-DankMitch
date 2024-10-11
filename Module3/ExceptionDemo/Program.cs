/*
Author: Dank Mitchell
Date: 11 Oct 2024
Assignment: PA3 Task 2
 */


namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Code try/catch block
            try
            {
                int result = DemoMethod(37);
                Console.WriteLine(result);
            }

            // Code a catch clause that catches specific (divide by zero) exception
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Can not divide by zero: {ex.Message}");
            }

            // Code a catch all clause that catches everything else
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured: {ex.Message}");
            }
                     
        }

        // Create static method that takes int as a parameter and returns int value
        static int DemoMethod(int x)
        {
            // Code for method is return x / 0; w/ x as input
            return x / 0;
        }
    }
}

