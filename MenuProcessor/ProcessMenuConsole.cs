using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProcessor
{
    public class ProcessMenuConsole : IProcessMenu
    {
        public ProcessMenuConsole()
        {

        }
        public string LoadMenuSelections(List<string> optionsList)
        {
            string output = "Output: ";
            bool errorFound = false;
            string mealTime = optionsList[0];
            string errorOutput = "error";

            if (mealTime.ToLower() == MenuEnums.MealTime.morning.ToString())
            {
                int eggsCount = 0;
                int toastCount = 0;
                int coffeeCount = 0;

                string eggsOutput = string.Empty;
                string toastOutput = string.Empty;
                string coffeeOutput = string.Empty;
                
                foreach (string optionItem in optionsList)
                {
                    //User may enter lower or upper case in any combination
                    string lowerOptItem = optionItem.ToLower();
                    switch (lowerOptItem)
                    {
                        case "morning":
                            {
                                break;
                            }
                        case "1":
                            {
                                ++eggsCount;
                                if (eggsCount > 1)
                                {
                                    errorFound = true;
                                }
                                else
                                {
                                    eggsOutput = "eggs, ";
                                }
                                break;
                            }
                        case "2":
                            {
                                ++toastCount;
                                if (toastCount > 1)
                                {
                                    errorFound = true;
                                }
                                else
                                {
                                    toastOutput = "toast, ";
                                }
                                break;
                            }
                        case "3":
                            {
                                ++coffeeCount;
                                if (coffeeCount == 1)
                                {
                                    coffeeOutput = "coffee, ";
                                }
                                else
                                {
                                    for (int i = 0; i < coffeeCount; ++i )
                                    {
                                        coffeeOutput = "coffee(x" + coffeeCount + "), ";
                                    }
                                }

                                break;
                            }
                        default:
                            {
                                errorFound = true;
                                break;
                            }
                    }

                    if (errorFound)
                    {
                        break;
                    }
                }

                if (!errorFound)
                {
                    output = eggsOutput + toastOutput + coffeeOutput;
                }
                else
                {
                    output = eggsOutput + toastOutput + coffeeOutput + errorOutput;
                }

            }
            else if (mealTime == MenuEnums.MealTime.night.ToString())
            {
                int steakCount = 0;
                int potatoCount = 0;
                int wineCount = 0;
                int cakeCount = 0;

                string steakOutput = string.Empty;
                string potatoOutput = string.Empty;
                string wineOutput = string.Empty;
                string cakeOutput = string.Empty;
           
                foreach (string optionItem in optionsList)
                {
                    string lowerOptItem = optionItem.ToLower();

                    switch (lowerOptItem)
                    {
                        case "night":
                            {
                                break;
                            }
                        case "1":
                            {
                                ++steakCount;
                                if (steakCount > 1)
                                {
                                    errorFound = true;
                                }
                                else
                                {
                                    steakOutput = "steak, ";
                                }
                                break;
                            }
                        case "2":
                            {
                                ++potatoCount;
                                if (potatoCount == 1)
                                {
                                    potatoOutput = "potato, ";
                                }
                                else
                                {
                                    for (int i = 0; i < potatoCount; ++i)
                                    {
                                        potatoOutput = "potato(x" + potatoCount + "), ";
                                    }
                                }

                                break;
                            }
                        case "3":
                            {
                                ++wineCount;
                                if (wineCount > 1)
                                {
                                    errorFound = true;
                                }
                                else
                                {
                                    wineOutput = "wine, ";
                                }
                                break;
                            }
                        case "4":
                            {
                                ++cakeCount;
                                if (cakeCount > 1)
                                {
                                    errorFound = true;
                                }
                                else
                                {
                                    cakeOutput = "cake, ";
                                }
                                break;
                            }
                        default:
                            {
                                errorFound = true;
                                break;
                            }
                    }

                    if (errorFound)
                    {
                        break;
                    }
                }

                if (!errorFound)
                {
                    output = steakOutput + potatoOutput + wineOutput + cakeOutput;
                }
                else
                {
                    output = steakOutput + potatoOutput + wineOutput + cakeOutput + errorOutput;
                }
            }
            else
            {
                Console.WriteLine("Meal Time option is not supported. Please check input data.");
            }

            return output;
        }

        public void DisplayOutput(List<string> optionList, string outputItems)
        {
            string displayLine = "";
            foreach (string item in optionList)
            {
              displayLine += item + ", ";
            }

            displayLine = displayLine.TrimEnd().TrimEnd(',');
            Console.WriteLine("Input: " + displayLine);

            outputItems = outputItems.TrimEnd().TrimEnd(',');
            Console.WriteLine("Output: " + outputItems);
        }
    }
}
