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
    }
}
