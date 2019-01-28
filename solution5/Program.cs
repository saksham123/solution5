using System;

namespace solution5
{
    class Program
    {
        public static void printPyramid()
        {
            int n, x, blank;
            Console.WriteLine("Please enter the height of pyramid in number of lines");//input value from user for number of lines
            n = Int32.Parse(Console.ReadLine()); // convert to integer
            Console.WriteLine("Enjoy your pyramid");//display message
            for (int i = 1; i <= n; i++) //till height of pyramid
            {
                for (blank = 1; blank <= (n - i); blank++) // insert space
                    Console.Write(" ");
                for (x = 1; x <= i; x++) //increment value by 1 each time
                    Console.Write('*');
                for (x = (i - 1); x >= 1; x--) //decrement the value by 1
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            try
            {
                printPyramid();//call the method
            }
            catch (Exception)
            {
                Console.Write("Please enter a valid input");
            }
            Console.ReadLine();
        }
    }
}

