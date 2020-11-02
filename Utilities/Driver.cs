using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Utilities
{
    public static class Driver
    {
        [ThreadStatic] private static IWebDriver _driver;
        [ThreadStatic] public static WebDriverWait Wait;

        public static IWebDriver Current
        {
            get
            {
                if (_driver == null)
                    throw new Exception("Driver is null. Call Driver.Init() first.");

                return _driver;
            }
        }

        public static void Init(string type, string browser, int setWait)
        {
            _driver = DriverFactory.Build(type, browser);
            Wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(setWait));
        }

        public static void Goto(string url)
        {
            Current.Navigate().GoToUrl(url);
        }

        public static void Quit()
        {
            if (_driver == null) return;
            Current.Quit();
            Current.Dispose();
        }
    }
}
