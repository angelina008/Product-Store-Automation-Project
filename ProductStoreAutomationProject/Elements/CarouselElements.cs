using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class CarouselElements : MainTest
    {
        DriverCommands driverCommands;
        public CarouselElements(IWebDriver driver) : base(driver) 
        {
            driverCommands = new(driver);
        }

        public IWebElement CarouselBody()
        {
            return driverCommands.FindElementUntilVisible(By.Id("carouselExampleIndicators"));
        }
        public IWebElement CarouselFirstImage()
        {
            return driverCommands.FindElementUntilVisible(By.XPath("//*[@id=\"carouselExampleIndicators\"]/div/div[1]/img"));
        }
        public IWebElement CarouselSecondImage()
        {
            return driverCommands.FindElementUntilVisible(By.XPath("//*[@id=\"carouselExampleIndicators\"]/div/div[2]/img"));
        }
        public IWebElement CarouselThirdImage()
        {
            return driverCommands.FindElementUntilVisible(By.XPath("//*[@id=\"carouselExampleIndicators\"]/div/div[3]/img"));
        }

        public IWebElement CarouselPrevButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"carouselExampleIndicators\"]/a[1]"));
        }
        public IWebElement CarouselNextButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"carouselExampleIndicators\"]/a[2]"));
        }
    }
}
