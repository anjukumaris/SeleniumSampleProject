using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumSampleProject.pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSampleProject.tests
{
    class LogInTest
    {
        //Browser Driver
        IWebDriver WebDriver = new ChromeDriver(@"C:\myProjects");

        //Hooks in Nunit
        [SetUp]
        public void setUp()
        {
            //Navigate to Site
            WebDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            

        }
        [Test]
        public void logInTest()
        {
            HomePage homePage = new HomePage(WebDriver);
            homePage.clickLogin();
            LogInPage logInPage = new LogInPage(WebDriver);
            logInPage.validlogIn("admin", "password");
            Assert.That(homePage.IssuccessfulLogin, Is.True);
        }
        [TearDown]
        public void tearDown() => WebDriver.Quit();
       
    }
}
