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
    public class TaskCategoryPage : PageBase
    {
        #region Mapping
        By selectTaskCategory = By.Name("category");
        By clickUpdateCategory = By.XPath("//*[@id='action-group-div']/form/div/div[2]/div[2]/input");

        #endregion

        #region Actions

        public void SelecionarCategoriaDaTarefa(string prioridade)
        {
            ComboBoxSelectByVisibleText(selectTaskCategory, prioridade);
        }

        public void ClicarEmAtualizarCategoria()
        {
            Click(clickUpdateCategory);
        }

        #endregion
    }
}