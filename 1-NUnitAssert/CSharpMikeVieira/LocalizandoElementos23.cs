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
    public class LocalizandoElementos23
    {
        #region
        #endregion

        IWebDriver driver = new ChromeDriver();
    

        [Test]
        [Obsolete]
        public void NavegarPreencher()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");

            String result = "Form filled out successfully";

            IWebElement Nome = driver.FindElement(By.Id("et_pb_contact_name_0"));
            Nome.SendKeys("Mike");
            IWebElement Mensagem = driver.FindElement(By.Id("et_pb_contact_message_0"));
            Mensagem.SendKeys("Teste de Automoção com Selenium Webdriver");
            IWebElement Submit = driver.FindElement(By.Name("et_builder_submit_button"));
            Submit.Click();

            wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='et_pb_contact_form_0']/div/p")));
            IWebElement Resposta = driver.FindElement(By.XPath("//*[@id='et_pb_contact_form_0']/div/p"));

            string TextoResposta = Resposta.Text;

            if (TextoResposta != result)
            {
                driver.Quit();
            } else
            {
                Assert.AreEqual(result, TextoResposta);
            }

            driver.Quit();

        }

        [Test]
        [Obsolete]
        public void NavegarSemPreencher()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");

            String result = "Please, fill in the following fields:";

            IWebElement Mensagem = driver.FindElement(By.Id("et_pb_contact_message_0"));
            Mensagem.SendKeys("Teste de Automoção com Selenium Webdriver");
            IWebElement Submit = driver.FindElement(By.Name("et_builder_submit_button"));
            Submit.Click();

            wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='et_pb_contact_form_0']/div/p")));
            IWebElement Resposta = driver.FindElement(By.XPath("//*[@id='et_pb_contact_form_0']/div[1]/p"));

            string textoResposta = Resposta.Text;

            Assert.AreEqual(result, textoResposta);

            driver.Quit();

        }

    }
}
