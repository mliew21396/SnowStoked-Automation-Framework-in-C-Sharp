using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnowboardSite;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Go_To_HomePage()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestMethod]
        public void Can_Go_To_About_Page()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectAbout();
            Assert.IsTrue(Pages.HomePage.IsAtAboutPage("About"));
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}
