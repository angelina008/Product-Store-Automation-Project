using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Asserts
{
    class CartPageAsserts : CartPageElements
    {
        public CartPageAsserts(IWebDriver driver) : base(driver) { }

        public bool ProductCartTableIsDisplayed()
        {
            Thread.Sleep(2000);
            return ProductCartTable() != null && ProductCartTable().Displayed;
        }

        public bool NumberOfProductsInCartIsEqualTo(int n)
        {
            Thread.Sleep(2000);
            return NumberOfProductsInCart() == n;
        }
    }
}
