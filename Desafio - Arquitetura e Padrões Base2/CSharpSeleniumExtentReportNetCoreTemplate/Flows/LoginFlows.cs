using CSharpSeleniumExtentReportNetCoreTemplate.Helpers;
using CSharpSeleniumExtentReportNetCoreTemplate.Pages;
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

        public LoginFlows()
        {
            loginPage = new LoginPage();
        }
        #endregion

        public void EfetuarLogin()
        {
            #region Parameters
            string username = BuilderJson.ReturnParameterAppSettings("CT_USER");
            string password = BuilderJson.ReturnParameterAppSettings("CT_PASSWORD");
            #endregion

            loginPage.PreencherUsuario(username);
            loginPage.PreencherSenha(password);
            loginPage.ClicarEmLogin();
        }
    }
}
