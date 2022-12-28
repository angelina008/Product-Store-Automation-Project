using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Commands
{
    class ProductDescriptionPageCommands : ProductDescriptionPageElements
    {
        public ProductDescriptionPageCommands(IWebDriver driver) : base(driver)
        {
        }

        public void ClickOnAddToCartButton()
        {
            AddToCartButton().Click();
            Thread.Sleep(1500);
        }
    }
}
