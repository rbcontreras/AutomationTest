using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Test.Models.AndroidModels
{
    public class AndroidCalculator
    {
        private IWebDriver _driver;

        public AndroidCalculator(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(_driver, this);
        }        

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/bt_01")]
        public IWebElement Num1 { get; set; }

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/bt_02")]
        public IWebElement Num2 { get; set; }

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/bt_03")]
        public IWebElement Num3 { get; set; }

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/bt_04")]
        public IWebElement Num4 { get; set; }

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/bt_05")]
        public IWebElement Num5 { get; set; }

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/bt_06")]
        public IWebElement Num6 { get; set; }

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/bt_07")]
        public IWebElement Num7 { get; set; }

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/bt_08")]
        public IWebElement Num8 { get; set; }

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/bt_09")]
        public IWebElement Num9 { get; set; }

        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/bt_clear")]
        [CacheLookup]
        public IWebElement Clear { get; set; }

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/bt_equal")]
        public IWebElement Equal { get; set; }

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/bt_add")]
        public IWebElement Plus { get; set; }

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/bt_sub")]
        public IWebElement Minus { get; set; }

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "com.sec.android.app.popupcalculator:id/txtCalc")]
        public IWebElement TxtResult { get; set; }

        public void SimpleAdd()
        {
            Clear.Click();
            Num1.Click();
            Plus.Click();
            Num2.Click();
            Equal.Click();
        }

        public void SimpleMinus()
        {
            Clear.Click();
            Num2.Click();
            Minus.Click();
            Num1.Click();
            Equal.Click();
        }
    }
}
