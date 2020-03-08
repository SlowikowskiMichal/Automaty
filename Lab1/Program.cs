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
            string dupa = "DUPA";
            Menu mainMenu = new Menu(new List<MenuOption> { 
                new MenuOption(ConsoleKey.D1, "Pierwszy test",delegate(){PrintPierwszy(out dupa);}),
                new MenuOption(ConsoleKey.C, "Oblicz siatke",delegate(){Calculate();})
            });
            ConsoleKey key;
            do
            {
                key = mainMenu.printMenu();
                Console.WriteLine($"Out: {dupa}");
            } while (key != ConsoleKey.Escape);
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
            
            Console.Write("Podaj regułę:");
            int rule = 127;
            int.TryParse(Console.ReadLine(), out rule);

            string stringRule = Convert.ToString(rule, 2).PadLeft(8,'0');
            bool[] ruleArray = stringRule.Reverse().Select(s => s.Equals('1')).ToArray();

            Random rand = new Random();
            bool[] grid = new bool[size];
            bool[] nextStepGrid = new bool[size];
            for (int i = 0; i < size; i++)
            {
                grid[i] = false;// rand.NextDouble() > 0.5 ? true : false;
            }

            grid[size / 2] = true;

            ConsoleKey userInput;

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

    public class Menu
    {
        string menuTitle = "---MENU---";
        string inputTitle = "Wybierz opcje: ";
        List<MenuOption> menuOptions;

        public Menu(List<MenuOption> menuOptions)
        {
            this.menuOptions = menuOptions;
        }

        public System.ConsoleKey printMenu()
        {
            Console.Clear();
            Console.WriteLine(menuTitle);
            foreach(MenuOption mo in menuOptions)
            {
                System.Console.WriteLine(mo.ToString());
            }
            Console.Write(inputTitle);
            System.ConsoleKey userInput = Console.ReadKey().Key;
            MenuOption optionToCall = menuOptions.FirstOrDefault(m => userInput == m.KeyValue);

            if (optionToCall != null)
            {
                Console.WriteLine();
                optionToCall.Execute();
                Console.WriteLine("Wciśnij dowolny klawisz");
                Console.ReadKey();
            }

            return userInput;
        }
    }

    public class MenuOption
    {
        public ConsoleKey KeyValue;
        public string OptionTitle;
        FunctionToCall Func = delegate ()
        {
            Console.WriteLine("Not implemented");
        };

        public delegate void FunctionToCall();

        public MenuOption(ConsoleKey keyValue, string optionTitle, FunctionToCall func)
        {
            KeyValue = keyValue;
            OptionTitle = optionTitle;
            Func = func;
        }

        public void Execute()
        {
            Func();
        }

        public override string ToString()
        {
            return $"{KeyValue.ToString()} - {OptionTitle}";
        }
    }
}
