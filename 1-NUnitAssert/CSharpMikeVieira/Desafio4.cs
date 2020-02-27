using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMikeVieira
{
    [TestFixture]
    public class Desafio4
    {

        IWebDriver driver = new ChromeDriver();
        

        [Test]
        public void DropDownList()
        {
                     
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dropdown");

            IWebElement OpcoesCombo = driver.FindElement(By.Id("dropdown"));
            SelectElement ComboBox = new SelectElement(OpcoesCombo);

            ComboBox.SelectByIndex(1);
        }

        [Test]
        [Obsolete]
        public void CrowdTest()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://blackmirror.crowdtest.me/users/sign_in");

            //wait.Until(ExpectedConditions.ElementExists(By.Name("user[email]")));
            IWebElement Email = driver.FindElement(By.Name("user[email]"));
            Email.SendKeys("mike.vieira@base2.com.br");

            IWebElement Senha = driver.FindElement(By.Name("user[password]"));
            Senha.SendKeys("fresno2019");

            IWebElement Logar = driver.FindElement(By.Name("commit"));
            Logar.Click();

            IWebElement GerenciarProjetos = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[1]/div[3]/a"));
            GerenciarProjetos.Click();

            wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/nav/div[2]/div/ul/a[2]/li/div/i")));
            IWebElement Projetos = driver.FindElement(By.XPath("/html/body/div/nav/div[2]/div/ul/a[2]/li/div/i"));
            Projetos.Click();

            wait.Until(ExpectedConditions.ElementExists(By.Id("btn_open_project_425")));
            IWebElement SelecionarProjeto = driver.FindElement(By.Id("btn_open_project_425"));
            SelecionarProjeto.Click();

            IWebElement CasoDeTeste = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/ul/li[3]/a/span"));
            CasoDeTeste.Click();

            
            IWebElement Item = driver.FindElement(By.XPath(".//td[@class='sorting_1' and contains(text(),'Validar o cadastro de releases')]"));

            Assert.IsTrue(Item.Displayed);
        }
    }
}
