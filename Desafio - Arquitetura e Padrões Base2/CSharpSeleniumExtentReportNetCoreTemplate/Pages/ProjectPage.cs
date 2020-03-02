using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class ProjectPage : PageBase
    {
        #region Mapping
        By clicarEmCasoDeTeste = By.XPath("/html/body/div/div/div[1]/div[2]/ul/li[3]/a/span");

        #endregion

        public void ClicarEmCasoDeTeste()
        {
            Click(clicarEmCasoDeTeste);

        }

    }
}
