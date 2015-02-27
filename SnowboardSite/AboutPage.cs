using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SnowboardSite
{
    public class AboutPage
    {
        //[FindsBy(How = How.CssSelector, Using = "div#the-post h2.entry-title.single")]
        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[2]/div/div[2]/div/h2")]
        private IWebElement aboutName;
        public string AboutName
        {
            get { return aboutName.Text; }
        }
    }
}
