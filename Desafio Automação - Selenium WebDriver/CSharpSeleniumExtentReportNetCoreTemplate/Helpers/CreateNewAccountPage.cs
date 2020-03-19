using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using CSharpSeleniumExtentReportNetCoreTemplate.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class CreateNewAccountPage : PageBase
    {
        #region Mapping
        By fillUsername = By.Id("user-username");
        By fillRealName = By.Id("user-realname");
        By fillEmail = By.Id("email-field");
        By selectAccessLevel = By.Id("user-access-level");
        By clickCreateUser = By.XPath("//*[@id='manage-user-create-form']/div/div[3]/input");
        #endregion

        #region Actions
        public void SelecionarNivelDeAcesso(string nivelAcesso)
        {
            ComboBoxSelectByVisibleText(selectAccessLevel, nivelAcesso);
        }
        public void PreencherEmail(string email)
        {
            SendKeys(fillEmail, email);
        }
        public void PreencherNomeDeUsuario(string nomeUsuario)
        {
            SendKeys(fillUsername, nomeUsuario);
        }
        public void PreencherNomeVerdadeiro(string nomeVerdadeiro)
        {
            SendKeys(fillRealName, nomeVerdadeiro);
        }
        public void ClicarEmCriarUsuario()
        {
            Click(clickCreateUser);
        }
       
        #endregion
    }
}