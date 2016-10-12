using OpenQA.Selenium.Remote;
using System;
using AppiumTestFramework_v2.Helpers;

namespace AppiumTestFramework_v2
{
    public class AppiumManager
    {
        public string BrowserName { get; set; }
        public string FwkVersion { get; set; }
        public DevicePlatform Platform { get; set; }
        public string PlatformVersion { get; set; }
        public string DeviceName { get; set; }
        public string App { get; set; }
        public bool AutoWebView { get; set; }
        public string AutomationName { get; set; }
        public string AppActivity { get; set; }

        public AppiumManager()
        {
            this.BrowserName = String.Empty;
            this.FwkVersion = String.Empty;
            this.Platform = DevicePlatform.Undefined;
            this.PlatformVersion = String.Empty;
            this.DeviceName = String.Empty;
            this.App = String.Empty;
            this.AutoWebView = true;
            this.AutomationName = String.Empty;
            this.AppActivity = String.Empty;
        }

        public void AssignAppiumCapabilities(ref DesiredCapabilities appiumCapabilities)
        {
            appiumCapabilities.SetCapability("browserName", this.BrowserName);
            appiumCapabilities.SetCapability("appium-version", this.FwkVersion);
            appiumCapabilities.SetCapability("platformName", this.Platform.ToEnumString());
            appiumCapabilities.SetCapability("platformVersion", this.PlatformVersion);
            appiumCapabilities.SetCapability("deviceName", this.DeviceName);
            appiumCapabilities.SetCapability("autoWebview", this.AutoWebView);

            appiumCapabilities.SetCapability("testobject_api_key", "123456789");
            appiumCapabilities.SetCapability("testobject_device", "SAMSUNG_S6_EDGE");

            if (this.App != String.Empty)
            {
                appiumCapabilities.SetCapability("appPackage", this.App);
                appiumCapabilities.SetCapability("appActivity", this.AppActivity);
            }
        }
    }
}
