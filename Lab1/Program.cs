using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
        }

        static public void PrintPierwszy(out string a)
        {
            a = "DUPA".ToLower();
            Console.WriteLine(a);
        }

        static public void Calculate()
        {
            Console.Write("Podaj rozmiar siatki:");
            int size = 10;
            int.TryParse(Console.ReadLine(), out size);
            size = size > 2 ? size : 3;

            Console.Write("Podaj regułę:");
            int rule = 127;
            int.TryParse(Console.ReadLine(), out rule);

            string stringRule = Convert.ToString(rule, 2).PadLeft(8,'0');
            bool[] ruleArray = stringRule.Reverse().Select(s => s.Equals('1')).ToArray();

            Random rand = new Random();
            bool[] grid = new bool[size];
            bool[] nextStepGrid = new bool[size];

            Console.WriteLine("Wybierz układ początkowy siatki:\n1. Jedna komórka w centrum w stanie 1\n2. Losowy rozkład stanów");
            ConsoleKey userInput;
            bool continueFlag = true;
            do
            {
                userInput = Console.ReadKey().Key;

                switch (userInput)
                {
                    case ConsoleKey.D1:
                        for (int i = 0; i < size; i++)
                        {
                            grid[i] = false;
                        }

                        grid[size / 2] = true;
                        continueFlag = false;
                        break;
                    case ConsoleKey.D2:
                        int proc;
                        Console.WriteLine("\nPodaj ilość komórek w stanie 1 [%]:");
                        if (!int.TryParse(Console.ReadLine(), out proc))
                        {
                            Console.WriteLine("Nieprawidłowa wartość, system przyjmuje 50%");
                            proc = 50;
                        }
                        proc = Math.Min(Math.Max(proc, 0), 100);

                        int sizeToActive = size * proc / 100;

                        List<int> range = Enumerable.Range(0, size).OrderBy(a => rand.Next()).ToList();

                        for(int i = 0; i < sizeToActive; i++)
                        {
                            grid[range[i]] = true;
                        }

                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("\nNieprawidłowa wartość");
                        break;
                }
            } while (continueFlag);


            Console.WriteLine("Aby przerwać działanie programu wciśnij ESC");
            do
            {
                printGrid(grid);
                nextStepGrid[0] = ruleArray[getRuleIndex(grid[size - 1], grid[0], grid[1])];
                for(int i = 1; i < size - 1; i++)
                {
                    nextStepGrid[i] = ruleArray[getRuleIndex(grid[i - 1], grid[i], grid[i + 1])];
                }
                nextStepGrid[size - 1] = ruleArray[getRuleIndex(grid[size - 2], grid[size -1], grid[0])];

                nextStepGrid.CopyTo(grid,0);
                userInput = Console.ReadKey().Key;

            } while (userInput != ConsoleKey.Escape);
        }

        static void printGrid(bool[] grid)
        {
            foreach(bool b in grid)
            {
                Console.Write(b ? "X" : "_");
            }
            Console.WriteLine();
        }

        static int getRuleIndex(bool left, bool center, bool right)
        {
            return (left ? 4 : 0) + (center ? 2 : 0) + (right ? 1 : 0);
        }
    }
}
