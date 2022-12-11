using NUnit.Framework;
using ProductStoreAutomationProject.Asserts;
using ProductStoreAutomationProject.Commands;

namespace ProductStoreAutomationProject.Tests.HomePageTests
{
    class ATopMenuBarTest : MainTest
    {

        [Test]
        public void TopMenuBarSmokeTest()
        {
            TopMenuBarCommands topMenuBarCommands = new(driver);
            PopUpAsserts popUpAsserts = new(driver);
            CarouselAsserts carouselAsserts = new(driver);
            CartPageAsserts cartPageAsserts = new(driver);
            ContactPopUpCommands contactPopUpCommands = new(driver);
            AboutUsPopUpCommands aboutUsPopUpCommands = new(driver);
            LogInPopUpCommands logInPopUpCommands = new(driver);
            SingUpPopUpCommands singUpPopUpCommands = new(driver);

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");

            topMenuBarCommands.ClickOnContactTab();
            Assert.That(popUpAsserts.ContactPopUpIsDisplayed(), Is.True, "Contact pop up is not displayed");
            contactPopUpCommands.ClickOnXButton();

            topMenuBarCommands.ClickOnAboutUsTab();
            Assert.That(popUpAsserts.AboutUsPopUpIsDisplayed(), Is.True, "About Us pop up is not displayed");
            aboutUsPopUpCommands.ClickOnXButton();

            topMenuBarCommands.ClickOnLogInTab();
            Assert.That(popUpAsserts.LogInPopUpIsDisplayed(), Is.True, "Log In pop up is not displayed");
            logInPopUpCommands.ClickOnXButton();

            topMenuBarCommands.ClickOnSingUpTab();
            Assert.That(popUpAsserts.SingUpPopUpIsDisplayed(), Is.True, "Sing Up pop up is not displayed");
            singUpPopUpCommands.ClickOnXButton();

            topMenuBarCommands.ClickOnCartTab();
            Assert.That(cartPageAsserts.ProductCartTableIsDisplayed(), Is.True, "Product Cart Table is not displayed, Cart Page is not loaded.");
            topMenuBarCommands.ClickOnHomeTab();
            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            Thread.Sleep(2000);
        }
    }
}
