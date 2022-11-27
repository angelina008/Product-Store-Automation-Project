using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class ContactPopUpElements : MainTest
    {
        public ContactPopUpElements(IWebDriver driver) : base(driver) { }

        public IWebElement ContactPopUpTitle()
        {
            return driver.FindElement(By.Id("exampleModalLabel"));
        }

        public IWebElement PopUpXButton()
        {
            return driver.FindElement(By.XPath("//*[@id=\"exampleModal\"]/div/div/div[1]/button"));
        }
    }
}
