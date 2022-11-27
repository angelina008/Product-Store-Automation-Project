using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class SingUpPopUpElements : MainTest
    {
        public SingUpPopUpElements(IWebDriver driver) : base(driver) { }

        public IWebElement SingUpPopUpTitle()
        {
            return driver.FindElement(By.Id("signInModalLabel"));
        }

        public IWebElement PopUpXButton()
        {
            return driver.FindElement(By.XPath("//*[@id=\"signInModal\"]/div/div/div[1]/button"));
        }
    }
}
