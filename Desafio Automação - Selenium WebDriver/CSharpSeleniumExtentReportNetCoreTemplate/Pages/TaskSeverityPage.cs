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
    public class TaskSeverityPage : PageBase
    {
        #region Mapping
        By selectTaskSeverity = By.Name("severity");
        By clickUpdateSeverity = By.XPath("//*[@id='action-group-div']/form/div/div[2]/div[2]/input");

        #endregion

        #region Actions

        public void SelecionarGravidadeDaTarefa(string prioridade)
        {
            ComboBoxSelectByVisibleText(selectTaskSeverity, prioridade);
        }

        public void ClicarEmAtualizarGravidade()
        {
            Click(clickUpdateSeverity);
        }

        #endregion
    }
}