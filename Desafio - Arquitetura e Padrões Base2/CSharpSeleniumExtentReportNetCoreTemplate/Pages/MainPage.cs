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
        By usernameLoginInfoTextArea = By.XPath("//td[@class='login-info-left']/span[@class='italic']");
        By reportIssueLink = By.XPath("//a[@href='/bug_report_page.php']");
        By gerenciarProjetos = By.XPath("/html/body/div[1]/div/div/div[2]/div[1]/div[3]/a");

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

        #endregion
    }
}