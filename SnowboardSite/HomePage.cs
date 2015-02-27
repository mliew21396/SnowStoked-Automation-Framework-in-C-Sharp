using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SnowboardSite
{
    public class HomePage
    {

        static string Url = "http://snowstoked.com/";
        static string PageTitle = "snowstoked.com";

        [FindsBy(How = How.LinkText, Using = "About")]
        private IWebElement aboutLink;

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void SelectAbout()
        {
            aboutLink.Click();
        }

        public bool IsAtAboutPage(string aboutName)
        {
            var aboutPage = new AboutPage();
            PageFactory.InitElements(Browser.Driver, aboutPage);
            return aboutPage.AboutName == aboutName;
        }
    }
}
