using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class LogInPopUpElements : MainTest
    {
        DriverCommands driverCommands;
        public LogInPopUpElements(IWebDriver driver) : base(driver) 
        {
            driverCommands = new(driver);
        }

        public IWebElement LogInPopUpTitle()
        {
            return driverCommands.FindElementUntilVisible(By.Id("logInModalLabel"));
        }

        public IWebElement PopUpXButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"logInModal\"]/div/div/div[1]/button"));
        }

        public IWebElement LogInUsernameTextBox()
        {
            return driverCommands.FindElementUntilVisible(By.Id("loginusername"));
        }

        public IWebElement LogInPasswordTextBox()
        {
            return driverCommands.FindElementUntilClickable(By.Id("loginpassword"));
        }

        public IWebElement CloseButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"logInModal\"]/div/div/div[3]/button[1]"));
        }

        public IWebElement LogInButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"logInModal\"]/div/div/div[3]/button[2]"));
        }

        public IWebElement LogInWelcomeUserText()
        {
            return driverCommands.FindElementUntilVisible(By.Id("nameofuser"));
        }
    }
}
