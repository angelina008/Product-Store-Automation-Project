using NUnit.Framework;
using OpenQA.Selenium;
using ProductStoreAutomationProject.Asserts;
using ProductStoreAutomationProject.Commands;

namespace ProductStoreAutomationProject.Tests.HomePageTests
{
    class OpenProductDetailsTest : MainTest
    {
        [Test]
        public void OpenProductDetailsPageTest()
        {
            CategoriesCommands categoriesCommands = new(driver);
            ProductDescriptionPageAsserts productDescriptionPageAsserts = new(driver);
            TopMenuBarCommands topMenuBarCommands = new(driver);
            CarouselAsserts carouselAsserts = new(driver);
            DriverCommands driverCommands = new(driver);
            CategoriesAsserts categoriesAsserts = new(driver);
            var firstMonitor = "Apple monitor 24";

            for (int i = 1; i <= 9; i++)
            {
                Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
                var productName = categoriesCommands.ProductName(i).Text;
                categoriesCommands.ClickOnProductName(i);
                Assert.Multiple(() =>
                {
                    Assert.That(productDescriptionPageAsserts.ProductNameTitleIsDisplayed(), Is.True, "Product Title is not displayed, not on Product Details Page.");
                    Assert.That(productDescriptionPageAsserts.ProductNameTitleIsEqualToProductName(productName), Is.True, "Prouct Title is not correct.");
                    Assert.That(productDescriptionPageAsserts.ProductPriceIsDisplayed(), Is.True, "Product Price is not displayed.");
                    Assert.That(productDescriptionPageAsserts.ProductDescriptionIsDisplayed(), Is.True, "Product Description is not displayed.");
                    Assert.That(productDescriptionPageAsserts.AddToCartButtonIsDisplayed(), Is.True, "Product Add to cart button is not displayed.");
                    Assert.That(productDescriptionPageAsserts.ProductPhotoIsDisplayed(), Is.True, "Product Price is not displayed.");
                });
                topMenuBarCommands.ClickOnProductStoreLogo();
                Thread.Sleep(1500);
            }

            for (int i = 1; i <= 6; i++)
            {
                Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
                driverCommands.ScrollToEndOfPage();
                categoriesCommands.ClickOnProductListNextButton();
                driverCommands.ScrollToTopOfPage();
                Assert.That(categoriesAsserts.ProductNameIsEqualTo(1, firstMonitor), Is.True, $"The name \"{firstMonitor}\" of the product is not correct.");
                var productName = categoriesCommands.ProductName(i).Text;
                categoriesCommands.ClickOnProductName(i);
                Assert.Multiple(() =>
                {
                    Assert.That(productDescriptionPageAsserts.ProductNameTitleIsDisplayed(), Is.True, "Product Title is not displayed, not on Product Details Page.");
                    Assert.That(productDescriptionPageAsserts.ProductNameTitleIsEqualToProductName(productName), Is.True, "Prouct Title is not correct.");
                    Assert.That(productDescriptionPageAsserts.ProductPriceIsDisplayed(), Is.True, "Product Price is not displayed.");
                    Assert.That(productDescriptionPageAsserts.ProductDescriptionIsDisplayed(), Is.True, "Product Description is not displayed.");
                    Assert.That(productDescriptionPageAsserts.AddToCartButtonIsDisplayed(), Is.True, "Product Add to cart button is not displayed.");
                    Assert.That(productDescriptionPageAsserts.ProductPhotoIsDisplayed(), Is.True, "Product Price is not displayed.");
                });
                topMenuBarCommands.ClickOnProductStoreLogo();
                Thread.Sleep(1500);
            }
        }
    }
}
