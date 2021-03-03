using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo_Crawford.Core;
using TestDemo_Crawford.Utilities;
using TestDemo_Crawford.Pages;
using OpenQA.Selenium;
using TestDemo_Crawford.Testdata;

namespace TestDemo_Crawford.Test
{
    class TestWeburl
    {
        [SetUp]
        public static void StartTest()
        {
            BrowserManagement.LaunchBrowser(GlobalEnums.Browser.Chrome);
        }
        [Test]
        public static void VerifyFacebookURL()
        {
            try
            {
                IWebDriver driver = BrowserManagement.driver;
                Assert.AreEqual(driver.Title, TestdataValidation.homePageTitle);

                UserAction.ButtonClick(driver, GlobalEnums.Locators.XPath, HomePage.ReturnWebelements(GlobalEnums.HomePageElements.about));
                UserAction.ButtonClick(driver, GlobalEnums.Locators.XPath, HomePage.ReturnWebelements(GlobalEnums.HomePageElements.contact));
                string faceBookUrl = UserAction.GetUrl(driver, GlobalEnums.Locators.XPath, HomePage.ReturnWebelements(GlobalEnums.HomePageElements.faceBook));

                Console.WriteLine(faceBookUrl);
                Assert.AreEqual(faceBookUrl, TestdataValidation.crawfordFacebookURL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }           


        }
        [TearDown]
        public static void CloseBrowser()
        {
            BrowserManagement.CloseBrowser();
        }

    }
}
