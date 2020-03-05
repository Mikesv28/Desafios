using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class ProjectsPage : PageBase
    {
        #region Mapping
        By visualizarProjeto = By.Id("btn_open_project_425");

        #endregion

        #region Actions
        public void VisualizarProjeto()
        {
            Click(visualizarProjeto);
        }
        #endregion
    }
}
