using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSampleProject.pages
{
    class LogInPage
    {
        public LogInPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebDriver driver { get; }
        IWebElement txtUsername => driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => driver.FindElement(By.Id("Password"));
        IWebElement lnkSubmit => driver.FindElement(By.XPath("//input[@type='submit']"));
        public void validlogIn(String username, String password) 
        {
            txtUsername.SendKeys(username);
            txtPassword.SendKeys(password);
            lnkSubmit.Click();

        }
    }
}
