using NUnit.Framework;
using ProductStoreAutomationProject.Asserts;
using ProductStoreAutomationProject.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStoreAutomationProject.Tests.PurchaseProductTests
{
    class SingUpTest : MainTest
    {
        [Test]
        public void SingUp()
        {
            CarouselAsserts carouselAsserts = new(driver);
            SingUpPopUpCommands singUpPopUpCommands = new(driver);
            PopUpAsserts popUpAsserts = new(driver);
            TopMenuBarCommands topMenuBarCommands = new(driver);
            DriverCommands driverCommands = new(driver);

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            topMenuBarCommands.ClickOnSingUpTab();
            Assert.That(popUpAsserts.SingUpPopUpIsDisplayed(), Is.True, "Sing Up pop up is not displayed");
            singUpPopUpCommands.ClickOnCloseButton();

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            topMenuBarCommands.ClickOnSingUpTab();
            Assert.That(popUpAsserts.SingUpPopUpIsDisplayed(), Is.True, "Sing Up pop up is not displayed");
            singUpPopUpCommands.ClickOnSingUpButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Please fill out Username and Password."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            Assert.That(popUpAsserts.SingUpPopUpIsDisplayed(), Is.True, "Sing Up pop up is not displayed");
            singUpPopUpCommands.InsertTextInUsernameTextBox("user");
            singUpPopUpCommands.ClickOnSingUpButton();
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("Please fill out Username and Password."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();

            Assert.That(popUpAsserts.SingUpPopUpIsDisplayed(), Is.True, "Sing Up pop up is not displayed");
            singUpPopUpCommands.InsertTextInUsernameTextBox("AngelinaQA");
            singUpPopUpCommands.InsertTextInPasswordTextBox("P@ssw0rd");
            singUpPopUpCommands.ClickOnSingUpButton(); //waiting too long
            Assert.That(driverCommands.ReturnMessageFromPopUp(), Is.EqualTo("This user already exist."), "The Pop-up message is not the right one.");
            driverCommands.ClickOkOnPopUp();
            //...
        }
    }
}
