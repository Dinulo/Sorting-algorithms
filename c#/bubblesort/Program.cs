using System;
using System.Diagnostics;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            /* To-do:
            - validate inputs
            - limit input to 65k or up to int32   
             */
            //get user inputs for range
            Console.WriteLine("Bubblesort \n");
            Console.WriteLine("Enter array size (int): ");
            int arraySize = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter bottom of range(int): ");
            int rangeBottom = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter top of range(int): ");
            int rangeTop = Int16.Parse(Console.ReadLine());

            /*To-do:
             - limit output to 100 chars or so if array is too long
             */
            //fill array with random numbers and print to console
            Random rnd = new Random();
            int[] numbers = new int[arraySize];
            for (int i = 0; i < arraySize; i++) {
                numbers[i] = rnd.Next(rangeBottom, rangeTop);
            }
            Console.WriteLine("Your random array: " + string.Join(",", numbers));
            
            //declare helping variables "swapped" and "slot" for swapping numbers and "stopwatch" for timing the execution
            bool swapped = true;
            int slot = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (swapped) {
                swapped = false;
                for (int i = 0; i < numbers.Length-1 ; i++) {
                    if (numbers[i] > numbers[i + 1]) {
                        slot = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = slot;
                        swapped = true;
                    }
                }
            }

            /* To-do:
             - proper exit and "run again" option
             */
            //stop time and display it with the sorted array
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Your sorted array: " + string.Join(",", numbers));
            Console.WriteLine("Time elapsed: " + ts);
        }
    }
}
