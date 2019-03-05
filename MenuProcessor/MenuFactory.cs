using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProcessor
{
    public abstract class MenuProcessorFactCreator
    {
        public abstract IProcessMenu FactoryMethod();
    }

    public class FactoryCreatorConsole : MenuProcessorFactCreator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IProcessMenu FactoryMethod()
        {
            return new ProcessMenuConsole();
        }
    }
}
