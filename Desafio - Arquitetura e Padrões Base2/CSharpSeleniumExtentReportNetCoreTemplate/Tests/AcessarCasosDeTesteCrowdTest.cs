using NUnit.Framework;
using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using CSharpSeleniumExtentReportNetCoreTemplate.Flows;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using CSharpSeleniumExtentReportNetCoreTemplate.Helpers;
using CSharpSeleniumExtentReportNetCoreTemplate.Pages;

namespace CSharpMikeVieira
{
    [TestFixture]
    public class AcessarCasosDeTesteCrowdTest : TestBase
    {
        #region Pages and Flows Objects
        MainPage mainPage;
        LoginFlows loginFlows;
        DashboardPage dashboardPage;
        ProjectsPage projectsPage;
        ProjectPage projectPage;
        #endregion
        protected OpenQA.Selenium.Support.UI.WebDriverWait wait { get; private set; }

        protected IWebElement WaitForElement(By locator)
        {

            wait = new OpenQA.Selenium.Support.UI.WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(Convert.ToInt32(BuilderJson.ReturnParameterAppSettings("DEFAULT_TIMEOUT_IN_SECONDS"))));
            wait.Until(ExpectedConditions.ElementExists(locator));
            IWebElement element = DriverFactory.INSTANCE.FindElement(locator);

            return element;
        }

        [Test]
        public void CrowdTest()
        {
            #region Instancia de Objetos
            mainPage = new MainPage();
            loginFlows = new LoginFlows();
            dashboardPage = new DashboardPage();
            projectsPage = new ProjectsPage();
            projectPage = new ProjectPage();

            #endregion

            #region Parameters
            string usuario = "mike.vieira@base2.com.br";
            string senha = "fresno2019";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);

            mainPage.ClicarEmGerenciarProjetos();

            dashboardPage.AguardaProjetos();
            dashboardPage.ClicarEmProjetos();

            projectsPage.AguardaProjeto();
            projectsPage.VisualizarProjeto();

            projectPage.ClicarEmCasoDeTeste();

            //IWebElement Item = DriverFactory.INSTANCE.FindElement(By.XPath(".//td[@class='sorting_1' and contains(text(),'Validar o cadastro de releases')]"));
            //Verificar com a larissa como resolver o assert.
            //string Item = mainPage.LocalizarCasoDeTeste();

            IWebElement Item = DriverFactory.INSTANCE.FindElement(By.XPath(".//td[@class='sorting_1' and contains(text(),'Validar o cadastro de releases')]"));

            Assert.IsTrue(Item.Displayed);           
        }
    }
}
