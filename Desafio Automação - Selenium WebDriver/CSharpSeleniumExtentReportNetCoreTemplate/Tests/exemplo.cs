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
    public class exemplo : TestBase
    {
        #region Pages and Flows Objects
        MainPage mainPage;
        LoginFlows loginFlows;
        #endregion
        
        [Test]
        public void AcessasCasosDeTestes()
        {
            #region Instancia de Objetos
            mainPage = new MainPage();
            loginFlows = new LoginFlows();

            #endregion

            #region Tests

            loginFlows.EfetuarLogin();

            #endregion
        }
    }
}
