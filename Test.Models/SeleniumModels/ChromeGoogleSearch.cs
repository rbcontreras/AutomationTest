using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Test.Models.SeleniumModels
{
    public class ChromeGoogleSearch
    {
        private readonly IWebDriver _driver;

        public ChromeGoogleSearch(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='name_3_firstname']")]
        [CacheLookup]
        public IWebElement TxtFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='name_3_lastname']")]
        [CacheLookup]
        public IWebElement TxtLastName { get; set; }

        [FindsBy(How = How.Name, Using = "pie_submit")]
        [CacheLookup]
        public IWebElement BtnSubmit { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='legend error']")]
        [CacheLookup]
        public IWebElement ErrorDisplay { get; set; }

        public void Register()
        {
            TxtFirstName.SendKeys("Raymond");
            TxtLastName.SendKeys("Contreras");
            BtnSubmit.Submit();
        }

        //[FindsBy(How = How.XPath, Using = "//*[@id='lst-ib']")]
        //[CacheLookup]
        //public IWebElement SearchBox { get; set; }

        //[FindsBy(How = How.Id, Using = "//*[@value='search']")]
        //[CacheLookup]
        //public IWebElement ResultPanel { get; set; }

        //[FindsBy(How = How.XPath, Using = ".//a")]
        //[CacheLookup]
        //IList<IWebElement> SearchResults { get; set; }

        //public void SearchText(string searchString)
        //{
        //    SearchBox.SendKeys(searchString);            
        //}
    }
}
