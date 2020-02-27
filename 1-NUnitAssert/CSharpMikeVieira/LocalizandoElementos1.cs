using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Tests
{
    [TestFixture]
    public class LocalizandoElementos1
    {
        #region 

        #endregion

        IWebDriver driver = new ChromeDriver();

    
        [Test]
        public void NavegarBusca()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");

            IWebElement Search = driver.FindElement(By.Name("q"));
            Search.SendKeys("Teste");
            Search.Submit();
        
            IWebElement Link = driver.FindElement(By.PartialLinkText("Teste"));

            Assert.IsTrue(Link.Displayed);

            driver.Quit();

        }

    }
}
