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

		public PopUpAsserts(IWebDriver driver) : base(driver) {

            contactPopUpElements = new ContactPopUpElements(driver);
			aboutUsPopUpElements = new AboutUsPopUpElements(driver);
			loginPopUpElements = new LogInPopUpElements(driver);
			singUpPopUpElements = new SingUpPopUpElements(driver);
		}

        public bool ContactPopUpIsDisplayed()
        {
			Thread.Sleep(1000);  //needs to be changed with other type of waiting
			return contactPopUpElements.ContactPopUpTitle() != null && contactPopUpElements.ContactPopUpTitle().Displayed;
        }

		public bool AboutUsPopUpIsDisplayed()
		{
			Thread.Sleep(1000);  //needs to be changed with other type of waiting
			return aboutUsPopUpElements.AboutUsPopUpTitle() != null && aboutUsPopUpElements.AboutUsPopUpTitle().Displayed;
		}

		public bool LogInPopUpIsDisplayed()
		{
			Thread.Sleep(1000);  //needs to be changed with other type of waiting
			return loginPopUpElements.LogInPopUpTitle() != null && loginPopUpElements.LogInPopUpTitle().Displayed;
		}

		public bool SingUpPopUpIsDisplayed()
		{
			Thread.Sleep(1000);  //needs to be changed with other type of waiting
			return singUpPopUpElements.SingUpPopUpTitle() != null && singUpPopUpElements.SingUpPopUpTitle().Displayed;
		}
	}
}
