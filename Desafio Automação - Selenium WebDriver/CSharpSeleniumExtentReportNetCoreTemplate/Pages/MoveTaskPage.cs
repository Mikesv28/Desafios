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
    public class MoveTaskPage : PageBase
    {
        #region Mapping
        By selectProject = By.Name("project_id");
        By clickMoveTasks = By.XPath("//*[@id='action-group-div']/form/div/div[2]/div[2]/input"); 

        #endregion

        #region Actions
        public void SelecionarProjeto(string projeto)
        {
            ComboBoxSelectByVisibleText(selectProject, projeto);
        }

        public void ClicarEmMoverProjetos()
        {
            Click(clickMoveTasks);
        }

        #endregion
    }
}