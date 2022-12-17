using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class ContactPopUpElements : MainTest
    {
        DriverCommands driverCommands;
        public ContactPopUpElements(IWebDriver driver) : base(driver) 
        {
            driverCommands = new(driver);
        }

        public IWebElement ContactPopUpTitle()
        {
            return driverCommands.FindElementUntilVisible(By.Id("exampleModalLabel"));
        }

        public IWebElement PopUpXButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"exampleModal\"]/div/div/div[1]/button"));
        }
    }
}
