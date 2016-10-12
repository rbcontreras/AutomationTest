using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models.AndroidModels
{
    public class GoogleSearch
    {
        private readonly IWebDriver _driver; 

        public GoogleSearch(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "lst-ib")]
        [CacheLookup]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.Id, Using = "tsbb")]
        public IWebElement BtnSearch { get; set; }

        public void SearchText()
        {
            SearchBox.SendKeys("test");
            BtnSearch.Submit();
        }
    }
}
