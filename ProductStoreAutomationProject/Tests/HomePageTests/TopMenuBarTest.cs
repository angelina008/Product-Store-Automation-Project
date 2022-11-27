using NUnit.Framework;
using ProductStoreAutomationProject.Asserts;
using ProductStoreAutomationProject.Commands;

namespace ProductStoreAutomationProject.Tests.HomePageTests
{
    class TopMenuBarTest : MainTest
    {

        [Test]
        public void TopMenuBarSmokeTest()
        {
            TopMenuBarCommands topMenuBarCommands = new TopMenuBarCommands(driver);
            PopUpAsserts popUpAsserts = new PopUpAsserts(driver);
            CarouselAsserts carouselAsserts = new CarouselAsserts(driver);
            CartPageAsserts cartPageAsserts = new CartPageAsserts(driver);
            ContactPopUpCommands contactPopUpCommands = new ContactPopUpCommands(driver);
            AboutUsPopUpCommands aboutUsPopUpCommands = new AboutUsPopUpCommands(driver);
            LogInPopUpCommands logInPopUpCommands = new LogInPopUpCommands(driver);
            SingUpPopUpCommands singUpPopUpCommands = new SingUpPopUpCommands(driver);

            Assert.True(carouselAsserts.CarouselIsDisplayed(), "Carousel is not displayed, Home Page is not loaded.");

            topMenuBarCommands.ClickOnContactTab();
            Assert.True(popUpAsserts.ContactPopUpIsDisplayed(), "Contact pop up is not displayed");
            contactPopUpCommands.ClickOnXButton();

            topMenuBarCommands.ClickOnAboutUsTab();
            Assert.True(popUpAsserts.AboutUsPopUpIsDisplayed(), "About Us pop up is not displayed");
            aboutUsPopUpCommands.ClickOnXButton();

            topMenuBarCommands.ClickOnLogInTab();
            Assert.True(popUpAsserts.LogInPopUpIsDisplayed(), "Log In pop up is not displayed");
            logInPopUpCommands.ClickOnXButton();

            topMenuBarCommands.ClickOnSingUpTab();
            Assert.True(popUpAsserts.SingUpPopUpIsDisplayed(), "Sing Up pop up is not displayed");
            singUpPopUpCommands.ClickOnXButton();

            topMenuBarCommands.ClickOnCartTab();
            Assert.True(cartPageAsserts.ProductCartTableIsDisplayed(), "Product Cart Table is not displayed, Cart Page is not loaded.");
            topMenuBarCommands.ClickOnHomeTab();
            Assert.True(carouselAsserts.CarouselIsDisplayed(), "Carousel is not displayed, Home Page is not loaded.");
            Thread.Sleep(2000);
        }
    }
}
