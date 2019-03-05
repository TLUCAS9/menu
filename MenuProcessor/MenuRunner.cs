using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProcessor
{
    public class MenuRunner
    {
        public virtual void RunMenu(IProcessMenu processor, List<string> optionsList)
        {
            if (optionsList.Count > 0)
            {
                string outputValues = processor.LoadMenuSelections(optionsList);
                processor.DisplayOutput(optionsList, outputValues);
            }
            else
            {
                throw new Exception("Error occurred in method RunMenu. Menu Item List is empty. Please check data. ");
            }
        }
    }
}
