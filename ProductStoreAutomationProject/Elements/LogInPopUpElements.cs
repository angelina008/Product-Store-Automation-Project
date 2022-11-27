using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class LogInPopUpElements : MainTest
    {
        public LogInPopUpElements(IWebDriver driver) : base(driver) { }

        public IWebElement LogInPopUpTitle()
        {
            return driver.FindElement(By.Id("logInModalLabel"));
        }

        public IWebElement PopUpXButton()
        {
            return driver.FindElement(By.XPath("//*[@id=\"logInModal\"]/div/div/div[1]/button"));
        }
    }
}
