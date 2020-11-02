using System;
using NUnit.Framework;
using Pages.HomePage;

namespace Tests
{
    [TestFixture]
    //[Parallelizable]
    public class PageNavigationTests : TestBase
    {
        
        [Test]
        [Category("About Us")]
        [Category("Smoke")]
        [Category("Page Navigation")]
        [TestCase("About Us")]
        [TestCase("Loan Programs")]
        [TestCase("Homebuyer Education")]
        [TestCase("News")]
        [TestCase("Careers")]
        [TestCase("Find a Loan Officer")]
        public void AboutUsMenuIsDisplayed(string menuItem)
        {
            // 1. Navigate To Home Page
            //This is done as part of Test Base Setup

            // 2. Verify Menu Item Is Displayed
            bool aboutUsMenuIsDisplayed = HomePage.MenuItemIsDisplayed(menuItem);
            Assert.IsTrue(aboutUsMenuIsDisplayed, "About Us Menu Item Is Not Displayed on HomePage");
        }

        [Test]
        [Category("About Us")]
        [Category("Smoke")]
        [Category("Page Navigation")]
        [TestCase("About Us", "Who We Are")]
        [TestCase("About Us", "What Sets Us Apart")]
        [TestCase("About Us", "How We Measure Success")]
        [TestCase("About Us", "Where We Began")]
        [TestCase("About Us", "Contact Us")]
        public void AboutUsSubMenuNavigations(string mainMenu, string subMenuItem)
        {
            // 1. Navigate To Home Page
            //This is done as part of Test Base Setup

            // 2. Navigate to About Us > Sub Menu Item (Who We Are, What Sets Us Apart, How We Measure Success, Where We Began, Contact Us)
            HomePage.NavigateToMenu(whichMenu: mainMenu, whichSubMenu: subMenuItem);

            // 3. Validate for each page Header Text Is Displayed
            bool correctPageLoaded = HomePage.CorrectPageLoaded(whichSubMenu: subMenuItem);
            Assert.IsTrue(correctPageLoaded, $"{mainMenu} > {subMenuItem} Did Not Load");

        }

    }
}
