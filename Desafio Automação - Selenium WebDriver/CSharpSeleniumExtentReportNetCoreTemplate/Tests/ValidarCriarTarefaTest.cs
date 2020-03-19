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
    public class ValidarCriarTarefaTest : TestBase
    {

        #region Pages and Flows Objects
        MainPage mainPage;
        LoginFlows loginFlows;
        SelectProjectPage selectProjectPage;
        CreateTaskPage createTaskPage;
        GeneralHelpers generalHelpers;
        #endregion
        
        [Test]
        public void CriarNovaTarefa()
        {
            
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            selectProjectPage = new SelectProjectPage();
            createTaskPage = new CreateTaskPage();
            generalHelpers = new GeneralHelpers();

            #region Descriptions
            string projeto = "TestProject";
            string categoria = "[Todos os Projetos] General";
            string gravidade = "grande";
            string prioridade = "baixa";
            string atribuir = "administrator";
            string resumo = "Criar tarefa";
            string descricao = "Criação da tarefa de teste";           
            #endregion

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmCriarTarefa();
            selectProjectPage.SelecionarProjeto(projeto);
            selectProjectPage.ClicarEmSelecionarProjeto();
            createTaskPage.SelecionarCategoria(categoria);
            createTaskPage.SelecionarGravidade(gravidade);
            createTaskPage.SelecionarPrioridade(prioridade);
            createTaskPage.SelecionarAtribuirA(atribuir);
            createTaskPage.PreencherResumo(resumo);
            createTaskPage.PreencherDescricao(descricao);
            createTaskPage.ClicarEmCriarNovaTarefa();

            string verifica = "Núm";

            Assert.AreEqual(verifica, createTaskPage.RetornaInfoCreateTask());

        }

        [Test]
        public void ValidarCriarMaisTarefas()
        {

            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            selectProjectPage = new SelectProjectPage();
            createTaskPage = new CreateTaskPage();
            generalHelpers = new GeneralHelpers();

            #region Descriptions
            string projeto = "TestProject";
            string categoria = "[Todos os Projetos] General";
            string gravidade = "grande";
            string prioridade = "baixa";
            string atribuir = "administrator";
            string resumo = "Criar tarefa mais tarefa";
            string descricao = "Criação da tarefa de teste mais tarefa";
            #endregion

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmCriarTarefa();
            selectProjectPage.SelecionarProjeto(projeto);
            selectProjectPage.ClicarEmSelecionarProjeto();
            createTaskPage.SelecionarCategoria(categoria);
            createTaskPage.SelecionarGravidade(gravidade);
            createTaskPage.SelecionarPrioridade(prioridade);
            createTaskPage.SelecionarAtribuirA(atribuir);
            createTaskPage.PreencherResumo(resumo);
            createTaskPage.PreencherDescricao(descricao);
            createTaskPage.ClicarEmSelecionarParaCriaMaisTarefas();
            createTaskPage.ClicarEmCriarNovaTarefa();

            string verifica = "Categoria";
            
            Assert.AreEqual(verifica, createTaskPage.RetornaInfoCreateMoreTask());

        }

        [Test]
        public void ValidarCampoResumoObrigatorio()
        {

            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            selectProjectPage = new SelectProjectPage();
            createTaskPage = new CreateTaskPage();
            generalHelpers = new GeneralHelpers();

            #region Descriptions
            string projeto = "TestProject";
            string categoria = "[Todos os Projetos] General";
            string gravidade = "grande";
            string prioridade = "baixa";
            string atribuir = "administrator";
            string descricao = "Criação da tarefa de teste mais tarefa";
            #endregion

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmCriarTarefa();
            selectProjectPage.SelecionarProjeto(projeto);
            selectProjectPage.ClicarEmSelecionarProjeto();
            createTaskPage.SelecionarCategoria(categoria);
            createTaskPage.SelecionarGravidade(gravidade);
            createTaskPage.SelecionarPrioridade(prioridade);
            createTaskPage.SelecionarAtribuirA(atribuir);
            createTaskPage.PreencherDescricao(descricao);
            createTaskPage.ClicarEmCriarNovaTarefa();

            string verifica = "";

            Assert.AreEqual(verifica, createTaskPage.RetornaResumoNaoPreenchido());

        }

        [Test]
        public void ValidarCampoDescricaoObrigatorio()
        {

            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            selectProjectPage = new SelectProjectPage();
            createTaskPage = new CreateTaskPage();
            generalHelpers = new GeneralHelpers();

            #region Descriptions
            string projeto = "TestProject";
            string categoria = "[Todos os Projetos] General";
            string gravidade = "grande";
            string prioridade = "baixa";
            string atribuir = "administrator";
            string resumo = "Criar tarefa mais tarefa";
            #endregion

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmCriarTarefa();
            selectProjectPage.SelecionarProjeto(projeto);
            selectProjectPage.ClicarEmSelecionarProjeto();
            createTaskPage.SelecionarCategoria(categoria);
            createTaskPage.SelecionarGravidade(gravidade);
            createTaskPage.SelecionarPrioridade(prioridade);
            createTaskPage.SelecionarAtribuirA(atribuir);
            createTaskPage.PreencherResumo(resumo);
            createTaskPage.ClicarEmCriarNovaTarefa();

            string verifica = "";

            Assert.AreEqual(verifica, createTaskPage.RetornaDescricaoNaoPreenchido());

        }
    }
}
