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
        
        [Test]
        public void AcessasCasosDeTestes()
        {
            #region Instancia de Objetos
            mainPage = new MainPage();
            loginFlows = new LoginFlows();
            dashboardPage = new DashboardPage();
            projectsPage = new ProjectsPage();
            projectPage = new ProjectPage();

            #endregion

            #region Tests

            loginFlows.EfetuarLogin();

            mainPage.ClicarEmGerenciarProjetos();
                        
            dashboardPage.ClicarEmProjetos();
                        
            projectsPage.VisualizarProjeto();

            projectPage.ClicarEmCasoDeTeste();                

            projectPage.VerificaCasoDeTeste();

            #endregion
        }
    }
}
