using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;
using Test.Models.AndroidModels;

namespace AppiumTestFramework_v2.UnitTests
{
    [TestClass]
    public class AndroidCalculatorAppiumTests
    {
        private AndroidDriver<AndroidElement> _driver;
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

            

            testCapabilities.App = "com.sec.android.app.popupcalculator";
            testCapabilities.AppActivity = "com.sec.android.app.popupcalculator.Calculator";

            testCapabilities.AutoWebView = false;
            testCapabilities.AutomationName = "Appium";
            testCapabilities.BrowserName = String.Empty; // Leave empty otherwise you test on browsers
            testCapabilities.DeviceName = "02157df2d993d72c";
            testCapabilities.FwkVersion = string.Empty; // Not really needed
            testCapabilities.Platform = DevicePlatform.Android; // Or IOS
            testCapabilities.PlatformVersion = String.Empty; // Not really needed            
            testCapabilities.AssignAppiumCapabilities(ref capabilities);

            _driver = new AndroidDriver<AndroidElement>(testServerAddress, capabilities, INIT_TIMEOUT_SEC);
            _driver.Manage().Timeouts().ImplicitlyWait(IMPLICIT_TIMEOUT_SEC);
        }

        /// <summary>
        /// Always quit, if you don't, next test session will fail
        /// </summary>
        [TestCleanup]
        public void AfterAll()
        {
            _driver.Quit();
        }

        [TestMethod]
        public void CheckTestEnvironment()
        {
            var context = _driver.Context;// .GetContext();
            Assert.IsNotNull(context);
        }

        [TestMethod]
        public void CheckSimpleAdd()
        {
            var androidCalculator = new AndroidCalculator(_driver);
            androidCalculator.SimpleAdd();
            androidCalculator.SimpleMinus();

            //_driver.FindElement(By.Name("C")).Click();
            //_driver.FindElement(By.Name("1")).Click();
            //_driver.FindElement(By.Name("+")).Click();
            //_driver.FindElement(By.Name("2")).Click();
            //_driver.FindElement(By.Name("=")).Click();
            //var result = _driver.FindElementById("txtCalc").Text;

            //Assert.AreEqual("3", result);
        }
    }
}
