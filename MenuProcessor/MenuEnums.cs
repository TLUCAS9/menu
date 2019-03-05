using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProcessor
{
    public static class MenuEnums
    {
        public enum MealTime
        {
            [Description("morning")]
            morning = 0,
            [Description("night")]
            night = 1
        }
    }
}
