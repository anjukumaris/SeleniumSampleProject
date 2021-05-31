using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSampleProject.pages
{
    class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            this.driver=driver; 
        }
        private IWebDriver driver { get; }
        public IWebElement lnkLogIn=> driver.FindElement(By.Id("loginLink"));
        IWebElement lnkAdmin => driver.FindElement(By.XPath("//a[text()='Hello admin!']"));
        public void clickLogin() => lnkLogIn.Click();

        public bool IssuccessfulLogin() => lnkAdmin.Displayed;
    }
}
