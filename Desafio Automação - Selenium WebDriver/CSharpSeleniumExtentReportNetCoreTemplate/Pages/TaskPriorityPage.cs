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
    public class TaskPriorityPage : PageBase
    {
        #region Mapping
        By selectTaskPriority = By.Name("priority");
        By clickUpdatePriority = By.XPath("//*[@id='action-group-div']/form/div/div[2]/div[2]/input");

        #endregion

        #region Actions

        public void SelecionarPrioridadeDaTarefa(string prioridade)
        {
            ComboBoxSelectByVisibleText(selectTaskPriority, prioridade);
        }

        public void ClicarEmAtualizarPrioridade()
        {
            Click(clickUpdatePriority);
        }

        #endregion
    }
}