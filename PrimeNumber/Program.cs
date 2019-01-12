using System;

//---------------------------------------------------------------
//
// PrimeNumber.cs
//
// An example C# console application to generate prime numbers
//
// by Michael G. Workman
// michael DOT g DOT workman AT gmail DOT COM
//
//---------------------------------------------------------------



namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 0;
            int endNumber = 0;

            Console.WriteLine("Enter a start number and an end number:");
            startNumber = Int32.Parse(Console.ReadLine());
            endNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("start {0}, end {1}", startNumber, endNumber);

            int i = 0;

            // 1 and 0 are not prime numbers, exclude them from calculation
            if ((startNumber == 1) || (startNumber == 0))
            {
                startNumber = 2;
            }

            // flag for prime or not
            bool isPrime = false;

            for (i = startNumber;i <= endNumber;i++)
            {
                if (i % 2 == 0) { isPrime = false; }
                else if (i % 3 == 0) { isPrime = false; }
                else if (i % 5 == 0) { isPrime = false; }
                else if (i % 7 == 0) { isPrime = false; }
                else { isPrime = true; }

                if (isPrime)
                {
                    Console.WriteLine(i + " is a prime number");
                }
            }

            Console.ReadLine();
        }
    }
}
