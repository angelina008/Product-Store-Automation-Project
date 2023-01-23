using NUnit.Framework;
using ProductStoreAutomationProject.Asserts;
using ProductStoreAutomationProject.Commands;

namespace ProductStoreAutomationProject.Tests.HomePageTests
{
    class CarouselImagesTest : MainTest
    {
        [Test]
        public void ChangeImagesInCarousel()
        {
            CarouselCommands carouselCommands = new(driver);
            CarouselAsserts carouselAsserts = new(driver);

            Assert.That(carouselAsserts.CarouselIsDisplayed(), Is.True, "Carousel is not displayed, Home Page is not loaded.");
            Assert.That(carouselAsserts.FirstImageIsDisplayed(), Is.True, "First Image in Carousel is not displayed, automatic swipe.");
            carouselCommands.WaitForImageToChange();
            carouselCommands.ClickOnPrevButton();
            Assert.That(carouselAsserts.FirstImageIsDisplayed(), Is.True, "First Image in Carousel is not displayed, manual change back.");
            carouselCommands.ClickOnNextButton();
            Assert.That(carouselAsserts.SecondImageIsDisplayed(), Is.True, "Second Image in Carousel is not displayed, manual change forward.");
            carouselCommands.ClickOnNextButton();
            Assert.That(carouselAsserts.ThirdImageIsDisplayed(), Is.True, "Third Image in Carousel is not displayed, manual change forward.");
            carouselCommands.ClickOnPrevButton();
            Assert.That(carouselAsserts.SecondImageIsDisplayed(), Is.True, "Second Image in Carousel is not displayed, manual change back.");
            carouselCommands.ClickOnNextButton();
            Assert.That(carouselAsserts.ThirdImageIsDisplayed(), Is.True, "Third Image in Carousel is not displayed, manual change forward second time.");
            carouselCommands.ClickOnNextButton();
            Assert.That(carouselAsserts.FirstImageIsDisplayed(), Is.True, "First Image in Carousel is not displayed, manual change forward.");
        }

        [Test]
        public void AutomaticChangeImagesInCarousel()
        {
            CarouselCommands carouselCommands = new(driver);
            CarouselAsserts carouselAsserts = new(driver);

            Assert.That(carouselAsserts.FirstImageIsDisplayed(), Is.True, "First Image in Carousel is not displayed, in automatic swipe.");
            carouselCommands.WaitForImageToChange();
            Assert.That(carouselAsserts.SecondImageIsDisplayed(), Is.True, "Second Image in Carousel is not displayed, in automatic swipe.");
            carouselCommands.WaitForImageToChange();
            Assert.That(carouselAsserts.ThirdImageIsDisplayed(), Is.True, "Third Image in Carousel is not displayed, in automatic swipe.");
            carouselCommands.WaitForImageToChange();
        }
    }
}
