using System;
using NUnit.Framework;
using _15uzduotisSeleniumFramework;
using _15uzduotisSeleniumFramework.Pages.SeleniumEasy;
using OpenQA.Selenium;

namespace _15uzduotisSeleniumTests.SeleniumEasy
{
    [TestFixture]
    public class DemoqaTextBoxTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.InitializeDriver();
            DemoqaTextBox.Open();
        }

        [Test]
        public void FillAllFieldsAndCheckDisplayedInfo()
        {
            DemoqaTextBox.EnterUserName("Jonas Jonaitis");
            DemoqaTextBox.EnterUserEmail("jonas.jonaitis@example.com");
            DemoqaTextBox.EnterCurrentAddress("Gatvės adresas 1");
            DemoqaTextBox.EnterPermanentAddress("Gatvės adresas 2");
            DemoqaTextBox.ClickSubmit();

            StringAssert.Contains("Jonas Jonaitis", DemoqaTextBox.GetNameText());
            StringAssert.Contains("jonas.jonaitis@example.com", DemoqaTextBox.GetEmailText());
            StringAssert.Contains("Gatvės adresas 1", DemoqaTextBox.GetCurrentAddressText());
            StringAssert.Contains("Gatvės adresas 2", DemoqaTextBox.GetPermanentAddressText());
        }

        [Test]
        public void TestInvalidEmailInput()
        {
            DemoqaTextBox.EnterUserName("Jonas Jonaitis");
            DemoqaTextBox.EnterUserEmail("jonas.jonaitis.example.com");
            DemoqaTextBox.EnterCurrentAddress("Gatvės adresas 1");
            DemoqaTextBox.EnterPermanentAddress("Gatvės adresas 2");
            DemoqaTextBox.ClickSubmit();

            string fieldErrorClass = "field-error";
            IWebElement userEmailField = Driver.GetDriver().FindElement(By.XPath("//*[@id='userEmail']"));
            string userEmailFieldClasses = userEmailField.GetAttribute("class");

            Assert.IsTrue(userEmailFieldClasses.Contains(fieldErrorClass), "Test failed: Email field does not have 'field-error' class.");
        }

        [TearDown]
        public void TearDown()
        {
           // Driver.ShutdownDriver();
        }
    }
}
