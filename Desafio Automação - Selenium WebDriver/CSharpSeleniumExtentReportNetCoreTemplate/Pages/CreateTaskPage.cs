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
    public class CreateTaskPage : PageBase
    {
        #region Mapping
        By selectCategory = By.Id("category_id");
        By selectGravity = By.Id("severity");
        By selectPriority = By.Id("priority");
        By selectAssingTo = By.Id("handler_id");
        By fillSumary = By.Id("summary");
        By fillDescription = By.Id("description");
        By clickCreateNewTask = By.XPath("//*[@id='report_bug_form']/div/div[2]/div[2]/input");
        By infoCreateTask = By.XPath("//*[@id='view-issue-details']/div/div[2]/div[2]/div/table/tbody/tr[1]/th[1]");
        By clickCreateMoreTasks = By.XPath("//*[@id='report_bug_form']/div/div[2]/div[1]/div/table/tbody/tr[10]/td/label/span");
        By infoCreateMoreTask = By.XPath("//*[@id='report_bug_form']/div/div[2]/div[1]/div/table/tbody/tr[1]/th/label");
        #endregion

        #region Actions
        public void SelecionarAtribuirA(string atribuir)
        {
            ComboBoxSelectByVisibleText(selectAssingTo, atribuir);
        }
        public void SelecionarPrioridade(string prioridade)
        {
            ComboBoxSelectByVisibleText(selectPriority, prioridade);
        }
        public void SelecionarGravidade(string gravidade)
        {
            ComboBoxSelectByVisibleText(selectGravity, gravidade);
        }
        public void SelecionarCategoria(string categoria)
        {
            ComboBoxSelectByVisibleText(selectCategory, categoria);
        }
        public void ClicarEmCriarNovaTarefa()
        {
            Click(clickCreateNewTask);
        }

        public void ClicarEmSelecionarParaCriaMaisTarefas()
        {
            Click(clickCreateMoreTasks);
        }
        public void PreencherResumo(string resumo)
        {
            SendKeys(fillSumary, resumo);
        }
        public void PreencherDescricao(string descricao)
        {
            SendKeys(fillDescription, descricao);
        }
        public string RetornaInfoCreateTask()
        {
            return GetText(infoCreateTask);
        }
        public string RetornaInfoCreateMoreTask()
        {
            return GetText(infoCreateMoreTask);
        }

        public string RetornaResumoNaoPreenchido()
        {
            return GetText(fillSumary);
        }

        public string RetornaDescricaoNaoPreenchido()
        {
            return GetText(fillDescription);
        }

        #endregion
    }
}