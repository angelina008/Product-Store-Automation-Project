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
    }
}
