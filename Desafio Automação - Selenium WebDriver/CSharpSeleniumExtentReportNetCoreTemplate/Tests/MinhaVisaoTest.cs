using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using CSharpSeleniumExtentReportNetCoreTemplate.DataBaseSteps;
using CSharpSeleniumExtentReportNetCoreTemplate.Flows;
using CSharpSeleniumExtentReportNetCoreTemplate.Helpers;
using CSharpSeleniumExtentReportNetCoreTemplate.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Tests
{
    [TestFixture]
    public class MinhaVisaoTest : TestBase
    {

        #region Pages and Flows Objects
        MainPage mainPage;
        LoginFlows loginFlows;
        TaskPage taskPage;
        #endregion

        protected OpenQA.Selenium.Support.UI.WebDriverWait wait { get; private set; }

        [Test]
        public void AcessarAtribuidosAMim()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            taskPage = new TaskPage();

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefasAtribuidasAMim();
                        
            string verifica = "administrator";

            Assert.AreEqual(verifica, taskPage.RetornaInfoTaskAtribuido());

        }

        [Test]
        public void AcessarNaoAtribuidos()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            taskPage = new TaskPage();

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefasNaoAtribuidas();
            
            string verifica = "nenhum";

            Assert.AreEqual(verifica, taskPage.RetornaInfoTaskAtribuido());

        }

        [Test]
        public void AcessarRelatadorPorMim()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            taskPage = new TaskPage();

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefasRelatadasPorMim();
            
            string verifica = "administrator";

            Assert.AreEqual(verifica, taskPage.RetornaInfoTaskRelatado());

        }

        [Test]
        public void AcessarResolvidos()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            taskPage = new TaskPage();

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefasResolvidas();

            string verifica = "resolvido";

            Assert.AreEqual(verifica, taskPage.RetornaInfoTaskResolvido());

        }

        [Test]
        public void AcessarModificadosRecentemente()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            taskPage = new TaskPage();

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefasModificadasRecentemente();

            string verifica = "Não";

            Assert.AreNotEqual(verifica, taskPage.RetornaInfoTaskModificadoRecentemente());

        }

        [Test]
        public void AcessarMonitoradosPorMim()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            taskPage = new TaskPage();

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefasMonitoradasPorMim();

            string verifica = "administrator";

            Assert.AreEqual(verifica, taskPage.RetornaInfoTaskMonitorado());

        }

    }
}
