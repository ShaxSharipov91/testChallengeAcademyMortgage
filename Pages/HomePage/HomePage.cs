using System;
using OpenQA.Selenium;
using Utilities;

namespace Pages.HomePage
{
    public static class HomePage
    {
        #region CONSTANTS
        public enum MenuItems
        {
            AboutUs,
            LoanPrograms,
            HomebuyerEducation,
            News,
            Careers,
            FindALoanOfficer
        }

        public enum AboutUsSubMenuItems
        {
            WhoWeAre,
            WhatSetsUsApart,
            HowWeMeasureSuccess,
            WhereWeBegan,
            ContactUs
        }
        #endregion

        #region ELEMENTS
        private static IWebElement MenuItem(string menuItem) => Driver.Current.FindElement(By.XPath($"//li/a[@href='{menuItem}']"));
        #endregion

        #region FUNCTIONS
        public static void NavigateToMenu(string whichMenu, string whichSubMenu)
        {
            //1. Click on Main Menu Item 
            //2. Click on Sub Menu under Main Menu
            if (string.Equals(whichMenu, MainMenuItemsValues(MenuItems.AboutUs), StringComparison.OrdinalIgnoreCase))
            {
                MenuItem(MainMenuItemLocator(MenuItems.AboutUs)).Click();
                if (string.Equals(whichSubMenu, SubMenuItemsValues(AboutUsSubMenuItems.WhoWeAre), StringComparison.OrdinalIgnoreCase))
                {
                    MenuItem(SubMenuItemLocator(AboutUsSubMenuItems.WhoWeAre)).Click();
                }
                if (string.Equals(whichSubMenu, SubMenuItemsValues(AboutUsSubMenuItems.WhatSetsUsApart), StringComparison.OrdinalIgnoreCase))
                {
                    MenuItem(SubMenuItemLocator(AboutUsSubMenuItems.WhatSetsUsApart)).Click();
                }
                if (string.Equals(whichSubMenu, SubMenuItemsValues(AboutUsSubMenuItems.HowWeMeasureSuccess), StringComparison.OrdinalIgnoreCase))
                {
                    MenuItem(SubMenuItemLocator(AboutUsSubMenuItems.HowWeMeasureSuccess)).Click();
                }
                if (string.Equals(whichSubMenu, SubMenuItemsValues(AboutUsSubMenuItems.WhereWeBegan), StringComparison.OrdinalIgnoreCase))
                {
                    MenuItem(SubMenuItemLocator(AboutUsSubMenuItems.WhereWeBegan)).Click();
                }
                if (string.Equals(whichSubMenu, SubMenuItemsValues(AboutUsSubMenuItems.ContactUs), StringComparison.OrdinalIgnoreCase))
                {
                    MenuItem(SubMenuItemLocator(AboutUsSubMenuItems.ContactUs)).Click();
                }
            }
        }
        private static string MainMenuItemLocator(MenuItems menuItems)
        {
            switch (menuItems)
            {
                case MenuItems.AboutUs:
                    return "/about-us";
                case MenuItems.LoanPrograms:
                    return "/loan-programs";
                case MenuItems.HomebuyerEducation:
                    return "/homebuyer-education";
                case MenuItems.News:
                    return "/news";
                case MenuItems.Careers:
                    return "/careers";
                case MenuItems.FindALoanOfficer:
                    return "/find-a-loan-officer";
                default:
                    throw new ArgumentOutOfRangeException(nameof(menuItems), menuItems, "Value Is Invalid");
            }

        }
        private static string SubMenuItemLocator(AboutUsSubMenuItems menuItems)
        {
            switch (menuItems)
            {
                case AboutUsSubMenuItems.WhoWeAre:
                    return "/about-us/who-we-are";
                case AboutUsSubMenuItems.WhatSetsUsApart:
                    return "/about-us/what-sets-us-apart";
                case AboutUsSubMenuItems.HowWeMeasureSuccess:
                    return "/about-us/how-we-measure-success";
                case AboutUsSubMenuItems.WhereWeBegan:
                    return "/about-us/where-we-began";
                case AboutUsSubMenuItems.ContactUs:
                    return "/about-us/contact-us";
                default:
                    throw new ArgumentOutOfRangeException(nameof(menuItems), menuItems, "Value Is Invalid");
            }

        }
        public static bool MenuItemIsDisplayed(string whichMenu)
        {
            if (string.Equals(whichMenu, MainMenuItemsValues(MenuItems.AboutUs), StringComparison.OrdinalIgnoreCase))
            {
                return MenuItem("/about-us").Displayed;
            }
            else if (string.Equals(whichMenu, MainMenuItemsValues(MenuItems.LoanPrograms), StringComparison.OrdinalIgnoreCase))
            {
                return MenuItem("/loan-programs").Displayed;
            }
            else if (string.Equals(whichMenu, MainMenuItemsValues(MenuItems.HomebuyerEducation), StringComparison.OrdinalIgnoreCase))
            {
                return MenuItem("/homebuyer-education").Displayed;
            }
            else if (string.Equals(whichMenu, MainMenuItemsValues(MenuItems.News), StringComparison.OrdinalIgnoreCase))
            {
                return MenuItem("/news").Displayed;
            }
            else if (string.Equals(whichMenu, MainMenuItemsValues(MenuItems.Careers), StringComparison.OrdinalIgnoreCase))
            {
                return MenuItem("/careers").Displayed;
            }
            else if (string.Equals(whichMenu, MainMenuItemsValues(MenuItems.FindALoanOfficer), StringComparison.OrdinalIgnoreCase))
            {
                return MenuItem("/find-a-loan-officer").Displayed;
            }
            return false;
       
        }
        public static bool CorrectPageLoaded(string whichSubMenu)
        {

            if (string.Equals(whichSubMenu, SubMenuItemsValues(AboutUsSubMenuItems.WhoWeAre), StringComparison.OrdinalIgnoreCase))
            {
                return Driver.Current.FindElement(By.XPath($"//h2/span[text()='{whichSubMenu}']")).Displayed;
            }
            if (string.Equals(whichSubMenu, SubMenuItemsValues(AboutUsSubMenuItems.WhatSetsUsApart), StringComparison.OrdinalIgnoreCase))
            {
                return Driver.Current.FindElement(By.XPath($"//h1[text()='{whichSubMenu}']")).Displayed;
            }
            if (string.Equals(whichSubMenu, SubMenuItemsValues(AboutUsSubMenuItems.HowWeMeasureSuccess), StringComparison.OrdinalIgnoreCase))
            {
                return Driver.Current.FindElement(By.XPath($"//h1[text()='{whichSubMenu}']")).Displayed;
            }
            if (string.Equals(whichSubMenu, SubMenuItemsValues(AboutUsSubMenuItems.WhereWeBegan), StringComparison.OrdinalIgnoreCase))
            {
                return Driver.Current.FindElement(By.XPath($"//h1[text()='{whichSubMenu}']")).Displayed;
            }
            if (string.Equals(whichSubMenu, SubMenuItemsValues(AboutUsSubMenuItems.ContactUs), StringComparison.OrdinalIgnoreCase))
            {
                return Driver.Current.FindElement(By.XPath($"//h1[text()='{whichSubMenu}']")).Displayed;
            }
            return false;
        }

