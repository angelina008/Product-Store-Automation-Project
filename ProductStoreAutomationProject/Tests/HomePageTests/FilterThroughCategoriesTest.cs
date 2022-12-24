using NUnit.Framework;
using ProductStoreAutomationProject.Asserts;
using ProductStoreAutomationProject.Commands;

namespace ProductStoreAutomationProject.Tests.HomePageTests
{
    class FilterThroughCategoriesTest : MainTest
    {

        [Test]
        public void FilterCategoriesTest()
        {
            CategoriesCommands categoriesCommands = new(driver);
            CategoriesAsserts categoriesAsserts = new(driver);
            DriverCommands driverCommands = new(driver);
            var firstPhone = "Samsung galaxy s6";
            var firstLaptop = "Sony vaio i5";
            var firstMonitor = "Apple monitor 24";

            Assert.That(categoriesAsserts.CategoriesTableIsDisplayed(), Is.True, "Categories Table is not displayed.");
            categoriesCommands.ClickOnCategoriesTitle();
            Assert.That(categoriesAsserts.ProductNameIsEqualTo(1, firstPhone), Is.True, $"The name \"{firstPhone}\" of the product is not correct.");
            Assert.That(categoriesAsserts.NumberOfProducts(), Is.EqualTo(9), "Products are missing.");
            categoriesCommands.ClickOnCategoriesPhones();
            Assert.That(categoriesAsserts.ProductNameIsEqualTo(1, firstPhone), Is.True, $"The name \"{firstPhone}\" of the product is not correct.");
            Assert.That(categoriesAsserts.NumberOfProducts(), Is.EqualTo(7), "Products are missing.");
            categoriesCommands.ClickOnCategoriesLaptops();
            Assert.That(categoriesAsserts.ProductNameIsEqualTo(1, firstLaptop), Is.True, $"The name \"{firstLaptop}\" of the product is not correct.");
            Assert.That(categoriesAsserts.NumberOfProducts(), Is.EqualTo(6), "Products are missing.");
            categoriesCommands.ClickOnCategoriesMonitors();
            Assert.That(categoriesAsserts.ProductNameIsEqualTo(1, firstMonitor), Is.True, $"The name \"{firstMonitor}\" of the product is not correct.");
            Assert.That(categoriesAsserts.NumberOfProducts(), Is.EqualTo(2), "Products are missing.");
            categoriesCommands.ClickOnCategoriesTitle();
            Assert.That(categoriesAsserts.ProductNameIsEqualTo(1, firstPhone), Is.True, $"The name \"{firstPhone}\" of the product is not correct.");
            Assert.That(categoriesAsserts.NumberOfProducts(), Is.EqualTo(9), "Products are missing.");

            driverCommands.ScrollToEndOfPage();
            Assert.That(categoriesAsserts.PreviousButtonIsDisplayed(), Is.True, "Previous button is not displayed.");
            Assert.That(categoriesAsserts.NextButtonIsDisplayed(), Is.True, "Next button is not displayed.");
            categoriesCommands.ClickOnProductListNextButton();
            driverCommands.ScrollToTopOfPage();
            Assert.That(categoriesAsserts.ProductNameIsEqualTo(1, firstMonitor), Is.True, $"The name \"{firstMonitor}\" of the product is not correct.");
            driverCommands.ScrollToEndOfPage();
            Assert.That(categoriesAsserts.PreviousButtonIsDisplayed(), Is.True, "Previous button is not displayed.");
            categoriesCommands.ClickOnProductListPreviousButton();
            Assert.That(categoriesAsserts.PreviousButtonIsDisplayed(), Is.True, "Previous button is not displayed.");
            Assert.That(categoriesAsserts.NextButtonIsDisplayed(), Is.True, "Next button is not displayed.");
            driverCommands.ScrollToTopOfPage();
            Assert.That(categoriesAsserts.ProductNameIsEqualTo(1, firstPhone), Is.False, $"The name \"{firstPhone}\" of the product is not correct."); //BUG
        }
    }
}
