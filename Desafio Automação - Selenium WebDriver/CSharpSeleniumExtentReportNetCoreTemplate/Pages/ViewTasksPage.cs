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
    public class ViewTasksPage : PageBase
    {
        #region Mapping
        By infoHome = By.XPath("//*[@id='trial_banner']/strong");

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

        #endregion
    }
}