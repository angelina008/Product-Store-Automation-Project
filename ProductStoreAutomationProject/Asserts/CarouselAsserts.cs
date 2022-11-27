using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Asserts
{
    class CarouselAsserts : CarouselElements
    {
        public CarouselAsserts(IWebDriver driver) : base(driver) { }

        public bool CarouselIsDisplayed()
        {
            Thread.Sleep(2000);  //needs to be changed with other type of waiting
            return CarouselBody() != null && CarouselBody().Displayed;
        }
    }
}
