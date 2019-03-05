using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuProcessor;

namespace Dishes
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments passed. ");
                Console.WriteLine("Usage Example 1: Dishes.exe morning, 1, 2, 3 ");
                Console.WriteLine("Usage Example 2: Dishes.exe night, 1, 2, 3, 4 ");
                return -1;
            }

            try
            {
                string inputOptions = string.Join("", args);
                List<string> optionsList = inputOptions.Split(',').ToList();
                ProcessMenuConsole consoleOutput = new ProcessMenuConsole();
                FactoryCreatorConsole createConsole = new FactoryCreatorConsole();
                ProcessMenuConsole menuConsole = (ProcessMenuConsole)createConsole.FactoryMethod();
                MenuRunner menuRunner = new MenuRunner();
                menuRunner.RunMenu(menuConsole, optionsList);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred Message: {0} InnerException: {1} StackTrace: {2}", ex.Message, ex.InnerException, ex.StackTrace);
            }

            return 0;
        }
    }
}
