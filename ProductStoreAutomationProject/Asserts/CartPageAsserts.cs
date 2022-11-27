using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Asserts
{
    class CartPageAsserts : CartPageElements
    {
        public CartPageAsserts(IWebDriver driver) : base(driver) { }

        public bool ProductCartTableIsDisplayed()
        {
            Thread.Sleep(2000);  //needs to be changed with other type of waiting
            return ProductCartTable() != null && ProductCartTable().Displayed;
        }
    }
}
