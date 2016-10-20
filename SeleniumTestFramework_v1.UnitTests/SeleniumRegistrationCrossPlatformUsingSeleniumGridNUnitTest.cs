using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models.SeleniumModels;

namespace SeleniumTestFramework_v1.UnitTests
{    
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]    
    public class SeleniumRegistrationCrossPlatformUsingSeleniumGridNUnitTest<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private IWebDriver _driver;
        private static TimeSpan INIT_TIMEOUT_SEC = TimeSpan.FromSeconds(180);
        private static TimeSpan IMPLICIT_TIMEOUT_SEC = TimeSpan.FromSeconds(10);

        public SeleniumRegistrationCrossPlatformUsingSeleniumGridNUnitTest()
        {
            Driver<TWebDriver>.Initialize(new Uri("http://localhost:4444/wd/hub"));
        }

        [SetUp]
        public void InitializeTest()
        {
            _driver = Driver<TWebDriver>.Instance;
            
            _driver.Url = "http://demoqa.com/registration/";
            _driver.Manage().Timeouts().ImplicitlyWait(IMPLICIT_TIMEOUT_SEC);            
        }

        [Test]
        public void RegisterInChromeNUnitCrossPlatform_Invalid()
        {
            var page = new ChromeGoogleSearch(_driver);
            page.Register();
            Assert.IsTrue(page.ErrorDisplay.Displayed);

            _driver.Close();
            _driver.Quit();
        }
    }


    public class Driver<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize(Uri remoteAddress)
        {
            if (typeof(TWebDriver) == typeof(ChromeDriver))
            {
                var browser = DesiredCapabilities.Chrome();
                Instance = new RemoteWebDriver(remoteAddress, browser);
            } 
            else 
            {
                DesiredCapabilities browser = DesiredCapabilities.Firefox();
                Instance = new RemoteWebDriver(remoteAddress, browser);
            }   
        }        
    }
}
