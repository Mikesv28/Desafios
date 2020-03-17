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
    public class MainPage : PageBase
    {
        #region Mapping
        By infoHome = By.XPath("//*[@id='trial_banner']/strong");
        By reportIssueLink = By.XPath("//a[@href='/bug_report_page.php']");
        By clickAssigned = By.XPath("//*[@id='assigned']/div[1]/h4/a");
        By clickUnassigned = By.XPath("//*[@id='unassigned']/div[1]/h4/a");
        By clickReported = By.XPath("//*[@id='reported']/div[1]/h4/a");
        By clickResolved = By.XPath("//*[@id='resolved']/div[1]/h4/a");
        By clickRecentlyModified = By.XPath("//*[@id='recent_mod']/div[1]/h4/a");
        By clickMonitored = By.XPath("//*[@id='monitored']/div[1]/h4/a");
        By clickProfile = By.ClassName("user-info");
        By clickMyAccount = By.XPath("//*[@id='navbar-container']/div[2]/ul/li[3]/ul/li[1]/a");
        By clickViewTasks = By.XPath("//*[@id='sidebar']/ul/li[2]/a/span"); 

        #endregion

        #region Actions
        public string RetornaInfoHome()
        {
            return GetText(infoHome);
        }

        public void ClicarEmReportIssue()
        {
            Click(reportIssueLink);
        }

        public void ClicarEmVerTarefasAtribuidasAMim()
        {
            Click(clickAssigned);
        }

        public void ClicarEmVerTarefasNaoAtribuidas()
        {
            Click(clickUnassigned);
        }

        public void ClicarEmVerTarefasRelatadasPorMim()
        {
            Click(clickReported);
        }

        public void ClicarEmVerTarefasResolvidas()
        {
            Click(clickResolved);
        }

        public void ClicarEmVerTarefasModificadasRecentemente()
        {
            Click(clickRecentlyModified);
        }
        public void ClicarEmVerTarefasMonitoradasPorMim()
        {
            Click(clickMonitored);
        }

        public void ClicarEmAdministrador()
        {
            Click(clickProfile);
        }

        public void ClicarEmMinhaConta()
        {
            Click(clickMyAccount);
        }

        public void ClicarEmVerTarefas()
        {
            Click(clickViewTasks);
        }
        #endregion
    }
}