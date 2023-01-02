using NUnit.Framework;
using ProductStoreAutomationProject.Asserts;
using ProductStoreAutomationProject.Commands;

namespace ProductStoreAutomationProject.Tests.PurchaseProductTests
{
    class ContactSendMessageTest : MainTest
    {
        [Test]
        public void ContactUsSendMessageTest()
        {
            CarouselAsserts carouselAsserts = new(driver);
            LogInPopUpCommands logInPopUpCommands = new(driver);
            PopUpAsserts popUpAsserts = new(driver);
            TopMenuBarCommands topMenuBarCommands = new(driver);
            DriverCommands driverCommands = new(driver);
            ContactPopUpCommands contactPopUpCommands = new(driver);

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            topMenuBarCommands.ClickOnLogInTab();
            Assert.That(popUpAsserts.LogInPopUpIsDisplayed(), Is.True, "Log In pop up is not displayed");
            logInPopUpCommands.InsertTextInUsernameTextBox("AngelinaQA");
            logInPopUpCommands.InsertTextInPasswordTextBox("P@ssw0rd");
            logInPopUpCommands.ClickOnLogInButton();
            Assert.That(popUpAsserts.LogInWelcomeUserIsDisplayed(), Is.True, "Welcome User is not displayed");
            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");

            topMenuBarCommands.ClickOnContactTab();
            Assert.That(popUpAsserts.ContactPopUpIsDisplayed(), Is.True, "Contact pop up is not displayed");
            contactPopUpCommands.ClickOnCloseButton();
            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            
            topMenuBarCommands.ClickOnContactTab();
            contactPopUpCommands.InsertTextInContactEmailTextBox("qa@test.com");
            contactPopUpCommands.InsertTextInContactNameTextBox("Angelina");
            contactPopUpCommands.InsertTextInMessageTextBox("There is bug in Contact pop-up please check it up. :)");
            contactPopUpCommands.ClickOnSendMessageButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Thanks for the message!!"), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            topMenuBarCommands.ClickOnContactTab();
            contactPopUpCommands.ClickOnSendMessageButton();
            //BUG!!
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Please fill out Contact Email and Message."), "The Pop-up message is not the right one."); 
            driverCommands.ClickOkOnPopUp();


            topMenuBarCommands.ClickOnLogOutTab();
            Assert.That(popUpAsserts.SingUpTabIsDisplayed(), Is.True, "Welcome User is displayed");
            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");

        }

    }
}
