using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class AboutUsPopUpElements : MainTest
    {
        DriverCommands driverCommands;
        public AboutUsPopUpElements(IWebDriver driver) : base(driver) 
        {
            driverCommands = new(driver);
        }

        public IWebElement AboutUsPopUpTitle()
        {
            return driverCommands.FindElementUntilVisible(By.Id("videoModalLabel"));
        }

        public IWebElement PopUpXButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"videoModal\"]/div/div/div[1]/button")); 
        }
    }
}
