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
    public class TaskResolutionPage : PageBase
    {
        #region Mapping
        By selectResolutionTask = By.Name("resolution");
        By clickSolveTasks = By.XPath("//*[@id='action-group-div']/form/div/div[2]/div[2]/input");

        #endregion

        #region Actions

        public void SelecionarResolucaoDaTarefa(string resolucao)
        {
            ComboBoxSelectByVisibleText(selectResolutionTask, resolucao);
        }

        public void ClicarEmResolverTarefas()
        {
            Click(clickSolveTasks);
        }

        #endregion
    }
}