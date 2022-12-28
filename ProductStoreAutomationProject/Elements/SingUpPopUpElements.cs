using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class SingUpPopUpElements : MainTest
    {
        DriverCommands driverCommands;
        public SingUpPopUpElements(IWebDriver driver) : base(driver) 
        {
            driverCommands = new(driver);
        }

        public IWebElement SingUpPopUpTitle()
        {
            return driverCommands.FindElementUntilVisible(By.Id("signInModalLabel"));
        }

        public IWebElement PopUpXButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"signInModal\"]/div/div/div[1]/button"));
        }

        public IWebElement SingUpUsernameTextBox()
        {
            return driverCommands.FindElementUntilVisible(By.Id("sign-username"));
        }

        public IWebElement SingUpPasswordTextBox()
        {
            return driverCommands.FindElementUntilClickable(By.Id("sign-password"));
        }

        public IWebElement CloseButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"signInModal\"]/div/div/div[3]/button[1]"));
        }

        public IWebElement SingUpButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"signInModal\"]/div/div/div[3]/button[2]"));
        }

    }
}
