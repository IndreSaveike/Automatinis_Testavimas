using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _15uzduotisSeleniumFramework
{
    public class Driver
    {
        private static IWebDriver driver = null!;

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        internal static void OpenPage(string url)
        {
            driver.Url = url;
        }

        public static void ShutdownDriver()
        {
            driver.Quit();
        }
    }
}