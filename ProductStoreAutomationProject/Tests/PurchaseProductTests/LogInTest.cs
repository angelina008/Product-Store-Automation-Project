using NUnit.Framework;
using ProductStoreAutomationProject.Asserts;
using ProductStoreAutomationProject.Commands;

namespace ProductStoreAutomationProject.Tests.PurchaseProductTests
{
    class LogInTest : MainTest 
    {
        [Test]
        public void LogIn()
        {
            CarouselAsserts carouselAsserts = new(driver);
            LogInPopUpCommands logInPopUpCommands = new(driver);
            PopUpAsserts popUpAsserts = new(driver);
            TopMenuBarCommands topMenuBarCommands = new(driver);
            DriverCommands driverCommands = new(driver);

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            topMenuBarCommands.ClickOnLogInTab();
            Assert.That(popUpAsserts.LogInPopUpIsDisplayed(), Is.True, "Log In pop up is not displayed");
            logInPopUpCommands.ClickOnCloseButton();

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            topMenuBarCommands.ClickOnLogInTab();
            Assert.That(popUpAsserts.LogInPopUpIsDisplayed(), Is.True, "Log In pop up is not displayed");
            logInPopUpCommands.ClickOnLogInButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Please fill out Username and Password."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            Assert.That(popUpAsserts.LogInPopUpIsDisplayed(), Is.True, "Log In pop up is not displayed");
            logInPopUpCommands.InsertTextInUsernameTextBox("user");
            logInPopUpCommands.ClickOnLogInButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Please fill out Username and Password."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            Assert.That(popUpAsserts.LogInPopUpIsDisplayed(), Is.True, "Log In pop up is not displayed");
            logInPopUpCommands.RemoveTextFromUsernameTextBox();
            logInPopUpCommands.InsertTextInPasswordTextBox("password");
            logInPopUpCommands.ClickOnLogInButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Please fill out Username and Password."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            Assert.That(popUpAsserts.LogInPopUpIsDisplayed(), Is.True, "Log In pop up is not displayed");
            logInPopUpCommands.InsertTextInUsernameTextBox("AngelinaQA");
            logInPopUpCommands.InsertTextInPasswordTextBox("password");
            logInPopUpCommands.ClickOnLogInButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Wrong password."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            Assert.That(popUpAsserts.LogInPopUpIsDisplayed(), Is.True, "Log In pop up is not displayed");
            logInPopUpCommands.InsertTextInUsernameTextBox("AngelinaQA2");
            logInPopUpCommands.InsertTextInPasswordTextBox("password");
            logInPopUpCommands.ClickOnLogInButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("User does not exist."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            Assert.That(popUpAsserts.LogInPopUpIsDisplayed(), Is.True, "Log In pop up is not displayed");
            logInPopUpCommands.InsertTextInUsernameTextBox("AngelinaQA");
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
