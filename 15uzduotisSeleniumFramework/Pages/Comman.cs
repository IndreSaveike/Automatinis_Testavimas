using OpenQA.Selenium;
using _15uzduotisSeleniumFramework;

namespace _15uzduotisSeleniumFramework.Pages
{
    public class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        public static void Click(string locator)
        {
            GetElement(locator).Click();
        }

        public static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        public static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }
    }
}