using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class CartPageElements : MainTest
    {
        public CartPageElements(IWebDriver driver) : base(driver) { }

        public IWebElement ProductCartTable()
        {
            return driver.FindElement(By.ClassName("table-responsive"));
        }
    }
}
