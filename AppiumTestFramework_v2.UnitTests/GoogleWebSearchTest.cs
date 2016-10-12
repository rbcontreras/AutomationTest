using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using Test.Models.AndroidModels;

namespace AppiumTestFramework_v2.UnitTests
{
    [TestClass]
    public class GoogleWebSearchTest
    {
        private IWebDriver _driver;
        private static Uri testServerAddress = new Uri(TestServers.Server1);
        private static TimeSpan INIT_TIMEOUT_SEC = TimeSpan.FromSeconds(180);
        private static TimeSpan IMPLICIT_TIMEOUT_SEC = TimeSpan.FromSeconds(10);

        [TestInitialize]
        public void BeforeAll()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            AppiumManager testCapabilities = new AppiumManager();

            //testCapabilities.App = "com.viber.voip";
            //testCapabilities.AppActivity = ".WelcomeActivity";            

            testCapabilities.App = "com.android.chrome";
            testCapabilities.AppActivity = "com.google.android.apps.chrome.Main";

            testCapabilities.AutoWebView = false;
            testCapabilities.AutomationName = "Search Google";
            testCapabilities.BrowserName = "Chrome"; // Leave empty otherwise you test on browsers
            testCapabilities.DeviceName = "02157df2d993d72c";
            testCapabilities.FwkVersion = string.Empty; // Not really needed
            testCapabilities.Platform = DevicePlatform.Android; // Or IOS
            testCapabilities.PlatformVersion = String.Empty; // Not really needed            
            testCapabilities.AssignAppiumCapabilities(ref capabilities);

            _driver = new AndroidDriver<AndroidElement>(testServerAddress, capabilities, INIT_TIMEOUT_SEC);
            
            _driver.Url = "https://www.google.com.ph";
            _driver.Manage().Timeouts().ImplicitlyWait(IMPLICIT_TIMEOUT_SEC);
        }

        /// <summary>
        /// Always quit, if you don't, next test session will fail
        /// </summary>
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
        public void SearchTestInGoogle()
        {
            var googleSearchPage = new GoogleSearch(_driver);
            googleSearchPage.SearchText();
        }
        
    }
}
