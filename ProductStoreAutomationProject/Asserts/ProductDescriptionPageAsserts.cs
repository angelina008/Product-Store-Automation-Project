using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Asserts
{
    class ProductDescriptionPageAsserts : ProductDescriptionPageElements
    {
        public ProductDescriptionPageAsserts(IWebDriver driver) : base(driver)
        {
        }

        public bool ProductNameTitleIsDisplayed()
        {
            return ProductNameTitle() != null && ProductNameTitle().Displayed;
        }

        public bool ProductNameTitleIsEqualToProductName(string productName)
        {
            return ProductNameTitle() != null && ProductNameTitle().Text == productName;
        }

        public bool ProductPriceIsDisplayed()
        {
            return ProductPrice() != null && ProductPrice().Displayed;
        }

        public bool ProductDescriptionIsDisplayed()
        {
            return ProductDescription() != null && ProductDescription().Displayed;
        }

        public bool AddToCartButtonIsDisplayed()
        {
            return AddToCartButton() != null && AddToCartButton().Displayed;
        }

        public bool ProductPhotoIsDisplayed()
        {
            return ProductPhoto() != null && ProductPhoto().Displayed;
        }
    }
}
