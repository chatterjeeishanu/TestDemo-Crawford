using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo_Crawford.Core;

namespace TestDemo_Crawford.Utilities
{
    class GenericHelpers
    {
        public static void WaitForElements(IWebDriver driver, GlobalEnums.Locators locatorType, string locatorValue)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                switch (locatorType)
                {
                    case GlobalEnums.Locators.XPath:
                        wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
                        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
                        break;

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);                
            }
            
            
        }
        public static IRestResponse CallAPI(string enteredClient, string enteredRequest)
        {
            try
            {
                RestClient client = new RestClient(enteredClient);
                RestRequest request = new RestRequest(enteredRequest, Method.GET);
                IRestResponse response = client.Execute(request);
                return response;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
