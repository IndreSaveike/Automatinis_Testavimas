using _16uzduotisDemoEasySeleniumFramework;
using _16uzduotisDemoEasySeleniumFramework.Pages;
using NUnit.Framework;

namespace _16uzduotisDemoEasySeleniumTest
{
    [TestFixture]
    public class DemoEasyTest
    {
        private DemoSeleniumEasyPage demoPage;

        [SetUp]
        public void Init()
        {
            Driver.InitializeDriver();
            demoPage = new DemoSeleniumEasyPage();
            demoPage.Open();
        }

        [Test]
        public void TestUserInformationAppears()
        {
            demoPage.ClickGetUserButton();
            Assert.IsTrue(demoPage.UserInformationAppeared(), "Vartotojo informacija neatėjo.");
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.ShutdownDriver();

        }
    }
}