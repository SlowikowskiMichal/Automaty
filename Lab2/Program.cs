using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    class Program
    {

        static List<int> CalculationOrder;

        static void Main(string[] args)
        {
            
            int size = 10;
            do
            {
                Console.Write("Podaj rozmiar siatki:");
            } while(!int.TryParse(Console.ReadLine(), out size));
            size = size > 2 ? size : 3;
            CalculationOrder = new List<int>();
            CalculationOrder.AddRange(Enumerable.Range(0, size));
            int rule = 127;
            do
            {
                Console.Write("Podaj regułę (0-255):");
                
            }while(!int.TryParse(Console.ReadLine(), out rule));

            string stringRule = Convert.ToString(rule, 2).PadLeft(8, '0');
            bool[] ruleArray = stringRule.Reverse().Select(s => s.Equals('1')).ToArray();

            bool[] grid = new bool[size];
            
            gridCellValuesSetup(ref grid);
            Func<bool[], bool[], bool[]> updateMode = setUpdateMode(size);
            mainLoop(grid, ruleArray, updateMode);
        }

        private static Func<bool[],bool[], bool[]> setUpdateMode(int size)
        {
            ConsoleKey userInput;
            Console.WriteLine(@"Wybierz tryb aktualizowania automatu:
1 - Synchroniczny
2 - asynchroniczny z uporządkowaną aktualizacją
3 - asynchroniczny z cykliczną aktualizacją
4 - asynchroniczny z losowo uporządkowaną aktualizacją");
            do
            {
                userInput = Console.ReadKey().Key;
                Console.WriteLine();
                switch (userInput)
                {
                    case ConsoleKey.D1:
                        return new Func<bool[], bool[], bool[]>(synchronousUpdate);
                    case ConsoleKey.D2:
                        return new Func<bool[], bool[], bool[]>(asyncOrderlyUpdate);
                    case ConsoleKey.D3:
                        SetCalculationOrder();
                        return new Func<bool[], bool[], bool[]>(asyncCyclicUpdate);
                    case ConsoleKey.D4:
                        return new Func<bool[], bool[], bool[]>(asyncCyclicRandomUpdate);
                    default:
                        Console.WriteLine("Nieprawidłowa wartość!");
                        Console.WriteLine(@"Wybierz tryb aktualizowania automatu:
1 - Synchroniczny
2 - asynchroniczny z uporządkowaną aktualizacją
3 - asynchroniczny z cykliczną aktualizacją
4 - asynchroniczny z losowo uporządkowaną aktualizacją");
                        break;
                }

            } while (true);

        }

        private static void SetCalculationOrder()
        {
            Random r = new Random();
            CalculationOrder = CalculationOrder.OrderBy(x => r.Next()).ToList();
        }

        private static bool[] synchronousUpdate(bool[] grid, bool[] ruleArray)
        {
            int size = grid.Length;
            bool[] nextStepGrid = new bool[size];
            nextStepGrid[0] = ruleArray[getRuleIndex(grid[size - 1], grid[0], grid[1])];
            for (int i = 1; i < size - 1; i++)
            {
                nextStepGrid[i] = ruleArray[getRuleIndex(grid[i - 1], grid[i], grid[i + 1])];
            }
            nextStepGrid[size - 1] = ruleArray[getRuleIndex(grid[size - 2], grid[size - 1], grid[0])];

            return nextStepGrid;
        }

        private static bool[] asyncOrderlyUpdate(bool[] grid, bool[] ruleArray)
        {
            int size = grid.Length;
            grid[0] = ruleArray[getRuleIndex(grid[size - 1], grid[0], grid[1])];
            for (int i = 1; i < size - 1; i++)
            {
                grid[i] = ruleArray[getRuleIndex(grid[i - 1], grid[i], grid[i + 1])];
            }
            grid[size - 1] = ruleArray[getRuleIndex(grid[size - 2], grid[size - 1], grid[0])];

            return grid;
        }

        private static bool[] asyncCyclicUpdate(bool[] grid, bool[] ruleArray)
        {
            int size = grid.Length;
            int firstIndex = CalculationOrder.IndexOf(0);
            int endIndex = CalculationOrder.IndexOf(size - 1);

            if(firstIndex < endIndex)
            {
                for (int i = 0; i < firstIndex; i++)
                {
                    grid[CalculationOrder[i]] = ruleArray[getRuleIndex(grid[CalculationOrder[i] - 1], 
                        grid[CalculationOrder[i]], grid[CalculationOrder[i] + 1])];
                }
                
                grid[0] = ruleArray[getRuleIndex(grid[size - 1], grid[0], grid[1])];
                
                for (int i = firstIndex+1; i < endIndex; i++)
                {
                    grid[CalculationOrder[i]] = ruleArray[getRuleIndex(grid[CalculationOrder[i] - 1], 
                        grid[CalculationOrder[i]], grid[CalculationOrder[i] + 1])];
                }

                grid[size - 1] = ruleArray[getRuleIndex(grid[size - 2], grid[size - 1], grid[0])];

                for (int i = endIndex + 1; i < size - 1; i++)
                {
                    grid[CalculationOrder[i]] = ruleArray[getRuleIndex(grid[CalculationOrder[i] - 1], 
                        grid[CalculationOrder[i]], grid[CalculationOrder[i] + 1])];
                }
            }
            else
            {
                for (int i = 0; i < endIndex; i++)
                {
                    grid[CalculationOrder[i]] = ruleArray[getRuleIndex(grid[CalculationOrder[i] - 1], 
                        grid[CalculationOrder[i]], grid[CalculationOrder[i] + 1])];
                }

                grid[size - 1] = ruleArray[getRuleIndex(grid[size - 2], grid[size - 1], grid[0])];

                for (int i = endIndex + 1; i < firstIndex; i++)
                {
                    grid[CalculationOrder[i]] = ruleArray[getRuleIndex(grid[CalculationOrder[i] - 1], 
                        grid[CalculationOrder[i]], grid[CalculationOrder[i] + 1])];
                }

                grid[0] = ruleArray[getRuleIndex(grid[size - 1], grid[0], grid[1])];

                for (int i = firstIndex + 1; i < size - 1; i++)
                {
                    grid[CalculationOrder[i]] = ruleArray[getRuleIndex(grid[CalculationOrder[i] - 1],
                        grid[CalculationOrder[i]], grid[CalculationOrder[i] + 1])];
                }
            }
            return grid;
        }

        private static bool[] asyncCyclicRandomUpdate(bool[] grid, bool[] ruleArray)
        {
            int size = grid.Length;
            SetCalculationOrder();
            int firstIndex = CalculationOrder.IndexOf(0);
            int endIndex = CalculationOrder.IndexOf(size - 1);

            if (firstIndex < endIndex)
            {
                for (int i = 0; i < firstIndex; i++)
                {
                    grid[CalculationOrder[i]] = ruleArray[getRuleIndex(grid[CalculationOrder[i] - 1], grid[CalculationOrder[i]], grid[CalculationOrder[i] + 1])];
                }

                grid[0] = ruleArray[getRuleIndex(grid[size - 1], grid[0], grid[1])];

                for (int i = firstIndex + 1; i < endIndex; i++)
                {
                    grid[CalculationOrder[i]] = ruleArray[getRuleIndex(grid[CalculationOrder[i] - 1], grid[CalculationOrder[i]], grid[CalculationOrder[i] + 1])];
                }

                grid[size - 1] = ruleArray[getRuleIndex(grid[size - 2], grid[size - 1], grid[0])];

                for (int i = endIndex + 1; i < size - 1; i++)
                {
                    grid[CalculationOrder[i]] = ruleArray[getRuleIndex(grid[CalculationOrder[i] - 1], grid[CalculationOrder[i]], grid[CalculationOrder[i] + 1])];
                }
            }
            else
            {
                for (int i = 0; i < endIndex; i++)
                {
                    grid[CalculationOrder[i]] = ruleArray[getRuleIndex(grid[CalculationOrder[i] - 1], grid[CalculationOrder[i]], grid[CalculationOrder[i] + 1])];
                }

                grid[size - 1] = ruleArray[getRuleIndex(grid[size - 2], grid[size - 1], grid[0])];

                for (int i = endIndex + 1; i < firstIndex; i++)
                {
                    grid[CalculationOrder[i]] = ruleArray[getRuleIndex(grid[CalculationOrder[i] - 1], grid[CalculationOrder[i]], grid[CalculationOrder[i] + 1])];
                }

                grid[0] = ruleArray[getRuleIndex(grid[size - 1], grid[0], grid[1])];

                for (int i = firstIndex + 1; i < size - 1; i++)
                {
                    grid[CalculationOrder[i]] = ruleArray[getRuleIndex(grid[CalculationOrder[i] - 1], grid[CalculationOrder[i]], grid[CalculationOrder[i] + 1])];
                }
            }
            return grid;
        }

        private static void mainLoop(bool[] grid, bool[] ruleArray, Func<bool[], bool[], bool[]> updateMode)
        {
            ConsoleKey userInput;
            Console.WriteLine("Aby przerwać działanie programu wciśnij ESC");
            do
            {
                printGrid(grid);
                Array.Copy(updateMode.Invoke(grid, ruleArray), grid,grid.Length);
                userInput = Console.ReadKey().Key;

            } while (userInput != ConsoleKey.Escape);
        }

        private static void gridCellValuesSetup(ref bool[] grid)
        {
            Console.WriteLine("Wybierz układ początkowy siatki:\n1. Jedna komórka w centrum w stanie 1\n2. Losowy rozkład stanów");
            ConsoleKey userInput;
            bool continueFlag = true;
            do
            {
                userInput = Console.ReadKey().Key;
                Console.WriteLine();
                int size = grid.Length;
                Random rand = new Random();
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

                        for (int i = 0; i < sizeToActive; i++)
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
        }

        static void printGrid(bool[] grid)
        {
            foreach (bool b in grid)
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