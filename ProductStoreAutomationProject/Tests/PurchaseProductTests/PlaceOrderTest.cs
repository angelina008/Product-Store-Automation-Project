using NUnit.Framework;
using OpenQA.Selenium;
using ProductStoreAutomationProject.Asserts;
using ProductStoreAutomationProject.Commands;

namespace ProductStoreAutomationProject.Tests.PurchaseProductTests
{
    class PlaceOrderTest : MainTest
    {
        [Test]
        public void PlaceOrderSuccessfully()
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
            PlaceOrderPopUpCommands placeOrderPopUpCommands = new(driver);
            var productName1 = categoriesCommands.ProductName(1).Text;

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
            topMenuBarCommands.ClickOnCartTab();
            Assert.That(cartPageAsserts.ProductCartTableIsDisplayed(), Is.True, "Product Cart Table is not displayed, Cart Page is not loaded.");
            Assert.That(cartPageAsserts.NumberOfProductsInCartIsEqualTo(1), Is.True, "There are more/less products.");
            cartPageCommands.ClickOnPlaceOrderButton();
            Assert.That(popUpAsserts.PlaceOrderPopUpIsDisplayed(), Is.True, "Place Order pop up is not displayed");
            placeOrderPopUpCommands.ClickOnCloseButton();
            Assert.That(cartPageAsserts.ProductCartTableIsDisplayed(), Is.True, "Product Cart Table is not displayed, Cart Page is not loaded.");
            cartPageCommands.ClickOnPlaceOrderButton();
            Assert.That(popUpAsserts.PlaceOrderPopUpIsDisplayed(), Is.True, "Place Order pop up is not displayed");
            placeOrderPopUpCommands.ClickOnPurchaseButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Please fill out Name and Creditcard."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();
            placeOrderPopUpCommands.InsertTextInNameTextBox("Angelina");
            placeOrderPopUpCommands.InsertTextInCountryTextBox("North Macedonia");
            placeOrderPopUpCommands.InsertTextInCityTextBox("Skopje");
            placeOrderPopUpCommands.InsertTextInCreditCardTextBox("1111");
            placeOrderPopUpCommands.InsertTextInMonthTextBox("1");
            placeOrderPopUpCommands.InsertTextInYearTextBox("2023");
            placeOrderPopUpCommands.ClickOnPurchaseButton();
            Assert.That(popUpAsserts.SuccessfulPurchasePopUpIsDisplayed(), Is.True, "Successful Purchase pop up is not displayed");
            placeOrderPopUpCommands.ClickOnOKButton();

            topMenuBarCommands.ClickOnLogOutTab();
            Assert.That(popUpAsserts.SingUpTabIsDisplayed(), Is.True, "Welcome User is displayed");
            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
        }

        [Test]
        public void PlaceOrderUnsuccessfully()
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
            PlaceOrderPopUpCommands placeOrderPopUpCommands = new(driver);
            var productName1 = categoriesCommands.ProductName(1).Text;

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            topMenuBarCommands.ClickOnLogInTab();
            Assert.That(popUpAsserts.LogInPopUpIsDisplayed(), Is.True, "Log In pop up is not displayed");
            logInPopUpCommands.InsertTextInUsernameTextBox("AngelinaQA");
            logInPopUpCommands.InsertTextInPasswordTextBox("P@ssw0rd");
            logInPopUpCommands.ClickOnLogInButton();
            Assert.That(popUpAsserts.LogInWelcomeUserIsDisplayed(), Is.True, "Welcome User is not displayed");
            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");

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
            topMenuBarCommands.ClickOnCartTab();
            Assert.That(cartPageAsserts.ProductCartTableIsDisplayed(), Is.True, "Product Cart Table is not displayed, Cart Page is not loaded.");
            Assert.That(cartPageAsserts.NumberOfProductsInCartIsEqualTo(1), Is.True, "There are more/less products.");
            cartPageCommands.ClickOnPlaceOrderButton();
            Assert.That(popUpAsserts.PlaceOrderPopUpIsDisplayed(), Is.True, "Place Order pop up is not displayed");
            placeOrderPopUpCommands.ClickOnPurchaseButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Please fill out Name and Creditcard."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            Assert.That(popUpAsserts.PlaceOrderPopUpIsDisplayed(), Is.True, "Place Order pop up is not displayed");
            placeOrderPopUpCommands.InsertTextInNameTextBox("Angelina");
            placeOrderPopUpCommands.ClickOnPurchaseButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Please fill out Name and Creditcard."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            Assert.That(popUpAsserts.PlaceOrderPopUpIsDisplayed(), Is.True, "Place Order pop up is not displayed");
            placeOrderPopUpCommands.RemoveTextFromNameTextBox();
            placeOrderPopUpCommands.InsertTextInCreditCardTextBox("1111");
            placeOrderPopUpCommands.ClickOnPurchaseButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Please fill out Name and Creditcard."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            placeOrderPopUpCommands.InsertTextInNameTextBox("Angelina");
            placeOrderPopUpCommands.RemoveTextFromCreditCardTextBox();
            placeOrderPopUpCommands.InsertTextInCreditCardTextBox("1111");
            placeOrderPopUpCommands.ClickOnPurchaseButton();
            Assert.That(popUpAsserts.SuccessfulPurchasePopUpIsDisplayed(), Is.True, "Successful Purchase pop up is not displayed");
            placeOrderPopUpCommands.ClickOnOKButton();
            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");

            topMenuBarCommands.ClickOnLogOutTab();
            Assert.That(popUpAsserts.SingUpTabIsDisplayed(), Is.True, "Welcome User is displayed");
            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
        }
    }
}
