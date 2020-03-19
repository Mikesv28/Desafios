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
    public class LoginTests : TestBase
    {

        #region Pages and Flows Objects
        LoginPage loginPage;
        LoginFlows loginFlows;
        PageBase pageBase;
        #endregion

        protected OpenQA.Selenium.Support.UI.WebDriverWait wait { get; private set; }

        [Test]
        public void LoginComSucesso()
        {
            loginPage = new LoginPage();
            loginFlows = new LoginFlows();
            
            loginFlows.EfetuarLogin();
                      
        }

        [Test]

        public void LoginComFalha()
        {
            loginPage = new LoginPage();
            loginFlows = new LoginFlows();
            
            loginFlows.EfetuarLoginComFalha();

        }

        [Test]
        public void PerdeuSuaSenha()
        {
            #region Parameters
            string username = BuilderJson.ReturnParameterAppSettings("MT_USER");
            #endregion

            loginPage = new LoginPage();
            loginFlows = new LoginFlows();
            pageBase = new PageBase();

            loginPage.PreencherUsuario(username);
            loginPage.ClicarEmEntrar();
            loginPage.ClicarEmPerdeuSenha();
            loginPage.PreencherEmailAjuste(username);
            loginPage.ClicarEmEnviar();

            string urlRetorno = pageBase.GetURL();
            string urlEsperada = "https://basedois.mantishub.io/lost_pwd.php";

            Assert.AreEqual(urlEsperada, urlRetorno);                                 
        }
    }
}
