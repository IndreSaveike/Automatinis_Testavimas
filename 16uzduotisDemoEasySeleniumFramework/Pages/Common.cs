using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace _16uzduotisDemoEasySeleniumFramework
{
    public class Common
    {
        private static IWebDriver driver = Driver.Instance;

        public static IWebElement FindElement(string xpath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(d => d.FindElement(By.XPath(xpath)));
        }

        public static void ClickElement(string xpath)
        {
            FindElement(xpath).Click();
        }

        public static bool WaitForTextToAppear(string xpath, string text)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(d => d.FindElement(By.XPath(xpath)).Text.Contains(text));
        }

        public static bool WaitForTextToAppearById(string id, string text)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(d => d.FindElement(By.Id(id)).Text.Contains(text));
        }
    }
}
