using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _16uzduotisDemoEasySeleniumFramework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static IWebDriver Instance
        {
            get { return driver; }
        }

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
        }

        public static void ShutdownDriver()
        {
            driver.Quit();
        }
    }
}