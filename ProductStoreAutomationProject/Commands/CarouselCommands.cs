using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Commands
{
    class CarouselCommands : CarouselElements
    {
        public CarouselCommands(IWebDriver driver) : base(driver)
        {
        }

        public void ClickOnPrevButton()
        {
            CarouselPrevButton().Click();
            Thread.Sleep(400);
        }

        public void ClickOnNextButton()
        {
            CarouselNextButton().Click();
            Thread.Sleep(400);
        }

        public void WaitForImageToChange()
        {
            Thread.Sleep(5500);
        }
    }
}
