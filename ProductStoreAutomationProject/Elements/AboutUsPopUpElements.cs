using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class AboutUsPopUpElements : MainTest
    {
        public AboutUsPopUpElements(IWebDriver driver) : base(driver) { }

        public IWebElement AboutUsPopUpTitle()
        {
            return driver.FindElement(By.Id("videoModalLabel"));
        }

        public IWebElement PopUpXButton()
        {
            return driver.FindElement(By.XPath("//*[@id=\"videoModal\"]/div/div/div[1]/button")); 
        }
    }
}
