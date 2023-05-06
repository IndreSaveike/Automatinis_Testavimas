using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQATest
{
    [TestFixture]
    public class InvalidEmailFormatTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");
        }

        [Test]
        public void FillAllFieldsAndCheckDisplayedInfo()
        {
            // Fill all fields
            IWebElement userNameField = driver.FindElement(By.XPath("//*[@id='userName']"));
            userNameField.SendKeys("Jonas Jonaitis");

            IWebElement userEmailField = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            userEmailField.SendKeys("jonas.jonaitis@example.com");

            IWebElement currentAddressField = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            currentAddressField.SendKeys("Gatvės adresas 1");

            IWebElement permanentAddressField = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            permanentAddressField.SendKeys("Gatvės adresas 2");

            // Click submit button
            IWebElement submitButton = driver.FindElement(By.XPath("//*[@id='submit']"));
            submitButton.Click();

            // Check displayed info
            string name = driver.FindElement(By.XPath("//*[@id='name']"))
                .Text;
            string email = driver.FindElement(By.XPath("//*[@id='email']"))
                .Text;
            string currentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[contains(@id,'currentAddress')]"))
                .Text;
            string permanentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[contains(@id,'permanentAddress')]"))
                .Text;

            StringAssert.Contains("Jonas Jonaitis", name);
            StringAssert.Contains("jonas.jonaitis@example.com", email);
            StringAssert.Contains("Gatvės adresas 1", currentAddress);
            StringAssert.Contains("Gatvės adresas 2", permanentAddress);
        }

        [Test]
        public void TestInvalidEmailInput()
        {
        

            IWebElement userNameField = driver.FindElement(By.XPath("//*[@id='userName']"));
            IWebElement userEmailField = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement currentAddressField = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement permanentAddressField = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            IWebElement submitButton = driver.FindElement(By.XPath("//*[@id='submit']"));

            userNameField.SendKeys("Jonas Jonaitis");
            userEmailField.SendKeys("jonas.jonaitis.example.com");
            currentAddressField.SendKeys("Gatvės adresas 1");
            permanentAddressField.SendKeys("Gatvės adresas 2");

            submitButton.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(userEmailField));

            string fieldErrorClass = "field-error";
            string userEmailFieldClasses = userEmailField.GetAttribute("class");

            Assert.IsTrue(userEmailFieldClasses.Contains(fieldErrorClass), "Test failed: Email field does not have 'field-error' class.");
        }

        [TearDown]
        public void TearDown()
        {
         driver.Quit();
        }
    }
}

