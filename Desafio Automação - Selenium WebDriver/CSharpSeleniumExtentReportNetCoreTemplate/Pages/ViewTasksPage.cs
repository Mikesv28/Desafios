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
        By clickCategory = By.Id("show_category_filter");
        By selectCategory = By.XPath("//*[@id='show_category_filter_target']/select");
        By clickApplyFilter = By.XPath("//*[@id='filters_form_open']/div[2]/div/div/input[2]");
        By infoCategory = By.XPath("//*[@id='buglist']/tbody/tr/td[7]/div");
        By infoGravity = By.XPath("//*[@id='buglist']/tbody/tr[1]/td[8]/span");
        By clickGravity = By.Id("show_severity_filter");
        By selectGravity = By.XPath("//*[@id='show_severity_filter_target']/select");

        #endregion

        #region Actions
        public void ClicarEmGravidade()
        {
            Click(clickGravity);
        }
        public void SelecionarGravidade(string gravidade)
        {
            ComboBoxSelectByVisibleText(selectGravity, gravidade);
        }
        public string RetornaInfoCategoria()
        {
            return GetText(infoCategory);
        }
        public string RetornaInfoGravidade()
        {
            return GetText(infoGravity);
        }
        public void ClicarEmAplicarFiltro()
        {
            Click(clickApplyFilter);
        }
        public void SelecionarCategoria(string categoria)
        {
            ComboBoxSelectByVisibleText(selectCategory, categoria);
        }
        public void ClicarEmCategoria()
        {
            Click(clickCategory);
        }
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