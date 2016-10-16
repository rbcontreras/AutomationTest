using System;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using Test.Models.SeleniumModels;

namespace SeleniumTestFramework_v1.UnitTests
{
    public class SeleniumRegisterUsingSeleniumGridNUnit
    {
        private IWebDriver _driver;
        private static TimeSpan INIT_TIMEOUT_SEC = TimeSpan.FromSeconds(180);
        private static TimeSpan IMPLICIT_TIMEOUT_SEC = TimeSpan.FromSeconds(10);

        [SetUp]
        public void InitializeTest()
        {
            DesiredCapabilities capabilities = DesiredCapabilities.Chrome();
            _driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities, INIT_TIMEOUT_SEC);

            _driver.Url = "http://demoqa.com/registration/";
            _driver.Manage().Timeouts().ImplicitlyWait(IMPLICIT_TIMEOUT_SEC);
        }

        [Test]
        public void RegisterInChromeNUnit_Invalid()
        {
            var page = new ChromeGoogleSearch(_driver);
            page.Register();
            Assert.IsTrue(page.ErrorDisplay.Displayed);

            _driver.Close();
            _driver.Quit();
        }
    }
}
