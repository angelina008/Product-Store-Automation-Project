using NUnit.Framework;
using ProductStoreAutomationProject.Asserts;
using ProductStoreAutomationProject.Commands;

namespace ProductStoreAutomationProject.Tests.PurchaseProductTests
{
    class AddProductToCartTest : MainTest
    {
        [Test]
        public void AddProductToCart()
        {
            CarouselAsserts carouselAsserts = new(driver);
            LogInPopUpCommands logInPopUpCommands = new(driver);
            PopUpAsserts popUpAsserts = new(driver);
            TopMenuBarCommands topMenuBarCommands = new(driver);
            DriverCommands driverCommands = new(driver);
            CategoriesCommands categoriesCommands = new(driver);
            ProductDescriptionPageAsserts productDescriptionPageAsserts = new(driver);
            CategoriesAsserts categoriesAsserts = new(driver);
            ProductDescriptionPageCommands productDescriptionPageCommands = new(driver);
            CartPageAsserts cartPageAsserts = new(driver);
            CartPageCommands cartPageCommands = new(driver);
            var productName1 = categoriesCommands.ProductName(1).Text;
            var productName2 = categoriesCommands.ProductName(2).Text;

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            topMenuBarCommands.ClickOnLogInTab();
            Assert.That(popUpAsserts.LogInPopUpIsDisplayed(), Is.True, "Log In pop up is not displayed");
            logInPopUpCommands.InsertTextInUsernameTextBox("AngelinaQA");
            logInPopUpCommands.InsertTextInPasswordTextBox("P@ssw0rd");
            logInPopUpCommands.ClickOnLogInButton();
            Assert.That(popUpAsserts.LogInWelcomeUserIsDisplayed(), Is.True, "Welcome User is not displayed");
            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            categoriesCommands.ClickOnProductName(1);
            Assert.Multiple(() =>
            {
                Assert.That(productDescriptionPageAsserts.ProductNameTitleIsDisplayed(), Is.True, "Product Title is not displayed, not on Product Details Page.");
                Assert.That(productDescriptionPageAsserts.ProductNameTitleIsEqualToProductName(productName1), Is.True, "Prouct Title is not correct.");
                Assert.That(productDescriptionPageAsserts.ProductPriceIsDisplayed(), Is.True, "Product Price is not displayed.");
                Assert.That(productDescriptionPageAsserts.ProductDescriptionIsDisplayed(), Is.True, "Product Description is not displayed.");
                Assert.That(productDescriptionPageAsserts.AddToCartButtonIsDisplayed(), Is.True, "Product Add to cart button is not displayed.");
                Assert.That(productDescriptionPageAsserts.ProductPhotoIsDisplayed(), Is.True, "Product Price is not displayed.");
            });
            productDescriptionPageCommands.ClickOnAddToCartButton();
            driverCommands.ClickOkOnPopUp();
            topMenuBarCommands.ClickOnProductStoreLogo();

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            categoriesCommands.ClickOnProductName(2);
            Assert.Multiple(() =>
            {
                Assert.That(productDescriptionPageAsserts.ProductNameTitleIsDisplayed(), Is.True, "Product Title is not displayed, not on Product Details Page.");
                Assert.That(productDescriptionPageAsserts.ProductNameTitleIsEqualToProductName(productName2), Is.True, "Prouct Title is not correct.");
                Assert.That(productDescriptionPageAsserts.ProductPriceIsDisplayed(), Is.True, "Product Price is not displayed.");
                Assert.That(productDescriptionPageAsserts.ProductDescriptionIsDisplayed(), Is.True, "Product Description is not displayed.");
                Assert.That(productDescriptionPageAsserts.AddToCartButtonIsDisplayed(), Is.True, "Product Add to cart button is not displayed.");
                Assert.That(productDescriptionPageAsserts.ProductPhotoIsDisplayed(), Is.True, "Product Price is not displayed.");
            });
            productDescriptionPageCommands.ClickOnAddToCartButton();
            driverCommands.ClickOkOnPopUp();
            topMenuBarCommands.ClickOnCartTab();

            Assert.That(cartPageAsserts.ProductCartTableIsDisplayed(), Is.True, "Product Cart Table is not displayed, Cart Page is not loaded.");
            Assert.That(cartPageAsserts.NumberOfProductsInCartIsEqualTo(2), Is.True, "There are more/less products.");
            cartPageCommands.ClickOnDeleteButtonInRow(1);
            Assert.That(cartPageAsserts.NumberOfProductsInCartIsEqualTo(1), Is.True, "There are more/less products.");
            cartPageCommands.ClickOnDeleteButtonInRow(1);
            Assert.That(cartPageAsserts.NumberOfProductsInCartIsEqualTo(0), Is.True, "There are more/less products.");

            topMenuBarCommands.ClickOnProductStoreLogo();
            topMenuBarCommands.ClickOnLogOutTab();
            Assert.That(popUpAsserts.SingUpTabIsDisplayed(), Is.True, "Welcome User is displayed");
            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
        }
    }
}
