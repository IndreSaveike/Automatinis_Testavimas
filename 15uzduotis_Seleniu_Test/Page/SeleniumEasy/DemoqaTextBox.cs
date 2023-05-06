using _15uzduotisSeleniumFramework;
using _15uzduotisSeleniumFramework.Pages;
using OpenQA.Selenium;
using System;

namespace _15uzduotisSeleniumFramework.Pages.SeleniumEasy
{
    public class DemoqaTextBox
    {

        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/text-box");
        }

        public static void EnterUserName(string userName)
        {
            string locator = "//*[@id='userName']";
            Common.SendKeys(locator, userName);
        }

        public static void EnterUserEmail(string userEmail)
        {
            string locator = "//*[@id='userEmail']";
            Common.SendKeys(locator, userEmail);
        }

        public static void EnterCurrentAddress(string currentAddress)
        {
            string locator = "//*[@id='currentAddress']";
            Common.SendKeys(locator, currentAddress);
        }

        public static void EnterPermanentAddress(string permanentAddress)
        {
            string locator = "//*[@id='permanentAddress']";
            Common.SendKeys(locator, permanentAddress);
        }

        public static void ClickSubmit()
        {
            string locator = "//*[@id='submit']";
            Common.Click(locator);
        }

        public static string GetNameText()
        {
            string locator = "//*[@id='name']";
            return Common.GetElementText(locator);
        }

        public static string GetEmailText()
        {
            string locator = "//*[@id='email']";
            return Common.GetElementText(locator);
        }

        public static string GetCurrentAddressText()
        {
            string locator = "//*[@id='output']//*[contains(@id,'currentAddress')]";
            return Common.GetElementText(locator);
        }

        public static string GetPermanentAddressText()
        {
            string locator = "//*[@id='output']//*[contains(@id,'permanentAddress')]";
            return Common.GetElementText(locator);
        }
    }
}
