using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Asserts
{
    class CarouselAsserts : CarouselElements
    {
        public CarouselAsserts(IWebDriver driver) : base(driver) { }

        public bool CarouselIsDisplayed()
        {
            Thread.Sleep(1000); 
            return CarouselBody() != null && CarouselBody().Displayed;
        }

        public bool FirstImageIsDisplayed()
        {
            Thread.Sleep(100);
            return CarouselFirstImage() != null && CarouselFirstImage().Displayed;
        }

        public bool SecondImageIsDisplayed()
        {
            Thread.Sleep(100);
            return CarouselSecondImage() != null && CarouselSecondImage().Displayed;
        }

        public bool ThirdImageIsDisplayed()
        {
            Thread.Sleep(100);
            return CarouselThirdImage() != null && CarouselThirdImage().Displayed;
        }
    }
}
