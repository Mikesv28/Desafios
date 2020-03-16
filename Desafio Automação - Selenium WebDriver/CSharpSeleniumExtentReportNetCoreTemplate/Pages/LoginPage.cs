using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class LoginPage : PageBase
    {
        #region Mapping
        By usernameField = By.Id("username");
        By passwordField = By.Id("password");
        By loginButton = By.XPath("//*[@id='login-form']/fieldset/input[2]");
        By accessButton = By.XPath("//*[@id='login-form']/fieldset/input[3]");
        #endregion

        #region Actions
        public void PreencherUsuario(string usuario)
        {
            SendKeys(usernameField, usuario);
        }

        public void PreencherSenha(string senha)
        {
            SendKeys(passwordField, senha);
        }

        public void ClicarEmEntrar()
        {
            Click(loginButton);
        }

        public void ClicarEmAcessar()
        {
            Click(accessButton);
        }

        

        #endregion
    }
}
