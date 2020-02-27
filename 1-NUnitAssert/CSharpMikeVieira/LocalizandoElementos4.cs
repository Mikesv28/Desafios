using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Tests
{
    [TestFixture]
    public class LocalizandoElementos4
    {
        #region 
        
        #endregion

        IWebDriver driver = new ChromeDriver();
        

        [Test]
        [Obsolete]
        public void NavegarOTempo()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.otempo.com.br/");

            IWebElement PopoverNot = driver.FindElement(By.XPath("/html/body/div[11]/div/div/div[2]/button[2]"));
            PopoverNot.Click();

            IWebElement Busca = driver.FindElement(By.ClassName("open-busca"));
            Busca.Click();

            wait.Until(ExpectedConditions.ElementExists(By.Name("q")));
            IWebElement CampoBusca = driver.FindElement(By.Name("q"));
            CampoBusca.SendKeys("Teste");

            IWebElement Lupa = driver.FindElement(By.XPath("/html/body/header/div[3]/div/div[2]/div[3]/img"));
            Lupa.Click();

            IWebElement Busca2 = driver.FindElement(By.ClassName("open-busca"));
            Busca2.Click();

            wait.Until(ExpectedConditions.ElementExists(By.Name("q")));
            IWebElement CampoBusca2 = driver.FindElement(By.Name("q"));
            CampoBusca2.SendKeys("Automação");

            IWebElement Lupa2 = driver.FindElement(By.XPath("/html/body/header/div[3]/div/div[2]/div[3]/img"));
            Lupa2.Click();

            IWebElement Scroll = driver.FindElement(By.XPath("/html/body"));
            Scroll.SendKeys(Keys.PageDown);
            Scroll.SendKeys(Keys.PageDown);
            Scroll.SendKeys(Keys.PageDown);
            Scroll.SendKeys(Keys.PageDown);
            Scroll.SendKeys(Keys.PageDown);
            Scroll.SendKeys(Keys.PageDown);

            //driver.Quit();
        }

    }
}
