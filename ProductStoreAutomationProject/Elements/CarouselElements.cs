using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class CarouselElements : MainTest
    {
        public CarouselElements(IWebDriver driver) : base(driver) { }

        public IWebElement CarouselBody()
        {
            return driver.FindElement(By.Id("carouselExampleIndicators"));
        }
    }
}
