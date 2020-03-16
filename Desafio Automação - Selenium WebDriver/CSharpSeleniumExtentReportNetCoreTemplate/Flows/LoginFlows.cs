﻿using CSharpSeleniumExtentReportNetCoreTemplate.Helpers;
using CSharpSeleniumExtentReportNetCoreTemplate.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Flows
{
    public class LoginFlows
    {
        #region Page Object and Constructor
        LoginPage loginPage;
        MainPage mainPage;

        public LoginFlows()
        {
            loginPage = new LoginPage();
        }
        #endregion

        public void EfetuarLogin()
        {
            mainPage = new MainPage();

            #region Parameters
            string username = BuilderJson.ReturnParameterAppSettings("MT_USER");
            string password = BuilderJson.ReturnParameterAppSettings("MT_PASSWORD");
            #endregion

            loginPage.PreencherUsuario(username);
            loginPage.ClicarEmEntrar();
            loginPage.PreencherSenha(password);
            loginPage.ClicarEmAcessar();

            Assert.AreEqual(username, mainPage.RetornaUsernameDasInformacoesDeLogin());
        }

        public void EfetuarLoginComFalha()
        {
            mainPage = new MainPage();

            #region Parameters
            string username = BuilderJson.ReturnParameterAppSettings("MT_USER");
            string password = BuilderJson.ReturnParameterAppSettings("MT_INCORRECTPASSWORD");
            #endregion

            loginPage.PreencherUsuario(username);
            loginPage.ClicarEmEntrar();
            loginPage.PreencherSenha(password);
            loginPage.ClicarEmAcessar();

            Assert.AreNotEqual(username, mainPage.RetornaUsernameDasInformacoesDeLogin());
        }
    }
}
