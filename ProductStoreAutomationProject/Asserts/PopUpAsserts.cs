using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Asserts
{
    class PopUpAsserts : MainTest
    {
        ContactPopUpElements contactPopUpElements;
		AboutUsPopUpElements aboutUsPopUpElements;
		LogInPopUpElements loginPopUpElements;
		SingUpPopUpElements singUpPopUpElements;
		TopMenuBarElements topMenuBarElements;

        public PopUpAsserts(IWebDriver driver) : base(driver) {

            contactPopUpElements = new(driver);
			aboutUsPopUpElements = new(driver);
			loginPopUpElements = new(driver);
			singUpPopUpElements = new(driver);
			topMenuBarElements = new(driver);

        }

        public bool ContactPopUpIsDisplayed()
        {
			Thread.Sleep(1000);  
			return contactPopUpElements.ContactPopUpTitle() != null && contactPopUpElements.ContactPopUpTitle().Displayed;
        }

		public bool AboutUsPopUpIsDisplayed()
		{
			Thread.Sleep(1000);  
			return aboutUsPopUpElements.AboutUsPopUpTitle() != null && aboutUsPopUpElements.AboutUsPopUpTitle().Displayed;
		}

		public bool LogInPopUpIsDisplayed()
		{
			Thread.Sleep(1000);  
			return loginPopUpElements.LogInPopUpTitle() != null && loginPopUpElements.LogInPopUpTitle().Displayed;
		}

        public bool LogInWelcomeUserIsDisplayed()
        {
            Thread.Sleep(1000);
            return loginPopUpElements.LogInWelcomeUserText() != null && loginPopUpElements.LogInWelcomeUserText().Displayed;
        }

        public bool SingUpPopUpIsDisplayed()
		{
			Thread.Sleep(1000);  
			return singUpPopUpElements.SingUpPopUpTitle() != null && singUpPopUpElements.SingUpPopUpTitle().Displayed;
		}

        public bool SingUpTabIsDisplayed()
        {
            Thread.Sleep(1000);
            return topMenuBarElements.TopMenuBarSingUpTab() != null && topMenuBarElements.TopMenuBarSingUpTab().Displayed;
        }
    }
}
