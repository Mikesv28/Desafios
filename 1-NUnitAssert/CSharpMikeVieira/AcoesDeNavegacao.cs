using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Tests
{
    [TestFixture]
    public class Desafio2
    {
        #region Pages and Flows Objects
        
        #endregion

        IWebDriver driver = new ChromeDriver();
        [Test]
        public void Navegar()
        {

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Quit();
            
        }

        [Test]

        public void TesteNavegacao()
        {
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.google.com/");

            string teste;
            teste = driver.Url;

            Assert.AreEqual("https://www.google.com/", teste);

            driver.Quit();
            
        }

        public bool VerificaLink(string link)
        {
            return link.Equals("https://www.google.com/");
        }

        [Test]

        public void AssertLink()
        {
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.google.com/");

            string teste;
            teste = driver.Url;

            Assert.IsTrue(VerificaLink(teste));

            driver.Quit();

        }
    }
}
