using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo_Crawford.Core;

namespace TestDemo_Crawford.Pages
{
    class HomePage
    {
        public static string ReturnWebelements(GlobalEnums.HomePageElements homePageElements)
        {
            switch (homePageElements)
            {
                case (GlobalEnums.HomePageElements.about):
                    return "//a[@href='https://www.crawco.co.uk/about/our-story'][contains(text(),'About')]";
                case (GlobalEnums.HomePageElements.contact):
                    return "//div[@class='c-footer__nav-row']/nav[3]/ul/li[8]/a";
                case (GlobalEnums.HomePageElements.faceBook):
                    return "//a[@href='https://www.facebook.com/crawfordandco'][contains(text(),'Facebook')]";
                default: return null;

            }
                
        }
    }
}
