using System;

namespace InventorySys_V2
{
    public  class ConsoleHelper
    {
        public  string prompt(string userPrompt)
        {
            Console.Write(userPrompt);
            return Console.ReadLine();
        }
        public  int promptInt(string userPrompt)
        {
            Console.Write(userPrompt);
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Invalid input. please enter an integer:");
            }
            return result;
        }
        public  double promptDouble(string userPrompt)
        {
            Console.Write(userPrompt);
            double result;
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Invalid input. please enter a number:");
            }
            return result;
        }
        
    }
}