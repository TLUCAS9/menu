using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProcessor
{
    public interface IProcessMenu
    {
        string LoadMenuSelections(List<string> optionsList);
        void DisplayOutput(List<string> optionsList, string outputItems);
    }
}
