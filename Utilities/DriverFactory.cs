using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace Utilities
{
    public static class DriverFactory
    {
        public static IWebDriver Build(string type, string browser)
        {
            if (type == "local")
                switch (browser)
                {
                    case "chrome":
                        return BuildChromeDriver();
                    //case "firefox":
                    //    return BuildFirefoxDriver();
                    default:
                        throw new ArgumentException($"{browser} is not supported locally.");
                }

            throw new ArgumentException($"{type} is invalid. Choose 'local' or 'remote'.");
        }

        

        private static ChromeDriver BuildChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            return new ChromeDriver(options);
        }
    }
}
