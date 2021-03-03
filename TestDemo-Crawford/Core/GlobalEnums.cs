using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo_Crawford.Core
{
    class GlobalEnums
    {
        public enum Browser
        {
            Chrome,
            Firefox
        }
        public enum HomePageElements
        {
            about,
            contact,
            faceBook
        }
        public enum Locators
        {
            XPath,
            Id,
            CssSelector,
            Name,
            LinkText
        }
    }
}
