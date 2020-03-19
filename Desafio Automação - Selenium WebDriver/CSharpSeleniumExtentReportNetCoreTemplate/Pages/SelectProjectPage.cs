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
    public class SelectProjectPage : PageBase
    {
        #region Mapping
        By selectProject = By.Id("select-project-id");
        By clickSelectProject = By.XPath("//*[@id='select-project-form']/div/div[2]/div[2]/input");

        #endregion

        #region Actions
        public void SelecionarProjeto(string projeto)
        {
            ComboBoxSelectByVisibleText(selectProject, projeto);
        }

        public void ClicarEmSelecionarProjeto()
        {
            Click(clickSelectProject);
        }
        #endregion
    }
}