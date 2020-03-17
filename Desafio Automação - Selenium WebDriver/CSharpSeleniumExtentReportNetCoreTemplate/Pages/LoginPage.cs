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
        By infoLogin = By.XPath("//*[@id='login-div']/div[4]/p");
        By clickLostPassword = By.XPath("//*[@id='login-form']/fieldset/a");
        By emailRecovery = By.Id("email-field");
        By clickSend = By.XPath("//*[@id='lost-password-form']/fieldset/input");
        #endregion

        #region Actions
        public void ClicarEmPerdeuSenha()
        {
            Click(clickLostPassword);
        }

        public void ClicarEmEnviar()
        {
            Click(clickSend);
        }
        public string RetornaInfoLogin()
        {
            return GetText(infoLogin);
        }
        public void PreencherUsuario(string usuario)
        {
            SendKeys(usernameField, usuario);
        }

        public void PreencherEmailAjuste(string emailAjuste)
        {
            SendKeys(emailRecovery, emailAjuste);
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
