using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace SnowboardSite
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver = new InternetExplorerDriver(@"C:\Users\mliew\Desktop\Selenium Browser Drivers\");
            //IWebDriver driver = new ChromeDriver(@"C:\Users\mliew\Desktop\Selenium Browser Drivers\");
            //driver.Manage().Window.Maximize();

            driver.Url = "http://snowstoked.com/";
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            var aboutLink = driver.FindElement(By.PartialLinkText("About"));
            aboutLink.Click();

            var about = driver.FindElement(By.CssSelector("div#the-post h2.entry-title.single"));
            Console.WriteLine(about.Text);
        }
    }
}
