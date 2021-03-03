using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo_Crawford.Core;

namespace TestDemo_Crawford.Utilities
{
    class BrowserManagement
    {
        public static IWebDriver driver = GlobalDriverHook.driver;
        public static string testURL = Testdata.Browser.url;
        

        public static void LaunchBrowser(GlobalEnums.Browser browser)
        {
            switch (browser)
            {
                case GlobalEnums.Browser.Chrome:
                    driver = new ChromeDriver();
                    break;
                case GlobalEnums.Browser.Firefox:
                    driver = new ChromeDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;

            }
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(testURL);
        }
        public static void CloseBrowser()
        {
            driver.Close();
        }
    }
}
