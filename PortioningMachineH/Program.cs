using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortioningMachineH.Classes;

namespace PortioningMachineH
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlUnit Ctrl = new ControlUnit(4, 2000);
            while (true)
            {
                Console.WriteLine("\n ----------------------- \n");
                Console.WriteLine("Input command:");
                Console.WriteLine("0: Send in 10 items");
                Console.WriteLine("1: Send in 10 items");
                Console.WriteLine("2: Send in 50 items");
                Console.WriteLine("3: Print Input Log");
                Console.WriteLine("4: Print Output Log");
                Console.WriteLine("\n ----------------------- \n");

                ConsoleKeyInfo userInput = Console.ReadKey();

                int input = int.Parse(userInput.KeyChar.ToString());
                Console.WriteLine("\n");

                switch (input)
                {
                    case 0:
                        Ctrl.Run();
                        break;
                    case 1:
                        for (int i = 0; i < 10; i++)
                        {
                            Ctrl.Run();
                        }

                        break;
                    case 2:
                        for (int i = 0; i < 50; i++)
                        {
                            Ctrl.Run();
                        }

                        break;
                    case 3:
                        Ctrl.PrintEntry();
                        break;
                    case 4:
                        Ctrl.PrintBin();
                        break;
                }
            }
        }
    }
}
