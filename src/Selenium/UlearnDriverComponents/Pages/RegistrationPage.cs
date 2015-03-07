﻿using OpenQA.Selenium;

namespace Selenium.UlearnDriverComponents.Pages
{
	class RegistrationPage : UlearnPage, IObserver
	{
		private IWebElement loginField;
		private IWebElement passwordField;
		private IWebElement confirmPasswordField;
		private IWebElement registerButton;

		public RegistrationPage(IWebDriver driver, IObserver parent)
			: base(driver, parent)
		{
			Configure();
		}

		private void Configure()
		{
			loginField = UlearnDriver.FindElementSafely(driver, By.XPath(XPaths.RegistrationNameField));
			passwordField = UlearnDriver.FindElementSafely(driver, By.XPath(XPaths.RegistrationPasswordField));
			confirmPasswordField = UlearnDriver.FindElementSafely(driver, By.XPath(XPaths.RegistrationConfirmPasswordField));
			registerButton = UlearnDriver.FindElementSafely(driver, By.XPath(XPaths.RegistrationRegisterButton));
			CheckPage();
		}

		private void CheckPage()
		{
			if (loginField == null)
				throw new NotFoundException("login field not found");
			if (passwordField == null)
				throw new NotFoundException("password field not found");
			if (confirmPasswordField == null)
				throw new NotFoundException("confirm password fiels not found");
			if (registerButton == null)
				throw new NotFoundException("registrated button not found");
		}

		public UlearnDriverComponents.UlearnDriver SignUp(string login, string password)
		{
			loginField.SendKeys(login);
			passwordField.SendKeys(password);
			confirmPasswordField.SendKeys(password);
			registerButton.Click();
			return new UlearnDriverComponents.UlearnDriver(driver);
		}

		public new void Update()
		{
			base.Update();
			Configure();
		}
	}
}