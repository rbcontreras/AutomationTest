using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test.Models.SeleniumModels;

namespace SeleniumTestFramework_v1.UnitTests
{
    [TestClass]
    public class SeleniumWebApiTest
    {
        private IWebDriver _driver;
        private static TimeSpan INIT_TIMEOUT_SEC = TimeSpan.FromSeconds(180);
        private static TimeSpan IMPLICIT_TIMEOUT_SEC = TimeSpan.FromSeconds(10);

        [TestInitialize]
        public void InitializeTest()
        {
            _driver = new ChromeDriver(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            _driver.Url = "http://demoqa.com/registration/";
            _driver.Manage().Timeouts().ImplicitlyWait(IMPLICIT_TIMEOUT_SEC);
        }

        [TestCleanup]
        public void AfterAll()
        {
            _driver.Close();
            _driver.Quit();
        }

        [TestMethod]
        public void CheckTestEnvironment()
        {
            var context = _driver;// .GetContext();
            Assert.IsNotNull(context);
        }

        [TestMethod]
        public void RegisterInChrome_Invalid()
        {            
            //var page = new ChromeGoogleSearch(_driver);
            //page.Register();
            //Assert.IsTrue(page.ErrorDisplay.Displayed);
        }
    }
}
