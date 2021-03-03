using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo_Crawford.Core
{
    class GlobalDriverHook
    {
        public static IWebDriver driver { get; set; }
    }
}
