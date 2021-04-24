using OpenMRS.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace OpenMRS.Environment
{
   public class TestEnvironment
    {
        public static IWebDriver driver;
        public EnvironmentDetails EnvironmentDetails;
        public TestEnvironment()
        {
            this.EnvironmentDetails = new EnvironmentDetails();
        }
        public void SetupTestEnvironment()
        {
            switch(EnvironmentDetails.browser)
            {
                case Browsers.CHROME:
                    driver = new ChromeDriver();
                    driver.Url = EnvironmentDetails.baseUrl;
                    break;
                case Browsers.FIREFOX:
                    driver = new FirefoxDriver();
                    driver.Url = EnvironmentDetails.baseUrl;
                    break;
                default:
                    driver = new ChromeDriver();
                    driver.Url = EnvironmentDetails.baseUrl;
                    break;
            }
            driver.Manage().Window.Maximize();
        }

        
    }
}
