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
    public class SaveCurrentFilterPage : PageBase
    {
        #region Mapping
        By fillFilterName = By.Name("query_name");
        By clickAllProjects = By.XPath("//*[@id='save-filter']/div[2]/div/form[1]/div[4]/label/span");
        By clickSaveCurrentFilter = By.XPath("//*[@id='save-filter']/div[2]/div/form[1]/input[2]");

        #endregion

        #region Actions
        public void PreencherNomeDoFiltro(string nomeFiltro)
        {
            SendKeys(fillFilterName, nomeFiltro);

        }
        
        public void ClicarEmTodosOsProjetos()
        {
            Click(clickAllProjects);
        }

        public void ClicarEmSalvarFiltroAtual()
        {
            Click(clickSaveCurrentFilter);
        }

        #endregion
    }
}