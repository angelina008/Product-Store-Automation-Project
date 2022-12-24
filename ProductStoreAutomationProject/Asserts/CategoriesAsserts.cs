using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Asserts
{
    class CategoriesAsserts : CategoriesElements
    {
        public CategoriesAsserts(IWebDriver driver) : base(driver)
        {
        }

        public bool CategoriesTableIsDisplayed()
        {
            return CategoriesTable() != null && CategoriesTable().Displayed;
        }

        public bool ProductNameIsEqualTo(int i, string productName)
        {
            return ProductName(i).Text != null && ProductName(i).Text == productName;
        }

        public bool PreviousButtonIsDisplayed()
        {
            return ProductListPreviousButton().Text != null && ProductListPreviousButton().Displayed;
        }

        public bool NextButtonIsDisplayed()
        {
            return ProductListNextButton().Text != null && ProductListNextButton().Displayed;
        }
    }
}
