using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class TopMenuBarElements : MainTest
    {
        DriverCommands driverCommands;
        public TopMenuBarElements(IWebDriver driver) : base(driver) 
        {
            driverCommands = new(driver);
        }

        public IWebElement ProductStoreLogo()
        {
            return driverCommands.FindElementUntilClickable(By.Id("nava"));
        }

        public IWebElement TopMenuBarHomeTab()
        {
            return driver.FindElement(By.XPath("//*[@id=\"navbarExample\"]/ul/li[1]/a")); 
        }

        public IWebElement TopMenuBarContactTab()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"navbarExample\"]/ul/li[2]/a"));
        }

        public IWebElement TopMenuBarAboutUsTab()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"navbarExample\"]/ul/li[3]/a"));
        }

        public IWebElement TopMenuBarCartTab()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"navbarExample\"]/ul/li[4]/a"));
        }

        public IWebElement TopMenuBarLogInTab()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"navbarExample\"]/ul/li[5]/a"));
        }

        public IWebElement TopMenuBarLogOutTab()
        {
            return driverCommands.FindElementUntilClickable(By.Id("logout2"));
        }

        public IWebElement TopMenuBarSingUpTab()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"signin2\"]"));
        }
    }
}
