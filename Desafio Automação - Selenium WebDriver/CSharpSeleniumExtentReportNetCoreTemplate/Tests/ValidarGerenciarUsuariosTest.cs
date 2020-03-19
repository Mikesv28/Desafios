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
    public class ValidarGerenciarUsuariosTest : TestBase
    {

        #region Pages and Flows Objects
        MainPage mainPage;
        LoginFlows loginFlows;
        ManegePage manegePage;
        CreateNewAccountPage createNewAccountPage;
        ManegeEditUserPage manegeEditUserPage;
        #endregion
                
        [Test]
        public void ValidarCriarNovoUsuario()
        {

            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            manegePage = new ManegePage();
            createNewAccountPage = new CreateNewAccountPage();
            manegeEditUserPage = new ManegeEditUserPage();

            #region Descriptions
            string nomeDeUsuario = "RenatoG";
            string nomeReal = "Renato Garcia";
            string email = "renatog@gmail.com.br";
            string nivelAcesso = "administrador";
            #endregion

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmGerenciar();
            manegePage.ClicarEmGerenciarUsuarios();
            manegePage.ClicarEmCriarNovaConta();
            createNewAccountPage.PreencherNomeDeUsuario(nomeDeUsuario);
            createNewAccountPage.PreencherNomeVerdadeiro(nomeReal);
            createNewAccountPage.PreencherEmail(email);
            createNewAccountPage.SelecionarNivelDeAcesso(nivelAcesso);
            createNewAccountPage.ClicarEmCriarUsuario();

            Assert.AreEqual(nomeDeUsuario, manegeEditUserPage.RetornaInfoNomeUsuario());

        }
              
    }
}
