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
    public class AssingTasksPage : PageBase
    {
        #region Mapping
        By clickAssingTasks = By.XPath("//*[@id='action-group-div']/form/div/div[2]/div[2]/input");
        By selectUser = By.Name("assign");

        #endregion

        #region Actions

        public void ClicarEmAtribuirTarefas()
        {
            Click(clickAssingTasks);
        }

        public void SelecionarUsuario(string usuario)
        {
            ComboBoxSelectByVisibleText(selectUser, usuario);
        }

        #endregion
    }
}