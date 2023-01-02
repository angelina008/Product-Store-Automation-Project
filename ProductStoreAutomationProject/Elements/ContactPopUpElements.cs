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

        public IWebElement CloseButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"exampleModal\"]/div/div/div[3]/button[1]"));
        }

        public IWebElement SendMessageButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"exampleModal\"]/div/div/div[3]/button[2]"));
        }

        public IWebElement ContactEmailTextBox()
        {
            return driverCommands.FindElementUntilClickable(By.Id("recipient-email"));
        }

        public IWebElement ContactNameTextBox()
        {
            return driverCommands.FindElementUntilClickable(By.Id("recipient-name"));
        }

        public IWebElement MessageTextBox()
        {
            return driverCommands.FindElementUntilClickable(By.Id("message-text"));
        }
    }
}
