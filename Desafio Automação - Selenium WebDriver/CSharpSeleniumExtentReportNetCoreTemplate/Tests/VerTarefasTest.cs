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
    public class VerTarefasTest : TestBase
    {

        #region Pages and Flows Objects
        MainPage mainPage;
        LoginFlows loginFlows;
        #endregion

        protected OpenQA.Selenium.Support.UI.WebDriverWait wait { get; private set; }

        [Test]
        public void AcessarMinhaConta()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefas();

            string titleObtido = DriverFactory.INSTANCE.Title;
            string titleEsperado = "Minha Conta - MantisHub";

            Assert.AreEqual(titleEsperado, titleObtido);

        }

    }
}
