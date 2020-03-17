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
    public class ValidarTarefasTest : TestBase
    {

        #region Pages and Flows Objects
        MainPage mainPage;
        LoginFlows loginFlows;
        ViewTasksPage viewTasksPage;
        TaskDetailsPage taskDetailsPage;
        MoveTaskPage moveTaskPage;
        CopyTaskPage copyTaskPage;
        AssingTasksPage assingTasksPage;
        DeleteTasksPage deleteTasksPage;
        TaskResolutionPage taskResolutionPage;
        TaskPriorityPage taskPriorityPage;
        #endregion

        protected OpenQA.Selenium.Support.UI.WebDriverWait wait { get; private set; }

        [Test]
        public void VisualizarTarefaCadastrada()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            viewTasksPage = new ViewTasksPage();
            taskDetailsPage = new TaskDetailsPage();

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefas();
            viewTasksPage.ClicarEmUmaTarefa();

            string verifica = "Ver Detalhes da Tarefa";

            Assert.AreEqual(verifica, taskDetailsPage.RetornaInfoTaskDetails());

        }

        [Test]
        public void MoverTarefaCadastrada()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            viewTasksPage = new ViewTasksPage();
            moveTaskPage = new MoveTaskPage();

            string projeto = "TestProject";

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefas();
            viewTasksPage.SelecionarTarefa();
            viewTasksPage.ClicarEmOk();
            moveTaskPage.SelecionarProjeto(projeto);
            moveTaskPage.ClicarEmMoverProjetos();
            
            string urlObtido = DriverFactory.INSTANCE.Url;
            string urlEsperado = "https://basedois.mantishub.io/view_all_bug_page.php";

            Assert.AreEqual(urlEsperado, urlObtido);

        }

        [Test]
        public void CopiarTarefa()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            viewTasksPage = new ViewTasksPage();
            copyTaskPage = new CopyTaskPage();

            string acao = "Copiar";

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefas();
            viewTasksPage.SelecionarTarefa();
            viewTasksPage.SelecionarAcao(acao);
            viewTasksPage.ClicarEmOk();
            copyTaskPage.ClicarEmCopiarProjetos();

            string urlObtido = DriverFactory.INSTANCE.Url;
            string urlEsperado = "https://basedois.mantishub.io/view_all_bug_page.php";

            Assert.AreEqual(urlEsperado, urlObtido);

        }

        [Test]
        public void AtribuirTarefa()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            viewTasksPage = new ViewTasksPage();
            assingTasksPage = new AssingTasksPage();

            string acao = "Atribuir";
            string usuario = "Kleber";

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefas();
            viewTasksPage.SelecionarTarefa();
            viewTasksPage.SelecionarAcao(acao);
            viewTasksPage.ClicarEmOk();
            assingTasksPage.SelecionarUsuario(usuario);
            assingTasksPage.ClicarEmAtribuirTarefas();
            
            string urlObtido = DriverFactory.INSTANCE.Url;
            string urlEsperado = "https://basedois.mantishub.io/view_all_bug_page.php";

            Assert.AreEqual(urlEsperado, urlObtido);

        }

        [Test]
        public void ApagarTarefa()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            viewTasksPage = new ViewTasksPage();
            deleteTasksPage = new DeleteTasksPage();

            string acao = "Apagar";

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefas();
            viewTasksPage.SelecionarTarefa();
            viewTasksPage.SelecionarAcao(acao);
            viewTasksPage.ClicarEmOk();
            deleteTasksPage.ClicarEmApagarTarefas();
            
            string urlObtido = DriverFactory.INSTANCE.Url;
            string urlEsperado = "https://basedois.mantishub.io/view_all_bug_page.php";

            Assert.AreEqual(urlEsperado, urlObtido);

        }

        [Test]
        public void ResolverTarefa()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            viewTasksPage = new ViewTasksPage();
            taskResolutionPage = new TaskResolutionPage();

            string acao = "Resolver";
            string resolucao = "suspenso";

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefas();
            viewTasksPage.SelecionarTarefa();
            viewTasksPage.SelecionarAcao(acao);
            viewTasksPage.ClicarEmOk();
            taskResolutionPage.SelecionarResolucaoDaTarefa(resolucao);
            taskResolutionPage.ClicarEmResolverTarefas();
                       
            string urlObtido = DriverFactory.INSTANCE.Url;
            string urlEsperado = "https://basedois.mantishub.io/view_all_bug_page.php";

            Assert.AreEqual(urlEsperado, urlObtido);

        }

        [Test]
        public void AtualizarPrioridadeDaTarefa()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            viewTasksPage = new ViewTasksPage();
            taskPriorityPage = new TaskPriorityPage();

            string acao = "Atualizar Prioridade";
            string prioridade = "alta";

            loginFlows.EfetuarLogin();
            mainPage.ClicarEmVerTarefas();
            viewTasksPage.SelecionarTarefa();
            viewTasksPage.SelecionarAcao(acao);
            viewTasksPage.ClicarEmOk();
            taskPriorityPage.SelecionarPrioridadeDaTarefa(prioridade);
            taskPriorityPage.ClicarEmAtualizarPrioridade();

            string urlObtido = DriverFactory.INSTANCE.Url;
            string urlEsperado = "https://basedois.mantishub.io/view_all_bug_page.php";

            Assert.AreEqual(urlEsperado, urlObtido);

        }

    }
}
