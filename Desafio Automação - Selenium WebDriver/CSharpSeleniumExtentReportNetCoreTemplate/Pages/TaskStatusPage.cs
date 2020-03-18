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
    public class TaskStatusPage : PageBase
    {
        #region Mapping
        By selectTaskStatus = By.Name("status");
        By clickUpdateStatus = By.XPath("//*[@id='action-group-div']/form/div/div[2]/div[2]/input");

        #endregion

        #region Actions

        public void SelecionarStatusDaTarefa(string prioridade)
        {
            ComboBoxSelectByVisibleText(selectTaskStatus, prioridade);
        }

        public void ClicarEmAtualizarStatus()
        {
            Click(clickUpdateStatus);
        }

        #endregion
    }
}