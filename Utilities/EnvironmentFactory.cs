using System;
namespace Utilities
{
    public class EnvironmentFactory
    {
        public static string Build(string environment)
        {
            switch (environment)
            {
                case "DEV":
                    return
                        "https://Dev.academymortgage.com/";
                case "TEST":
                    return
                        "https://Test.academymortgage.com/";
                case "PROD":
                    return "https://academymortgage.com/";
                default:
                    throw new ArgumentException($"{environment} is invalid. Choose 'DEV','TEST' or 'PROD'.");
            }
        }
    }
}
