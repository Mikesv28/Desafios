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
    public class ViewTasksPage : PageBase
    {
        #region Mapping
        By clickTask = By.XPath("//*[@id='buglist']/tbody/tr[1]/td[4]/a");
        By selectTask = By.XPath("//*[@id='buglist']/tbody/tr[1]/td[1]/div/label/span");
        By clickOk = By.XPath("//*[@id='bug_action']/div/div[2]/div[2]/div[2]/div[1]/input");
        By selectAction = By.Name("action");
        By clickSave = By.XPath("//*[@id='filter']/div[2]/div/div/div/div/a[2]");

        #endregion

        #region Actions
        public void ClicarSalvar()
        {
            Click(clickSave);
        }

        public void SelecionarAcao(string acao)
        {
            ComboBoxSelectByVisibleText(selectAction, acao);
        }
        public void ClicarEmUmaTarefa()
        {
            Click(clickTask);
        }

        public void SelecionarTarefa()
        {
            Click(selectTask);
        }

        public void ClicarEmOk()
        {
            Click(clickOk);
        }
        #endregion
    }
}