        private static string MainMenuItemsValues(MenuItems menuItems)
        {
            switch (menuItems)
            {
                case MenuItems.AboutUs:
                    return "About Us";
                case MenuItems.LoanPrograms:
                    return "Loan Programs";
                case MenuItems.HomebuyerEducation:
                    return "Homebuyer Education";
                case MenuItems.News:
                    return "News";
                case MenuItems.Careers:
                    return "Careers";
                case MenuItems.FindALoanOfficer:
                    return "Find a Loan Officer";
                default:
                    throw new ArgumentOutOfRangeException(nameof(menuItems), menuItems, "Value Is Invalid");
            }
        }

        private static string SubMenuItemsValues(AboutUsSubMenuItems menuItems)
        {
            switch (menuItems)
            {
                case AboutUsSubMenuItems.WhoWeAre:
                    return "Who We Are";
                case AboutUsSubMenuItems.WhatSetsUsApart:
                    return "What Sets Us Apart";
                case AboutUsSubMenuItems.HowWeMeasureSuccess:
                    return "How We Measure Success";
                case AboutUsSubMenuItems.WhereWeBegan:
                    return "Where We Began";
                case AboutUsSubMenuItems.ContactUs:
                    return "Contact Us";
                default:
                    throw new ArgumentOutOfRangeException(nameof(menuItems), menuItems, "Value Is Invalid");
            }
        }
        #endregion

        #region SUB-CLASSES
        #endregion

    }
}
