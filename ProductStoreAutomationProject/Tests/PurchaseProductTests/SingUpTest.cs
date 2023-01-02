using NUnit.Framework;
using ProductStoreAutomationProject.Asserts;
using ProductStoreAutomationProject.Commands;
using System;

namespace ProductStoreAutomationProject.Tests.PurchaseProductTests
{
    class SingUpTest : MainTest
    {
        [Test]
        public void UnsuccessfulSingUp()
        {
            CarouselAsserts carouselAsserts = new(driver);
            SingUpPopUpCommands singUpPopUpCommands = new(driver);
            PopUpAsserts popUpAsserts = new(driver);
            TopMenuBarCommands topMenuBarCommands = new(driver);
            DriverCommands driverCommands = new(driver);

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            topMenuBarCommands.ClickOnSingUpTab();
            Assert.That(popUpAsserts.SingUpPopUpIsDisplayed(), Is.True, "Sign up pop up is not displayed");
            singUpPopUpCommands.ClickOnCloseButton();

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            topMenuBarCommands.ClickOnSingUpTab();
            Assert.That(popUpAsserts.SingUpPopUpIsDisplayed(), Is.True, "Sign up pop up is not displayed");
            singUpPopUpCommands.ClickOnSingUpButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Please fill out Username and Password."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            Assert.That(popUpAsserts.SingUpPopUpIsDisplayed(), Is.True, "Sign up pop up is not displayed");
            singUpPopUpCommands.InsertTextInUsernameTextBox("user");
            singUpPopUpCommands.ClickOnSingUpButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Please fill out Username and Password."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            Assert.That(popUpAsserts.SingUpPopUpIsDisplayed(), Is.True, "Sign up pop up is not displayed");
            singUpPopUpCommands.InsertTextInUsernameTextBox("AngelinaQA");
            singUpPopUpCommands.InsertTextInPasswordTextBox("P@ssw0rd");
            singUpPopUpCommands.ClickOnSingUpButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("This user already exist."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();
            singUpPopUpCommands.ClickOnCloseButton();
            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
        }

        [Test]
        [Ignore("This test is run only on clean DataBase.")]
        public void SuccessfulSingUp()
        {
            CarouselAsserts carouselAsserts = new(driver);
            SingUpPopUpCommands singUpPopUpCommands = new(driver);
            PopUpAsserts popUpAsserts = new(driver);
            TopMenuBarCommands topMenuBarCommands = new(driver);
            DriverCommands driverCommands = new(driver);
            LogInPopUpCommands logInPopUpCommands = new(driver);
            string guidUsername = Guid.NewGuid().ToString("N").Substring(5);

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            topMenuBarCommands.ClickOnSingUpTab();

            Assert.That(popUpAsserts.SingUpPopUpIsDisplayed(), Is.True, "Sign up pop up is not displayed");
            singUpPopUpCommands.InsertTextInUsernameTextBox(guidUsername);
            singUpPopUpCommands.InsertTextInPasswordTextBox("P@ssw0rd");
            singUpPopUpCommands.ClickOnSingUpButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Sign up successful."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            topMenuBarCommands.ClickOnLogInTab();
            Assert.That(popUpAsserts.LogInPopUpIsDisplayed(), Is.True, "Log In pop up is not displayed");
            logInPopUpCommands.InsertTextInUsernameTextBox(guidUsername);
            logInPopUpCommands.InsertTextInPasswordTextBox("P@ssw0rd");
            logInPopUpCommands.ClickOnLogInButton();
            Assert.That(popUpAsserts.LogInWelcomeUserIsDisplayed(), Is.True, "Welcome User is not displayed");
            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");

            topMenuBarCommands.ClickOnLogOutTab();
            Assert.That(popUpAsserts.SingUpTabIsDisplayed(), Is.True, "Welcome User is displayed");
            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");

        }
    }
}
