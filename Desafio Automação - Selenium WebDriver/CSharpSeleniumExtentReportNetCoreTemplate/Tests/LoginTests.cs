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
        MainPage mainPage;
        LoginFlows loginFlows;
        #endregion

        protected OpenQA.Selenium.Support.UI.WebDriverWait wait { get; private set; }

        [Test]
        public void LoginComSucesso()
        {
            loginPage = new LoginPage();
            mainPage = new MainPage();
            loginFlows = new LoginFlows();


            loginFlows.EfetuarLogin();

            

        }

        [Test]

        public void LoginComFalha()
        {
            loginPage = new LoginPage();
            mainPage = new MainPage();
            loginFlows = new LoginFlows();


            loginFlows.EfetuarLoginComFalha();

        }
    }
}
