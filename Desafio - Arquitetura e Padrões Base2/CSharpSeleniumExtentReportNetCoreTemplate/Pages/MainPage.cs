using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class MainPage : PageBase
    {
        #region Mapping
        By usernameLoginInfoTextArea = By.XPath("//td[@class='login-info-left']/span[@class='italic']");
        By reportIssueLink = By.XPath("//a[@href='/bug_report_page.php']");
        By gerenciarProjetos = By.XPath("/html/body/div[1]/div/div/div[2]/div[1]/div[3]/a");
        By clicarEmProjetos = By.XPath("/html/body/div/nav/div[2]/div/ul/a[2]/li/div/i");
        By visualizarProjeto = By.Id("btn_open_project_425");
        By clicarEmCasoDeTeste = By.XPath("/html/body/div/div/div[1]/div[2]/ul/li[3]/a/span");
        By localizarCasoDeTeste = By.XPath(".//td[@class='sorting_1' and contains(text(),'Validar o cadastro de releases')]");
        #endregion

        #region Actions
        public string RetornaUsernameDasInformacoesDeLogin()
        {
            return GetText(usernameLoginInfoTextArea);
        }

        public void ClicarEmReportIssue()
        {
            Click(reportIssueLink);
        }

        public void ClicarEmGerenciarProjetos()
        {
            Click(gerenciarProjetos);
        }

        public void ClicarEmProjetos()
        {
            Click(clicarEmProjetos);
        }

        public void VisualizarProjeto()
        {
            Click(visualizarProjeto);
        }

        public void ClicarEmCasoDeTeste()
        {
            Click(clicarEmCasoDeTeste);
        }

        public string LocalizarCasoDeTeste()
        {
            return GetText(localizarCasoDeTeste);
        }
        #endregion
    }
}
