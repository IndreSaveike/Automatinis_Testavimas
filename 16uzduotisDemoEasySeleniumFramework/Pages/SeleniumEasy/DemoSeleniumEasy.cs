namespace _16uzduotisDemoEasySeleniumFramework.Pages
{
    public class DemoSeleniumEasyPage
    {
        private const string GetUserButtonLocator = "//*[@id='save']";
        private const string UserElementLocator = "loading";

        public void Open()
        {
            Driver.Instance.Navigate().GoToUrl("https://demo.seleniumeasy.com/dynamic-data-loading-demo.html");
        }

        public void ClickGetUserButton()
        {
            Common.ClickElement(GetUserButtonLocator);
        }

        public bool UserInformationAppeared()
        {
            return Common.WaitForTextToAppearById(UserElementLocator, "First Name :") && Common.WaitForTextToAppearById(UserElementLocator, "Last Name :");
        }
    }
}
