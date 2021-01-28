using System;

namespace Lab_4___Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grand Circus -- Lab 4 -- Ramon Guarnes's Powers Table:");

            char checkFlag = 'y';

            do
            {
                Console.WriteLine("\nPlease enter an integer: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("\nNumber\tSquared\tCubed");
                Console.WriteLine("=======\t=======\t========");

                for (int i = 0; i <= number; i++)
                {
                    string ns = i.ToString();
                    string sq = (i * i).ToString();
                    string cb = (i * i * i).ToString();
                    Console.WriteLine(ns + "\t" + sq + "\t" + cb);
                }

                Console.WriteLine("\nContinue? (y/n)");
                checkFlag = Console.ReadLine()[0];
            } while (checkFlag == 'y');

            Console.WriteLine("\nProgram has ended.");
        }
    }
}
