//Inside SeleniumTest.cs

using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Firefox;

using System;

using System.Collections.ObjectModel;

using System.IO;

namespace SeleniumCsharp

{

    public class Tests

    {

        IWebDriver driver;

        [OneTimeSetUp]

        public void Setup()

        {

            //Below code is to get the drivers folder path dynamically.

            //You can also specify chromedriver.exe path dircly ex: C:/MyProject/Project/drivers

            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            //Creates the ChomeDriver object, Executes tests on Google Chrome

            driver = new ChromeDriver(path+@"\drivers\");

            //If you want to Execute Tests on Firefox uncomment the below code

            // Specify Correct location of geckodriver.exe folder path. Ex: C:/Project/drivers

            //driver= new FirefoxDriver(path + @"\drivers\");

        }

        [Test]

        public void verifyLogo()

        {

            driver.Navigate().GoToUrl("https://fap.fpi.edu.vn");

            Assert(driver.FindElement(By.Id("LogoBTEC")).Displayed);

        }

        [Test]

        public void verifyMenuItemcount()

        {

            ReadOnlyCollection<IWebElement> menuItem = driver.FindElements(By.XPath("//ul[contains(@class,'horizontal-list product-menu')]/li"));

            Assert(menuItem.Count, 4);

        }

        private void Assert(int count, int v)
        {
            throw new NotImplementedException();
        }

        [Test]

        public void verifyPricingPage()

        {

            driver.Navigate().GoToUrl("https://browserstack.com/pricing");
            IWebElement contactUsPageHeader = driver.FindElement(By.TagName("h1"));

            Assert(contactUsPageHeader.Text.Contains("Replace your device lab and VMs with any of these plans"));

        }

        private void Assert(bool v)
        {
            throw new NotImplementedException();
        }

        [OneTimeTearDown]

        public void TearDown()

        {

            driver.Quit();

        }

    }

}
