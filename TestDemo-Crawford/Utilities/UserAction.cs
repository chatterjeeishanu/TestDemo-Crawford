using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo_Crawford.Core;

namespace TestDemo_Crawford.Utilities
{
    class UserAction
    {
        public static void ButtonClick(IWebDriver driver, GlobalEnums.Locators locatorType, string locatorValue)
        {
            try
            {
                switch (locatorType)
                {
                    case GlobalEnums.Locators.XPath:
                        GenericHelpers.WaitForElements(driver, locatorType, locatorValue);
                        driver.FindElement(By.XPath(locatorValue)).Click();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public static string GetUrl(IWebDriver driver, GlobalEnums.Locators locatorType, string locatorValue)
        {
            try
            {
                switch (locatorType)
                {
                    case GlobalEnums.Locators.XPath:
                        GenericHelpers.WaitForElements(driver, locatorType, locatorValue);
                        string url = driver.FindElement(By.XPath(locatorValue)).GetAttribute("href");
                        return url;
                        break;
                    default: return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
