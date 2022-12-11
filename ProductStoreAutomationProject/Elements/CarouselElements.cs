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
        public IWebElement CarouselFirstImage()
        {
            return driver.FindElement(By.XPath("//*[@id=\"carouselExampleIndicators\"]/div/div[1]/img"));
        }
        public IWebElement CarouselSecondImage()
        {
            return driver.FindElement(By.XPath("//*[@id=\"carouselExampleIndicators\"]/div/div[2]/img"));
        }
        public IWebElement CarouselThirdImage()
        {
            return driver.FindElement(By.XPath("//*[@id=\"carouselExampleIndicators\"]/div/div[3]/img"));
        }

        public IWebElement CarouselPrevButton()
        {
            return driver.FindElement(By.XPath("//*[@id=\"carouselExampleIndicators\"]/a[1]"));
        }
        public IWebElement CarouselNextButton()
        {
            return driver.FindElement(By.XPath("//*[@id=\"carouselExampleIndicators\"]/a[2]"));
        }
    }
}
